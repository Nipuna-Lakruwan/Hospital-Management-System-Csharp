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
    public partial class addNewDoc : UserControl
    {
        public addNewDoc()
        {
            InitializeComponent();
        }

        private void addNewDoc_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                // 1. Collect form data
                string firstName = textBox1.Text.Trim();
                string lastName = textBox2.Text.Trim();
                string fullName = $"{firstName} {lastName}";
                string dob = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string gender = radioButton1.Checked ? "Male" : (radioButton2.Checked ? "Female" : "");
                string phone = textBox4.Text.Trim();
                string nic = textBox6.Text.Trim();
                string specialization = comboBox1.SelectedItem?.ToString(); // ensure it's selected
                string password = textBox3.Text.Trim();
                string rePassword = textBox5.Text.Trim();

                // 2. Validate
                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(gender)
                    || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(nic) || string.IsNullOrEmpty(specialization)
                    || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(rePassword))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error");
                    return;
                }

                if (password != rePassword)
                {
                    MessageBox.Show("Passwords do not match.", "Validation Error");
                    return;
                }

                string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    try
                    {
                        conn.Open();
                        MySqlTransaction transaction = conn.BeginTransaction();

                        // 3. Insert into users table
                        string insertUserQuery = "INSERT INTO users (username, password, role) VALUES (@username, @password, 'doctor')";
                        long userId;

                        using (MySqlCommand cmdUser = new MySqlCommand(insertUserQuery, conn, transaction))
                        {
                            cmdUser.Parameters.AddWithValue("@username", nic);
                            cmdUser.Parameters.AddWithValue("@password", password);
                            cmdUser.ExecuteNonQuery();
                            userId = cmdUser.LastInsertedId;
                        }

                        // 4. Insert into doctors table
                        string insertDoctorQuery = @"
                INSERT INTO doctors (user_id, name, dob, gender, phone, nic, specialization)
                VALUES (@user_id, @name, @dob, @gender, @phone, @nic, @specialization)";

                        using (MySqlCommand cmdDoctor = new MySqlCommand(insertDoctorQuery, conn, transaction))
                        {
                            cmdDoctor.Parameters.AddWithValue("@user_id", userId);
                            cmdDoctor.Parameters.AddWithValue("@name", fullName);
                            cmdDoctor.Parameters.AddWithValue("@dob", dob);
                            cmdDoctor.Parameters.AddWithValue("@gender", gender);
                            cmdDoctor.Parameters.AddWithValue("@phone", phone);
                            cmdDoctor.Parameters.AddWithValue("@nic", nic);
                            cmdDoctor.Parameters.AddWithValue("@specialization", specialization);
                            cmdDoctor.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Doctor added successfully!", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding doctor: " + ex.Message, "Database Error");
                    }
                }
            

        }
    }
}
