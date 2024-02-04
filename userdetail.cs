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
    public partial class userdetail : Form
    {
        OracleConnection con;
        public userdetail()
        {
            InitializeComponent();
        }

        private void email_txt_Click(object sender, EventArgs e)
        {

        }

        private void userdetail_Load(object sender, EventArgs e)
        {
            string str = @"DATA SOURCE = localhost:1521/xe; USER ID= DATABASEPROJECT; PASSWORD= 1234";
            con = new OracleConnection(str);
        }



        private void admin_login_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void admin_button_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Create a command to get the next value from the sequence
                OracleCommand getUserIdCmd = con.CreateCommand();
                getUserIdCmd.CommandText = "SELECT user_id_seq.NEXTVAL FROM DUAL";
                getUserIdCmd.CommandType = CommandType.Text;

                // Execute the query to get the next user ID
                object nextUserId = getUserIdCmd.ExecuteScalar();

                // Use the retrieved user ID for the insertion
                OracleCommand insertEmp = con.CreateCommand();
                insertEmp.CommandText = "INSERT INTO userd ( first_name, last_name, email, password) " +
                                        "VALUES ( :first_name, :last_name, :email, :password)";

                //insertEmp.Parameters.Add(":id", OracleDbType.Decimal).Value = nextUserId;
                insertEmp.Parameters.Add(":first_name", OracleDbType.Varchar2).Value = first_name.Text.ToString();
                insertEmp.Parameters.Add(":last_name", OracleDbType.Varchar2).Value = last_name.Text.ToString();
                insertEmp.Parameters.Add(":email", OracleDbType.Varchar2).Value = email.Text.ToString();
                insertEmp.Parameters.Add(":password", OracleDbType.Varchar2).Value = passward.Text.ToString();

                insertEmp.CommandType = CommandType.Text;

                int rows = insertEmp.ExecuteNonQuery();

                if (rows > 0)
                    MessageBox.Show("Data Inserted Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            USER f0 = new USER();
            f0.Show();
            Visible = false;
        }
    }
}

