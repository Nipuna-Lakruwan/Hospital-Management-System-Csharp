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
using System.Drawing.Printing;



namespace HMS
{
    public partial class generatebills : UserControl
    {
        private string selectedAppointmentId;

        PrintDocument printDoc = new PrintDocument();
        string printText = "";

        public generatebills()
        {
            InitializeComponent();

        }


        private void PreparePrintContent()
        {
            printText = "------ HOSPITAL BILL RECEIPT ------\n\n";
            printText += $"Patient Name: {label4.Text}\n";
            printText += $"Doctor: {label7.Text}\n";
            printText += $"Appointment Date: {label5.Text}\n\n";
            printText += $"Subtotal: Rs. {label9.Text}\n";
            printText += $"Discount: Rs. {textBox2.Text}\n";
            printText += $"Total: Rs. {label13.Text}\n";
            printText += $"Paid: Rs. {textBox3.Text}\n";
            printText += $"Balance: Rs. {label11.Text}\n\n";
            printText += "----------------------------------\n";
            printText += $"Printed On: {DateTime.Now}\n";
        }

        private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(printText, new Font("Arial", 12), Brushes.Black, new PointF(100, 100));
        }



        private void button1_Click(object sender, EventArgs e)
        {

            string nic = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(nic))
            {
                MessageBox.Show("Please enter NIC.");
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
                a.appointment_id,
                p.name AS 'Patient Name',
                d.name AS 'Doctor Name',
                a.appointment_date,
                dg.charges
            FROM appointments a
            JOIN patients p ON a.patient_id = p.patient_id
            JOIN doctors d ON a.doctor_id = d.doctor_id
            JOIN diagnosis dg ON a.appointment_id = dg.appointment_id
            WHERE p.nic = @nic AND a.payment_status = 'pending'";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nic", nic);

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
                    MessageBox.Show("Error loading billing data: " + ex.Message);
                }

            }

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Get values
                decimal subtotal = 0, discount = 0, paid = 0;

                decimal.TryParse(label9.Text, out subtotal);               // Subtotal
                decimal.TryParse(textBox2.Text, out discount);             // Discount
                decimal.TryParse(textBox3.Text, out paid);                 // Paid amount (optional)

                // Calculate total and balance
                decimal total = subtotal - ((discount / 100) * subtotal);
                decimal balance = total - paid;

                // Update fields
                label13.Text = total.ToString("0.00");    // Total
                label11.Text = balance.ToString("0.00");  // Balance

                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent beep sound on Enter
            }
        }


        private void CalculateTotalAndBalance()
        {
            decimal subtotal = 0, discount = 0, paid = 0;

            decimal.TryParse(label9.Text, out subtotal);
            decimal.TryParse(textBox2.Text, out discount);
            decimal.TryParse(textBox3.Text, out paid);

            decimal total = subtotal - ((discount / 100) * subtotal);
            label13.Text = total.ToString("0.00");

            decimal balance = total - paid;
            label11.Text = balance.ToString("0.00");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAndBalance();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAndBalance();
        }




        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                label4.Text = row.Cells["Patient Name"].Value.ToString();
                label7.Text = row.Cells["Doctor Name"].Value.ToString();
                label5.Text = Convert.ToDateTime(row.Cells["appointment_date"].Value).ToShortDateString();

                // Store appointment_id for update later
                selectedAppointmentId = row.Cells["appointment_id"].Value.ToString();

                decimal subtotal = Convert.ToDecimal(row.Cells["charges"].Value);
                label9.Text = subtotal.ToString("0.00");
                CalculateTotalAndBalance(); // Initial call in case discount or paid already entered
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Get values
                decimal subtotal = 0, discount = 0, paid = 0;

                decimal.TryParse(label9.Text, out subtotal);               // Subtotal
                decimal.TryParse(textBox2.Text, out discount);             // Discount
                decimal.TryParse(textBox3.Text, out paid);                 // Paid amount

                // Calculate total and balance
                decimal total = subtotal - ((discount / 100) * subtotal);
                decimal balance = total - paid;

                // Update fields
                label13.Text = total.ToString("0.00");    // Total
                label11.Text = balance.ToString("0.00");  // Balance

                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent beep sound on Enter
            }
        }

        private void generatebill1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(selectedAppointmentId))
            {
                MessageBox.Show("No appointment selected.", "Error");
                return;
            }

            if (string.IsNullOrEmpty(textBox3.Text.Trim()))
            {
                MessageBox.Show("Please enter the paid amount.", "Validation Error");
                return;
            }

            decimal paidAmount;
            if (!decimal.TryParse(textBox3.Text.Trim(), out paidAmount))
            {
                MessageBox.Show("Invalid paid amount entered.", "Error");
                return;
            }

            string conString = "server=127.0.0.1; user=root; database=HMS; password=root";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    // Start transaction (optional but recommended)
                    MySqlTransaction transaction = conn.BeginTransaction();

                    // 1. Update appointment table
                    string updateAppointmentQuery = @"
                UPDATE appointments 
                SET payment_status = 'paid'
                WHERE appointment_id = @appId";

                    using (MySqlCommand cmd = new MySqlCommand(updateAppointmentQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@appId", selectedAppointmentId);
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Optionally, record the paid amount in diagnosis table (if applicable)
                    string updateDiagnosisQuery = @"
                UPDATE diagnosis 
                SET charges = @paidAmount
                WHERE appointment_id = @appId";

                    using (MySqlCommand cmd2 = new MySqlCommand(updateDiagnosisQuery, conn, transaction))
                    {
                        cmd2.Parameters.AddWithValue("@appId", selectedAppointmentId);
                        cmd2.Parameters.AddWithValue("@paidAmount", paidAmount);
                        cmd2.ExecuteNonQuery();
                    }

                    // Commit transaction
                    transaction.Commit();

                    MessageBox.Show("Payment successful and records updated.", "Success");

                    // Optionally clear fields or refresh data
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error processing payment: " + ex.Message, "Error");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                PreparePrintContent();

                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDoc;
                printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDoc.Print();
                }
            }

        }
    }


