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
    public partial class recsearch : UserControl
    {
        public recsearch()
        {
            InitializeComponent();
            this.Load += SearchPatient_Load;
        }

        private void SearchPatient_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Appointments");
            comboBox1.Items.Add("Details");
            comboBox1.SelectedIndex = 0;
            appsearch1.Visible = false;
            userdetails1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nic = textBox1.Text.Trim();
            string selectedSearch = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nic) || string.IsNullOrEmpty(selectedSearch))
            {
                MessageBox.Show("Please enter NIC and select a search type.", "Error");
                return;
            }

            if (selectedSearch == "Appointments")
            {
                appsearch1.Visible = true;
                userdetails1.Visible = false;
                LoadAppointmentsToGrid(nic);
            }
            else if (selectedSearch == "Details")
            {
                appsearch1.Visible = false;
                userdetails1.Visible = true;
                LoadPatientDetails(nic);
            }
        }


        private void LoadAppointmentsToGrid(string nic)
        {
            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();

                string query = @"
            SELECT 
                a.appointment_id AS AID,
                p.name AS Patient,
                d.name AS Doctor,
                d.specialization AS Specialization,
                a.appointment_date AS Date,
                a.time_slot AS Time,
                a.special_notes AS Notes,
                p.nic AS NIC
            FROM appointments a
            JOIN patients p ON a.patient_id = p.patient_id
            JOIN doctors d ON a.doctor_id = d.doctor_id
            WHERE p.nic = @nic
            ORDER BY a.appointment_date DESC";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nic", nic);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        appsearch1.dataGridView1.DataSource = dt;
                    }
                }
            }
        }



        private void LoadAppointmentInfo(string nic)
        {
            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();

                string query = @"
                SELECT 
                    p.name AS patient_name,
                    d.name AS doctor_name,
                    d.specialization,
                    a.appointment_date,
                    a.time_slot,
                    a.special_notes
                FROM appointments a
                JOIN patients p ON a.patient_id = p.patient_id
                JOIN doctors d ON a.doctor_id = d.doctor_id
                WHERE p.nic = @nic
                ORDER BY a.appointment_date DESC
                LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nic", nic);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            appsearch1.label4.Text = reader["patient_name"].ToString();                            // Name
                            appsearch1.label7.Text = reader["doctor_name"].ToString();                             // Doctor
                            appsearch1.label5.Text = Convert.ToDateTime(reader["appointment_date"]).ToShortDateString();  // Appointment Date
                            appsearch1.label1.Text = reader["time_slot"].ToString();                               // Time Slot
                            appsearch1.label10.Text = reader["specialization"].ToString();                         // Specialization
                            appsearch1.textBox2.Text = reader["special_notes"].ToString();                         // Notes
                        }
                        else
                        {
                            MessageBox.Show("No appointment found for this patient NIC.", "Info");

                            // Clear UI fields
                            appsearch1.label4.Text = "-";
                            appsearch1.label7.Text = "-";
                            appsearch1.label5.Text = "-";
                            appsearch1.label1.Text = "-";
                            appsearch1.label10.Text = "-";
                            appsearch1.textBox2.Clear();
                        }
                    }
                }
            }
        }


        private void LoadPatientDetails(string nic)
        {
            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();

                string query = @"
            SELECT 
                name, dob, gender, phone, email, nic,
                address_line1, address_line2, city, province, postal_code,
                emergency_contact, notes
            FROM patients
            WHERE nic = @nic
            LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nic", nic);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Split full name into first and last name
                            string fullName = reader["name"].ToString();
                            var nameParts = fullName.Split(' ');

                            userdetails1.textBox1.Text = nameParts.Length > 0 ? nameParts[0] : "";  // First name
                            userdetails1.textBox2.Text = nameParts.Length > 1 ? nameParts[1] : "";  // Last name

                            userdetails1.dateTimePicker1.Value = reader["dob"] != DBNull.Value
                                ? Convert.ToDateTime(reader["dob"])
                                : DateTime.Today;

                            string gender = reader["gender"].ToString().ToLower();
                            userdetails1.radioButton1.Checked = gender == "male";
                            userdetails1.radioButton2.Checked = gender == "female";

                            userdetails1.textBox4.Text = reader["phone"].ToString();
                            userdetails1.textBox5.Text = reader["email"].ToString();
                            userdetails1.textBox6.Text = reader["nic"].ToString();
                            userdetails1.textBox7.Text = reader["address_line1"].ToString();
                            userdetails1.textBox8.Text = reader["address_line2"].ToString();
                            userdetails1.textBox9.Text = reader["city"].ToString();
                            userdetails1.textBox10.Text = reader["province"].ToString();
                            userdetails1.textBox11.Text = reader["postal_code"].ToString();
                            userdetails1.textBox12.Text = reader["emergency_contact"].ToString();
                            userdetails1.richTextBox1.Text = reader["notes"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No patient details found for this NIC.", "Info");

                            // Clear all fields
                            userdetails1.textBox1.Clear();
                            userdetails1.textBox2.Clear();
                            userdetails1.dateTimePicker1.Value = DateTime.Today;
                            userdetails1.radioButton1.Checked = false;
                            userdetails1.radioButton2.Checked = false;
                            userdetails1.textBox4.Clear();
                            userdetails1.textBox5.Clear();
                            userdetails1.textBox6.Clear();
                            userdetails1.textBox7.Clear();
                            userdetails1.textBox8.Clear();
                            userdetails1.textBox9.Clear();
                            userdetails1.textBox10.Clear();
                            userdetails1.textBox11.Clear();
                            userdetails1.textBox12.Clear();
                            userdetails1.richTextBox1.Clear();
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = appsearch1.dataGridView1.Rows[e.RowIndex];

                appsearch1.label4.Text = row.Cells["Patient"].Value?.ToString();          // Patient Name
                appsearch1.label7.Text = row.Cells["Doctor"].Value?.ToString();           // Doctor
                appsearch1.label10.Text = row.Cells["Specialization"].Value?.ToString();  // Specialization
                appsearch1.label5.Text = Convert.ToDateTime(row.Cells["Date"].Value).ToShortDateString(); // Date
                appsearch1.label1.Text = row.Cells["Time"].Value?.ToString();             // Time
                appsearch1.textBox2.Text = row.Cells["Notes"].Value?.ToString();          // Notes
            }
        }

        private void recsearch1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}