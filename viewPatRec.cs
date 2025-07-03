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
    public partial class viewPatRec : UserControl
    {
        public viewPatRec()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nic = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(nic))
            {
                MessageBox.Show("Please enter a NIC to search.", "Validation Error");
                return;
            }

            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    name, 
                    gender, 
                    phone, 
                    TIMESTAMPDIFF(YEAR, dob, CURDATE()) AS age
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
                                label23.Text = reader["name"].ToString();          // Name
                                label21.Text = reader["gender"].ToString();        // Gender
                                label16.Text = reader["phone"].ToString();         // Phone
                                label19.Text = reader["age"].ToString();           // Age
                            }
                            else
                            {
                                MessageBox.Show("No patient found with the provided NIC.", "Info");

                                // Clear previous values
                                label23.Text = "-";
                                label21.Text = "-";
                                label16.Text = "-";
                                label19.Text = "-";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving patient details: " + ex.Message, "Database Error");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nic = textBox2.Text.Trim();
            DateTime startDate = dateTimePicker2.Value.Date;
            DateTime endDate = dateTimePicker3.Value.Date;

            if (string.IsNullOrEmpty(nic))
            {
                MessageBox.Show("Please enter the patient's NIC first.", "Validation Error");
                return;
            }

            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    conn.Open();




                    string query = @"
SELECT 
    d.diagnosis_id AS 'ID',
    d.diagnosis AS 'Diagnosis',
    d.prescription AS 'Prescription',
    d.instructions AS 'Instructions',
    d.date AS 'Date'
FROM diagnosis d
JOIN patients p ON d.patient_id = p.patient_id
WHERE p.nic = @nic
  AND d.date BETWEEN @start AND @end
ORDER BY d.date DESC";




                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nic", nic);
                        cmd.Parameters.AddWithValue("@start", startDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@end", endDate.ToString("yyyy-MM-dd"));

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
                    MessageBox.Show("Error loading diagnosis records: " + ex.Message, "Database Error");
                }
            }

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
