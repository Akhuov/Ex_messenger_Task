namespace Ex_messenger_Task
{
    partial class Create_Account
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
            ExitButton = new Button();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.FromArgb(192, 255, 255);
            ExitButton.Font = new Font("Stencil", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ExitButton.ForeColor = Color.DarkRed;
            ExitButton.Location = new Point(12, 409);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(82, 29);
            ExitButton.TabIndex = 10;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click_1;
            // 
            // Create_Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Name = "Create_Account";
            Text = "Create_Account";
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
    }
}