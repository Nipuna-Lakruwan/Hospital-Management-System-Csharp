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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS
{
    public partial class viewdoctor1 : UserControl
    {
        public viewdoctor1()
        {
            InitializeComponent();
            LoadDoctors();
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged; // ✅ Fix: hook correct combo box
        }

        // ✅ Load doctor specialization when selection changes
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue != null && int.TryParse(comboBox2.SelectedValue.ToString(), out int doctorId))
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
            else
            {
                textBox2.Clear();
            }
        }

        // ✅ Load doctor list into comboBox2
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
                    comboBox2.DataSource = dt;
                    comboBox2.DisplayMember = "name";
                    comboBox2.ValueMember = "doctor_id";
                }
            }
        }

        // ✅ Search and display doctor's schedule
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue == null || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a doctor.", "Error");
                return;
            }

            int doctorId = Convert.ToInt32(comboBox2.SelectedValue);
            DateTime selectedDate = dateTimePicker1.Value.Date;

            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();

                string query = @"
                    SELECT 
                        a.time_slot AS 'Time Slot',
                        p.name AS 'Patient Name',
                        a.status AS 'Status',
                        a.special_notes AS 'Notes'
                    FROM appointments a
                    JOIN patients p ON a.patient_id = p.patient_id
                    WHERE a.doctor_id = @doctorId AND a.appointment_date = @appDate
                    ORDER BY a.time_slot";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);
                    cmd.Parameters.AddWithValue("@appDate", selectedDate);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        // Optional events (empty handlers)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void panel2_Paint(object sender, PaintEventArgs e) { }
    }
}
