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
    public partial class participants : Form
    {
        OracleConnection con;
        public participants()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                // Create a command to get the next value from the sequence
                OracleCommand participantid = con.CreateCommand();
                participantid.CommandText = "SELECT parti_seq.NEXTVAL FROM DUAL";
                participantid.CommandType = CommandType.Text;

                // Execute the query to get the next speaker ID
                object nextspeakerId = participantid.ExecuteScalar();

                // Validate and get other values from your UI or another source
                // Replace this with your logic to get the event_id, email, name, and phoneno
                // Example: int.TryParse(event_id.Text, out eventIdValue);
                int eventIdValue = 0;
                // Use the retrieved speaker ID for the insertion
                OracleCommand insertEmp = con.CreateCommand();
                insertEmp.CommandText = "INSERT INTO PARTICIPANTS (PARTICIPANT_ID, NAME, EMAIL, ADDRESS, AGE,PHONE_NO,EVENT_ID,GENDER) VALUES (:PARTICIPANT_ID, :name, :email, :address, :age,:phoneno,:eventid,:gender)";

                insertEmp.Parameters.Add(":PARTICIPANT_ID", OracleDbType.Decimal).Value = nextspeakerId;
                insertEmp.Parameters.Add(":name", OracleDbType.Varchar2).Value = name.Text;
                insertEmp.Parameters.Add(":email", OracleDbType.Varchar2).Value = email.Text;
                insertEmp.Parameters.Add(":address", OracleDbType.Varchar2).Value = address.Text;
                insertEmp.Parameters.Add(":age", OracleDbType.Varchar2).Value = age.Text;
                insertEmp.Parameters.Add(":phoneno", OracleDbType.Varchar2).Value = phoneno.Text;
                insertEmp.Parameters.Add(":eventid", OracleDbType.Varchar2).Value = eventIdValue;
                //insertEmp.Parameters.Add(":phoneno", OracleDbType.Varchar2).Value = phoneno.Text;

                // Determine the selected gender from radio buttons
                string genderValue = radioButton1.Checked ? "M" : (radioButton2.Checked ? "F" : null);
                insertEmp.Parameters.Add(":gender", OracleDbType.Char).Value = genderValue;
                if (int.TryParse(eventid.Text, out int event_id_value))
                {
                    insertEmp.Parameters[":eventid"].Value = event_id_value;
                }
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

            MessageBox.Show("MAIL HAS SENT SUCCESSFULLY TO PARTICIPANT");
        }

        private void participants_Load(object sender, EventArgs e)
        {
            string str = @"DATA SOURCE = localhost:1521/xe; USER ID= DATABASEPROJECT; PASSWORD= 1234";
            con = new OracleConnection(str);
            grid();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void grid()
        {
            con.Open();

            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "SELECT * FROM CREATE_EVENT ";

            getEmps.CommandType = CommandType.Text;

            OracleDataReader empDR = getEmps.ExecuteReader();

            DataTable empDT = new DataTable();

            empDT.Load(empDR);

            dataGridView1.DataSource = empDT;

            con.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            user1 g0 = new user1();
            g0.Show();
            Visible = false;
        }

     
    }
}
