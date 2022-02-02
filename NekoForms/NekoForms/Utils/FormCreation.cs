using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Drawing;
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Forms;

using NekoForms.Abstraction;
using NekoForms.Utils;

namespace NekoForms
{
    public class FormCreation : ICreate
    {
        public string Endpoint { get; set; }

        public class ImageInformation
        {
            public int Dynamic_Dim_X { get; set; }
            public int Dynamic_Dim_Y { get; set; }
            public string Url { get; set; }

            public string[] DownloadImageAndGetSize(string imageUrl, string subFolder)
            {
                Random randomChar = new Random();
                WebClient wc = new WebClient();

                string chars = "abcdefghijklmnopqrstuvwxyz1234567890";
                string fileName = new string(Enumerable.Repeat(chars, 7).Select(x => x[randomChar.Next(chars.Length)]).ToArray());
                string path = $@"C:\NekoForms_Assets\{subFolder}\{fileName}.jpg";

                wc.DownloadFile(imageUrl, path);

                GetDimensions(path);

                return new string[] { path, fileName };
            }

            private void GetDimensions(string path)
            {
                Image imgInfo = Image.FromFile(path);
                this.Dynamic_Dim_X = imgInfo.Width;
                this.Dynamic_Dim_Y = imgInfo.Height;
            }

            public string ParseSubFolder(string subFolderName) => subFolderName;
        }

        public void ParseEndpoint(string endPoint) => this.Endpoint = endPoint;

        private string GetResponse(string apiUrl)
        {
            HttpClient hp = new HttpClient();
            string response = hp.GetStringAsync(apiUrl).Result;
            return response;
        }

        private string GetImageUrl()
        {
            var deserializedObject = JsonConvert.DeserializeObject<ImageInformation>(GetResponse($"https://nekos.life/api/v2/img/{Endpoint}"));
            return deserializedObject.Url;
        }

        private PictureBox CreatePictureBox(ref Form _form, string imageUrl)
        {
            PictureBox PB = new PictureBox
            {
                Name = "nekoPictureBox",
                Size = new Size(_form.Width, _form.Height),
                Location = new Point(0, 0),
                ImageLocation = imageUrl,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Visible = true
            };

            Menu.formImageCollection.Add(PB);
            return PB;
        }

        public void CreateFormProperties(ref Form _form, string subFolder, int fixedWidth, int fixedHeight, bool isDynamicChecked, bool isDuplicateExcludeAllowed)
        {
            ImageInformation imgInfo = new ImageInformation();

            string imageUrl = GetImageUrl();
            string subFolderName = imgInfo.ParseSubFolder(subFolder);
            string[] pathAndFileName = imgInfo.DownloadImageAndGetSize(imageUrl, subFolderName);

            DuplicateCheck currentImage = new DuplicateCheck(imgInfo.Dynamic_Dim_X, imgInfo.Dynamic_Dim_Y, new FileInfo(pathAndFileName[0]).Length);

            if (isDuplicateExcludeAllowed)
            {
                if (!Menu.uniqueImages.Any())
                {
                    Menu.uniqueImages.Add(new ImageProfile(pathAndFileName[1], imgInfo.Dynamic_Dim_X, imgInfo.Dynamic_Dim_Y, new FileInfo(pathAndFileName[0]).Length, DateTime.Now));
                }
                else
                {
                    Menu.isCurrentDuplicate = currentImage.DuplicateCheck_Current(ref Menu.uniqueImages);
                    if (!Menu.isCurrentDuplicate)
                    {
                        Menu.uniqueImages.Add(new ImageProfile(pathAndFileName[1], imgInfo.Dynamic_Dim_X, imgInfo.Dynamic_Dim_Y, new FileInfo(pathAndFileName[0]).Length, DateTime.Now));
                    }
                }
            }

            if (!Menu.isCurrentDuplicate || !isDuplicateExcludeAllowed)
            {
                if (isDynamicChecked)
                {
                    _form.Width = imgInfo.Dynamic_Dim_X;
                    _form.Height = imgInfo.Dynamic_Dim_Y;
                }
                else
                {
                    _form.Width = fixedWidth;
                    _form.Height = fixedHeight;
                }
                _form.StartPosition = FormStartPosition.CenterScreen;
                _form.FormBorderStyle = FormBorderStyle.FixedSingle;
                _form.MaximizeBox = false;
                _form.ShowIcon = false;
                _form.Text = "NekoBox";

                _form.Controls.Add(CreatePictureBox(ref _form, imageUrl));

                Menu.imageProfileArray[0] = new ImageProfile(pathAndFileName[1], imgInfo.Dynamic_Dim_X, imgInfo.Dynamic_Dim_Y, new FileInfo(pathAndFileName[0]).Length, DateTime.Now);
                LogsWindow.SendLog(LogsMessage.GeneratedImage());
            }
            else
            {
                LogsWindow.SendLog($"Duplicate! ({Menu.uniqueImages.Count} unique images!)");
            }
        }
    }
}