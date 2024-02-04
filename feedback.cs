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
    public partial class feedback : Form
    {
        OracleConnection con;
        public feedback()
        {
            InitializeComponent();
        }

        private void feedback_Load(object sender, EventArgs e)
        {
            string str = @"DATA SOURCE = localhost:1521/xe; USER ID= DATABASEPROJECT; PASSWORD= 1234";
            con = new OracleConnection(str);
            gride();
         
        }

        private void gride()
        {
            con.Open();

            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "SELECT PARTICIPANT_ID FROM PARTICIPANTS ";

            getEmps.CommandType = CommandType.Text;

            OracleDataReader empDR = getEmps.ExecuteReader();

            DataTable empDT = new DataTable();

            empDT.Load(empDR);

            dataGridView2.DataSource = empDT;

            con.Close();
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }


        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Create a command to get the next value from the sequence
                OracleCommand feedback = con.CreateCommand();
                feedback.CommandText = "SELECT feedbackseq.NEXTVAL FROM DUAL";
                feedback.CommandType = CommandType.Text;

                // Execute the query to get the next user ID
                object nextUserId = feedback.ExecuteScalar();
                int eventIdValue = 0;

                // Use the retrieved user ID for the insertion
                OracleCommand insertEmp = con.CreateCommand();
                insertEmp.CommandText = "INSERT INTO FEEDBACK ( PARTICIPANT_ID, PUNCTUALITY, HOSPITALITY, COMMENTS) " +
                                        "VALUES ( :venue_name, :last_name, :email, :password)";

                //insertEmp.Parameters.Add(":id", OracleDbType.Decimal).Value = nextUserId;
                insertEmp.Parameters.Add(":venue_name", OracleDbType.Varchar2).Value = eventIdValue;
                insertEmp.Parameters.Add(":PUNCTUALITY", OracleDbType.Varchar2).Value = textBox1.Text.ToString();
                insertEmp.Parameters.Add(":HOSPITALITY", OracleDbType.Varchar2).Value = textBox2.Text.ToString();
                insertEmp.Parameters.Add(":COMMENTS", OracleDbType.Varchar2).Value = textBox3.Text.ToString();
                if (int.TryParse(venue_name.Text, out int event_id_value))
                {
                    insertEmp.Parameters[":venue_name"].Value = event_id_value;
                }
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

        private int GetParticipantID()
            {
                // Your logic to get ParticipantID
                return 1; // Replace with the actual ParticipantID
            }

        private void button1_Click(object sender, EventArgs e)
        {
            user1 f4 = new user1();
                f4.Show();
            Visible = false;
        }
    }
}
