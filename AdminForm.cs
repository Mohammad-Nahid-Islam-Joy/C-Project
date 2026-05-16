using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Food_Ordering_CRUD_App
{
    public partial class AdminForm : Form
    {
        private string currentUser;

        public AdminForm(string currentUser)
        {
            InitializeComponent();
            MenudataTable.DataSource = GetMenu();
            OrderGridView.DataSource = GetOrder();
            this.currentUser = currentUser;

            UserLabel.Text = "Welcome, " + currentUser + "!";
        }

        string connectionString = "Data Source=localhost;" +
                                  "Initial Catalog=FoodAppDB;" +
                                  "Integrated Security=True;" +
                                  "Connect Timeout=30;" +
                                  "Encrypt=True;" +
                                  "Trust Server Certificate=True;" +
                                  "Application Intent=ReadWrite;" +
                                  "Multi Subnet Failover=False;";

        private const string selectMenuCmd = "SELECT * FROM [Menu]";
        private const string insertCmd = "INSERT INTO [Menu] (ItemName, Price, Stock) VALUES (@name, @price, @stock)";
        private const string updateCmd = "UPDATE [Menu] SET ItemName = @name, Price = @price, Stock = @stock WHERE ItemID = @id";
        private const string deleteCmd = "DELETE FROM [Menu] WHERE ItemID = @id";

        private const string selectOrderCmd = "SELECT o.OrderID, u.UserName, o.TotalPrice, o.Status FROM [Order] o JOIN [User] u ON o.UserID = u.UserID;";
        private const string updateOrderStatusCmd = "UPDATE [Order] SET Status = @status WHERE OrderID = @oid";
        private const string deleteOrderCmd = "DELETE FROM [Order] WHERE OrderID = @oid;";

        public DataTable GetMenu()
        {
            var dataTable = new DataTable();

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(selectMenuCmd, cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public bool InsertItem()
        {
            int rows;
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(insertCmd, cnn))
                {
                    cmd.Parameters.AddWithValue("@name", ItemNameInputBox.Text);
                    cmd.Parameters.AddWithValue("@price", PriceInputBox.Text);
                    cmd.Parameters.AddWithValue("@stock", StockInputBox.Text);

                    rows = cmd.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        public bool UpdateItem()
        {
            int rows;
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(updateCmd, cnn))
                {
                    cmd.Parameters.AddWithValue("@id", ItemIDBox.Text);
                    cmd.Parameters.AddWithValue("@name", ItemNameInputBox.Text);
                    cmd.Parameters.AddWithValue("@price", PriceInputBox.Text);
                    cmd.Parameters.AddWithValue("@stock", StockInputBox.Text);

                    rows = cmd.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        public bool DeleteItem()
        {
            int rows;
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(deleteCmd, cnn))
                {
                    cmd.Parameters.AddWithValue("@id", ItemIDBox.Text);

                    rows = cmd.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var success = InsertItem();
            MenudataTable.DataSource = GetMenu();
            ClearControls();

            if (success)
            {
                MessageBox.Show("Item has been added successfully");
            }
            else
            {
                MessageBox.Show("Error occured. Please try again...");
            }
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var success = UpdateItem();
            MenudataTable.DataSource = GetMenu();
            ClearControls();

            if (success)
            {
                MessageBox.Show("Item has been updated successfully");
            }
            else
            {
                MessageBox.Show("Error occured. Please try again...");
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var success = DeleteItem();
            MenudataTable.DataSource = GetMenu();
            ClearControls();

            if (success)
            {
                MessageBox.Show("Item has been deleted successfully");
            }
            else
            {
                MessageBox.Show("Error occured. Please try again...");
            }
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        public DataTable GetOrder()
        {
            var dataTable = new DataTable();

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(selectOrderCmd, cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public bool UpdateOrderStatus()
        {
            int rows;
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(updateOrderStatusCmd, cnn))
                {
                    cmd.Parameters.AddWithValue("@oid", OrderIDBox.Text);

                    string? status = StatusComboBox.SelectedItem?.ToString();

                    if (string.IsNullOrWhiteSpace(status))
                    {
                        MessageBox.Show("Please select a status.");
                        return false;
                    }

                    cmd.Parameters.AddWithValue("@status", status);

                    rows = cmd.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
        private void UpdateStatusBtn_Click(object sender, EventArgs e)
        {
            var success = UpdateOrderStatus();
            OrderGridView.DataSource = GetOrder();
            ClearControls();

            if (success)
            {
                MessageBox.Show("Order Status has been updated successfully");
            }
            else
            {
                MessageBox.Show("Error occured. Please try again...");
            }
        }

        public bool DeleteOrder()
        {
            int rows;
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(deleteOrderCmd, cnn))
                {
                    cmd.Parameters.AddWithValue("@oid", OrderIDBox.Text);

                    rows = cmd.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
    
        private void DeleteOrderBtn_Click(object sender, EventArgs e)
        {
            var success = DeleteOrder();
            OrderGridView.DataSource = GetOrder();
            ClearControls();

            if (success)
            {
                MessageBox.Show("Order has been deleted successfully");
            }
            else
            {
                MessageBox.Show("Error occured. Please try again...");
            }
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void ClearControls()
        {
            ItemIDBox.Text = "";
            ItemNameInputBox.Text = "";
            PriceInputBox.Text = "";
            StockInputBox.Text = "";

            OrderIDBox.Text = "";
            UsernameBox.Text = "";
            TotalPriceBox.Text = "";
            StatusComboBox.SelectedIndex = -1;
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            LogInForm form = new LogInForm();
            form.Show();
            this.Hide();
        }

        private void MenudataTable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = e.RowIndex;
            ItemIDBox.Text = MenudataTable.Rows[index].Cells[0].Value?.ToString() ?? "";
            ItemNameInputBox.Text = MenudataTable.Rows[index].Cells[1].Value?.ToString() ?? "";
            PriceInputBox.Text = MenudataTable.Rows[index].Cells[2].Value?.ToString() ?? "";
        }

        private void OrderGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = e.RowIndex;
            OrderIDBox.Text = OrderGridView.Rows[index].Cells[0].Value?.ToString() ?? "";
            UsernameBox.Text = OrderGridView.Rows[index].Cells[1].Value?.ToString() ?? "";
            TotalPriceBox.Text = OrderGridView.Rows[index].Cells[2].Value?.ToString() ?? "";
            StatusComboBox.Text = OrderGridView.Rows[index].Cells[3].Value?.ToString() ?? "";
        }

        private void ClearOrderBtn_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

    }
}
