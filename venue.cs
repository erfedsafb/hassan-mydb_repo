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
    public partial class venue : Form
    {
        OracleConnection con;
        public venue()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void venue_Load(object sender, EventArgs e)
        {
            string str = @"DATA SOURCE = localhost:1521/xe; USER ID= DATABASEPROJECT; PASSWORD= 1234";
            con = new OracleConnection(str);
            gride();
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

        private void back_Click(object sender, EventArgs e)
        {
            Event_creation f6 = new Event_creation();
            f6.Show();
            Visible = false;
    
        }

        private void save_Click(object sender, EventArgs e)
        {
           

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                // Create a command to get the next value from the sequence
                OracleCommand venueIdCmd = con.CreateCommand();
                venueIdCmd.CommandText = "SELECT venue_id_seq.NEXTVAL FROM DUAL";
                venueIdCmd.CommandType = CommandType.Text;

                // Execute the query to get the next venue ID
                object nextVenueId = venueIdCmd.ExecuteScalar();

                // Validate and get the event_id from your UI or another source
                int eventIdValue = 0; // Replace this with your logic to get the event_id
                                      // Example: int.TryParse(event_id.Text, out eventIdValue);

                // Use the retrieved venue ID for the insertion
                OracleCommand insertEmp = con.CreateCommand();
                insertEmp.CommandText = "INSERT INTO Venue (venue_id, venue_name, address, capacity, event_id)   VALUES (:venue_id, :venue_name, :address, :capacity, :event_id)";

                insertEmp.Parameters.Add(":venue_id", OracleDbType.Decimal).Value = nextVenueId;
                insertEmp.Parameters.Add(":venue_name", OracleDbType.Varchar2).Value = venue_name.Text;
                insertEmp.Parameters.Add(":address", OracleDbType.Varchar2).Value = address.Text;
                insertEmp.Parameters.Add(":capacity", OracleDbType.Int32).Value = int.Parse(capacity.Text);
                insertEmp.Parameters.Add(":event_id", OracleDbType.Decimal).Value = eventIdValue;

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

        private void event_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
