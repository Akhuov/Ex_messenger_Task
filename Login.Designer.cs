namespace Ex_messenger_Task
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Exit_Button = new Button();
            ErrorLabel = new Label();
            IdTextBox = new TextBox();
            ShowPasswordButton = new Button();
            button = new Button();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();
            Registration_Button = new Button();
            SuspendLayout();
            // 
            // Exit_Button
            // 
            Exit_Button.BackColor = SystemColors.ActiveCaption;
            Exit_Button.Font = new Font("Stencil", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Exit_Button.ForeColor = Color.IndianRed;
            Exit_Button.Location = new Point(337, 2);
            Exit_Button.Name = "Exit_Button";
            Exit_Button.Size = new Size(37, 29);
            Exit_Button.TabIndex = 0;
            Exit_Button.Text = "X";
            Exit_Button.UseVisualStyleBackColor = false;
            Exit_Button.Click += Exit_Button_Click;
            // 
            // ErrorLabel
            // 
            ErrorLabel.BackColor = Color.Transparent;
            ErrorLabel.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(181, 83);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(120, 39);
            ErrorLabel.TabIndex = 14;
            // 
            // IdTextBox
            // 
            IdTextBox.BackColor = SystemColors.GradientActiveCaption;
            IdTextBox.Location = new Point(131, 125);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(120, 27);
            IdTextBox.TabIndex = 8;
            // 
            // ShowPasswordButton
            // 
            ShowPasswordButton.BackColor = Color.FromArgb(192, 255, 255);
            ShowPasswordButton.Location = new Point(327, 169);
            ShowPasswordButton.Name = "ShowPasswordButton";
            ShowPasswordButton.Size = new Size(10, 27);
            ShowPasswordButton.TabIndex = 13;
            ShowPasswordButton.Text = "☻";
            ShowPasswordButton.UseVisualStyleBackColor = false;
            // 
            // button
            // 
            button.BackColor = Color.FromArgb(192, 255, 255);
            button.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button.Location = new Point(188, 202);
            button.Name = "button";
            button.Size = new Size(63, 29);
            button.TabIndex = 12;
            button.Text = "Login";
            button.UseVisualStyleBackColor = false;
            button.Click += button_Click;
            // 
            // LoginLabel
            // 
            LoginLabel.BackColor = Color.Transparent;
            LoginLabel.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LoginLabel.Location = new Point(72, 126);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(53, 26);
            LoginLabel.TabIndex = 10;
            LoginLabel.Text = "ID";
            LoginLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PasswordLabel
            // 
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(19, 169);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(106, 26);
            PasswordLabel.TabIndex = 11;
            PasswordLabel.Text = "Password";
            PasswordLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = SystemColors.GradientActiveCaption;
            PasswordTextBox.Location = new Point(131, 169);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(120, 27);
            PasswordTextBox.TabIndex = 9;
            // 
            // Registration_Button
            // 
            Registration_Button.BackColor = Color.Transparent;
            Registration_Button.Location = new Point(12, 398);
            Registration_Button.Name = "Registration_Button";
            Registration_Button.Size = new Size(129, 29);
            Registration_Button.TabIndex = 15;
            Registration_Button.Text = "Create Account";
            Registration_Button.UseVisualStyleBackColor = false;
            Registration_Button.Click += Registration_Button_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 439);
            ControlBox = false;
            Controls.Add(Registration_Button);
            Controls.Add(ErrorLabel);
            Controls.Add(IdTextBox);
            Controls.Add(ShowPasswordButton);
            Controls.Add(button);
            Controls.Add(LoginLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(Exit_Button);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(375, 439);
            MinimumSize = new Size(375, 439);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Exit_Button;
        private Label ErrorLabel;
        private TextBox IdTextBox;
        private Button ShowPasswordButton;
        private Button button;
        private Label LoginLabel;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private Button Registration_Button;
    }
}