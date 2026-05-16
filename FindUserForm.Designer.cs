namespace Food_Ordering_CRUD_App
{
    partial class FindUserForm
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
            FindUserLabel = new Label();
            UsernameLabel = new Label();
            UsernameInputBox = new TextBox();
            SearchUserBtn = new Button();
            LogoLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // FindUserLabel
            // 
            FindUserLabel.AutoSize = true;
            FindUserLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FindUserLabel.Location = new Point(150, 86);
            FindUserLabel.Name = "FindUserLabel";
            FindUserLabel.Size = new Size(190, 54);
            FindUserLabel.TabIndex = 16;
            FindUserLabel.Text = "Find User";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameLabel.Location = new Point(113, 173);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(70, 17);
            UsernameLabel.TabIndex = 17;
            UsernameLabel.Text = "Username:";
            // 
            // UsernameInputBox
            // 
            UsernameInputBox.Location = new Point(194, 170);
            UsernameInputBox.Name = "UsernameInputBox";
            UsernameInputBox.Size = new Size(180, 23);
            UsernameInputBox.TabIndex = 18;
            // 
            // SearchUserBtn
            // 
            SearchUserBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchUserBtn.Location = new Point(183, 228);
            SearchUserBtn.Name = "SearchUserBtn";
            SearchUserBtn.Size = new Size(125, 30);
            SearchUserBtn.TabIndex = 19;
            SearchUserBtn.Text = "Search";
            SearchUserBtn.UseVisualStyleBackColor = true;
            SearchUserBtn.Click += SearchUserBtn_Click;
            // 
            // LogoLabel
            // 
            LogoLabel.AutoSize = true;
            LogoLabel.Font = new Font("Rockwell", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoLabel.Location = new Point(90, 24);
            LogoLabel.Name = "LogoLabel";
            LogoLabel.Size = new Size(310, 62);
            LogoLabel.TabIndex = 20;
            LogoLabel.Text = "FlavorFlow";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 140);
            label1.Name = "label1";
            label1.Size = new Size(201, 15);
            label1.TabIndex = 21;
            label1.Text = "Input your username to find account";
            // 
            // FindUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 286);
            Controls.Add(label1);
            Controls.Add(LogoLabel);
            Controls.Add(SearchUserBtn);
            Controls.Add(UsernameInputBox);
            Controls.Add(UsernameLabel);
            Controls.Add(FindUserLabel);
            Name = "FindUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Find Account";
            Load += FindUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label FindUserLabel;
        private Label UsernameLabel;
        private TextBox UsernameInputBox;
        private Button SearchUserBtn;
        private Label LogoLabel;
        private Label label1;
    }
}