namespace Activity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getNamebtn_Click(object sender, EventArgs e)
        {
           string name = NameTextBox.Text.ToString();
            MessageBox.Show(name);        }
    }
}