namespace Food_Ordering_CRUD_App
{
    partial class SignUpForm
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
            ShowPassCheckBox = new CheckBox();
            PasswordInputBox = new TextBox();
            UsernameInputBox = new TextBox();
            ConfirmPassInputBox = new TextBox();
            ConfirmPassLabel = new Label();
            TypeComboBox = new ComboBox();
            TypeLabel = new Label();
            SignUpBtn = new Button();
            HaveAccountLabel = new Label();
            LogInLinkLabel = new Label();
            LogoLabel = new Label();
            LogInLabel = new Label();
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            SuspendLayout();
            // 
            // ShowPassCheckBox
            // 
            ShowPassCheckBox.AutoSize = true;
            ShowPassCheckBox.Location = new Point(333, 240);
            ShowPassCheckBox.Name = "ShowPassCheckBox";
            ShowPassCheckBox.Size = new Size(108, 19);
            ShowPassCheckBox.TabIndex = 20;
            ShowPassCheckBox.Text = "Show Password";
            ShowPassCheckBox.UseVisualStyleBackColor = true;
            ShowPassCheckBox.CheckedChanged += ShowPassCheckBox_CheckedChanged;
            // 
            // PasswordInputBox
            // 
            PasswordInputBox.Location = new Point(164, 199);
            PasswordInputBox.Name = "PasswordInputBox";
            PasswordInputBox.Size = new Size(163, 23);
            PasswordInputBox.TabIndex = 19;
            PasswordInputBox.UseSystemPasswordChar = true;
            // 
            // UsernameInputBox
            // 
            UsernameInputBox.Location = new Point(164, 159);
            UsernameInputBox.Name = "UsernameInputBox";
            UsernameInputBox.Size = new Size(163, 23);
            UsernameInputBox.TabIndex = 18;
            // 
            // ConfirmPassInputBox
            // 
            ConfirmPassInputBox.Location = new Point(164, 239);
            ConfirmPassInputBox.Name = "ConfirmPassInputBox";
            ConfirmPassInputBox.Size = new Size(163, 23);
            ConfirmPassInputBox.TabIndex = 23;
            ConfirmPassInputBox.UseSystemPasswordChar = true;
            // 
            // ConfirmPassLabel
            // 
            ConfirmPassLabel.AutoSize = true;
            ConfirmPassLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmPassLabel.Location = new Point(88, 242);
            ConfirmPassLabel.Name = "ConfirmPassLabel";
            ConfirmPassLabel.Size = new Size(57, 17);
            ConfirmPassLabel.TabIndex = 22;
            ConfirmPassLabel.Text = "Confirm:";
            // 
            // TypeComboBox
            // 
            TypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Items.AddRange(new object[] { "Customer", "Admin", "SuperAdmin" });
            TypeComboBox.Location = new Point(164, 279);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(163, 23);
            TypeComboBox.TabIndex = 24;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TypeLabel.Location = new Point(88, 282);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(38, 17);
            TypeLabel.TabIndex = 25;
            TypeLabel.Text = "Type:";
            // 
            // SignUpBtn
            // 
            SignUpBtn.Location = new Point(183, 321);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(125, 30);
            SignUpBtn.TabIndex = 26;
            SignUpBtn.Text = "Sign - Up";
            SignUpBtn.UseVisualStyleBackColor = true;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // HaveAccountLabel
            // 
            HaveAccountLabel.AutoSize = true;
            HaveAccountLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HaveAccountLabel.Location = new Point(136, 375);
            HaveAccountLabel.Name = "HaveAccountLabel";
            HaveAccountLabel.Size = new Size(156, 17);
            HaveAccountLabel.TabIndex = 27;
            HaveAccountLabel.Text = "Already have an account?";
            // 
            // LogInLinkLabel
            // 
            LogInLinkLabel.AutoSize = true;
            LogInLinkLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogInLinkLabel.ForeColor = SystemColors.HotTrack;
            LogInLinkLabel.Location = new Point(298, 375);
            LogInLinkLabel.Name = "LogInLinkLabel";
            LogInLinkLabel.Size = new Size(48, 17);
            LogInLinkLabel.TabIndex = 28;
            LogInLinkLabel.Text = "Log-In";
            LogInLinkLabel.Click += LogInLinkLabel_Click;
            // 
            // LogoLabel
            // 
            LogoLabel.AutoSize = true;
            LogoLabel.Font = new Font("Rockwell", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoLabel.Location = new Point(90, 24);
            LogoLabel.Name = "LogoLabel";
            LogoLabel.Size = new Size(310, 62);
            LogoLabel.TabIndex = 29;
            LogoLabel.Text = "FlavorFlow";
            // 
            // LogInLabel
            // 
            LogInLabel.AutoSize = true;
            LogInLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogInLabel.Location = new Point(161, 86);
            LogInLabel.Name = "LogInLabel";
            LogInLabel.Size = new Size(168, 54);
            LogInLabel.TabIndex = 30;
            LogInLabel.Text = "Sign-Up";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameLabel.Location = new Point(88, 162);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(70, 17);
            UsernameLabel.TabIndex = 31;
            UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(88, 202);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(67, 17);
            PasswordLabel.TabIndex = 32;
            PasswordLabel.Text = "Password:";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(LogInLabel);
            Controls.Add(LogoLabel);
            Controls.Add(LogInLinkLabel);
            Controls.Add(HaveAccountLabel);
            Controls.Add(SignUpBtn);
            Controls.Add(TypeLabel);
            Controls.Add(TypeComboBox);
            Controls.Add(ConfirmPassInputBox);
            Controls.Add(ConfirmPassLabel);
            Controls.Add(ShowPassCheckBox);
            Controls.Add(PasswordInputBox);
            Controls.Add(UsernameInputBox);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUpForm";
            FormClosed += SignUpForm_FormClosed;
            Load += SignUpForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox ShowPassCheckBox;
        private TextBox PasswordInputBox;
        private TextBox UsernameInputBox;
        private TextBox ConfirmPassInputBox;
        private Label ConfirmPassLabel;
        private ComboBox TypeComboBox;
        private Label TypeLabel;
        private Button SignUpBtn;
        private Label HaveAccountLabel;
        private Label LogInLinkLabel;
        private Label LogoLabel;
        private Label LogInLabel;
        private Label UsernameLabel;
        private Label PasswordLabel;
    }
}