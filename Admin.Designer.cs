namespace HMS
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button4 = new Button();
            button7 = new Button();
            button3 = new Button();
            button2 = new Button();
            adDash = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            addViewAppo1 = new addViewAppo();
            addDash1 = new addDash();
            manageUsers1 = new manageUsers();
            addViewAppo2 = new addViewAppo();
            viewPatRec1 = new viewPatRec();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 24, 24);
            panel1.BackgroundImage = Properties.Resources.Illustration__1_;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(adDash);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 648);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(12, 12, 12);
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(27, 337);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(170, 37);
            button4.TabIndex = 9;
            button4.Text = "View Patients";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Red;
            button7.Cursor = Cursors.Hand;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button7.ForeColor = Color.White;
            button7.Location = new Point(27, 582);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(170, 37);
            button7.TabIndex = 8;
            button7.Text = "Log Out";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(12, 12, 12);
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(27, 286);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(170, 37);
            button3.TabIndex = 4;
            button3.Text = "View Appointments";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(12, 12, 12);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(27, 234);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(170, 37);
            button2.TabIndex = 3;
            button2.Text = "Manage Users";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // adDash
            // 
            adDash.BackColor = Color.FromArgb(12, 12, 12);
            adDash.Cursor = Cursors.Hand;
            adDash.FlatStyle = FlatStyle.Flat;
            adDash.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            adDash.ForeColor = Color.White;
            adDash.Location = new Point(27, 180);
            adDash.Margin = new Padding(3, 2, 3, 2);
            adDash.Name = "adDash";
            adDash.Size = new Size(170, 37);
            adDash.TabIndex = 2;
            adDash.Text = "Dashboard";
            adDash.UseVisualStyleBackColor = false;
            adDash.Click += adDash_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(27, 72);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(12, 12, 12);
            panel2.BackgroundImage = Properties.Resources.bg__1_;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(214, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(996, 54);
            panel2.TabIndex = 6;
            // 
            // addViewAppo1
            // 
            addViewAppo1.BackColor = Color.FromArgb(19, 22, 25);
            addViewAppo1.Location = new Point(214, 54);
            addViewAppo1.Name = "addViewAppo1";
            addViewAppo1.Size = new Size(0, 594);
            addViewAppo1.TabIndex = 10;
            // 
            // addDash1
            // 
            addDash1.BackColor = Color.FromArgb(19, 22, 25);
            addDash1.Location = new Point(214, 54);
            addDash1.Name = "addDash1";
            addDash1.Size = new Size(996, 594);
            addDash1.TabIndex = 11;
            addDash1.Load += addDash1_Load;
            // 
            // manageUsers1
            // 
            manageUsers1.Location = new Point(214, 54);
            manageUsers1.Name = "manageUsers1";
            manageUsers1.Size = new Size(996, 594);
            manageUsers1.TabIndex = 12;
            manageUsers1.Load += manageUsers1_Load;
            // 
            // addViewAppo2
            // 
            addViewAppo2.BackColor = Color.FromArgb(19, 22, 25);
            addViewAppo2.Location = new Point(214, 54);
            addViewAppo2.Name = "addViewAppo2";
            addViewAppo2.Size = new Size(996, 594);
            addViewAppo2.TabIndex = 14;
            addViewAppo2.Load += addViewAppo2_Load;
            // 
            // viewPatRec1
            // 
            viewPatRec1.BackgroundImage = Properties.Resources.Admin_verfication__1_;
            viewPatRec1.Location = new Point(214, 54);
            viewPatRec1.Name = "viewPatRec1";
            viewPatRec1.Size = new Size(996, 594);
            viewPatRec1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 26F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(267, 7);
            label1.Name = "label1";
            label1.Size = new Size(463, 40);
            label1.TabIndex = 10;
            label1.Text = "Hospital Management System";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 648);
            Controls.Add(viewPatRec1);
            Controls.Add(addViewAppo2);
            Controls.Add(manageUsers1);
            Controls.Add(addDash1);
            Controls.Add(addViewAppo1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Admin";
            Text = "Admin";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button7;
        private Button button3;
        private Button button2;
        private Button adDash;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button button4;
        private addViewAppo addViewAppo1;
        private addDash addDash1;
        private manageUsers manageUsers1;
        private addViewAppo addViewAppo2;
        private viewPatRec viewPatRec1;
        private Label label1;
    }
}