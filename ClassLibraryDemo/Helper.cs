using System.Windows.Forms;

namespace ClassLibraryDemo
{
    public class Helper
    {
        public string GetMessage(string str)
        {
            return $"Hello from Helper class! You passed: {str}";
        }
        //I/O 
        // File Director , Stream Reader , Stream Writer , File Stream
        public void Clean(Control controlCollection)
        {
            foreach (Control control in controlCollection.Controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    control.Text = string.Empty;
                }
                if (control is GroupBox)
                {
                    Clean(control);
                }
            }
        }
    }
}
