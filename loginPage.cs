using MySql.Data.MySqlClient;

namespace HMS
    
{
    public partial class loginPage : Form
    {
        public static loginPage Instance;
        public loginPage()
        {
            InitializeComponent();
            Instance = this;
            password.UseSystemPasswordChar = true;
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string logUsername = username.Text;
            string logPassword = password.Text;

            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();

                // Get user_id, username, role
                string userQuery = "SELECT user_id, username, role FROM users WHERE username = @usern AND password = @pass";

                using (MySqlCommand cmd = new MySqlCommand(userQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@usern", logUsername.Trim());
                    cmd.Parameters.AddWithValue("@pass", logPassword.Trim());

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Store session values
                            Session.UserId = reader.GetInt32("user_id");
                            Session.Username = reader.GetString("username");
                            Session.Role = reader.GetString("role").ToLower();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Login Failed");
                            return;
                        }
                    }
                }

                // Get the user's full name based on role
                string nameQuery = "";

                if (Session.Role == "doctor")
                {
                    string doctorQuery = "SELECT doctor_id, name FROM doctors WHERE user_id = @uid";
                    using (MySqlCommand docCmd = new MySqlCommand(doctorQuery, conn))
                    {
                        docCmd.Parameters.AddWithValue("@uid", Session.UserId);
                        using (var docReader = docCmd.ExecuteReader())
                        {
                            if (docReader.Read())
                            {
                                Session.Name = docReader["name"].ToString();
                                Session.doctor_id = docReader["doctor_id"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Doctor not found in doctors table.", "Error");
                                return;
                            }
                        }
                    }
                }
                else if (Session.Role == "reception")
                    nameQuery = "SELECT name FROM receptionists WHERE user_id = @uid";
                else
                    Session.Name = "Administrator"; // Static for admin

                if (Session.Role == "reception")
                {
                    using (MySqlCommand nameCmd = new MySqlCommand("SELECT name FROM receptionists WHERE user_id = @uid", conn))
                    {
                        nameCmd.Parameters.AddWithValue("@uid", Session.UserId);
                        object result = nameCmd.ExecuteScalar();
                        Session.Name = result != null ? result.ToString() : "Unknown";
                    }
                }

                MessageBox.Show($"Login successful! Welcome {Session.Name}", "Success");

                // Open dashboard
                if (Session.Role == "admin")
                {
                    Admin adminForm = new Admin();
                    adminForm.Show();
                    this.Hide();
                }
                else if (Session.Role == "doctor")
                {
                    DoctorDash doctorForm = new DoctorDash();
                    doctorForm.Show();
                    this.Hide();
                }
                else if (Session.Role == "reception")
                {
                    ReseptionDash recForm = new ReseptionDash();
                    recForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Unknown role: " + Session.Role, "Error");
                }
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.UseSystemPasswordChar = false; // Show password
            }
            else
            {
                password.UseSystemPasswordChar = true; // Hide password
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
