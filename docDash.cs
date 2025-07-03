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
    public partial class docDash : UserControl
    {
        public docDash()
        {

            InitializeComponent();
            LoadPatientCount();
            LoadTodayAppointmentsForDoctor();
            LoadAllUpcomingAppointmentsForDoctor();
        

            label3.Text = Session.Name; 

        }

        private void LoadTodayAppointmentsForDoctor()
        {
            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT COUNT(*) 
                FROM appointments 
                WHERE doctor_id = @doctorId 
                  AND appointment_date = CURDATE()";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@doctorId", Session.doctor_id); // 👈 Your logged-in doctor ID from session

                        object result = cmd.ExecuteScalar();
                        int todayCount = Convert.ToInt32(result);

                        label7.Text = todayCount.ToString(); // 👈 Use the label where you want to show this number
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching today's appointments: " + ex.Message);
                }
            }
        }

        private void LoadAllUpcomingAppointmentsForDoctor()
        {
            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT COUNT(*) 
                FROM appointments 
                WHERE doctor_id = @doctorId 
                  AND appointment_date >= CURDATE()";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@doctorId", Session.doctor_id); // Session variable with logged-in doctor ID

                        object result = cmd.ExecuteScalar();
                        int upcomingCount = Convert.ToInt32(result);

                        label9.Text = upcomingCount.ToString(); // 👈 Display in label9
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching upcoming appointments: " + ex.Message);
                }
            }
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
    }
}


