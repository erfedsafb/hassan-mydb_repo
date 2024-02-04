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
    public partial class ADMIN : Form
    {
        OracleConnection con;
        public ADMIN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string str = @"DATA SOURCE = localhost:1521/xe; USER ID= DATABASEPROJECT; PASSWORD= 1234";
            con = new OracleConnection(str);
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ADMIN_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void admin_login_Click(object sender, EventArgs e)
        {

            string email = textBox1.Text;
            string password = textBox2.Text;

            if (ValidateLogin(email, password))
            {
                MessageBox.Show("Login successful!");
                admin1 f6 = new admin1();
                f6.Show();
                Visible = false;
                // Perform actions after successful login, e.g., navigate to another form
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

                using (OracleCommand cmd = new OracleCommand("SELECT COUNT(*) FROM ADMIN_DATA WHERE email = :email AND pass = :password", connection))
                {
                    cmd.Parameters.Add(new OracleParameter("email", email));
                    cmd.Parameters.Add(new OracleParameter("pass", password));

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




        private void back_button_Click(object sender, EventArgs e)
        {
            Frontform f3 = new Frontform();
            f3.Show();
            Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
