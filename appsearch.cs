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
    public partial class appsearch : UserControl
    {
        public appsearch()
        {
            InitializeComponent();
        }

        public void label4_Click(object sender, EventArgs e)
        {

        }

        public void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                label3.Text = row.Cells["NIC"].Value?.ToString();
                label13.Text = row.Cells["AID"].Value?.ToString();
                label4.Text = row.Cells["Patient"].Value?.ToString();          // Patient Name
                label7.Text = row.Cells["Doctor"].Value?.ToString();           // Doctor
                label10.Text = row.Cells["Specialization"].Value?.ToString();  // Specialization
                label5.Text = Convert.ToDateTime(row.Cells["Date"].Value).ToShortDateString(); // Date
                label1.Text = row.Cells["Time"].Value?.ToString();             // Time
                textBox2.Text = row.Cells["Notes"].Value?.ToString();          // Notes
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (label13.Text == null)
            {
                MessageBox.Show("Please select an appointment to delete.", "Warning");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // Get the appointment_id from the selected row
                string appointmentId = label13.Text;

                string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    conn.Open();

                    string query = "DELETE FROM appointments WHERE appointment_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", appointmentId);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Appointment deleted successfully.", "Success");
                            // Reload the data in the grid
                            ReloadAppointments(label3.Text);

                            label3.Text = "-";
                            label13.Text = "-";
                            label4.Text = "-";
                            label7.Text = "-";
                            label10.Text = "-";
                            label5.Text = "-";
                            textBox2.Text = "-";
                            label1.Text = "-";

                        }
                        else
                        {
                            MessageBox.Show("Failed to delete appointment.", "Error");
                        }

                    }
                }
            }

        }

        public void ReloadAppointments(String CurrentNIC)
        {
            if (!string.IsNullOrEmpty(CurrentNIC))
            {
                // Reuse your existing grid load logic
                string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    conn.Open();

                    string query = @"
            SELECT 
                a.appointment_id,
                p.name AS Patient,
                d.name AS Doctor,
                d.specialization AS Specialization,
                a.appointment_date AS Date,
                a.time_slot AS Time,
                a.special_notes AS Notes
            FROM appointments a
            JOIN patients p ON a.patient_id = p.patient_id
            JOIN doctors d ON a.doctor_id = d.doctor_id
            WHERE p.nic = @nic
            ORDER BY a.appointment_date DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nic", CurrentNIC);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchapp1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            
        }
    }
}
