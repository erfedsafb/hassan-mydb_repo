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
    public partial class delete_event : Form
    {
        OracleConnection con;
       
        // Add a constructor that accepts an instance of Event_creation
        public delete_event()
        {
            InitializeComponent();
         

        }

        private void delete_event_Load(object sender, EventArgs e)
        {
            string str = @"DATA SOURCE = localhost:1521/xe; USER ID= DATABASEPROJECT; PASSWORD= 1234";
            con = new OracleConnection(str);
            gride();
        }

        // Change the protection level of the method to public or internal
       

        // Rest of your code...

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Your event handler code here

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

        private void admin_button_Click(object sender, EventArgs e)
        {
            Event_creation f6=new Event_creation();
            f6.Show();
            Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertemp = con.CreateCommand();
            insertemp.CommandText = "DELETE FROM CREATE_EVENT WHERE EVENT_ID = " + del_eventid.Text.ToString();

            insertemp.CommandType = CommandType.Text;
            int rows=insertemp.ExecuteNonQuery();
            if(rows>0)
            {
                MessageBox.Show("Successfully deleted ");
            }

            con.Close();
            gride();


        }
    }
}
