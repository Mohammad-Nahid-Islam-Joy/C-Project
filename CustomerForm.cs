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
    public partial class CustomerForm : Form
    {
        public string currentUser;
        public int currentUserID;

        public CustomerForm(string currentUser, int currentUserID)
        {
            this.currentUser = currentUser;
            this.currentUserID = currentUserID;

            InitializeComponent();
            MenudataTable.DataSource = GetMenu();
            OrderGridView.DataSource = GetOrder();

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
        private const string checkStockQuery = "SELECT Stock FROM Menu WHERE ItemID = @iid";
        private const string AddItemToOrderCmd = "INSERT INTO [Order] (UserID, ItemID, Quantity, TotalPrice) VALUES (@uid, @iid, @qnt, @tprice)";
        private const string updateStockinMenuCmd = "UPDATE Menu SET Stock = Stock - @qnt WHERE ItemID = @iid";

        private const string selectOrderCmd = "SELECT o.OrderID, m.ItemName, o.Quantity, m.Price, o.TotalPrice, o.OrderDate, o.Status FROM [Order] o JOIN Menu m ON o.ItemID = m.ItemID WHERE o.UserID = @uid";
        private const string updateOrderCmd = "UPDATE [Order] SET Quantity = @newQty, TotalPrice = @newQty * (SELECT Price FROM Menu WHERE ItemID = @iid) WHERE OrderID = @oid";
        private const string updateStockinOrderCmd = "UPDATE [Menu] SET Stock = Stock + @oldQty - @newQty WHERE ItemID = @iid";

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

        public bool AddItemToOrder()
        {
            int rows = 0;

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();

                try
                {
                    if (string.IsNullOrWhiteSpace(ItemIDBox.Text) ||
                        string.IsNullOrWhiteSpace(QuantityBox.Text) ||
                        string.IsNullOrWhiteSpace(PriceInputBox.Text))
                    {
                        MessageBox.Show("Please fill all fields!");
                        return false;
                    }

                    int itemId = Convert.ToInt32(ItemIDBox.Text);
                    int quantity = Convert.ToInt32(QuantityBox.Text);
                    decimal itemPrice = Convert.ToDecimal(PriceInputBox.Text);

                    decimal totalPrice = itemPrice * quantity;

                    using (SqlCommand checkCmd = new SqlCommand(checkStockQuery, cnn))
                    {
                        checkCmd.Parameters.AddWithValue("@iid", itemId);

                        object result = checkCmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Item not found!");
                            return false;
                        }

                        int stock = Convert.ToInt32(result);

                        if (stock < quantity)
                        {
                            MessageBox.Show("Not enough stock available!");
                            return false;
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand(AddItemToOrderCmd, cnn))
                    {
                        cmd.Parameters.AddWithValue("@uid", currentUserID);
                        cmd.Parameters.AddWithValue("@iid", itemId);
                        cmd.Parameters.AddWithValue("@qnt", quantity);
                        cmd.Parameters.AddWithValue("@tprice", totalPrice);

                        rows = cmd.ExecuteNonQuery();
                    }

                    // STEP 3: UPDATE STOCK
                    using (SqlCommand stockCmd = new SqlCommand(updateStockinMenuCmd, cnn))
                    {
                        stockCmd.Parameters.AddWithValue("@qnt", quantity);
                        stockCmd.Parameters.AddWithValue("@iid", itemId);

                        stockCmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }

            return rows > 0;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var success = AddItemToOrder();

            if (success)
            {
                MessageBox.Show("Order has been added successfully");
                MenudataTable.DataSource = GetMenu();
                OrderGridView.DataSource = GetOrder();
                ClearControls();
            }
            else
            {
                MessageBox.Show("Error occured. Please try again...");
            }
        }

        public DataTable GetOrder()
        {
            var dataTable = new DataTable();

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(selectOrderCmd, cnn))
                {
                    cmd.Parameters.Add("@uid", SqlDbType.Int).Value = currentUserID;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public bool UpdateOrderItem()
        {
            int rows = 0;

            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();

                    int orderId = Convert.ToInt32(OrderIDBox.Text);
                    int newQty = Convert.ToInt32(OrderQntBox.Text);

                    int oldQty = 0;
                    int itemId = 0;

                    string getData = "SELECT Quantity, ItemID FROM [Order] WHERE OrderID = @oid";

                    using (SqlCommand getCmd = new SqlCommand(getData, cnn))
                    {
                        getCmd.Parameters.AddWithValue("@oid", orderId);

                        using (SqlDataReader dr = getCmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                oldQty = Convert.ToInt32(dr["Quantity"]);
                                itemId = Convert.ToInt32(dr["ItemID"]);
                            }
                            else
                            {
                                MessageBox.Show("Order not found!");
                                return false;
                            }
                        }
                    }

                    int diff = newQty - oldQty;

                    using (SqlCommand cmd = new SqlCommand(updateOrderCmd, cnn))
                    {
                        cmd.Parameters.AddWithValue("@newQty", newQty);
                        cmd.Parameters.AddWithValue("@iid", itemId);
                        cmd.Parameters.AddWithValue("@oid", orderId);

                        rows = cmd.ExecuteNonQuery();
                    }

                    using (SqlCommand stockCmd = new SqlCommand(updateStockinOrderCmd, cnn))
                    {
                        stockCmd.Parameters.AddWithValue("@oldQty", oldQty);
                        stockCmd.Parameters.AddWithValue("@newQty", newQty);
                        stockCmd.Parameters.AddWithValue("@iid", itemId);

                        stockCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input! Please enter valid numbers.");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }

            return rows > 0;
        }

        private void UpdateOrderBtn_Click(object sender, EventArgs e)
        {
            var success = UpdateOrderItem();

            if (success)
            {
                MessageBox.Show("Order has been Updated successfully");
                MenudataTable.DataSource = GetMenu();
                OrderGridView.DataSource = GetOrder();
                ClearControls();
            }
            else
            {
                MessageBox.Show("Error occured. Please try again...");
            }
        }

        public bool DeleteOrderItem()
        {
            int rows = 0;

            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();

                    int orderId = Convert.ToInt32(OrderIDBox.Text);

                    int itemId = 0;
                    int qty = 0;

                    // STEP 1: GET ITEM DATA
                    string getData = "SELECT ItemID, Quantity FROM [Order] WHERE OrderID = @oid";

                    using (SqlCommand getCmd = new SqlCommand(getData, cnn))
                    {
                        getCmd.Parameters.AddWithValue("@oid", orderId);

                        using (SqlDataReader dr = getCmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                itemId = Convert.ToInt32(dr["ItemID"]);
                                qty = Convert.ToInt32(dr["Quantity"]);
                            }
                            else
                            {
                                MessageBox.Show("Order not found!");
                                return false;
                            }
                        }
                    }

                    // STEP 2: DELETE ORDER
                    string deleteCmd = "DELETE FROM [Order] WHERE OrderID = @oid";

                    using (SqlCommand cmd = new SqlCommand(deleteCmd, cnn))
                    {
                        cmd.Parameters.AddWithValue("@oid", orderId);

                        rows = cmd.ExecuteNonQuery();
                    }

                    // STEP 3: RESTORE STOCK
                    string restoreStock =
                        "UPDATE Menu SET Stock = Stock + @qty WHERE ItemID = @iid";

                    using (SqlCommand stockCmd = new SqlCommand(restoreStock, cnn))
                    {
                        stockCmd.Parameters.AddWithValue("@qty", qty);
                        stockCmd.Parameters.AddWithValue("@iid", itemId);

                        stockCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Order ID!");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }

            return rows > 0;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var success = DeleteOrderItem();

            if (success)
            {
                MessageBox.Show("Order has been deleted successfully");
                MenudataTable.DataSource = GetMenu();
                OrderGridView.DataSource = GetOrder();
                ClearControls();
            }
            else
            {
                MessageBox.Show("Error occured. Please try again...");
            }
        }

        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            ItemIDBox.Text = "";
            ItemNameInputBox.Text = "";
            PriceInputBox.Text = "";
            QuantityBox.Text = "";
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
            OrderItemNameBox.Text = MenudataTable.Rows[index].Cells[1].Value?.ToString() ?? "";
            TotalPriceBox.Text = OrderGridView.Rows[index].Cells[4].Value?.ToString() ?? "";
            OrderQntBox.Text = OrderGridView.Rows[index].Cells[2].Value?.ToString() ?? "";
        }

    }
}
