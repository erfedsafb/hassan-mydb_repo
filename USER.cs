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
    public partial class USER : Form
    {
        OracleConnection con;
        public USER()
        {
            InitializeComponent();
        }

        private void USER_Load(object sender, EventArgs e)
        {
            string str = @"DATA SOURCE = localhost:1521/xe; USER ID= DATABASEPROJECT; PASSWORD= 1234";
            con = new OracleConnection(str);
        }

        private void pss_txt_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_txt_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Frontform f4 = new Frontform();
            f4.Show();
            Visible = false;
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            userdetail f6 = new userdetail();
            f6.Show();
            Visible = false;

        }

        private void admin_login_Click(object sender, EventArgs e)
        {
            string email = user_email.Text;
            string password = user_pass.Text;

            if (ValidateLogin(email, password))
            {
                MessageBox.Show("Login successful!");
                user1 f6 = new user1();
                f6.Show();
                Visible = false;

               
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.");
            }
        }



        private bool ValidateLogin(string email, string password)
        {
            using (OracleConnection connection = new OracleConnection(@"DATA SOURCE=localhost:1521/xe;USER ID=DATABASEPROJECT;PASSWORD=1234"))
            {
                connection.Open();

                using (OracleCommand cmd = new OracleCommand("SELECT COUNT(*) FROM USERD WHERE email = :email AND password = :password", connection))
                {
                    cmd.Parameters.Add(new OracleParameter("email", email));
                    cmd.Parameters.Add(new OracleParameter("password", password));

                    try
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Error converting result to integer: " + ex.Message);
                        return false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

    }
}
