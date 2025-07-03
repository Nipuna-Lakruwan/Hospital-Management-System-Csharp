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
    public partial class DocApp : UserControl
    {
        public DocApp()
        {
            InitializeComponent();
            appDetails1.Visible = false;

        }

        public string selectedAppointmentId;




        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    a.time_slot AS 'Time Slot',
                    p.name AS 'Patient Name',
                    p.patient_id AS 'Patient ID',
                    p.nic AS 'NIC',
                    a.status AS 'Status',
                    a.special_notes AS 'Note',
                    a.appointment_id AS appointment_id
                FROM appointments a
                JOIN patients p ON a.patient_id = p.patient_id
                WHERE a.doctor_id = @doctorId 
                  AND a.appointment_date = @selectedDate
                ORDER BY a.time_slot";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@doctorId", Session.doctor_id);
                        cmd.Parameters.AddWithValue("@selectedDate", dateTimePicker1.Value.Date);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading appointments: " + ex.Message);
                }
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string appointmentId = row.Cells["appointment_id"].Value.ToString();

                selectedAppointmentId = appointmentId;

                LoadAppointmentDetails(selectedAppointmentId);
            }


        }

        private void LoadAppointmentDetails(string appointmentId)
        {

            selectedAppointmentId = appointmentId;

            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();

                string query = @"
            SELECT 
                p.name AS patient_name,
                p.gender,
                TIMESTAMPDIFF(YEAR, p.dob, CURDATE()) AS age,
                a.appointment_date,
                p.patient_id AS 'Patient ID',
                p.nic AS 'NIC',
                a.time_slot,
                a.special_notes AS appointment_note,
                p.notes AS patient_note,
                a.appointment_id AS appID
            FROM appointments a
            JOIN patients p ON a.patient_id = p.patient_id
            WHERE a.appointment_id = @appId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@appId", appointmentId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            appDetails1.Visible = true;

                            // Patient Info
                            appDetails1.label19.Text = reader["appID"].ToString();
                            appDetails1.label4.Text = reader["patient_name"].ToString();               // Name
                            appDetails1.label7.Text = reader["gender"].ToString();                    // Gender
                            appDetails1.label10.Text = reader["age"].ToString();                      // Age
                            appDetails1.label22.Text = reader["Patient ID"].ToString();
                            appDetails1.label21.Text = reader["NIC"].ToString();

                            // Appointment Info
                            appDetails1.label2.Text = Convert.ToDateTime(reader["appointment_date"]).ToShortDateString();  // Date
                            appDetails1.label5.Text = reader["time_slot"].ToString();                 // Time Slot
                            appDetails1.label12.Text = reader["appointment_note"].ToString();         // Appointment Note
                            appDetails1.textBox1.Text = reader["patient_note"].ToString();            // Patient Notes
                        }
                        else
                        {
                            MessageBox.Show("Appointment details not found.", "Error");
                        }
                    }
                }
            }
        }


        private void DocApp_Load(object sender, EventArgs e)
        {

        }

        private void appDetails1_Load(object sender, EventArgs e)
        {

        }
    }
}
