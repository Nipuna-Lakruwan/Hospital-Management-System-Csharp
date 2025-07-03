using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class RecDash : UserControl
    {
        public RecDash()
        {
            InitializeComponent();
            LoadPatientCount();
            LoadTodaysAppointments();
            LoadPendingBillsCount();
            LoadTodayDoctorCount();

            label3.Text = Session.Name;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void LoadPatientCount()
        {
            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM patients";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    object result = cmd.ExecuteScalar();
                    int count = Convert.ToInt32(result);

                    label6.Text = count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching patient count: " + ex.Message);
                }
            }
        }

        private void LoadTodaysAppointments()
        {
            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM appointments WHERE DATE(appointment_date) = CURDATE()";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    object result = cmd.ExecuteScalar();
                    int count = Convert.ToInt32(result);

                    label7.Text = count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching today's appointments: " + ex.Message);
                }
            }
        }

        private void LoadPendingBillsCount()
        {
          
                string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    try
                    {
                        conn.Open();

                        string query = "SELECT COUNT(*) FROM appointments WHERE payment_status = 'pending'";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            object result = cmd.ExecuteScalar();
                            int pendingCount = Convert.ToInt32(result);
                            label9.Text = pendingCount.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching pending bill count: " + ex.Message);
                    }
                }
            

        }

        private void LoadTodayDoctorCount()
        {
            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT COUNT(DISTINCT doctor_id)
                FROM appointments
                WHERE appointment_date = CURDATE()";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        int count = result != null ? Convert.ToInt32(result) : 0;

                        label11.Text = count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading doctor appointment count: " + ex.Message, "Database Error");
                }
            }
        }


        private void RecDash_Load(object sender, EventArgs e)
        {

        }
    }
}
