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
    public partial class assign_speaker : Form
    {
        OracleConnection con;
        public assign_speaker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                // Create a command to get the next value from the sequence
                OracleCommand assign_speakerid = con.CreateCommand();
                assign_speakerid.CommandText = "SELECT assign_id_seq.NEXTVAL FROM DUAL";
                assign_speakerid.CommandType = CommandType.Text;

                // Execute the query to get the next venue ID
                object nextsessionId = assign_speakerid.ExecuteScalar();

                // Validate and get the event_id from your UI or another source
                int eventIdValue = 0;
                int eventIdValue2 = 0;// Replace this with your logic to get the event_id
                                     // Example: int.TryParse(event_id.Text, out eventIdValue);
                                     //  int eventIdValue2 = 0;

                // Use the retrieved venue ID for the insertion
                OracleCommand insertEmp = con.CreateCommand();
                insertEmp.CommandText = "INSERT INTO assign_speaker (ASSIGN_ID,SESSION_ID,SPEAKER_ID) VALUES (:ASSIGN_ID,:session_id,:SPEAKER_iD)";

                insertEmp.Parameters.Add(":assign_id", OracleDbType.Decimal).Value = nextsessionId;
                insertEmp.Parameters.Add(":session_id", OracleDbType.Decimal).Value = eventIdValue;
                insertEmp.Parameters.Add(":SPEAKER_ID", OracleDbType.Decimal).Value = eventIdValue2;

                //insertEmp.Parameters.Add(":SPEAKER_ID", OracleDbType.Decimal).Value = eventIdValue2;
                //insertEmp.Parameters.Add(":event_id", OracleDbType.Decimal).Value = eventIdValue;
                //insertEmp.Parameters.Add(":STARTTIME", OracleDbType.Date).Value = DateTime.Parse(start_time.Text); // Assuming start_time is a string representing a date/time
                //insertEmp.Parameters.Add(":ENDTIME", OracleDbType.Date).Value = DateTime.Parse(end_time.Text); // Assuming end_time is a string representing a date/time
                //insertEmp.Parameters.Add(":TITLE", OracleDbType.Varchar2).Value = title;

                int sessionIdValue;
                if (int.TryParse(session_id.Text, out sessionIdValue))
                {
                    insertEmp.Parameters[":session_id"].Value = sessionIdValue;
                }
                else
                {
                    // Handle the case where session_id is not a valid integer
                    MessageBox.Show("Invalid session_id");
                    return; // or handle the error in another way
                }

                int speakerIdValue;
                if (int.TryParse(SPEAKER_ID.Text, out speakerIdValue))
                {
                    insertEmp.Parameters[":speaker_id"].Value = speakerIdValue;
                }
                else
                {
                    // Handle the case where speaker_id is not a valid integer
                    MessageBox.Show("Invalid speaker_id");
                    return; // or handle the error in another way
                }

                //if (int.TryParse(speaker_ID.Text, out int event_id_value))
                //{
                //    insertEmp.Parameters[":SPEAKER_ID"].Value = event_id_value;
                //}

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gride()
        {
            con.Open();

            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "SELECT SESSIONID FROM SESSIONS ";

            getEmps.CommandType = CommandType.Text;

            OracleDataReader empDR = getEmps.ExecuteReader();

            DataTable empDT = new DataTable();

            empDT.Load(empDR);

            dataGridView1.DataSource = empDT;

            con.Close();
        }

        private void assign_speaker_Load(object sender, EventArgs e)
        {
            string str = @"DATA SOURCE = localhost:1521/xe; USER ID= DATABASEPROJECT; PASSWORD= 1234";
            con = new OracleConnection(str);
            gride();
            gride2();
        }


        private void gride2()
        {
            con.Open();

            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "SELECT SPEAKER_ID FROM SPEAKER ";

            getEmps.CommandType = CommandType.Text;

            OracleDataReader empDR = getEmps.ExecuteReader();

            DataTable empDT = new DataTable();

            empDT.Load(empDR);

            dataGridView2.DataSource = empDT;

            con.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            schedule f8 = new schedule();
            f8.Show();
            Visible = false;
        }
    }
}
