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
    public partial class addViewAppo : UserControl
    {
        public addViewAppo()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void addViewAppo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                DateTime startDate = dateTimePicker1.Value.Date;
                DateTime endDate = dateTimePicker2.Value.Date;

                if (startDate > endDate)
                {
                    MessageBox.Show("Start date cannot be after end date.", "Validation Error");
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
                    a.appointment_id AS 'ID',
                    d.name AS 'Doctor',
                    p.name AS 'Patient',
                    a.appointment_date AS 'Date',
                    a.time_slot AS 'Time',
                    a.status AS 'Status',
                    a.special_notes AS 'Note'
                FROM appointments a
                JOIN doctors d ON a.doctor_id = d.doctor_id
                JOIN patients p ON a.patient_id = p.patient_id
                WHERE a.appointment_date BETWEEN @start AND @end
                ORDER BY a.appointment_date, a.time_slot
            ";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@start", startDate.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@end", endDate.ToString("yyyy-MM-dd"));

                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }

                        panel1.Visible = true; // Show the panel only after data is loaded
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading schedule: " + ex.Message, "Database Error");
                    }
                }
            

        }
    }
}
