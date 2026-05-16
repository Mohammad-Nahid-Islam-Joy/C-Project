namespace Food_Ordering_CRUD_App
{
    partial class SuperAdminForm
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
            LogOutBtn = new Button();
            UserLabel = new Label();
            LogoLabel = new Label();
            UserdataTable = new DataGridView();
            PasswordLabel = new Label();
            UsernameLabel = new Label();
            TypeLabel = new Label();
            TypeComboBox = new ComboBox();
            PasswordInputBox = new TextBox();
            UsernameInputBox = new TextBox();
            UserIDLabel = new Label();
            UserIDBox = new TextBox();
            AddBtn = new Button();
            DeleteBtn = new Button();
            UpdateBtn = new Button();
            ClearBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)UserdataTable).BeginInit();
            SuspendLayout();
            // 
            // LogOutBtn
            // 
            LogOutBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogOutBtn.Location = new Point(709, 9);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(75, 30);
            LogOutBtn.TabIndex = 27;
            LogOutBtn.Text = "Log-Out";
            LogOutBtn.UseVisualStyleBackColor = true;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            UserLabel.Location = new Point(12, 83);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(95, 17);
            UserLabel.TabIndex = 25;
            UserLabel.Text = "Welcome, User!";
            // 
            // LogoLabel
            // 
            LogoLabel.AutoSize = true;
            LogoLabel.Font = new Font("Rockwell", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoLabel.Location = new Point(12, 9);
            LogoLabel.Name = "LogoLabel";
            LogoLabel.Size = new Size(310, 62);
            LogoLabel.TabIndex = 24;
            LogoLabel.Text = "FlavorFlow";
            // 
            // UserdataTable
            // 
            UserdataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserdataTable.Location = new Point(341, 106);
            UserdataTable.Name = "UserdataTable";
            UserdataTable.ReadOnly = true;
            UserdataTable.Size = new Size(443, 332);
            UserdataTable.TabIndex = 28;
            UserdataTable.RowHeaderMouseClick += UserdataTable_RowHeaderMouseClick;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(28, 224);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(67, 17);
            PasswordLabel.TabIndex = 41;
            PasswordLabel.Text = "Password:";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameLabel.Location = new Point(28, 184);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(70, 17);
            UsernameLabel.TabIndex = 40;
            UsernameLabel.Text = "Username:";
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TypeLabel.Location = new Point(28, 264);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(38, 17);
            TypeLabel.TabIndex = 39;
            TypeLabel.Text = "Type:";
            // 
            // TypeComboBox
            // 
            TypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Items.AddRange(new object[] { "Customer", "Admin", "SuperAdmin" });
            TypeComboBox.Location = new Point(104, 261);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(163, 23);
            TypeComboBox.TabIndex = 38;
            // 
            // PasswordInputBox
            // 
            PasswordInputBox.Location = new Point(104, 221);
            PasswordInputBox.Name = "PasswordInputBox";
            PasswordInputBox.Size = new Size(163, 23);
            PasswordInputBox.TabIndex = 34;
            // 
            // UsernameInputBox
            // 
            UsernameInputBox.Location = new Point(104, 181);
            UsernameInputBox.Name = "UsernameInputBox";
            UsernameInputBox.Size = new Size(163, 23);
            UsernameInputBox.TabIndex = 33;
            // 
            // UserIDLabel
            // 
            UserIDLabel.AutoSize = true;
            UserIDLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserIDLabel.Location = new Point(28, 144);
            UserIDLabel.Name = "UserIDLabel";
            UserIDLabel.Size = new Size(54, 17);
            UserIDLabel.TabIndex = 43;
            UserIDLabel.Text = "User ID:";
            // 
            // UserIDBox
            // 
            UserIDBox.Enabled = false;
            UserIDBox.Location = new Point(104, 141);
            UserIDBox.Name = "UserIDBox";
            UserIDBox.ReadOnly = true;
            UserIDBox.Size = new Size(163, 23);
            UserIDBox.TabIndex = 42;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(28, 314);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(115, 23);
            AddBtn.TabIndex = 44;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(28, 355);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(115, 23);
            DeleteBtn.TabIndex = 45;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(152, 314);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(115, 23);
            UpdateBtn.TabIndex = 46;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(152, 355);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(115, 23);
            ClearBtn.TabIndex = 47;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // SuperAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClearBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(AddBtn);
            Controls.Add(UserIDLabel);
            Controls.Add(UserIDBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(TypeLabel);
            Controls.Add(TypeComboBox);
            Controls.Add(PasswordInputBox);
            Controls.Add(UsernameInputBox);
            Controls.Add(UserdataTable);
            Controls.Add(LogOutBtn);
            Controls.Add(UserLabel);
            Controls.Add(LogoLabel);
            Name = "SuperAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuperAdminForm";
            FormClosed += SuperAdminForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)UserdataTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogOutBtn;
        private Label UserLabel;
        private Label LogoLabel;
        private DataGridView UserdataTable;
        private Label PasswordLabel;
        private Label UsernameLabel;
        private Label TypeLabel;
        private ComboBox TypeComboBox;
        private TextBox PasswordInputBox;
        private TextBox UsernameInputBox;
        private Label UserIDLabel;
        private TextBox UserIDBox;
        private Button AddBtn;
        private Button DeleteBtn;
        private Button UpdateBtn;
        private Button ClearBtn;
    }
}