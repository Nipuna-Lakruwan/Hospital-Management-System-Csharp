namespace HMS
{
    partial class DocApp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            appDetails1 = new appDetails();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(48, 36);
            label1.Name = "label1";
            label1.Size = new Size(335, 50);
            label1.TabIndex = 104;
            label1.Text = "My Appointments";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 61, 96);
            panel1.Location = new Point(48, 182);
            panel1.Name = "panel1";
            panel1.Size = new Size(732, 3);
            panel1.TabIndex = 108;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(171, 184, 196);
            label4.Location = new Point(48, 115);
            label4.Name = "label4";
            label4.Size = new Size(121, 17);
            label4.TabIndex = 105;
            label4.Text = "Appointment Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(48, 135);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(292, 23);
            dateTimePicker1.TabIndex = 106;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(36, 174, 124);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(440, 125);
            button1.Name = "button1";
            button1.Size = new Size(124, 33);
            button1.TabIndex = 107;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(54, 58, 61);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 207);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(732, 217);
            dataGridView1.TabIndex = 109;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(36, 174, 124);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(48, 513);
            button2.Name = "button2";
            button2.Size = new Size(156, 34);
            button2.TabIndex = 110;
            button2.Text = "Back to Dashboard";
            button2.UseVisualStyleBackColor = false;
            // 
            // appDetails1
            // 
            appDetails1.AutoValidate = AutoValidate.EnablePreventFocusChange;
            appDetails1.BackColor = Color.FromArgb(19, 22, 25);
            appDetails1.Location = new Point(0, 0);
            appDetails1.Name = "appDetails1";
            appDetails1.Size = new Size(996, 594);
            appDetails1.TabIndex = 111;
            appDetails1.Load += appDetails1_Load;
            // 
            // DocApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 22, 25);
            Controls.Add(appDetails1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "DocApp";
            Size = new Size(996, 594);
            Load += DocApp_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private appDetails appDetails1;
    }
}
