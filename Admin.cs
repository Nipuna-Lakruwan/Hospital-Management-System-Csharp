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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            addDash1.Visible = true;
            manageUsers1.Visible = false;
            addViewAppo2.Visible = false;
            viewPatRec1.Visible = false;
        }

        private void addDash1_Load(object sender, EventArgs e)
        {
            addDash1.Visible = true;
        }

        private void manageUsers1_Load(object sender, EventArgs e)
        {
            manageUsers1.Visible = true;
        }

        private void addViewAppo2_Load(object sender, EventArgs e)
        {
            addViewAppo2.Visible = true;
        }

        private void viewPatAdmin1_Load(object sender, EventArgs e)
        {
            viewPatRec1.Visible = true;
        }

        private void adDash_Click(object sender, EventArgs e)
        {
            addDash1.Visible = true;
            manageUsers1.Visible = false;
            addViewAppo2.Visible = false;
            viewPatRec1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addDash1.Visible = false;
            manageUsers1.Visible = true;
            addViewAppo2.Visible = false;
            viewPatRec1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addDash1.Visible = false;
            manageUsers1.Visible = false;
            addViewAppo2.Visible = true;
            viewPatRec1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addDash1.Visible = false;
            manageUsers1.Visible = false;
            addViewAppo2.Visible = false;
            viewPatRec1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            loginPage logout = new loginPage();
            logout.Show();
            this.Hide();
        }
    }
}
