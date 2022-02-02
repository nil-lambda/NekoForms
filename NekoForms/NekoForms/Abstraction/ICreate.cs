using System.Windows.Forms;

namespace NekoForms.Abstraction
{
    /// <summary>
    /// Contains methods to create the NekoForm Form properties such as image allign, size of the window, size of the image and so on.
    /// </summary>
    interface ICreate
    {
        /// <summary>
        /// The main and most important method in the program. Creates everything related to the form such as size (width and height), item placement, properties and much more.
        /// </summary>
        /// <param name="_form">Parameter expects form</param>
        /// <param name="subFolder">Parameter expects the subfolder where the image will be saved in.</param>
        /// <param name="fixedWidth">Parameter expects the given fixed width if any.</param>
        /// <param name="fixedHeight">Parameter expects the given fixed height if any.</param>
        /// <param name="isDynamicChecked">Parameter expects boolean value that will determine whether or not the parsed CheckBox is checked or not.</param>
        /// <param name="isDublicateExcludeAllowed">Parameter expects boolean value that will determine whether or not the parsed CheckBox is checked or not.</param>
        void CreateFormProperties(ref Form _form, string subFolder, int fixedWidth, int fixedHeight, bool isDynamicChecked, bool isDublicateExcludeAllowed);
        /// <summary>
        /// Method for parsing the given Neko endpoint to the class so we can work with it.
        /// </summary>
        /// <param name="endPoint">Parameter expects endpoint that the program will be working with.</param>
        void ParseEndpoint(string endPoint);
    }
}