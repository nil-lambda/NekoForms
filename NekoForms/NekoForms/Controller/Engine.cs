using System.Text.RegularExpressions;
using NekoForms.Utils.Interfaces;
using NekoForms.Utils.Announcer;

namespace NekoForms.Utils
{
    public delegate Task FunctionInvoker();

    internal class Engine : ICallable, ICheckable
    {
        public string? Url { get; private set; }

        public int Width { get; private set; }

        public int Height { get; private set; }

        public string? BaseUrl { get; private set; }

        public string? Endpoint { get; private set; }

        public HttpClient Client { get; private set; }

        public Regex LinkRegex { get; private set; }

        public FunctionInvoker[] FunctionInvoker { get; private set; }

        public Engine(string baseUrl, string endpoint, params int[] windowDimensions)
        {
            BaseUrl = baseUrl;
            Endpoint = endpoint;
            Width = windowDimensions[0];
            Height = windowDimensions[1];
            Client = new HttpClient();
            LinkRegex = new Regex("(https://|http://)(.*?)\"");
            FunctionInvoker = new FunctionInvoker[]
            {
                PerformChecks,
                AssignUrl,
                InitForm
            };
        }

        public async Task Run()
        {
            foreach (FunctionInvoker function in FunctionInvoker)
            {
                await function.Invoke();
            }
        }

        private async Task PerformChecks()
        {
            if (IsNull(BaseUrl))
                throw new ArgumentException("BaseUrl cannot be null or whitespace. Program will not continue.");

            if (IsNull(Endpoint))
                throw new ArgumentException("Endpoint cannot be null or whitespace. Program will not continue.");

            Debug.Print(LogSeverity.Success, "Nullable checks passed.");
            Debug.Print(LogSeverity.Success, $"Info: URL: {BaseUrl} - ENDPOINT: {Endpoint}");
        }

        #region Check_Methods
        public bool IsWhiteSpace(string? obj)
        {
            foreach (char currentChar in obj)
            {
                if (currentChar is not ' ')
                    return false;
            }

            return true;
        }

        public bool IsNull(string? obj)
        {
            if (obj is null || obj.Length is 0 || IsWhiteSpace(obj))
                return true;

            return false;
        }
        #endregion

        public string GetResponse(string? url)
        {
            try
            {
                return Client.GetStringAsync(url).Result;
            }
            catch (InvalidOperationException)
            {
                Debug.Print(LogSeverity.Fatal, "Requested URL is not valid address. Program will not continue");
            }
            catch (AggregateException)
            {
                Debug.Print(LogSeverity.Fatal, "Requested URL possible return \"404 Page Not Found\". Program will not continue");
            }

            return "Error";
        }

        private async Task AssignUrl()
        {
            string response = GetResponse(BaseUrl + Endpoint);
            if (response == "Error" || !LinkRegex.IsMatch(response))
                return;

            Url = LinkRegex.Match(response).Groups[1].Value + LinkRegex.Match(response).Groups[2].Value;
            Debug.Print(LogSeverity.Success, $"Extracted URL: {Url}");
        }

        private async Task InitForm()
        {
            if (IsNull(Url))
                return;

            FormControl.CreateForm(Url, Width, Height);

            Debug.Print(LogSeverity.Success, "Created window successfully!");
        }
    }
}