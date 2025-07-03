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
    public partial class resetPw : UserControl
    {
        public resetPw()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                string nic = textBox6.Text.Trim();
                string newPassword = textBox3.Text.Trim();
                string confirmPassword = textBox5.Text.Trim();

                if (string.IsNullOrEmpty(nic) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
                {
                    MessageBox.Show("Please fill all fields.", "Validation Error");
                    return;
                }

                if (newPassword != confirmPassword)
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

                        // Get user_id from NIC (check both doctors and receptionists)
                        string getUserQuery = @"
                SELECT u.user_id
                FROM users u
                JOIN doctors d ON u.user_id = d.user_id
                WHERE d.nic = @nic
                UNION
                SELECT u.user_id
                FROM users u
                JOIN receptionists r ON u.user_id = r.user_id
                WHERE r.nic = @nic
            ";

                        int userId = -1;

                        using (MySqlCommand cmd = new MySqlCommand(getUserQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@nic", nic);

                            object result = cmd.ExecuteScalar();
                            if (result != null)
                            {
                                userId = Convert.ToInt32(result);
                            }
                            else
                            {
                                MessageBox.Show("No user found with the provided NIC.", "Error");
                                return;
                            }
                        }

                        // Update password
                        string updateQuery = "UPDATE users SET password = @pass WHERE user_id = @uid";

                        using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@pass", newPassword);
                            updateCmd.Parameters.AddWithValue("@uid", userId);
                            int rowsAffected = updateCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Password reset successfully.", "Success");
                                textBox3.Clear();
                                textBox5.Clear();
                                textBox6.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Password reset failed.", "Error");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message);
                    }
                }
            

        }
    }
}
