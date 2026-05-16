namespace Food_Ordering_CRUD_App
{
    partial class AdminForm
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
            AdminTabControl = new TabControl();
            AdminMenuTabPage = new TabPage();
            StockLabel = new Label();
            StockInputBox = new TextBox();
            ClearBtn = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            AddBtn = new Button();
            MenuIDLabel = new Label();
            ItemIDBox = new TextBox();
            PriceLabel = new Label();
            ItemNameLabel = new Label();
            PriceInputBox = new TextBox();
            ItemNameInputBox = new TextBox();
            MenudataTable = new DataGridView();
            AdminOrderTabPage = new TabPage();
            ClearOrderBtn = new Button();
            StatusLabel = new Label();
            StatusComboBox = new ComboBox();
            UpdateStatusBtn = new Button();
            DeleteOrderBtn = new Button();
            OrderIDBox = new TextBox();
            TotalPriceBox = new TextBox();
            UsernameBox = new TextBox();
            OrderIDLabel = new Label();
            TotalPriceLabel = new Label();
            UserNamelabel = new Label();
            OrderGridView = new DataGridView();
            UserLabel = new Label();
            LogoLabel = new Label();
            AdminTabControl.SuspendLayout();
            AdminMenuTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenudataTable).BeginInit();
            AdminOrderTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderGridView).BeginInit();
            SuspendLayout();
            // 
            // LogOutBtn
            // 
            LogOutBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogOutBtn.Location = new Point(709, 11);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(75, 30);
            LogOutBtn.TabIndex = 23;
            LogOutBtn.Text = "Log-Out";
            LogOutBtn.UseVisualStyleBackColor = true;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // AdminTabControl
            // 
            AdminTabControl.Controls.Add(AdminMenuTabPage);
            AdminTabControl.Controls.Add(AdminOrderTabPage);
            AdminTabControl.Location = new Point(12, 114);
            AdminTabControl.Name = "AdminTabControl";
            AdminTabControl.SelectedIndex = 0;
            AdminTabControl.Size = new Size(776, 326);
            AdminTabControl.TabIndex = 21;
            // 
            // AdminMenuTabPage
            // 
            AdminMenuTabPage.Controls.Add(StockLabel);
            AdminMenuTabPage.Controls.Add(StockInputBox);
            AdminMenuTabPage.Controls.Add(ClearBtn);
            AdminMenuTabPage.Controls.Add(UpdateBtn);
            AdminMenuTabPage.Controls.Add(DeleteBtn);
            AdminMenuTabPage.Controls.Add(AddBtn);
            AdminMenuTabPage.Controls.Add(MenuIDLabel);
            AdminMenuTabPage.Controls.Add(ItemIDBox);
            AdminMenuTabPage.Controls.Add(PriceLabel);
            AdminMenuTabPage.Controls.Add(ItemNameLabel);
            AdminMenuTabPage.Controls.Add(PriceInputBox);
            AdminMenuTabPage.Controls.Add(ItemNameInputBox);
            AdminMenuTabPage.Controls.Add(MenudataTable);
            AdminMenuTabPage.Location = new Point(4, 24);
            AdminMenuTabPage.Name = "AdminMenuTabPage";
            AdminMenuTabPage.Padding = new Padding(3);
            AdminMenuTabPage.Size = new Size(768, 298);
            AdminMenuTabPage.TabIndex = 0;
            AdminMenuTabPage.Text = "Menu";
            AdminMenuTabPage.UseVisualStyleBackColor = true;
            // 
            // StockLabel
            // 
            StockLabel.AutoSize = true;
            StockLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StockLabel.Location = new Point(46, 172);
            StockLabel.Name = "StockLabel";
            StockLabel.Size = new Size(42, 17);
            StockLabel.TabIndex = 59;
            StockLabel.Text = "Stock:";
            // 
            // StockInputBox
            // 
            StockInputBox.Location = new Point(122, 169);
            StockInputBox.Name = "StockInputBox";
            StockInputBox.Size = new Size(163, 23);
            StockInputBox.TabIndex = 58;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(170, 245);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(115, 23);
            ClearBtn.TabIndex = 57;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(170, 207);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(115, 23);
            UpdateBtn.TabIndex = 56;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(46, 245);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(115, 23);
            DeleteBtn.TabIndex = 55;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(46, 207);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(115, 23);
            AddBtn.TabIndex = 54;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // MenuIDLabel
            // 
            MenuIDLabel.AutoSize = true;
            MenuIDLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuIDLabel.Location = new Point(46, 58);
            MenuIDLabel.Name = "MenuIDLabel";
            MenuIDLabel.Size = new Size(52, 17);
            MenuIDLabel.TabIndex = 53;
            MenuIDLabel.Text = "Item ID:";
            // 
            // ItemIDBox
            // 
            ItemIDBox.Enabled = false;
            ItemIDBox.Location = new Point(122, 55);
            ItemIDBox.Name = "ItemIDBox";
            ItemIDBox.ReadOnly = true;
            ItemIDBox.Size = new Size(163, 23);
            ItemIDBox.TabIndex = 52;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PriceLabel.Location = new Point(46, 134);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(39, 17);
            PriceLabel.TabIndex = 51;
            PriceLabel.Text = "Price:";
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ItemNameLabel.Location = new Point(46, 96);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new Size(75, 17);
            ItemNameLabel.TabIndex = 50;
            ItemNameLabel.Text = "Item Name:";
            // 
            // PriceInputBox
            // 
            PriceInputBox.Location = new Point(122, 131);
            PriceInputBox.Name = "PriceInputBox";
            PriceInputBox.Size = new Size(163, 23);
            PriceInputBox.TabIndex = 49;
            // 
            // ItemNameInputBox
            // 
            ItemNameInputBox.Location = new Point(122, 93);
            ItemNameInputBox.Name = "ItemNameInputBox";
            ItemNameInputBox.Size = new Size(163, 23);
            ItemNameInputBox.TabIndex = 48;
            // 
            // MenudataTable
            // 
            MenudataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MenudataTable.Location = new Point(319, 6);
            MenudataTable.Name = "MenudataTable";
            MenudataTable.ReadOnly = true;
            MenudataTable.Size = new Size(443, 286);
            MenudataTable.TabIndex = 29;
            MenudataTable.RowHeaderMouseClick += MenudataTable_RowHeaderMouseClick;
            // 
            // AdminOrderTabPage
            // 
            AdminOrderTabPage.Controls.Add(ClearOrderBtn);
            AdminOrderTabPage.Controls.Add(StatusLabel);
            AdminOrderTabPage.Controls.Add(StatusComboBox);
            AdminOrderTabPage.Controls.Add(UpdateStatusBtn);
            AdminOrderTabPage.Controls.Add(DeleteOrderBtn);
            AdminOrderTabPage.Controls.Add(OrderIDBox);
            AdminOrderTabPage.Controls.Add(TotalPriceBox);
            AdminOrderTabPage.Controls.Add(UsernameBox);
            AdminOrderTabPage.Controls.Add(OrderIDLabel);
            AdminOrderTabPage.Controls.Add(TotalPriceLabel);
            AdminOrderTabPage.Controls.Add(UserNamelabel);
            AdminOrderTabPage.Controls.Add(OrderGridView);
            AdminOrderTabPage.Location = new Point(4, 24);
            AdminOrderTabPage.Name = "AdminOrderTabPage";
            AdminOrderTabPage.Padding = new Padding(3);
            AdminOrderTabPage.Size = new Size(768, 298);
            AdminOrderTabPage.TabIndex = 1;
            AdminOrderTabPage.Text = "Orders";
            AdminOrderTabPage.UseVisualStyleBackColor = true;
            // 
            // ClearOrderBtn
            // 
            ClearOrderBtn.Location = new Point(39, 259);
            ClearOrderBtn.Name = "ClearOrderBtn";
            ClearOrderBtn.Size = new Size(239, 23);
            ClearOrderBtn.TabIndex = 93;
            ClearOrderBtn.Text = "Clear";
            ClearOrderBtn.UseVisualStyleBackColor = true;
            ClearOrderBtn.Click += ClearOrderBtn_Click;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StatusLabel.Location = new Point(39, 154);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(46, 17);
            StatusLabel.TabIndex = 92;
            StatusLabel.Text = "Status:";
            // 
            // StatusComboBox
            // 
            StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Items.AddRange(new object[] { "Cancelled", "Delivered", "Confirmed", "Pending" });
            StatusComboBox.Location = new Point(115, 151);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(163, 23);
            StatusComboBox.TabIndex = 91;
            // 
            // UpdateStatusBtn
            // 
            UpdateStatusBtn.Location = new Point(39, 186);
            UpdateStatusBtn.Name = "UpdateStatusBtn";
            UpdateStatusBtn.Size = new Size(239, 23);
            UpdateStatusBtn.TabIndex = 90;
            UpdateStatusBtn.Text = "Update Status";
            UpdateStatusBtn.UseVisualStyleBackColor = true;
            UpdateStatusBtn.Click += UpdateStatusBtn_Click;
            // 
            // DeleteOrderBtn
            // 
            DeleteOrderBtn.Location = new Point(39, 221);
            DeleteOrderBtn.Name = "DeleteOrderBtn";
            DeleteOrderBtn.Size = new Size(239, 23);
            DeleteOrderBtn.TabIndex = 88;
            DeleteOrderBtn.Text = "Delete";
            DeleteOrderBtn.UseVisualStyleBackColor = true;
            DeleteOrderBtn.Click += DeleteOrderBtn_Click;
            // 
            // OrderIDBox
            // 
            OrderIDBox.Enabled = false;
            OrderIDBox.Location = new Point(115, 46);
            OrderIDBox.Name = "OrderIDBox";
            OrderIDBox.ReadOnly = true;
            OrderIDBox.Size = new Size(163, 23);
            OrderIDBox.TabIndex = 85;
            // 
            // TotalPriceBox
            // 
            TotalPriceBox.Enabled = false;
            TotalPriceBox.Location = new Point(115, 116);
            TotalPriceBox.Name = "TotalPriceBox";
            TotalPriceBox.ReadOnly = true;
            TotalPriceBox.Size = new Size(163, 23);
            TotalPriceBox.TabIndex = 82;
            // 
            // UsernameBox
            // 
            UsernameBox.Enabled = false;
            UsernameBox.Location = new Point(115, 81);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.ReadOnly = true;
            UsernameBox.Size = new Size(163, 23);
            UsernameBox.TabIndex = 81;
            // 
            // OrderIDLabel
            // 
            OrderIDLabel.AutoSize = true;
            OrderIDLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrderIDLabel.Location = new Point(39, 49);
            OrderIDLabel.Name = "OrderIDLabel";
            OrderIDLabel.Size = new Size(62, 17);
            OrderIDLabel.TabIndex = 86;
            OrderIDLabel.Text = "Order ID:";
            // 
            // TotalPriceLabel
            // 
            TotalPriceLabel.AutoSize = true;
            TotalPriceLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalPriceLabel.Location = new Point(39, 119);
            TotalPriceLabel.Name = "TotalPriceLabel";
            TotalPriceLabel.Size = new Size(71, 17);
            TotalPriceLabel.TabIndex = 84;
            TotalPriceLabel.Text = "Total Price:";
            // 
            // UserNamelabel
            // 
            UserNamelabel.AutoSize = true;
            UserNamelabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNamelabel.Location = new Point(39, 84);
            UserNamelabel.Name = "UserNamelabel";
            UserNamelabel.Size = new Size(70, 17);
            UserNamelabel.TabIndex = 83;
            UserNamelabel.Text = "Username:";
            // 
            // OrderGridView
            // 
            OrderGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGridView.Location = new Point(319, 6);
            OrderGridView.Name = "OrderGridView";
            OrderGridView.ReadOnly = true;
            OrderGridView.Size = new Size(443, 286);
            OrderGridView.TabIndex = 30;
            OrderGridView.RowHeaderMouseClick += OrderGridView_RowHeaderMouseClick;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            UserLabel.Location = new Point(12, 85);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(95, 17);
            UserLabel.TabIndex = 20;
            UserLabel.Text = "Welcome, User!";
            // 
            // LogoLabel
            // 
            LogoLabel.AutoSize = true;
            LogoLabel.Font = new Font("Rockwell", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoLabel.Location = new Point(12, 11);
            LogoLabel.Name = "LogoLabel";
            LogoLabel.Size = new Size(310, 62);
            LogoLabel.TabIndex = 19;
            LogoLabel.Text = "FlavorFlow";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LogOutBtn);
            Controls.Add(AdminTabControl);
            Controls.Add(UserLabel);
            Controls.Add(LogoLabel);
            Name = "AdminForm";
            Text = "Admin";
            FormClosed += AdminForm_FormClosed;
            AdminTabControl.ResumeLayout(false);
            AdminMenuTabPage.ResumeLayout(false);
            AdminMenuTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MenudataTable).EndInit();
            AdminOrderTabPage.ResumeLayout(false);
            AdminOrderTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrderGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogOutBtn;
        private TabControl AdminTabControl;
        private TabPage AdminMenuTabPage;
        private TabPage AdminOrderTabPage;
        private Label UserLabel;
        private Label LogoLabel;
        private DataGridView MenudataTable;
        private DataGridView OrderGridView;
        private Button ClearBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button AddBtn;
        private Label MenuIDLabel;
        private TextBox ItemIDBox;
        private Label PriceLabel;
        private Label ItemNameLabel;
        private TextBox PriceInputBox;
        private TextBox ItemNameInputBox;
        private Label StockLabel;
        private TextBox StockInputBox;
        private TextBox OrderIDBox;
        private TextBox TotalPriceBox;
        private TextBox UsernameBox;
        private Label OrderIDLabel;
        private Label TotalPriceLabel;
        private Label UserNamelabel;
        private Button UpdateStatusBtn;
        private Button DeleteOrderBtn;
        private Label StatusLabel;
        private ComboBox StatusComboBox;
        private Button ClearOrderBtn;
    }
}