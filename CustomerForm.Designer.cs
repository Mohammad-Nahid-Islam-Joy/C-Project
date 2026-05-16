namespace Food_Ordering_CRUD_App
{
    partial class CustomerForm
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
            LogoLabel = new Label();
            UserLabel = new Label();
            LogOutBtn = new Button();
            CustomerOrderTabPage = new TabPage();
            DeleteBtn = new Button();
            UpdateOrderBtn = new Button();
            OrderQntLabel = new Label();
            OrderQntBox = new TextBox();
            OrderIDBox = new TextBox();
            TotalPriceBox = new TextBox();
            OrderItemNameBox = new TextBox();
            OrderIDLabel = new Label();
            TotalPriceLabel = new Label();
            OrderItemlabel = new Label();
            OrderGridView = new DataGridView();
            CustomerMenuTabPage = new TabPage();
            ClearBtn = new Button();
            AddBtn = new Button();
            QuantityLabel = new Label();
            QuantityBox = new TextBox();
            ItemIDBox = new TextBox();
            PriceInputBox = new TextBox();
            ItemNameInputBox = new TextBox();
            MenuIDLabel = new Label();
            PriceLabel = new Label();
            ItemNameLabel = new Label();
            MenudataTable = new DataGridView();
            CustomerTabControl = new TabControl();
            CustomerOrderTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderGridView).BeginInit();
            CustomerMenuTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenudataTable).BeginInit();
            CustomerTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // LogoLabel
            // 
            LogoLabel.AutoSize = true;
            LogoLabel.Font = new Font("Rockwell", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoLabel.Location = new Point(12, 9);
            LogoLabel.Name = "LogoLabel";
            LogoLabel.Size = new Size(310, 62);
            LogoLabel.TabIndex = 13;
            LogoLabel.Text = "FlavorFlow";
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            UserLabel.Location = new Point(12, 83);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(95, 17);
            UserLabel.TabIndex = 14;
            UserLabel.Text = "Welcome, User!";
            // 
            // LogOutBtn
            // 
            LogOutBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogOutBtn.Location = new Point(709, 9);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(75, 30);
            LogOutBtn.TabIndex = 18;
            LogOutBtn.Text = "Log-Out";
            LogOutBtn.UseVisualStyleBackColor = true;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // CustomerOrderTabPage
            // 
            CustomerOrderTabPage.Controls.Add(DeleteBtn);
            CustomerOrderTabPage.Controls.Add(UpdateOrderBtn);
            CustomerOrderTabPage.Controls.Add(OrderQntLabel);
            CustomerOrderTabPage.Controls.Add(OrderQntBox);
            CustomerOrderTabPage.Controls.Add(OrderIDBox);
            CustomerOrderTabPage.Controls.Add(TotalPriceBox);
            CustomerOrderTabPage.Controls.Add(OrderItemNameBox);
            CustomerOrderTabPage.Controls.Add(OrderIDLabel);
            CustomerOrderTabPage.Controls.Add(TotalPriceLabel);
            CustomerOrderTabPage.Controls.Add(OrderItemlabel);
            CustomerOrderTabPage.Controls.Add(OrderGridView);
            CustomerOrderTabPage.Location = new Point(4, 24);
            CustomerOrderTabPage.Name = "CustomerOrderTabPage";
            CustomerOrderTabPage.Padding = new Padding(3);
            CustomerOrderTabPage.Size = new Size(768, 298);
            CustomerOrderTabPage.TabIndex = 1;
            CustomerOrderTabPage.Text = "Order";
            CustomerOrderTabPage.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(39, 233);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(239, 23);
            DeleteBtn.TabIndex = 84;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UpdateOrderBtn
            // 
            UpdateOrderBtn.Location = new Point(39, 192);
            UpdateOrderBtn.Name = "UpdateOrderBtn";
            UpdateOrderBtn.Size = new Size(239, 23);
            UpdateOrderBtn.TabIndex = 83;
            UpdateOrderBtn.Text = "Update";
            UpdateOrderBtn.UseVisualStyleBackColor = true;
            UpdateOrderBtn.Click += UpdateOrderBtn_Click;
            // 
            // OrderQntLabel
            // 
            OrderQntLabel.AutoSize = true;
            OrderQntLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrderQntLabel.Location = new Point(39, 157);
            OrderQntLabel.Name = "OrderQntLabel";
            OrderQntLabel.Size = new Size(59, 17);
            OrderQntLabel.TabIndex = 82;
            OrderQntLabel.Text = "Quantity:";
            // 
            // OrderQntBox
            // 
            OrderQntBox.Location = new Point(115, 154);
            OrderQntBox.Name = "OrderQntBox";
            OrderQntBox.Size = new Size(163, 23);
            OrderQntBox.TabIndex = 81;
            // 
            // OrderIDBox
            // 
            OrderIDBox.Enabled = false;
            OrderIDBox.Location = new Point(115, 40);
            OrderIDBox.Name = "OrderIDBox";
            OrderIDBox.ReadOnly = true;
            OrderIDBox.Size = new Size(163, 23);
            OrderIDBox.TabIndex = 79;
            // 
            // TotalPriceBox
            // 
            TotalPriceBox.Enabled = false;
            TotalPriceBox.Location = new Point(115, 116);
            TotalPriceBox.Name = "TotalPriceBox";
            TotalPriceBox.ReadOnly = true;
            TotalPriceBox.Size = new Size(163, 23);
            TotalPriceBox.TabIndex = 76;
            // 
            // OrderItemNameBox
            // 
            OrderItemNameBox.Enabled = false;
            OrderItemNameBox.Location = new Point(115, 78);
            OrderItemNameBox.Name = "OrderItemNameBox";
            OrderItemNameBox.ReadOnly = true;
            OrderItemNameBox.Size = new Size(163, 23);
            OrderItemNameBox.TabIndex = 75;
            // 
            // OrderIDLabel
            // 
            OrderIDLabel.AutoSize = true;
            OrderIDLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrderIDLabel.Location = new Point(39, 43);
            OrderIDLabel.Name = "OrderIDLabel";
            OrderIDLabel.Size = new Size(62, 17);
            OrderIDLabel.TabIndex = 80;
            OrderIDLabel.Text = "Order ID:";
            // 
            // TotalPriceLabel
            // 
            TotalPriceLabel.AutoSize = true;
            TotalPriceLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalPriceLabel.Location = new Point(39, 119);
            TotalPriceLabel.Name = "TotalPriceLabel";
            TotalPriceLabel.Size = new Size(71, 17);
            TotalPriceLabel.TabIndex = 78;
            TotalPriceLabel.Text = "Total Price:";
            // 
            // OrderItemlabel
            // 
            OrderItemlabel.AutoSize = true;
            OrderItemlabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrderItemlabel.Location = new Point(39, 81);
            OrderItemlabel.Name = "OrderItemlabel";
            OrderItemlabel.Size = new Size(75, 17);
            OrderItemlabel.TabIndex = 77;
            OrderItemlabel.Text = "Item Name:";
            // 
            // OrderGridView
            // 
            OrderGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGridView.Location = new Point(319, 6);
            OrderGridView.Name = "OrderGridView";
            OrderGridView.ReadOnly = true;
            OrderGridView.Size = new Size(443, 286);
            OrderGridView.TabIndex = 61;
            OrderGridView.RowHeaderMouseClick += OrderGridView_RowHeaderMouseClick;
            // 
            // CustomerMenuTabPage
            // 
            CustomerMenuTabPage.Controls.Add(ClearBtn);
            CustomerMenuTabPage.Controls.Add(AddBtn);
            CustomerMenuTabPage.Controls.Add(QuantityLabel);
            CustomerMenuTabPage.Controls.Add(QuantityBox);
            CustomerMenuTabPage.Controls.Add(ItemIDBox);
            CustomerMenuTabPage.Controls.Add(PriceInputBox);
            CustomerMenuTabPage.Controls.Add(ItemNameInputBox);
            CustomerMenuTabPage.Controls.Add(MenuIDLabel);
            CustomerMenuTabPage.Controls.Add(PriceLabel);
            CustomerMenuTabPage.Controls.Add(ItemNameLabel);
            CustomerMenuTabPage.Controls.Add(MenudataTable);
            CustomerMenuTabPage.Location = new Point(4, 24);
            CustomerMenuTabPage.Name = "CustomerMenuTabPage";
            CustomerMenuTabPage.Padding = new Padding(3);
            CustomerMenuTabPage.Size = new Size(768, 298);
            CustomerMenuTabPage.TabIndex = 0;
            CustomerMenuTabPage.Text = "Menu";
            CustomerMenuTabPage.UseVisualStyleBackColor = true;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(31, 229);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(239, 23);
            ClearBtn.TabIndex = 74;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(31, 188);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(239, 23);
            AddBtn.TabIndex = 73;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuantityLabel.Location = new Point(31, 153);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(59, 17);
            QuantityLabel.TabIndex = 72;
            QuantityLabel.Text = "Quantity:";
            // 
            // QuantityBox
            // 
            QuantityBox.Location = new Point(107, 150);
            QuantityBox.Name = "QuantityBox";
            QuantityBox.Size = new Size(163, 23);
            QuantityBox.TabIndex = 71;
            // 
            // ItemIDBox
            // 
            ItemIDBox.Enabled = false;
            ItemIDBox.Location = new Point(107, 36);
            ItemIDBox.Name = "ItemIDBox";
            ItemIDBox.ReadOnly = true;
            ItemIDBox.Size = new Size(163, 23);
            ItemIDBox.TabIndex = 65;
            // 
            // PriceInputBox
            // 
            PriceInputBox.Enabled = false;
            PriceInputBox.Location = new Point(107, 112);
            PriceInputBox.Name = "PriceInputBox";
            PriceInputBox.ReadOnly = true;
            PriceInputBox.Size = new Size(163, 23);
            PriceInputBox.TabIndex = 62;
            // 
            // ItemNameInputBox
            // 
            ItemNameInputBox.Enabled = false;
            ItemNameInputBox.Location = new Point(107, 74);
            ItemNameInputBox.Name = "ItemNameInputBox";
            ItemNameInputBox.ReadOnly = true;
            ItemNameInputBox.Size = new Size(163, 23);
            ItemNameInputBox.TabIndex = 61;
            // 
            // MenuIDLabel
            // 
            MenuIDLabel.AutoSize = true;
            MenuIDLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuIDLabel.Location = new Point(31, 39);
            MenuIDLabel.Name = "MenuIDLabel";
            MenuIDLabel.Size = new Size(52, 17);
            MenuIDLabel.TabIndex = 66;
            MenuIDLabel.Text = "Item ID:";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PriceLabel.Location = new Point(31, 115);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(39, 17);
            PriceLabel.TabIndex = 64;
            PriceLabel.Text = "Price:";
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ItemNameLabel.Location = new Point(31, 77);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new Size(75, 17);
            ItemNameLabel.TabIndex = 63;
            ItemNameLabel.Text = "Item Name:";
            // 
            // MenudataTable
            // 
            MenudataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MenudataTable.Location = new Point(319, 6);
            MenudataTable.Name = "MenudataTable";
            MenudataTable.ReadOnly = true;
            MenudataTable.Size = new Size(443, 286);
            MenudataTable.TabIndex = 60;
            MenudataTable.RowHeaderMouseClick += MenudataTable_RowHeaderMouseClick;
            // 
            // CustomerTabControl
            // 
            CustomerTabControl.Controls.Add(CustomerMenuTabPage);
            CustomerTabControl.Controls.Add(CustomerOrderTabPage);
            CustomerTabControl.Location = new Point(12, 112);
            CustomerTabControl.Name = "CustomerTabControl";
            CustomerTabControl.SelectedIndex = 0;
            CustomerTabControl.Size = new Size(776, 326);
            CustomerTabControl.TabIndex = 15;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LogOutBtn);
            Controls.Add(CustomerTabControl);
            Controls.Add(UserLabel);
            Controls.Add(LogoLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            FormClosed += CustomerForm_FormClosed;
            CustomerOrderTabPage.ResumeLayout(false);
            CustomerOrderTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrderGridView).EndInit();
            CustomerMenuTabPage.ResumeLayout(false);
            CustomerMenuTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MenudataTable).EndInit();
            CustomerTabControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LogoLabel;
        private Label UserLabel;
        private Button LogOutBtn;
        private TabPage CustomerOrderTabPage;
        private TabPage CustomerMenuTabPage;
        private Label QuantityLabel;
        private TextBox QuantityBox;
        private TextBox ItemIDBox;
        private TextBox PriceInputBox;
        private TextBox ItemNameInputBox;
        private Label MenuIDLabel;
        private Label PriceLabel;
        private Label ItemNameLabel;
        private DataGridView MenudataTable;
        private TabControl CustomerTabControl;
        private DataGridView OrderGridView;
        private Button ClearBtn;
        private Button AddBtn;
        private Button DeleteBtn;
        private Button UpdateOrderBtn;
        private Label OrderQntLabel;
        private TextBox OrderQntBox;
        private TextBox OrderIDBox;
        private TextBox TotalPriceBox;
        private TextBox OrderItemNameBox;
        private Label OrderIDLabel;
        private Label TotalPriceLabel;
        private Label OrderItemlabel;
    }
}