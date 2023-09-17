namespace xara_assistant_v1.Forms
{
    partial class CreateAdminfm
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
            PasswordTxtBox = new TextBox();
            label2 = new Label();
            UsernameTxtBox = new TextBox();
            label1 = new Label();
            BackBtn = new Button();
            CreateUserBtn = new Button();
            label3 = new Label();
            RePasswordTxtBox = new TextBox();
            SuspendLayout();
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordTxtBox.Location = new Point(284, 145);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.Size = new Size(275, 25);
            PasswordTxtBox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(209, 148);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // UsernameTxtBox
            // 
            UsernameTxtBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameTxtBox.Location = new Point(284, 92);
            UsernameTxtBox.Name = "UsernameTxtBox";
            UsernameTxtBox.Size = new Size(275, 25);
            UsernameTxtBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(209, 95);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 6;
            label1.Text = "Username";
            // 
            // BackBtn
            // 
            BackBtn.BackColor = SystemColors.MenuHighlight;
            BackBtn.BackgroundImageLayout = ImageLayout.Center;
            BackBtn.FlatStyle = FlatStyle.Popup;
            BackBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BackBtn.ForeColor = SystemColors.ButtonHighlight;
            BackBtn.Location = new Point(470, 389);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(167, 38);
            BackBtn.TabIndex = 11;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // CreateUserBtn
            // 
            CreateUserBtn.BackColor = SystemColors.MenuHighlight;
            CreateUserBtn.BackgroundImageLayout = ImageLayout.Center;
            CreateUserBtn.FlatStyle = FlatStyle.Popup;
            CreateUserBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CreateUserBtn.ForeColor = SystemColors.ButtonHighlight;
            CreateUserBtn.Location = new Point(164, 389);
            CreateUserBtn.Name = "CreateUserBtn";
            CreateUserBtn.Size = new Size(167, 38);
            CreateUserBtn.TabIndex = 10;
            CreateUserBtn.Text = "Create";
            CreateUserBtn.UseVisualStyleBackColor = false;
            CreateUserBtn.Click += CreateUserBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(189, 202);
            label3.Name = "label3";
            label3.Size = new Size(86, 17);
            label3.TabIndex = 8;
            label3.Text = "Re-Password";
            // 
            // RePasswordTxtBox
            // 
            RePasswordTxtBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            RePasswordTxtBox.Location = new Point(284, 199);
            RePasswordTxtBox.Name = "RePasswordTxtBox";
            RePasswordTxtBox.Size = new Size(275, 25);
            RePasswordTxtBox.TabIndex = 9;
            // 
            // CreateAdminfm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 510);
            Controls.Add(BackBtn);
            Controls.Add(CreateUserBtn);
            Controls.Add(RePasswordTxtBox);
            Controls.Add(label3);
            Controls.Add(PasswordTxtBox);
            Controls.Add(label2);
            Controls.Add(UsernameTxtBox);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "CreateAdminfm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create-Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PasswordTxtBox;
        private Label label2;
        private TextBox UsernameTxtBox;
        private Label label1;
        private Button BackBtn;
        private Button CreateUserBtn;
        private Label label3;
        private TextBox RePasswordTxtBox;
    }
}