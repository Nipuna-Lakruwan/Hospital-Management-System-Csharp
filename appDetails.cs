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
using Mysqlx.Crud;



namespace HMS
{
    public partial class appDetails : UserControl
    {
        public appDetails()
        {
            InitializeComponent();
            addDiagnosis1.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            addDiagnosis1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addDiagnosis1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string appId = label19.Text;

            if (string.IsNullOrEmpty(appId))
            {
                MessageBox.Show("No appointment selected to cancel.", "Error");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to cancel this appointment?", "Confirm", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM appointments WHERE appointment_id = @id";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", appId);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Appointment cancelled successfully.");
                        this.Visible = false; // Hide the panel

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error cancelling appointment: " + ex.Message);
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control parent = this.Parent;

            if (parent != null)
            {
                // Find the DocApp control inside the same parent container
                foreach (Control control in parent.Controls)
                {
                    if (control is DocApp docAppControl)
                    {
                        docAppControl.Visible = true;   // Show DocApp
                        break;
                    }
                }

                this.Visible = false; // Hide appDetails
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string appId = label19.Text;

            if (string.IsNullOrWhiteSpace(appId))
            {
                MessageBox.Show("No appointment selected.", "Error");
                return;
            }

            string diagnosis = textBox2.Text.Trim();
            string prescription = textBox3.Text.Trim();
            string instructions = textBox4.Text.Trim();
            string chargesText = textBox5.Text.Trim();
            string nic = label21.Text.Trim();
            string patientId = label22.Text.Trim();
            string date = DateTime.Now.ToString("yyyy-MM-dd");


            if (string.IsNullOrWhiteSpace(diagnosis) || string.IsNullOrWhiteSpace(prescription)
                    || string.IsNullOrWhiteSpace(instructions) || string.IsNullOrWhiteSpace(chargesText))
            {
                MessageBox.Show("Please fill in all fields.", "Validation");
                return;
            }

            if (!decimal.TryParse(chargesText, out decimal charges))
            {
                MessageBox.Show("Doctor charges must be a valid number.", "Validation");
                return;
            }

            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    conn.Open();


                    string insertQuery = @"
    INSERT INTO diagnosis(appointment_id, diagnosis, prescription, instructions, charges, date, nic, patient_id)
    VALUES(@appId, @diagnosis, @prescription, @instructions, @charges, @date, @nic, @patientId)";


                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@appId", appId);
                        cmd.Parameters.AddWithValue("@diagnosis", diagnosis);
                        cmd.Parameters.AddWithValue("@prescription", prescription);
                        cmd.Parameters.AddWithValue("@instructions", instructions);
                        cmd.Parameters.AddWithValue("@charges", charges);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@nic", nic);
                        cmd.Parameters.AddWithValue("@patientId", patientId);

                        cmd.ExecuteNonQuery();
                    }

                    // Optionally update the appointment status
                    string updateStatusQuery = "UPDATE appointments SET status = 'Completed', payment_status = 'pending' WHERE appointment_id = @appId";

                    using (MySqlCommand statusCmd = new MySqlCommand(updateStatusQuery, conn))
                    {
                        statusCmd.Parameters.AddWithValue("@appId", appId);
                        statusCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Diagnosis saved and appointment marked as complete.");
                    this.Visible = false; // Hide appDetails or redirect to previous screen
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving diagnosis: " + ex.Message);
                }
            }



        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}

