using Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            dbconnect();
        }

        public SqlConnection dbconnect()
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-HPV9BD7;Initial Catalog=voting_system;Integrated Security=True";

            cnn = new SqlConnection(connetionString);
            cnn.Open();
            //MessageBox.Show("Successfully connected!");
            Console.WriteLine("Successfully connected!");
            cnn.Close();
            return cnn;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblStatus.Text = "Please enter both username and password.";
                return;
            }

            using (SqlConnection connection = dbconnect())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Table_Registration WHERE Username = @Username AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int result = (int)cmd.ExecuteScalar();

                    if (result > 0)
                    {
                        lblStatus.Text = "Login successful!";

                        vote form1 = new vote();
                        form1.Show();
                        this.Close();
                    }
                    else
                    {
                        lblStatus.Text = "Invalid username or password.";
                    }
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Error: " + ex.Message;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard.Registration r = new Dashboard.Registration();
            r.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            vote form1 = new vote();
            form1.Show();
            //this.Close();
        }
    }
}
