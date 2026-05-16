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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
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
        
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    if (UsernameInputBox.Text == "" && PasswordInputBox.Text == "" && ConfirmPassInputBox.Text == "")
                    {
                        MessageBox.Show("Input Box's Empty! Pleace Input all information..", "Sign-Up Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else if (PasswordInputBox.Text == ConfirmPassInputBox.Text)
                    {
                        string signUpCmd = "INSERT INTO [User] (UserName, UserPassword, Role) VALUES (@name, @pass, @role)";

                        SqlCommand cmd = new SqlCommand(signUpCmd, cnn);

                        cmd.Parameters.AddWithValue("@name", UsernameInputBox.Text);
                        cmd.Parameters.AddWithValue("@pass", PasswordInputBox.Text);
                        
                        string? role = TypeComboBox.SelectedItem?.ToString();

                        if (string.IsNullOrWhiteSpace(role))
                        {
                            MessageBox.Show("Please select a role.");
                            return;
                        }

                        cmd.Parameters.AddWithValue("@role", role);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        UsernameInputBox.Text = "";
                        PasswordInputBox.Text = "";
                        ConfirmPassInputBox.Text = "";
                        TypeComboBox.SelectedIndex = -1;
                        UsernameInputBox.Focus();

                        MessageBox.Show("Your Account has been Sucessfully Created", "Sign-Up Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LogInForm logInForm = new LogInForm();
                        logInForm.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Password does not matched , Please Re-enter", "Sign-Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        PasswordInputBox.Text = "";
                        ConfirmPassInputBox.Text = "";
                        PasswordInputBox.Focus();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Exception caught!");
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        private void LogInLinkLabel_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Hide();
        }


        private void ShowPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordInputBox.UseSystemPasswordChar = !ShowPassCheckBox.Checked;
            ConfirmPassInputBox.UseSystemPasswordChar = !ShowPassCheckBox.Checked;
        }

        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
