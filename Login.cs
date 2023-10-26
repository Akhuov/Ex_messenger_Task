namespace Ex_messenger_Task
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Registration_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var r = new Create_Account(this);
            r.Show();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
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

        private void button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var r = new Chat_Form(this);
            r.Show();
        }
    }
}
