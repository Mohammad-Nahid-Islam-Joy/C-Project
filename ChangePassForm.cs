using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Food_Ordering_CRUD_App
{
    public partial class ChangePassForm : Form
    {
        private string currentUsername;
        private string currentRole;

        public ChangePassForm(string currentUsername, string currentRole)
        {
            InitializeComponent();
            this.currentUsername = currentUsername;
            this.currentRole = currentRole;

            UsernameLabel.Text = "Username: " + currentUsername;
            TypeLabel.Text = "Type: " + currentRole;
        }

        string connectionString = "Data Source=localhost;" +
                                  "Initial Catalog=FoodAppDB;" +
                                  "Integrated Security=True;" +
                                  "Connect Timeout=30;" +
                                  "Encrypt=True;" +
                                  "Trust Server Certificate=True;" +
                                  "Application Intent=ReadWrite;" +
                                  "Multi Subnet Failover=False;";

        private void ChangePassBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    if (PasswordInputBox.Text == "" && ConfirmPassInputBox.Text == "")
                    {
                        MessageBox.Show("Input Box's Empty! Pleace Input all information..", "Sign-Up Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        if (PasswordInputBox.Text != ConfirmPassInputBox.Text)
                        {
                            MessageBox.Show("Passwords do not match!", "Change Password Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        cnn.Open();

                        string updateCmd = "UPDATE [User] SET UserPassword = @pass WHERE UserName = @name";

                        SqlCommand cmd = new SqlCommand(updateCmd, cnn);

                        cmd.Parameters.AddWithValue("@pass", PasswordInputBox.Text);
                        cmd.Parameters.AddWithValue("@name", currentUsername);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //PasswordInputBox.Clear();
                            //ConfirmPassInputBox.Clear();
                            this.Hide();

                            PasswordInputBox.Focus();
                        }
                        else
                        {
                            MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception caught!");
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        private void ShowPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordInputBox.UseSystemPasswordChar = !ShowPassCheckBox.Checked;
            ConfirmPassInputBox.UseSystemPasswordChar = !ShowPassCheckBox.Checked;
        }
    }
}
