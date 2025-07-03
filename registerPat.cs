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
    public partial class registerPat : UserControl
    {
        public registerPat()
        {
            InitializeComponent();
        }

        private void guna2ImageRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text.Trim();
            string lastName = textBox2.Text.Trim();
            DateTime dob = dateTimePicker1.Value;
            string gender = radioButton1.Checked ? "male" : (radioButton2.Checked ? "female" : "other");
            string phone = textBox4.Text.Trim();
            string email = textBox5.Text.Trim();
            string nic = textBox6.Text.Trim();
            string address1 = textBox7.Text.Trim();
            string address2 = textBox8.Text.Trim(); // optional
            string city = textBox9.Text.Trim();
            string province = textBox10.Text.Trim();
            string postalCode = textBox11.Text.Trim();
            string emergencyPhone = textBox12.Text.Trim();
            string notes = richTextBox1.Text.Trim();

            string fullName = firstName + " " + lastName;

            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    string query = @"INSERT INTO Patients 
                (name, gender, dob, nic, phone, email, address_line1, address_line2, city, province, postal_code, emergency_contact, notes) 
                VALUES 
                (@name, @gender, @dob, @nic, @phone, @email, @addr1, @addr2, @city, @prov, @postal, @emergency, @notes)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", fullName);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@dob", dob);
                        cmd.Parameters.AddWithValue("@nic", nic);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@addr1", address1);
                        cmd.Parameters.AddWithValue("@addr2", address2);
                        cmd.Parameters.AddWithValue("@city", city);
                        cmd.Parameters.AddWithValue("@prov", province);
                        cmd.Parameters.AddWithValue("@postal", postalCode);
                        cmd.Parameters.AddWithValue("@emergency", emergencyPhone);
                        cmd.Parameters.AddWithValue("@notes", notes);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Patient registered successfully!", "Success");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error registering patient: " + ex.Message);
                }

            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear all TextBoxes
            textBox1.Clear(); // First Name
            textBox2.Clear(); // Last Name
            textBox4.Clear(); // Phone
            textBox5.Clear(); // Email
            textBox6.Clear(); // NIC
            textBox7.Clear(); // Address Line 1
            textBox8.Clear(); // Address Line 2 (optional)
            textBox9.Clear(); // City
            textBox10.Clear(); // Province
            textBox11.Clear(); // Postal Code
            textBox12.Clear(); // Emergency Contact

            // Clear Date Picker
            dateTimePicker1.Value = DateTime.Today;

            // Uncheck Radio Buttons
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            // Clear Notes/Allergies
            richTextBox1.Clear();

            // Optional: Set focus to the first field
            textBox1.Focus();
        }

    }
}

        
    

