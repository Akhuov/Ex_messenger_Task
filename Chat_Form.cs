namespace Ex_messenger_Task
{
    public partial class Chat_Form : Form
    {
        private Form main { get; set; }
        public Chat_Form(Form main)
        {
            
            InitializeComponent();
            this.main = main;
        }

        private void ExitButton_Click(object sender, EventArgs e)
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
                this.Close();
            }
        }

    }
}