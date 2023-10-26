namespace Ex_messenger_Task
{
    public partial class Create_Account : Form
    {
        private Form main { get; set; }
        public Create_Account(Form main)
        {
            InitializeComponent();
            this.main = main;
        }
        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            var r = MessageBox.Show(
            "Exit from System?",
            "Exit",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (r == DialogResult.Yes)
            {
                main.Close();
            }
        }
    }
}
