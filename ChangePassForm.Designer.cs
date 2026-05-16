namespace Food_Ordering_CRUD_App
{
    partial class ChangePassForm
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
            UsernameLabel = new Label();
            TypeLabel = new Label();
            ShowPassCheckBox = new CheckBox();
            PasswordInputBox = new TextBox();
            PasswordLabel = new Label();
            ConfirmPassInputBox = new TextBox();
            ConfirmPassLabel = new Label();
            ChangePassBtn = new Button();
            LogoLabel = new Label();
            SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 21.75F);
            UsernameLabel.Location = new Point(90, 86);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(283, 40);
            UsernameLabel.TabIndex = 17;
            UsernameLabel.Text = "Username: username";
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Segoe UI", 21.75F);
            TypeLabel.Location = new Point(90, 126);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(146, 40);
            TypeLabel.TabIndex = 18;
            TypeLabel.Text = "Type: type";
            // 
            // ShowPassCheckBox
            // 
            ShowPassCheckBox.AutoSize = true;
            ShowPassCheckBox.Font = new Font("Segoe UI", 9.75F);
            ShowPassCheckBox.Location = new Point(345, 243);
            ShowPassCheckBox.Name = "ShowPassCheckBox";
            ShowPassCheckBox.Size = new Size(118, 21);
            ShowPassCheckBox.TabIndex = 21;
            ShowPassCheckBox.Text = "Show Password";
            ShowPassCheckBox.UseVisualStyleBackColor = true;
            ShowPassCheckBox.CheckedChanged += ShowPassCheckBox_CheckedChanged;
            // 
            // PasswordInputBox
            // 
            PasswordInputBox.Location = new Point(159, 203);
            PasswordInputBox.Name = "PasswordInputBox";
            PasswordInputBox.Size = new Size(180, 23);
            PasswordInputBox.TabIndex = 20;
            PasswordInputBox.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 9.75F);
            PasswordLabel.Location = new Point(86, 206);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(67, 17);
            PasswordLabel.TabIndex = 19;
            PasswordLabel.Text = "Password:";
            // 
            // ConfirmPassInputBox
            // 
            ConfirmPassInputBox.Location = new Point(159, 242);
            ConfirmPassInputBox.Name = "ConfirmPassInputBox";
            ConfirmPassInputBox.Size = new Size(180, 23);
            ConfirmPassInputBox.TabIndex = 23;
            ConfirmPassInputBox.UseSystemPasswordChar = true;
            // 
            // ConfirmPassLabel
            // 
            ConfirmPassLabel.AutoSize = true;
            ConfirmPassLabel.Font = new Font("Segoe UI", 9.75F);
            ConfirmPassLabel.Location = new Point(96, 245);
            ConfirmPassLabel.Name = "ConfirmPassLabel";
            ConfirmPassLabel.Size = new Size(57, 17);
            ConfirmPassLabel.TabIndex = 22;
            ConfirmPassLabel.Text = "Confirm:";
            // 
            // ChangePassBtn
            // 
            ChangePassBtn.Location = new Point(183, 284);
            ChangePassBtn.Name = "ChangePassBtn";
            ChangePassBtn.Size = new Size(125, 30);
            ChangePassBtn.TabIndex = 24;
            ChangePassBtn.Text = "Change Password";
            ChangePassBtn.UseVisualStyleBackColor = true;
            ChangePassBtn.Click += ChangePassBtn_Click;
            // 
            // LogoLabel
            // 
            LogoLabel.AutoSize = true;
            LogoLabel.Font = new Font("Rockwell", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoLabel.Location = new Point(90, 24);
            LogoLabel.Name = "LogoLabel";
            LogoLabel.Size = new Size(310, 62);
            LogoLabel.TabIndex = 25;
            LogoLabel.Text = "FlavorFlow";
            // 
            // ChangePassForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 341);
            Controls.Add(LogoLabel);
            Controls.Add(ChangePassBtn);
            Controls.Add(ConfirmPassInputBox);
            Controls.Add(ConfirmPassLabel);
            Controls.Add(ShowPassCheckBox);
            Controls.Add(PasswordInputBox);
            Controls.Add(PasswordLabel);
            Controls.Add(TypeLabel);
            Controls.Add(UsernameLabel);
            Name = "ChangePassForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label UsernameLabel;
        private Label TypeLabel;
        private CheckBox ShowPassCheckBox;
        private TextBox PasswordInputBox;
        private Label PasswordLabel;
        private TextBox ConfirmPassInputBox;
        private Label ConfirmPassLabel;
        private Button ChangePassBtn;
        private Label LogoLabel;
    }
}