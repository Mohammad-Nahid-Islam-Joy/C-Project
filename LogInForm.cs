using Microsoft.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace Food_Ordering_CRUD_App
{
    public partial class LogInForm : Form
    {
        public LogInForm()
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

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    if (UsernameInputBox.Text == "" && PasswordInputBox.Text == "")
                    {
                        MessageBox.Show("Input Box's Empty! Pleace Input all information..", "Sign-Up Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        string role = "";

                        if (TypeCustomerRadioButton.Checked)
                        {
                            role = "Customer";
                        }
                        else if (TypeAdminRadioButton.Checked)
                        {
                            role = "Admin";
                        }
                        else if (TypeSuperAdminRadioButton.Checked)
                        {
                            role = "SuperAdmin";
                        }
                        else
                        {
                            MessageBox.Show("Please select a role");
                            return;
                        }

                        cnn.Open();

                        string loginCmd = "SELECT * FROM [User] WHERE UserName = @name AND UserPassword = @pass AND Role = @role";

                        SqlCommand cmd = new SqlCommand(loginCmd, cnn);

                        cmd.Parameters.AddWithValue("@name", UsernameInputBox.Text);
                        cmd.Parameters.AddWithValue("@pass", PasswordInputBox.Text);
                        cmd.Parameters.AddWithValue("@role", role);

                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            if (role == "Admin")
                            {
                                string username = dr["UserName"].ToString()!;
                                AdminForm f = new AdminForm(username);
                                f.Show();
                                //MessageBox.Show("Admin");
                            }
                            else if (role == "Customer")
                            {
                                string username = dr["UserName"].ToString()!;
                                int userId = Convert.ToInt32(dr["UserID"]);
                                CustomerForm f = new CustomerForm(username, userId);
                                f.Show();

                                //MessageBox.Show("Customer");

                                this.Hide();
                            }
                            else if (role == "SuperAdmin")
                            {
                                string username = dr["UserName"].ToString()!;
                                SuperAdminForm f = new SuperAdminForm(username);
                                f.Show();
                                //MessageBox.Show("SuperAdmin");

                                this.Hide();
                            }

                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Wrong Information , Please Try Again", "Login Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            UsernameInputBox.Text = "";
                            PasswordInputBox.Text = "";

                            TypeCustomerRadioButton.Checked = false;
                            TypeAdminRadioButton.Checked = false;
                            TypeSuperAdminRadioButton.Checked = false;

                            UsernameInputBox.Focus();
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

        private void SignUpLinkLabel_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void ForgotPassLinkLabel_Click(object sender, EventArgs e)
        {
            FindUserForm findUserForm = new FindUserForm();
            findUserForm.ShowDialog();
        }

        private void ShowPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordInputBox.UseSystemPasswordChar = !ShowPassCheckBox.Checked;
        }

        private void LogInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
