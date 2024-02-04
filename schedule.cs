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
    public partial class schedule : Form
    {
        OracleConnection con;
        public schedule()
        {
            InitializeComponent();
        }

        private void schedule_Load(object sender, EventArgs e)
        {
            string str = @"DATA SOURCE = localhost:1521/xe; USER ID= DATABASEPROJECT; PASSWORD= 1234";
            con = new OracleConnection(str);
        }

        private void save_Click(object sender, EventArgs e)
        {
            session f6=new session();
            f6.Show();
            Visible = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Event_creation f6 = new Event_creation();
            f6.Show();
            Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            assign_speaker f9 = new assign_speaker();
            f9.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            speaker f8=new speaker();
            f8.Show();
            Visible=false;
        }
    }
}
