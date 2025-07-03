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
    public partial class userdetails : UserControl
    {
        public userdetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            // Collect all values from the form
            string firstName = textBox1.Text.Trim();
            string lastName = textBox2.Text.Trim();
            string fullName = $"{firstName} {lastName}";
            DateTime dob = dateTimePicker1.Value;
            string gender = radioButton1.Checked ? "Male" : (radioButton2.Checked ? "Female" : "");
            string phone = textBox4.Text.Trim();
            string email = textBox5.Text.Trim();
            string nic = textBox6.Text.Trim();
            string address1 = textBox7.Text.Trim();
            string address2 = textBox8.Text.Trim();
            string city = textBox9.Text.Trim();
            string province = textBox10.Text.Trim();
            string postal = textBox11.Text.Trim();
            string emergency = textBox12.Text.Trim();
            string notes = richTextBox1.Text.Trim();

            if (string.IsNullOrEmpty(nic))
            {
                MessageBox.Show("NIC is required to update the record.", "Error");
                return;
            }

            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();

                string query = @"
        UPDATE patients
        SET 
            name = @name,
            dob = @dob,
            gender = @gender,
            phone = @phone,
            email = @email,
            address_line1 = @address1,
            address_line2 = @address2,
            city = @city,
            province = @province,
            postal_code = @postal,
            emergency_contact = @emergency,
            notes = @notes
        WHERE nic = @nic";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", fullName);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@address1", address1);
                    cmd.Parameters.AddWithValue("@address2", address2);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@province", province);
                    cmd.Parameters.AddWithValue("@postal", postal);
                    cmd.Parameters.AddWithValue("@emergency", emergency);
                    cmd.Parameters.AddWithValue("@notes", notes);
                    cmd.Parameters.AddWithValue("@nic", nic);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Patient details updated successfully.", "Success");
                    }
                    else
                    {
                        MessageBox.Show("No matching patient found or no changes made.", "Info");

                    }
                }
            }

        }

        private void ClearPatientForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            richTextBox1.Clear();
            dateTimePicker1.Value = DateTime.Today;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            {
                string nic = textBox6.Text.Trim(); // assuming NIC is in textBox6

                if (string.IsNullOrEmpty(nic))
                {
                    MessageBox.Show("Please enter a valid NIC to delete.", "Error");
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this patient and all related records?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes)
                    return;

                string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    conn.Open();

                    // Get the patient_id from NIC first
                    string getIdQuery = "SELECT patient_id FROM patients WHERE nic = @nic";
                    int patientId = -1;

                    using (MySqlCommand getIdCmd = new MySqlCommand(getIdQuery, conn))
                    {
                        getIdCmd.Parameters.AddWithValue("@nic", nic);
                        var resultId = getIdCmd.ExecuteScalar();
                        if (resultId == null)
                        {
                            MessageBox.Show("Patient not found.", "Error");
                            return;
                        }

                        patientId = Convert.ToInt32(resultId);
                    }

                    // Delete patient
                    string deleteQuery = "DELETE FROM patients WHERE patient_id = @patientId";

                    using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@patientId", patientId);
                        int rows = deleteCmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Patient and related records deleted successfully.", "Success");

                            // Optionally clear UI fields
                            ClearPatientForm();
                        }
                        else
                        {
                            MessageBox.Show("Deletion failed.", "Error");
                        }
                    }

                }

            }
        }
    }
}
    

       

