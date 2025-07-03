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
    public partial class addNewRec : UserControl
    {
        public addNewRec()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
                // Collect data from input fields
                string firstName = textBox1.Text.Trim();
                string lastName = textBox2.Text.Trim();
                string fullName = $"{firstName} {lastName}";
                string dob = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string gender = radioButton1.Checked ? "Male" : (radioButton2.Checked ? "Female" : "");
                string phone = textBox4.Text.Trim();
                string nic = textBox6.Text.Trim();
                string password = textBox3.Text;
                string rePassword = textBox5.Text;

                // Validate inputs
                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                    string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(phone) ||
                    string.IsNullOrEmpty(nic) || string.IsNullOrEmpty(password) ||
                    string.IsNullOrEmpty(rePassword))
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

                        // Insert into users table
                        string insertUserQuery = "INSERT INTO users (username, password, role) VALUES (@username, @password, 'reception')";
                        long userId;

                        using (MySqlCommand cmdUser = new MySqlCommand(insertUserQuery, conn, transaction))
                        {
                            cmdUser.Parameters.AddWithValue("@username", nic);
                            cmdUser.Parameters.AddWithValue("@password", password);
                            cmdUser.ExecuteNonQuery();
                            userId = cmdUser.LastInsertedId;
                        }

                        // Insert into receptionists table
                        string insertRecQuery = @"INSERT INTO receptionists (user_id, name, dob, gender, phone, nic)
                                      VALUES (@user_id, @name, @dob, @gender, @phone, @nic)";

                        using (MySqlCommand cmdRec = new MySqlCommand(insertRecQuery, conn, transaction))
                        {
                            cmdRec.Parameters.AddWithValue("@user_id", userId);
                            cmdRec.Parameters.AddWithValue("@name", fullName);
                            cmdRec.Parameters.AddWithValue("@dob", dob);
                            cmdRec.Parameters.AddWithValue("@gender", gender);
                            cmdRec.Parameters.AddWithValue("@phone", phone);
                            cmdRec.Parameters.AddWithValue("@nic", nic);
                            cmdRec.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Receptionist added successfully!", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding receptionist: " + ex.Message, "Database Error");
                    }
                }
            



        }
    }
}
