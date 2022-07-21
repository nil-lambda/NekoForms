namespace NekoForms.Utils
{
    internal class FormControl
    {
        public static void CreateForm(string? url, int width, int height)
        {
            Form nekoForm = new Form()
            {
                Text = "NekoForm",
                Width = width,
                Height = height,
                StartPosition = FormStartPosition.CenterScreen,
                MinimizeBox = false
            };

            PictureBox nekoBox = new PictureBox()
            {
                Width = width,
                Height = height,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nekoBox.Load(url);
            nekoForm.Controls.Add(nekoBox);
            Task.Run(() => Application.Run(nekoForm));

            Menu.OpenedForms.Add(nekoForm);
        }
    }
}
