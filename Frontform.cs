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
    public partial class Frontform : Form
    {
        public Frontform()
        {
            InitializeComponent();
        }

        private void Frontform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADMIN f1 = new ADMIN();
            f1.Show();
            Visible = false;

        }

        private void user_button_Click(object sender, EventArgs e)
        {
           USER f4 = new USER();
            f4.Show();
            Visible = false;
        }
    }
}
