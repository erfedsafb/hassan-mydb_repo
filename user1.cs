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
    public partial class user1 : Form
    {
        public user1()
        {
            InitializeComponent();
        }

        private void user1_Load(object sender, EventArgs e)
        {

        }

        private void eventcreate_button_Click(object sender, EventArgs e)
        {
            Event_creation f7 = new Event_creation();
            f7.Show();
            Visible = false;
        }

        private void addparticipants_button_Click(object sender, EventArgs e)
        {
            participants f9=new participants();
            f9.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            feedback f6=new feedback();
            f6.Show();
            Visible=false;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            USER f9 = new USER();
            f9.Show();
            Visible = false;
        }
    }
}
