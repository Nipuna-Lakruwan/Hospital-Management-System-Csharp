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
    public partial class DoctorDash : Form
    {
        public DoctorDash()
        {
            InitializeComponent();
            docDash1.Visible = true;
            docApp1.Visible = false;
            viewPatRec1.Visible = false;
        }

        private void docDash1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            loginPage logout = new loginPage();
            logout.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            docDash1.Visible = true;
            docApp1.Visible = false;
            viewPatRec1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            docApp1.Visible = true;
            docDash1.Visible = false;
            viewPatRec1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewPatRec1.Visible = true;
            docDash1.Visible = false;
            docApp1.Visible = false;
            
        }

        private void appDetails1_Load(object sender, EventArgs e)
        {

        }
    }
}
