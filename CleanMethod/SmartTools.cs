namespace CleanMethod
{
    public static class SmartTools
    {
        public static void Clean(Control frm, string Excpt = "")
        {
            foreach (Control item in frm.Controls)
            {
                if (item.Name == Excpt)
                {
                    continue;
                }
                if (item is TextBox || item is ComboBox)
                    item.Text = string.Empty;
                if (item is GroupBox)
                {
                    Clean(item);
                }
            }
        }
    }
}
