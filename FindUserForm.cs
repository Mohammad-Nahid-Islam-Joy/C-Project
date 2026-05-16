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
    public partial class FindUserForm : Form
    {
        public FindUserForm()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=localhost;" +
                                  "Initial Catalog=FoodAppDB;" +
                                  "Integrated Security=True;" +
                                  "Connect Timeout=30;" +
                                  "Encrypt=True;" +
                                  "Trust Server Certificate=True;" +
                                  "Application Intent=ReadWrite;" +
                                  "Multi Subnet Failover=False;";

        private void SearchUserBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            { 
                try
                {
                    if (UsernameInputBox.Text == "")
                    {
                        MessageBox.Show("Input Box's Empty! Pleace Input all information..", "Sign-Up Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        cnn.Open();
                        string searchCmd = "SELECT * FROM [User] WHERE UserName = @name";

                        SqlCommand cmd = new SqlCommand(searchCmd, cnn);

                        cmd.Parameters.AddWithValue("@name", UsernameInputBox.Text);

                        SqlDataReader dr = cmd.ExecuteReader();

                        if(dr.Read())
                        {
                            string username = Convert.ToString(dr["UserName"])!;
                            string role = Convert.ToString(dr["Role"])!;

                            ChangePassForm changePassForm = new ChangePassForm(username, role);
                            this.Hide();
                            changePassForm.ShowDialog();
                        }

                        else
                        {
                            MessageBox.Show("User not found.", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FindUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
