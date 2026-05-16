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
    public partial class SuperAdminForm : Form
    {
        private string currentUser;

        public SuperAdminForm(string currentUser)
        {
            InitializeComponent();
            UserdataTable.DataSource = GetUser();
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

        private const string selectCmd = "SELECT * FROM [User]";
        private const string insertCmd = "INSERT INTO [User] (UserName, UserPassword, Role) VALUES (@name, @pass, @role)";
        private const string updateCmd = "UPDATE [User] SET UserName = @name, UserPassword = @pass, Role = @role WHERE UserID = @id";
        private const string deleteCmd = "DELETE FROM [User] WHERE UserID = @id";

        public DataTable GetUser()
        {
            var dataTable = new DataTable();

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(selectCmd, cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public bool InsertUser()
        {
            int rows;
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(insertCmd, cnn))
                {
                    cmd.Parameters.AddWithValue("@name", UsernameInputBox.Text);
                    cmd.Parameters.AddWithValue("@pass", PasswordInputBox.Text);

                    string? role = TypeComboBox.SelectedItem?.ToString();

                    if (string.IsNullOrWhiteSpace(role))
                    {
                        MessageBox.Show("Please select a role.");
                        return false;
                    }

                    cmd.Parameters.AddWithValue("@role", role);

                    rows = cmd.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        public bool UpdateUser()
        {
            int rows;
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(updateCmd, cnn))
                {
                    cmd.Parameters.AddWithValue("@id", UserIDBox.Text);
                    cmd.Parameters.AddWithValue("@name", UsernameInputBox.Text);
                    cmd.Parameters.AddWithValue("@pass", PasswordInputBox.Text);

                    string? role = TypeComboBox.SelectedItem?.ToString();

                    if (string.IsNullOrWhiteSpace(role))
                    {
                        MessageBox.Show("Please select a role.");
                        return false;
                    }

                    cmd.Parameters.AddWithValue("@role", role);

                    rows = cmd.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        public bool DeleteUser()
        {
            int rows;
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(deleteCmd, cnn))
                {
                    cmd.Parameters.AddWithValue("@id", UserIDBox.Text);

                    rows = cmd.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var success = InsertUser();
            UserdataTable.DataSource = GetUser();
            ClearControls();

            if (success)
            {
                MessageBox.Show("User has been added successfully");
            }
            else
            {
                MessageBox.Show("Error occured. Please try again...");
            }
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var success = UpdateUser();
            UserdataTable.DataSource = GetUser();
            ClearControls();

            if (success)
            {
                MessageBox.Show("User has been update successfully");
            }
            else
            {
                MessageBox.Show("Error occured. Please try again...");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var success = DeleteUser();
            UserdataTable.DataSource = GetUser();
            ClearControls();

            if (success)
            {
                MessageBox.Show("User has been deleted successfully");
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

        private void ClearControls()
        {
            UserIDBox.Text = "";
            UsernameInputBox.Text = "";
            PasswordInputBox.Text = "";
            TypeComboBox.SelectedIndex = -1;
        }
        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Hide();
        }

        private void SuperAdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UserdataTable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = e.RowIndex;
            UserIDBox.Text = UserdataTable.Rows[index].Cells[0].Value?.ToString() ?? "";
            UsernameInputBox.Text = UserdataTable.Rows[index].Cells[1].Value?.ToString() ?? "";
            PasswordInputBox.Text = UserdataTable.Rows[index].Cells[2].Value?.ToString() ?? "";
            TypeComboBox.Text = UserdataTable.Rows[index].Cells[3].Value?.ToString() ?? "";
        }
    }
}
