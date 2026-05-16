namespace Food_Ordering_CRUD_App
{
    partial class LogInForm
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
            UsernameLabel = new Label();
            UsernameInputBox = new TextBox();
            PasswordInputBox = new TextBox();
            ShowPassCheckBox = new CheckBox();
            TypeCustomerRadioButton = new RadioButton();
            TypeAdminRadioButton = new RadioButton();
            TypeSuperAdminRadioButton = new RadioButton();
            LogInBtn = new Button();
            LogInLabel = new Label();
            LogoLabel = new Label();
            PasswordLabel = new Label();
            NoAccLabel = new Label();
            SignUpLinkLabel = new Label();
            ForgotPassLinkLabel = new Label();
            SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameLabel.Location = new Point(105, 155);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(70, 17);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "Username:";
            // 
            // UsernameInputBox
            // 
            UsernameInputBox.Location = new Point(181, 152);
            UsernameInputBox.Name = "UsernameInputBox";
            UsernameInputBox.Size = new Size(180, 23);
            UsernameInputBox.TabIndex = 3;
            // 
            // PasswordInputBox
            // 
            PasswordInputBox.Location = new Point(181, 190);
            PasswordInputBox.Name = "PasswordInputBox";
            PasswordInputBox.Size = new Size(180, 23);
            PasswordInputBox.TabIndex = 4;
            PasswordInputBox.UseSystemPasswordChar = true;
            // 
            // ShowPassCheckBox
            // 
            ShowPassCheckBox.AutoSize = true;
            ShowPassCheckBox.Location = new Point(367, 192);
            ShowPassCheckBox.Name = "ShowPassCheckBox";
            ShowPassCheckBox.Size = new Size(108, 19);
            ShowPassCheckBox.TabIndex = 5;
            ShowPassCheckBox.Text = "Show Password";
            ShowPassCheckBox.UseVisualStyleBackColor = true;
            ShowPassCheckBox.CheckedChanged += ShowPassCheckBox_CheckedChanged;
            // 
            // TypeCustomerRadioButton
            // 
            TypeCustomerRadioButton.AutoSize = true;
            TypeCustomerRadioButton.Font = new Font("Segoe UI", 10F);
            TypeCustomerRadioButton.Location = new Point(151, 223);
            TypeCustomerRadioButton.Name = "TypeCustomerRadioButton";
            TypeCustomerRadioButton.Size = new Size(87, 23);
            TypeCustomerRadioButton.TabIndex = 7;
            TypeCustomerRadioButton.TabStop = true;
            TypeCustomerRadioButton.Text = "Customer";
            TypeCustomerRadioButton.UseVisualStyleBackColor = true;
            // 
            // TypeAdminRadioButton
            // 
            TypeAdminRadioButton.AutoSize = true;
            TypeAdminRadioButton.Font = new Font("Segoe UI", 10F);
            TypeAdminRadioButton.Location = new Point(151, 252);
            TypeAdminRadioButton.Name = "TypeAdminRadioButton";
            TypeAdminRadioButton.Size = new Size(67, 23);
            TypeAdminRadioButton.TabIndex = 8;
            TypeAdminRadioButton.TabStop = true;
            TypeAdminRadioButton.Text = "Admin";
            TypeAdminRadioButton.UseVisualStyleBackColor = true;
            // 
            // TypeSuperAdminRadioButton
            // 
            TypeSuperAdminRadioButton.AutoSize = true;
            TypeSuperAdminRadioButton.Font = new Font("Segoe UI", 10F);
            TypeSuperAdminRadioButton.Location = new Point(151, 281);
            TypeSuperAdminRadioButton.Name = "TypeSuperAdminRadioButton";
            TypeSuperAdminRadioButton.Size = new Size(106, 23);
            TypeSuperAdminRadioButton.TabIndex = 9;
            TypeSuperAdminRadioButton.TabStop = true;
            TypeSuperAdminRadioButton.Text = "Super Admin";
            TypeSuperAdminRadioButton.UseVisualStyleBackColor = true;
            // 
            // LogInBtn
            // 
            LogInBtn.Font = new Font("Segoe UI", 10F);
            LogInBtn.Location = new Point(181, 310);
            LogInBtn.Name = "LogInBtn";
            LogInBtn.Size = new Size(125, 30);
            LogInBtn.TabIndex = 10;
            LogInBtn.Text = "Log - In";
            LogInBtn.UseVisualStyleBackColor = true;
            LogInBtn.Click += LogInBtn_Click;
            // 
            // LogInLabel
            // 
            LogInLabel.AutoSize = true;
            LogInLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogInLabel.Location = new Point(168, 86);
            LogInLabel.Name = "LogInLabel";
            LogInLabel.Size = new Size(138, 54);
            LogInLabel.TabIndex = 11;
            LogInLabel.Text = "Log-in";
            // 
            // LogoLabel
            // 
            LogoLabel.AutoSize = true;
            LogoLabel.Font = new Font("Rockwell", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoLabel.Location = new Point(90, 24);
            LogoLabel.Name = "LogoLabel";
            LogoLabel.Size = new Size(310, 62);
            LogoLabel.TabIndex = 12;
            LogoLabel.Text = "FlavorFlow";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(105, 192);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(67, 17);
            PasswordLabel.TabIndex = 13;
            PasswordLabel.Text = "Password:";
            // 
            // NoAccLabel
            // 
            NoAccLabel.AutoSize = true;
            NoAccLabel.Font = new Font("Segoe UI", 10F);
            NoAccLabel.Location = new Point(135, 352);
            NoAccLabel.Name = "NoAccLabel";
            NoAccLabel.Size = new Size(155, 19);
            NoAccLabel.TabIndex = 14;
            NoAccLabel.Text = "Don't have an Account?";
            // 
            // SignUpLinkLabel
            // 
            SignUpLinkLabel.AutoSize = true;
            SignUpLinkLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpLinkLabel.ForeColor = SystemColors.HotTrack;
            SignUpLinkLabel.Location = new Point(296, 352);
            SignUpLinkLabel.Name = "SignUpLinkLabel";
            SignUpLinkLabel.Size = new Size(65, 17);
            SignUpLinkLabel.TabIndex = 15;
            SignUpLinkLabel.Text = "Sign - Up";
            SignUpLinkLabel.Click += SignUpLinkLabel_Click;
            // 
            // ForgotPassLinkLabel
            // 
            ForgotPassLinkLabel.AutoSize = true;
            ForgotPassLinkLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForgotPassLinkLabel.ForeColor = SystemColors.HotTrack;
            ForgotPassLinkLabel.Location = new Point(182, 383);
            ForgotPassLinkLabel.Name = "ForgotPassLinkLabel";
            ForgotPassLinkLabel.Size = new Size(117, 17);
            ForgotPassLinkLabel.TabIndex = 16;
            ForgotPassLinkLabel.Text = "Forgot Password?";
            ForgotPassLinkLabel.Click += ForgotPassLinkLabel_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(ForgotPassLinkLabel);
            Controls.Add(SignUpLinkLabel);
            Controls.Add(NoAccLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(LogoLabel);
            Controls.Add(LogInLabel);
            Controls.Add(LogInBtn);
            Controls.Add(TypeSuperAdminRadioButton);
            Controls.Add(TypeAdminRadioButton);
            Controls.Add(TypeCustomerRadioButton);
            Controls.Add(ShowPassCheckBox);
            Controls.Add(PasswordInputBox);
            Controls.Add(UsernameInputBox);
            Controls.Add(UsernameLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log - In";
            FormClosed += LogInForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UsernameLabel;
      
        private TextBox UsernameInputBox;
        private TextBox PasswordInputBox;
        private CheckBox ShowPassCheckBox;
        
        private RadioButton TypeCustomerRadioButton;
        private RadioButton TypeAdminRadioButton;
        private RadioButton TypeSuperAdminRadioButton;
        private Button LogInBtn;
        private Label LogInLabel;
        private Label LogoLabel;
        private Label PasswordLabel;
        private Label NoAccLabel;
        private Label SignUpLinkLabel;
        private Label ForgotPassLinkLabel;
    }
}
