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
    public partial class REVENUE : Form
    {
        OracleConnection con;
        public REVENUE()
        {
            InitializeComponent();
        }

        private void REVENUE_Load(object sender, EventArgs e)
        {
            string str = @"DATA SOURCE = localhost:1521/xe; USER ID= DATABASEPROJECT; PASSWORD= 1234";
            con = new OracleConnection(str);
            gride();
        }

        private void gride()
        {
            con.Open();

            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "select p.event_id,count(p.event_id) * 1700 as Total_amount,e.NAME from  create_event e inner join PARTICIPANTS p on p.EVENT_ID =e.EVENT_ID group by p.event_id,e.NAME";


            getEmps.CommandType = CommandType.Text;

            OracleDataReader empDR = getEmps.ExecuteReader();

            DataTable empDT = new DataTable();

            empDT.Load(empDR);

            dataGridView1.DataSource = empDT;

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin1 f9 = new admin1();
            f9.Show();
            Visible = false;
        }
    }
}
