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
    public partial class session : Form
    {
        OracleConnection con;
        public session()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gride()
        {
            con.Open();

            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "SELECT EVENT_ID FROM create_event ";

            getEmps.CommandType = CommandType.Text;

            OracleDataReader empDR = getEmps.ExecuteReader();

            DataTable empDT = new DataTable();

            empDT.Load(empDR);

            dataGridView1.DataSource = empDT;

            con.Close();
        }

        private void session_Load(object sender, EventArgs e)
        {
            string str = @"DATA SOURCE = localhost:1521/xe; USER ID= DATABASEPROJECT; PASSWORD= 1234";
            con = new OracleConnection(str);
            gride();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                // Create a command to get the next value from the sequence
                OracleCommand sessionid = con.CreateCommand();
                sessionid.CommandText = "SELECT session_id_seq.NEXTVAL FROM DUAL";
                sessionid.CommandType = CommandType.Text;

                // Execute the query to get the next venue ID
                object nextsessionId = sessionid.ExecuteScalar();

                // Validate and get the event_id from your UI or another source
                int eventIdValue = 0; // Replace this with your logic to get the event_id
                                      // Example: int.TryParse(event_id.Text, out eventIdValue);

                // Use the retrieved venue ID for the insertion
                OracleCommand insertEmp = con.CreateCommand();
                insertEmp.CommandText = "INSERT INTO sessions (sessionid, eventid, STARTTIME, ENDTIME, TITLE)   VALUES (:sessionid, :event_id, :start_time, :end_time, :title)";

                insertEmp.Parameters.Add(":sessionid", OracleDbType.Decimal).Value = nextsessionId;
                insertEmp.Parameters.Add(":event_id", OracleDbType.Decimal).Value = eventIdValue;
                insertEmp.Parameters.Add(":STARTTIME", OracleDbType.Date).Value = DateTime.Parse(start_time.Text); // Assuming start_time is a string representing a date/time
                insertEmp.Parameters.Add(":ENDTIME", OracleDbType.Date).Value = DateTime.Parse(end_time.Text); // Assuming end_time is a string representing a date/time
                insertEmp.Parameters.Add(":TITLE", OracleDbType.Varchar2).Value = title;

                if (int.TryParse(event_id.Text, out int event_id_value))
                {
                    insertEmp.Parameters[":event_id"].Value = event_id_value;
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



        }

        private void button1_Click(object sender, EventArgs e)
        {
            schedule f8=new schedule();
            f8.Show();
            Visible=false;
        }
    }
}
