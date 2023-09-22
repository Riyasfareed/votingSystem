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
using WindowsFormsApp1;

namespace Dashboard
{
    public partial class GetResult : Form
    {
        public string connectionString;

        public string connetString;
        public GetResult()
        {
            InitializeComponent();
        }
        private SqlConnection connectDB()
        {
            string connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source=DESKTOP-HPV9BD7;Initial Catalog=voting_system;Integrated Security=True";
            cnn = new SqlConnection(connectionstring);
            cnn.Open();

            return cnn;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lb_VotingResult_Click(object sender, EventArgs e)
        {

        }

        private void btn_President_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = connectDB())
            {


                String query = "select Name,Votes from Result where Position= 'President' ";

                SqlDataAdapter da = new SqlDataAdapter(query, sqlCon);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();

                da.Fill(ds);

                chart1.DataSource = da;
                sqlCon.Close();

                chart1.Series["Number Of Votes"].XValueMember = "Name";
                chart1.Series["Number Of Votes"].YValueMembers = "Votes";
                //MessageBox.Show("Show Chart President");
                chart1.Titles.Add(" ");

               MessageBox.Show("Show Chart President");

            }
        }

        private void btn_Secretary_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = connectDB())
            {


                String query1 = "select Name,Votes from Result where Position= 'Secretary' ";

                SqlDataAdapter da1 = new SqlDataAdapter(query1, sqlCon);
                SqlCommandBuilder builder = new SqlCommandBuilder(da1);
                var ds1 = new DataSet();

                da1.Fill(ds1);

                chart1.DataSource = da1;
                sqlCon.Close();

                chart1.Series["Number Of Votes"].XValueMember = "Name";
                chart1.Series["Number Of Votes"].YValueMembers = "Votes";
                chart1.Titles.Add("");

                MessageBox.Show("Show Chart Secretary");



            }
        }

        private void btn_Committee_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = connectDB())
            {


                String query2 = "select Name,Votes from Result where Position= 'Committee' ";

                SqlDataAdapter da2 = new SqlDataAdapter(query2, sqlCon);
                SqlCommandBuilder builder = new SqlCommandBuilder(da2);
                var ds2 = new DataSet();

                da2.Fill(ds2);

                chart1.DataSource = da2;
                sqlCon.Close();

                chart1.Series["Number Of Votes"].XValueMember = "Name";
                chart1.Series["Number Of Votes"].YValueMembers = "Votes";
                chart1.Titles.Add("");

                MessageBox.Show("Show Chart Committee'");

            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btn_winners_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = connectDB())
            {
                // Write a SQL query to retrieve the maximum value from your database
                string query = "SELECT TOP 1 Name FROM Result WHERE Position='President' ORDER BY Votes DESC "; 
               
                SqlCommand command = new SqlCommand(query, cnn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Retrieve the maximum value from the query results
                    string maxPresident = (string)reader["Name"];
                  

                    // Display the maximum value in the label
                    lb_output.Text = "THE PRESIDENT IS: " + maxPresident.ToString();
                    
                    


                }
                lb_output.Visible = true;
                lb_output3.Visible = false;
                lb_output2.Visible = false;

                reader.Close();
            }
        }

        private void lb_output_Click(object sender, EventArgs e)
        {

        }

        private void btn_winSecretary_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = connectDB())
            {
                // Write a SQL query to retrieve the maximum value from your database
                string query = "SELECT TOP 1 Name FROM Result WHERE Position='Secretary' ORDER BY Votes DESC ";

                SqlCommand command = new SqlCommand(query, cnn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Retrieve the maximum value from the query results
                    string maxSecretary = (string)reader["Name"];


                    // Display the maximum value in the label
                    lb_output2.Text = "THE SECRETARY IS: " + maxSecretary.ToString();




                }
                lb_output2.Visible = true;
                lb_output.Visible = false;
                lb_output3.Visible = false;

                reader.Close();
            }
        }

        private void btn_winCommittee_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = connectDB())
            {
                // Write a SQL query to retrieve the maximum value from your database
                string query = "SELECT TOP 1 Name FROM Result WHERE Position='Committee' ORDER BY Votes DESC ";
               
                SqlCommand command = new SqlCommand(query, cnn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Retrieve the maximum value from the query results
                    string maxCommittee = (string)reader["Name"];


                    // Display the maximum value in the label
                    lb_output3.Text = "THE COMMITTEE IS: " + maxCommittee.ToString();




                }
                lb_output3.Visible = true;
                lb_output.Visible = false;
                lb_output2.Visible = false;
                reader.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vote vp = new vote();
            vp.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Nominee np = new Nominee();
            np.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Close();
        }
    }
}
