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
using System.IO;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCandidates("President");
            nomineeDetailsTextBox.Text = "Select a candidate to view details from here.";
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
                    string query = "SELECT ID, Name FROM Nominies WHERE Position=@Position";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Position", position);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Clear the CheckBoxList before adding new items
                    checkedListBox.Items.Clear();

                    while (reader.Read())
                    {
                        int candidateId = reader.GetInt32(0);
                        string candidateName = reader.GetString(1);

                        // Add the candidate to the CheckBoxList
                        checkedListBox.Items.Add($"{candidateName} (ID: {candidateId})", false);
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
            if (checkedListBox.SelectedIndex != -1)
            {
                // Get the selected candidate's name and ID from the checkedListBox
                string selectedCandidateText = checkedListBox.SelectedItem.ToString();
                int candidateId = int.Parse(selectedCandidateText.Split(new[] { "(ID: ", ")" }, StringSplitOptions.RemoveEmptyEntries)[1]);

                DisplayNomineeDetails(candidateId);

                // Load and display the candidate's image
                LoadCandidateImage(candidateId);
            }
        }

        private void LoadCandidateImage(int candidateId)
        {
            string connstring = "Data Source=DESKTOP-D8QH7FT\\MSSQLSERVER02;Initial Catalog=Vote;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connstring))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connected to the database!");
                    string query = "SELECT Images FROM Nominies WHERE ID=@CandidateId"; // Retrieve the candidate's image
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@CandidateId", candidateId);
                    byte[] imageData = (byte[])cmd.ExecuteScalar();

                    if (imageData != null)
                    {
                        // Display the candidate's image in the PictureBox
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            profilephoto.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        // If there's no image data, you can display a placeholder image or handle it accordingly
                        profilephoto.Image = null; // Set to a placeholder image or leave empty
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading candidate image: " + ex.Message);
                }
            }
        }

        private void DisplayNomineeDetails(int candidateId)
        {
            string connstring = "Data Source=DESKTOP-D8QH7FT\\MSSQLSERVER02;Initial Catalog=Vote;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connstring))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connected to the database!");
                    string query = "SELECT ID, [Name], [Application No] FROM Nominies WHERE ID=@CandidateId"; // Updated query
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@CandidateId", candidateId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    nomineeDetailsTextBox.Clear(); // Clear any previous details

                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string applicationNo = reader.GetString(2);
                        string name = reader.GetString(1);

                        // Display the candidate details in the nomineeDetailsTextBox
                        nomineeDetailsTextBox.AppendText($"ID: {id}{Environment.NewLine}");
                        nomineeDetailsTextBox.AppendText($"Name: {name}{Environment.NewLine}");
                        nomineeDetailsTextBox.AppendText($"Application No: {applicationNo}{Environment.NewLine}");
                    }
                    else
                    {
                        nomineeDetailsTextBox.AppendText("No details found for the selected candidate.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
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

        private void secretary_Click_1(object sender, EventArgs e)
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

        private void commiteemember_Click(object sender, EventArgs e)
        {
            try
            {
                LoadCandidates("Commitee Member");
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
            int checkedCount = checkedListBox.CheckedItems.Count;

            if (checkedCount != 1)
            {
                MessageBox.Show(checkedCount == 0 ? "Please select a candidate." : "Please select only one candidate.");
                return;
            }

            // Assuming your CheckBoxList is named 'checkedListBox'
            string selectedCandidate = checkedListBox.SelectedItem.ToString();

            // Split the selectedCandidate string to get the candidate ID
            int candidateId = int.Parse(selectedCandidate.Split(new[] { "(ID: ", ")" }, StringSplitOptions.RemoveEmptyEntries)[1]);

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void viewprofile_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if an item is selected in the checkedListBox
                if (checkedListBox.SelectedIndex != -1)
                {
                    // Get the selected candidate's ID from the checkedListBox
                    string selectedCandidateText = checkedListBox.SelectedItem.ToString();
                    int candidateId = int.Parse(selectedCandidateText.Split(new[] { "(ID: ", ")" }, StringSplitOptions.RemoveEmptyEntries)[1]);

                    // Open the CandidateProfileForm with the selected candidate's details
                    CandidateProfile candidateProfileForm = new CandidateProfile(candidateId);
                    candidateProfileForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a candidate to view the profile.", "No Candidate Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while viewing the profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nomineeDetailsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }


}
