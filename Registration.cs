using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Dashboard
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Show or hide the password based on the checkbox state
            passwordTextBox.UseSystemPasswordChar = checkBox1.Checked;
            confirmPasswordTextBox.UseSystemPasswordChar = checkBox1.Checked;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Open File";
                openFileDialog.Filter = "All Files (*.*)|*.*"; // You can specify file types here.

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                  
                    // Do something with the selected file path, e.g., display it in a TextBox or process the file.
                }
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string studentId = studentIdTextBox.Text;
            string username = usernameTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;
            string faculty = comboBox1.Text;
           // String picture = null;
            //String picture = button6_Click(sender, e);
            //picture
            

            // Perform validation
            if (string.IsNullOrWhiteSpace(studentId) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Password and confirm password do not match.");
            }
            else
            {
                // Registration successful, you can perform further actions here
                // Insert data into the database
                string connectionString = "Data Source=DESKTOP-HPV9BD7;Initial Catalog=voting_system;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create the SQL command for inserting data
                        string insertQuery = "INSERT INTO Table_Registration (StudentId, Username, Email, Password,ConfirmPassword,Faculty,Picture,president,secretary,commiteemember) VALUES (@StudentId, @Username, @Email, @Password,@ConfirmPassword,@Faculty,NULL,0,0,0)";
                        SqlCommand cmd = new SqlCommand(insertQuery, connection);

                        // Add parameters
                        cmd.Parameters.AddWithValue("@StudentId", studentId);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@ConfirmPassword", confirmPassword);
                        cmd.Parameters.AddWithValue("@Faculty", faculty);
                        //cmd.Parameters.AddWithValue("@Picture", picture);
                        //picture


                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration successful!");
                            // Clear the form or navigate to another page

                            login lg = new login();
                            lg.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again later.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }

        private void confirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            confirmPasswordTextBox.PasswordChar = '*';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
