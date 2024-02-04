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
    public partial class admin1 : Form
    {
        public admin1()
        {
            InitializeComponent();
        }

        private void eventcreate_button_Click(object sender, EventArgs e)
        {
            user1 f8 = new user1();
            f8.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reports f8 = new reports();
            f8.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Event_information f8 = new Event_information();
            f8.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            participants_details h9 = new participants_details();
            h9.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ADMIN h9 = new ADMIN();
            h9.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            REVENUE h9 = new REVENUE();
            h9.Show();
            Visible = false;
        }
    }
}
