using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HMS
{
    public partial class addDash : UserControl
    {
        public addDash()
        {
            InitializeComponent();
            LoadTotalPatientCount();
            LoadTotalDoctorCount();
            LoadPendingAppointmentsCount();
            LoadTotalIncome();

        }

        private void LoadTotalIncome()
        {
            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    // Sum all charges from the diagnosis table where payment is done
                    string query = @"
                SELECT IFNULL(SUM(d.charges), 0) 
                FROM diagnosis d
                JOIN appointments a ON d.appointment_id = a.appointment_id
                WHERE a.payment_status = 'paid'";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        decimal totalIncome = Convert.ToDecimal(result);
                        label9.Text = "Rs. " + totalIncome.ToString("N2");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching total income: " + ex.Message);
                }
            }
        }



        private void addDash_Load(object sender, EventArgs e)
        {

        }

        private void LoadPendingAppointmentsCount()
        {
            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM appointments WHERE status = 'scheduled'";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        int count = Convert.ToInt32(result);

                        label11.Text = count.ToString(); // Display count in label11
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching pending appointments count: " + ex.Message);
                }
            }
        }


        private void LoadTotalDoctorCount()
        {
            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM doctors";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        int count = Convert.ToInt32(result);

                        label7.Text = count.ToString(); // Show count in label7
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching doctor count: " + ex.Message);
                }
            }
        }



        private void LoadTotalPatientCount()
        {
            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM patients";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        int count = Convert.ToInt32(result);

                        label6.Text = count.ToString(); // Show count in label6
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching patient count: " + ex.Message);
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
