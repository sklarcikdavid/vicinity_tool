namespace free_vbucks_generator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LoginButton = new Button();
            PasswordtextBox = new TextBox();
            PasswordLabel = new Label();
            EmailLabel = new Label();
            EmailtextBox = new TextBox();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(224, 224, 224);
            LoginButton.ForeColor = Color.Black;
            LoginButton.Location = new Point(193, 235);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(177, 43);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.BackColor = Color.FromArgb(224, 224, 224);
            PasswordtextBox.Location = new Point(260, 194);
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.Size = new Size(296, 23);
            PasswordtextBox.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.ForeColor = Color.Black;
            PasswordLabel.Location = new Point(193, 197);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(43, 15);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Heslo: ";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.ForeColor = Color.Black;
            EmailLabel.Location = new Point(193, 162);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(47, 15);
            EmailLabel.TabIndex = 6;
            EmailLabel.Text = "E-mail: ";
            // 
            // EmailtextBox
            // 
            EmailtextBox.BackColor = Color.FromArgb(224, 224, 224);
            EmailtextBox.Location = new Point(260, 159);
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(296, 23);
            EmailtextBox.TabIndex = 5;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.FromArgb(224, 224, 224);
            ExitButton.ForeColor = Color.Black;
            ExitButton.Location = new Point(379, 235);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(177, 43);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(EmailLabel);
            Controls.Add(EmailtextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordtextBox);
            Controls.Add(LoginButton);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Free VBUCKS Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private RichTextBox scamAnnouncementBox;
        private Button LoginButton;
        private TextBox PasswordtextBox;
        private Label PasswordLabel;
        private Label EmailLabel;
        private TextBox EmailtextBox;
        private Button ExitButton;
    }
}
