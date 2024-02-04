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
    public partial class Event_information : Form
    {
        OracleConnection con;
        public Event_information()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reports f9 = new reports();
            f9.Show();
            Visible = false;
        }

        private void Event_information_Load(object sender, EventArgs e)
        {
            string str = @"DATA SOURCE = localhost:1521/xe; USER ID= DATABASEPROJECT; PASSWORD= 1234";
            con = new OracleConnection(str);
            gride();
        }

        private void gride()
        {
            con.Open();

            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "SELECT e.*, s.* FROM CREATE_EVENT e LEFT OUTER JOIN SESSIONS s ON e.EVENT_ID = s.EVENTID";



            getEmps.CommandType = CommandType.Text;

            OracleDataReader empDR = getEmps.ExecuteReader();

            DataTable empDT = new DataTable();

            empDT.Load(empDR);

            dataGridView1.DataSource = empDT;

            con.Close();
        }

    }
}
