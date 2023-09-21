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
using System.Xml.Linq;

namespace Dashboard
{
    public partial class CandidateProfile : Form
    {
        public CandidateProfile(int candidateId)
        {
            InitializeComponent();
            LoadCandidateData(candidateId);

        }

        private void LoadCandidateData(int candidateId)
        {
            string connstring = "Data Source=DESKTOP-D8QH7FT\\MSSQLSERVER02;Initial Catalog=Vote;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connstring))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connected to the database!");

                    string query = "SELECT Name, Position FROM Nominies WHERE ID=@CandidateId";
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

        private void agetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
