using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Database_project
{
    public partial class speaker : Form
    {
        OracleConnection con;
        public speaker()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void speaker_Load(object sender, EventArgs e)
        {
            string str = @"DATA SOURCE = localhost:1521/xe; USER ID= DATABASEPROJECT; PASSWORD= 1234";
            con = new OracleConnection(str);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            schedule f7=new schedule();
            f7.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (con.State == ConnectionState.Closed)
            //        con.Open();

            //    // Create a command to get the next value from the sequence
            //    OracleCommand speakerid = con.CreateCommand();
            //    speakerid.CommandText = "SELECT speaker_id_seq.NEXTVAL FROM DUAL";
            //    speakerid.CommandType = CommandType.Text;

            //    // Execute the query to get the next venue ID
            //    object nextspeakerId = speakerid.ExecuteScalar();

            //    // Validate and get the event_id from your UI or another source
            //   // Replace this with your logic to get the event_id
            //                          // Example: int.TryParse(event_id.Text, out eventIdValue);

            //    // Use the retrieved venue ID for the insertion
            //    OracleCommand insertEmp = con.CreateCommand();
            //    insertEmp.CommandText = "INSERT INTO speaker (SPEAKER_ID, EMAIL, NAME, PHONE_NO)   VALUES (:speaker_id, :email, :name, :phoneno)";

            //    insertEmp.Parameters.Add(":speaker_id", OracleDbType.Decimal).Value = nextspeakerId;

            //    insertEmp.Parameters.Add(":email", OracleDbType.Varchar2).Value = email.Text; // Assuming start_time is a string representing a date/time
            //    insertEmp.Parameters.Add(":name", OracleDbType.Varchar2).Value = name.Text; // Assuming end_time is a string representing a date/time
            //    insertEmp.Parameters.Add(":phoneno", OracleDbType.Varchar2).Value = phoneno.Text;

            //    //if (int.TryParse(speaker_id.Text, out int event_id_value))
            //    //{
            //    //    insertEmp.Parameters[":event_id"].Value = event_id_value;
            //    //}

            //    insertEmp.CommandType = CommandType.Text;

            //    int rows = insertEmp.ExecuteNonQuery();

            //    if (rows > 0)
            //    {
            //        MessageBox.Show("Data Inserted Successfully!");
            //        // Additional code for success if needed
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
            //finally
            //{
            //    if (con.State == ConnectionState.Open)
            //        con.Close();
            //}

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                // Create a command to get the next value from the sequence
                OracleCommand speakerid = con.CreateCommand();
                speakerid.CommandText = "SELECT speaker_id_seq.NEXTVAL FROM DUAL";
                speakerid.CommandType = CommandType.Text;

                // Execute the query to get the next speaker ID
                object nextspeakerId = speakerid.ExecuteScalar();

                // Validate and get other values from your UI or another source
                // Replace this with your logic to get the event_id, email, name, and phoneno
                // Example: int.TryParse(event_id.Text, out eventIdValue);

                // Use the retrieved speaker ID for the insertion
                OracleCommand insertEmp = con.CreateCommand();
                insertEmp.CommandText = "INSERT INTO speaker (SPEAKER_ID, EMAIL, NAME, PHONE_NO, GENDER) VALUES (:speaker_id, :email, :name, :phoneno, :gender)";

                insertEmp.Parameters.Add(":speaker_id", OracleDbType.Decimal).Value = nextspeakerId;
                insertEmp.Parameters.Add(":email", OracleDbType.Varchar2).Value = email.Text;
                insertEmp.Parameters.Add(":name", OracleDbType.Varchar2).Value = name.Text;
                insertEmp.Parameters.Add(":phoneno", OracleDbType.Varchar2).Value = phoneno.Text;

                // Determine the selected gender from radio buttons
                string genderValue = radioButton1.Checked ? "M" : (radioButton2.Checked ? "F" : null);
                insertEmp.Parameters.Add(":gender", OracleDbType.Char).Value = genderValue;

                insertEmp.CommandType = CommandType.Text;

                int rows = insertEmp.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Data Inserted Successfully!");
                    // Additional code for success if needed
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void phoneno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
