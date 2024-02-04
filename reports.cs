using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_project
{
    public partial class reports : Form
    {
        public reports()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin1 f0 = new admin1();
            f0.Show();
            Visible = false;
        }

        private void eventcreate_button_Click(object sender, EventArgs e)
        {
            event_attendence f0 = new event_attendence();
                f0.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            feedback_report g9 = new feedback_report();
            g9.Show();
            Visible = false;
        }
    }
}
