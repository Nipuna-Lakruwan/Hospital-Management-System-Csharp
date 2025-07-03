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
    public partial class manageUsers : UserControl
    {
        public manageUsers()
        {
            InitializeComponent();
            addNewRec1.Visible = false;
            addNewDoc1.Visible = false;
            resetPw1.Visible = false;
        }

        private void addNewRec1_Load(object sender, EventArgs e)
        {

        }

        private void resetPw1_Load(object sender, EventArgs e)
        {

        }

        private void addNewDoc1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addNewRec1.Visible = true;
            addNewDoc1.Visible = false;
            resetPw1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addNewRec1.Visible = false;
            addNewDoc1.Visible = true;
            resetPw1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addNewRec1.Visible = false;
            addNewDoc1.Visible = false;
            resetPw1.Visible = true;
        }

        
    }
}
