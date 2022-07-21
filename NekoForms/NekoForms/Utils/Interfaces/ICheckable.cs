namespace NekoForms.Utils.Interfaces
{
    internal interface ICheckable
    {
        bool IsNull(string? obj);

        bool IsWhiteSpace(string? obj);
    }
}
