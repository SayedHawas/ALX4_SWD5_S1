namespace WinFormsAppDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clean(this);
        }

        private void Clean(Control controlCollection)
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
