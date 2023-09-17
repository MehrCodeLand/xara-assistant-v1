namespace xara_assistant_v1.Forms
{
    partial class Home
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
            loginBtn = new Button();
            ExitBtn = new Button();
            label1 = new Label();
            UsernameTxtBox = new TextBox();
            PasswordTxtBox = new TextBox();
            label2 = new Label();
            CreateUserBtn = new Button();
            SuspendLayout();
            // 
            // loginBtn
            // 
            loginBtn.BackColor = SystemColors.MenuHighlight;
            loginBtn.BackgroundImageLayout = ImageLayout.Center;
            loginBtn.FlatStyle = FlatStyle.Popup;
            loginBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.ForeColor = SystemColors.ButtonHighlight;
            loginBtn.Location = new Point(176, 343);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(167, 38);
            loginBtn.TabIndex = 0;
            loginBtn.Text = "login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = SystemColors.MenuHighlight;
            ExitBtn.BackgroundImageLayout = ImageLayout.Center;
            ExitBtn.FlatStyle = FlatStyle.Popup;
            ExitBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ExitBtn.ForeColor = SystemColors.ButtonHighlight;
            ExitBtn.Location = new Point(482, 343);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(167, 38);
            ExitBtn.TabIndex = 1;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(222, 153);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // UsernameTxtBox
            // 
            UsernameTxtBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameTxtBox.Location = new Point(297, 150);
            UsernameTxtBox.Name = "UsernameTxtBox";
            UsernameTxtBox.Size = new Size(275, 25);
            UsernameTxtBox.TabIndex = 3;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordTxtBox.Location = new Point(297, 203);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.Size = new Size(275, 25);
            PasswordTxtBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(222, 206);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // CreateUserBtn
            // 
            CreateUserBtn.BackColor = Color.Salmon;
            CreateUserBtn.BackgroundImageLayout = ImageLayout.Center;
            CreateUserBtn.FlatStyle = FlatStyle.Popup;
            CreateUserBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CreateUserBtn.ForeColor = SystemColors.ButtonHighlight;
            CreateUserBtn.Location = new Point(12, 460);
            CreateUserBtn.Name = "CreateUserBtn";
            CreateUserBtn.Size = new Size(99, 38);
            CreateUserBtn.TabIndex = 6;
            CreateUserBtn.Text = "Create User";
            CreateUserBtn.UseVisualStyleBackColor = false;
            CreateUserBtn.Click += CreateUserBtn_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 510);
            Controls.Add(CreateUserBtn);
            Controls.Add(PasswordTxtBox);
            Controls.Add(label2);
            Controls.Add(UsernameTxtBox);
            Controls.Add(label1);
            Controls.Add(ExitBtn);
            Controls.Add(loginBtn);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginBtn;
        private Button ExitBtn;
        private Label label1;
        private TextBox UsernameTxtBox;
        private TextBox PasswordTxtBox;
        private Label label2;
        private Button CreateUserBtn;
    }
}