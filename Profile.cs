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
    public partial class Profile : Form
    {
        public Profile(int candidateId)
        {
            InitializeComponent();
        }

        private void LoadCandidateData(int candidateId)
        {
            //string connstring = "Data Source=DESKTOP-D8QH7FT\\MSSQLSERVER02;Initial Catalog=Vote;Integrated Security=True";

            login lg = new login();
            SqlConnection connstring = lg.dbconnect();
            SqlConnection cnn = connstring;

            using (SqlConnection connection = connstring)
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connected to the database!");

                    string query = "SELECT name, position FROM nominees WHERE Id=@CandidateId";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@CandidateId", candidateId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Read candidate data from the database
                        string name = reader.GetString(0);
                        string position = reader.GetString(1);

                        // Display data in the textboxes
                        nametxt.Text = name;
                        positiontxt.Text = position;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vote vp = new vote();
            vp.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
