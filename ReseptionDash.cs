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
    public partial class ReseptionDash : Form
    {
        public ReseptionDash()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            generatebills1.Visible = true;
            registerPat1.Visible = false;
            bookApp1.Visible = false;
            recDash1.Visible = false;
            viewdoctor1.Visible = false;
            recsearch1.Visible = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void time_Click(object sender, EventArgs e)
        {
        }

        private void regNewPat1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            registerPat1.Visible = true;
            bookApp1.Visible = false;
            recDash1.Visible = false;
            viewdoctor1.Visible = false;
            generatebills1.Visible = false;
            recsearch1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registerPat1.Visible = false;
            bookApp1.Visible = false;
            recDash1.Visible = true;
            viewdoctor1.Visible = false;
            generatebills1.Visible = false;
            recsearch1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            registerPat1.Visible = false;
            bookApp1.Visible = true;
            recDash1.Visible = false;
            viewdoctor1.Visible = false;
            generatebills1.Visible = false;
            recsearch1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            viewdoctor1.Visible = true;
            registerPat1.Visible = false;
            bookApp1.Visible = false;
            recDash1.Visible = false;
            generatebills1.Visible = false;
            recsearch1.Visible = false;
        }

        private void generatebills1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            recsearch1.Visible = true;
            viewdoctor1.Visible = false;
            registerPat1.Visible = false;
            bookApp1.Visible = false;
            recDash1.Visible = false;
            generatebills1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            loginPage logout = new loginPage();
            logout.Show();
            this.Hide();
        }

        private void ReseptionDash_Load(object sender, EventArgs e)
        {

        }
    }
}
