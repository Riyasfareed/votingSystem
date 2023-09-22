using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dashboard
{
    public partial class Nominee : Form
    {
        private byte[] newImageBytes;
        private SqlConnection cnn;
        private string name;
        private int id;
        private int appid;
        private string addInfo;
        private string position;
        private bool verify;
        private int votes;
        public Nominee()
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

        private void btnSelect_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                newImageBytes = File.ReadAllBytes(openFileDialog.FileName);
                pictureBox1.Image = System.Drawing.Image.FromStream(new MemoryStream(newImageBytes));
            }

            if(newImageBytes == null)
            {
                btnSelect.BackColor = Color.Red; btnSelect.ForeColor = Color.Green;
            }


        }
            
        //method for database connection
        public SqlConnection dbconnect()
        {
           // string connetionString;
            
            //connetionString = @"Data Source=LAPTOP-K6CD80MQ;Initial Catalog=Nominees;Integrated Security=True";
            login lg = new login();
            SqlConnection connstring = lg.dbconnect();
            SqlConnection cnn = connstring;


            //cnn = new SqlConnection(connetionString);
            cnn.Open();
            //MessageBox.Show("Successfully connected!");
            Console.WriteLine("Successfully connected!");
            cnn.Close();
            return cnn;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApp_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAdditional_TextChanged(object sender, EventArgs e)
        {

        }

        //private void btnVerify_Click(object sender, EventArgs e)
        //{
        //    //create a new table


        //    string connetionString;
        //    SqlConnection cnn;
        //    connetionString = @"Data Source=LAPTOP-K6CD80MQ;Initial Catalog=Nominees;Integrated Security=True";

        //    cnn = new SqlConnection(connetionString);
        //    cnn.Open();
        //    //id = int.Parse(txtId.Text);
        //    //string sql2 = "select appliaicationNo from applicationNo where id = @id";
        //    //SqlCommand command = new SqlCommand(sql2, cnn);

        //    //command.Parameters.AddWithValue("@Id", id);
        //    //command.ExecuteNonQuery();
        //    //command.Dispose();
        //    int appid = int.Parse(txtApp.Text);
        //    string query = "SELECT appliacationNo FROM applicationNo";
        //    using (SqlCommand command = new SqlCommand(query, cnn))
        //    {
        //        using (SqlDataReader reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                int id = reader.GetInt32(reader.GetOrdinal("Id"));
        //                //string name = reader.GetString(reader.GetOrdinal("Name"));
        //               if(id == appid)
        //                {
        //                    this.verify = true;
        //                    cnn.Close();
        //                    break;
        //                }
        //            }
        //        }
        //    }

        //    //if (command != null)
        //    //{
        //    //    this.verify = true;
        //    //    MessageBox.Show("Application number verified!");
        //    //}
        //    //else
        //    //{
        //    //    this.verify = false;
        //    //    MessageBox.Show("Application number not verified!");
        //    //}

        //    //this.verify = true;
        //    //cnn.Close();
        //}


        private void btnVerify_Click(object sender, EventArgs e)
        {
            // Replace "YourConnectionstring" with your actual database connection string.
            // string connetionString = @"Data Source=LAPTOP-K6CD80MQ;Initial Catalog=Nominees;Integrated Security=True";
            login lg = new login();
            SqlConnection connstring = lg.dbconnect();


            try
            {
                using (SqlConnection cnn = connstring)
                {
                    cnn.Open();

                    int appid;
                    if (int.TryParse(txtApp.Text, out appid))
                    {
                        // Query to check if the provided application number exists in the database.
                        string query = "SELECT COUNT(*) FROM nominees WHERE applicationNo = @AppId";

                        using (SqlCommand command = new SqlCommand(query, cnn))
                        {
                            command.Parameters.AddWithValue("@AppId", appid);

                            int count = (int)command.ExecuteScalar();

                            if (count > 0)
                            {
                                // Application number exists in the database.
                                MessageBox.Show("Application number verified!");
                                this.verify = true;
                            }
                            else
                            {
                                // Application number does not exist in the database.
                                MessageBox.Show("Application number not verified!");
                                this.verify = false;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid application number format.");
                        this.verify = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                this.verify = false;
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {

            name = txtName.Text;
            id = int.Parse(txtId.Text);
            appid = int.Parse(txtApp.Text);
            addInfo = txtAdditional.Text;
            position = comboBox1.Text;
            //votes = 0;

            if (verify == true)
            {
               // string connetionString;
                //SqlConnection cnn;
                //connetionString = @"Data Source=LAPTOP-K6CD80MQ;Initial Catalog=Nominees;Integrated Security=True";
                login lg = new login();
                SqlConnection connstring = lg.dbconnect();
                SqlConnection cnn = connstring;
                // cnn = new SqlConnection(connetionString);
                cnn.Open();


               
                if (newImageBytes != null)
                {
                    

                    string sql2 = "INSERT INTO nominees VALUES (@Id, @Name, @AppId, @Position, @AddInfo, @Photo,0)";
                    SqlCommand command = new SqlCommand(sql2, cnn);
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@AppId", appid);
                    command.Parameters.AddWithValue("@Position", position);
                    command.Parameters.AddWithValue("@AddInfo", addInfo);
                    command.Parameters.AddWithValue("@Photo", newImageBytes);
                    


                    command.ExecuteNonQuery();
                    command.Dispose();
                    MessageBox.Show("inserted data");

                }
                else
                {
                    MessageBox.Show("Image not inserted!!");
                }
            }
            else
            {
                MessageBox.Show("Application number not verified!!");
            }  
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //if (cnn.Open())
            //{
            //    cnn.Close();
            //    MessageBox.Show("Disconnect4ed");
            //    this.Close();
            //}
            //else
            //{
            //    this.Close();
            //}
            
        }

        private void btndb_Click(object sender, EventArgs e)
        {
           // string connetionString2;
            //SqlConnection cnn;
            //connetionString2 = @"Data Source=LAPTOP-K6CD80MQ;Initial Catalog=Nominees;Integrated Security=True";

            login lg = new login();
            SqlConnection connstring = lg.dbconnect();
            SqlConnection cnn = connstring;

            //cnn = new SqlConnection(connetionString2);
            cnn.Open();
            MessageBox.Show("Connected");
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Text = "";
                txtName.BackColor = Color.LightBlue;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Name";
                // textBox1.ForeColor  = Color.Red;
                txtName.BackColor = Color.Wheat;
            }
        }

        private void txtId_Enter(object sender, EventArgs e)
        {
            if (txtId.Text == "Id No.")
            {
                txtId.Text = "";
                txtId.BackColor = Color.LightBlue;
            }
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                txtId.Text = "Id No.";
                //  textBox5.ForeColor = Color.Red;
                txtId.BackColor = Color.Wheat;
            }
        }

        private void txtApp_Enter(object sender, EventArgs e)
        {
            if (txtApp.Text == "Application No.")
            {
                txtApp.Text = "";
                txtApp.BackColor = Color.LightBlue;
            }
        }

        private void txtApp_Leave(object sender, EventArgs e)
        {
            if (txtApp.Text == "")
            {
                txtApp.Text = "Application No.";
                //   textBox3.ForeColor = Color.Red;
                txtApp.BackColor = Color.Wheat;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Position")
            {
                comboBox1.Text = "";
                comboBox1.BackColor = Color.LightBlue;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            
        }
    }
 }

