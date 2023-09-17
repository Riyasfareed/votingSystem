using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadCandidates(string position)
        {
            string connstring = "Data Source=DESKTOP-D8QH7FT\\MSSQLSERVER02;Initial Catalog=Vote;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connstring))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connected to the database!");
                    string query = "SELECT * FROM Nominies WHERE Position=@Position";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Position", position);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Assuming 'checkBoxList' is a CheckBoxList control, you can use it to display the candidates.
                    checkedListBox.Items.Clear(); // Clear any previous items

                    while (reader.Read())
                    {
                        string candidateId = reader.GetString(0);
                        string candidateName = reader.GetString(1);

                        // Add the candidate ID to the beginning of the output string, separated by a space.
                        string output = $"{candidateId} {candidateName}";

                        // Add the candidate to the CheckBoxList
                        checkedListBox.Items.Add(output, false); // The second parameter sets the checkbox as unchecked
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void president_Click(object sender, EventArgs e)
        {
            try
            {
                LoadCandidates("President");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void vicepresident_Click(object sender, EventArgs e)
        {
            try
            {
                LoadCandidates("VicePre");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void secretary_Click(object sender, EventArgs e)
        {
            try
            {
                LoadCandidates("Secretary");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void vicesecretary_Click(object sender, EventArgs e)
        {
            try
            {
                LoadCandidates("ViceSecretary");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void treasurer_Click(object sender, EventArgs e)
        {
            try
            {
                LoadCandidates("Treasurer");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateVoteCount(int candidateId)
        {
            string connstring = "Data Source=DESKTOP-D8QH7FT\\MSSQLSERVER02;Initial Catalog=Vote;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connstring))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connected to the database!");

                    // Construct the SQL query to update the VoteCount
                    string updateQuery = "UPDATE Nominies SET VoteCount = VoteCount + 1 WHERE ID = @CandidateId";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, connection);
                    updateCmd.Parameters.AddWithValue("@CandidateId", candidateId);
                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // The VoteCount was updated successfully
                    }
                    else
                    {
                        MessageBox.Show("Failed to update the VoteCount.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            // Check if any item in the CheckBoxList is checked
            if (checkedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a candidate.");
                return;
            }

            // Assuming your CheckBoxList is named 'checkedListBox'
            string selectedCandidate = checkedListBox.SelectedItem.ToString();

            // Split the selectedCandidate string to get the candidate ID
            int candidateId = int.Parse(selectedCandidate.Split(' ')[0]);

            // Update the database to increment the VoteCount for the selected candidate
            try
            {
                UpdateVoteCount(candidateId);
                MessageBox.Show("Vote submitted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }


}
