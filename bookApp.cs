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
    public partial class bookApp : UserControl
    {
        public bookApp()
        {
            InitializeComponent();
            LoadDoctors();
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
        }

        private void LoadDoctors()
        {
            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();
                string query = "SELECT doctor_id, name FROM doctors";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    comboBox3.DataSource = dt;
                    comboBox3.DisplayMember = "name";
                    comboBox3.ValueMember = "doctor_id";
                }
            }
        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedValue != null && int.TryParse(comboBox3.SelectedValue.ToString(), out int doctorId))
            {
                string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    conn.Open();
                    string query = "SELECT specialization FROM doctors WHERE doctor_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", doctorId);
                        object result = cmd.ExecuteScalar();
                        textBox2.Text = result?.ToString() ?? "";
                    }
                }
            }
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookApp_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nic = textBox1.Text.Trim();  // 🔁 Changed from patientName
            int doctorId = Convert.ToInt32(comboBox3.SelectedValue);
            DateTime appointmentDate = dateTimePicker1.Value.Date;
            string timeSlot = comboBox1.SelectedItem?.ToString();
            string notes = richTextBox1.Text.Trim();

            if (string.IsNullOrEmpty(nic) || string.IsNullOrEmpty(timeSlot))
            {
                MessageBox.Show("Please enter NIC and select a time slot.", "Error");
                return;
            }

            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();

                // ✅ 1. Get patient_id using NIC
                string getPatientIdQuery = "SELECT patient_id FROM patients WHERE nic = @nic LIMIT 1";
                int patientId;

                using (MySqlCommand cmd = new MySqlCommand(getPatientIdQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@nic", nic);
                    object result = cmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Patient with this NIC not found.", "Error");
                        return;
                    }

                    patientId = Convert.ToInt32(result);
                }

                // ✅ 2. Get receptionist_id from session
                int receptionistId = GetReceptionistIdByUserId(Session.UserId);

                // ✅ 3. Insert appointment
                string insertQuery = @"
        INSERT INTO appointments 
        (patient_id, doctor_id, receptionist_id, appointment_date, time_slot, status, special_notes)
        VALUES 
        (@patient_id, @doctor_id, @receptionist_id, @date, @slot, 'scheduled', @notes)";

                using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@patient_id", patientId);
                    cmd.Parameters.AddWithValue("@doctor_id", doctorId);
                    cmd.Parameters.AddWithValue("@receptionist_id", receptionistId);
                    cmd.Parameters.AddWithValue("@date", appointmentDate);
                    cmd.Parameters.AddWithValue("@slot", timeSlot);
                    cmd.Parameters.AddWithValue("@notes", notes);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Appointment booked successfully!", "Success");
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private int GetReceptionistIdByUserId(int userId)
        {
            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";
            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();
                string query = "SELECT receptionist_id FROM receptionists WHERE user_id = @uid LIMIT 1";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@uid", userId);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
           
            comboBox3.SelectedIndex = -1;

            textBox2.Clear();
           
            dateTimePicker1.Value = DateTime.Today;
           
            comboBox1.SelectedIndex = -1;

            richTextBox1.Clear();

            textBox1.Focus();
        }
    }
}

