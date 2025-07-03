namespace HMS
{
    partial class DoctorDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorDash));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button7 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            docDash1 = new docDash();
            panel2 = new Panel();
            label1 = new Label();
            docApp1 = new DocApp();
            viewPatRec1 = new viewPatRec();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(29, 70);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Illustration__1_;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 648);
            panel1.TabIndex = 2;
            // 
            // button7
            // 
            button7.BackColor = Color.Red;
            button7.Cursor = Cursors.Hand;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button7.ForeColor = Color.White;
            button7.Location = new Point(29, 586);
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
            button3.BackColor = Color.Black;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(29, 287);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(170, 37);
            button3.TabIndex = 4;
            button3.Text = "View Patient Records";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(29, 233);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(170, 37);
            button2.TabIndex = 3;
            button2.Text = "My Appointments";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(29, 181);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(170, 37);
            button1.TabIndex = 2;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // docDash1
            // 
            docDash1.BackColor = Color.FromArgb(19, 22, 25);
            docDash1.BackgroundImage = (Image)resources.GetObject("docDash1.BackgroundImage");
            docDash1.Location = new Point(214, 54);
            docDash1.Name = "docDash1";
            docDash1.Size = new Size(996, 594);
            docDash1.TabIndex = 4;
            docDash1.Load += docDash1_Load;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.bg__1_;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(214, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(996, 54);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 26F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(223, 9);
            label1.Name = "label1";
            label1.Size = new Size(463, 40);
            label1.TabIndex = 9;
            label1.Text = "Hospital Management System";
            // 
            // docApp1
            // 
            docApp1.BackColor = Color.FromArgb(19, 22, 25);
            docApp1.Location = new Point(214, 54);
            docApp1.Name = "docApp1";
            docApp1.Size = new Size(996, 594);
            docApp1.TabIndex = 7;
            // 
            // viewPatRec1
            // 
            viewPatRec1.Location = new Point(214, 54);
            viewPatRec1.Name = "viewPatRec1";
            viewPatRec1.Size = new Size(996, 594);
            viewPatRec1.TabIndex = 8;
            // 
            // DoctorDash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 648);
            Controls.Add(viewPatRec1);
            Controls.Add(docApp1);
            Controls.Add(panel2);
            Controls.Add(docDash1);
            Controls.Add(panel1);
            Name = "DoctorDash";
            Text = "DoctorDash";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button7;
        private Button button3;
        private Button button2;
        private Button button1;
        private docDash docDash1;
        private Panel panel2;
        private DocApp docApp1;
        private viewPatRec viewPatRec1;
        private Label label1;
    }
}