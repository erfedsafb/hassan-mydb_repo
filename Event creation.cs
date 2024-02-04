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
    public partial class Event_creation : Form
    {
        OracleConnection con;
        public Event_creation()
        {

            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Event_creation_Load(object sender, EventArgs e)
        {
            string str = @"DATA SOURCE = localhost:1521/xe; USER ID= DATABASEPROJECT; PASSWORD= 1234";
            con = new OracleConnection(str);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                // Create a command to get the next value from the sequence
                OracleCommand geteventid = con.CreateCommand();
                geteventid.CommandText = "SELECT ev_id_sequence.NEXTVAL FROM DUAL";
                geteventid.CommandType = CommandType.Text;

                // Execute the query to get the next user ID
                object nexteventid = geteventid.ExecuteScalar();

                // Use the retrieved user ID for the insertion
                OracleCommand insertEmp = con.CreateCommand();
                insertEmp.CommandText = "INSERT INTO create_event (EVENT_ID, EVENT_DATE, LOCATION, DETAILS,NAME) " +
                                        "VALUES (:EVENT_ID, TO_DATE(:EVENT_DATE, 'MM/DD/YYYY'), :LOCATION, :DETAILS,:Eventname)";

                insertEmp.Parameters.Add(":EVENT_ID", OracleDbType.Decimal).Value = nexteventid;

                insertEmp.Parameters.Add(":EVENT_DATE", OracleDbType.Varchar2).Value = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                insertEmp.Parameters.Add(":LOCATION", OracleDbType.Varchar2).Value = Eventlocation.Text;
                insertEmp.Parameters.Add(":DETAILS", OracleDbType.Varchar2).Value = eventdetail.Text;
                insertEmp.Parameters.Add(":Eventname", OracleDbType.Varchar2).Value = Eventname.Text;


                insertEmp.CommandType = CommandType.Text;

                int rows = insertEmp.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Data Inserted Successfully!");
                   
                 
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


        private void Eventlocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user1 f5 = new user1();
            f5.Show();
            Visible = true;


        }



        private void admin_button_Click(object sender, EventArgs e)
        {
            delete_event f6 = new delete_event();
            f6.Show();
            Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void event_dur_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            venue f9 = new venue();
            f9.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            schedule f8 = new schedule();
            f8.Show();
            Visible = false;
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        //public void update_grid()
        //{
        //    con.Open();

        //    OracleCommand getEmps = con.CreateCommand();
        //    getEmps.CommandText = "SELECT EVENT_ID FROM create_event ";

        //    getEmps.CommandType = CommandType.Text;

        //    OracleDataReader empDR = getEmps.ExecuteReader();

        //    DataTable empDT = new DataTable();

        //    empDT.Load(empDR);

        //    dataGridView1.DataSource = empDT;

        //    con.Close();
        //}


    }

}

