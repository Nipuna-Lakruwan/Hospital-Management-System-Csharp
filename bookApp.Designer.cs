namespace HMS
{
    partial class bookApp
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
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            label17 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox3 = new ComboBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(171, 184, 196);
            label3.Location = new Point(66, 91);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 22;
            label3.Text = "Patient ID";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(54, 58, 61);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(66, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 16);
            textBox1.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(171, 184, 196);
            label1.Location = new Point(66, 154);
            label1.Name = "label1";
            label1.Size = new Size(49, 17);
            label1.TabIndex = 24;
            label1.Text = "Doctor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(171, 184, 196);
            label2.Location = new Point(66, 220);
            label2.Name = "label2";
            label2.Size = new Size(89, 17);
            label2.TabIndex = 26;
            label2.Text = "Specialization";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(54, 58, 61);
            dateTimePicker1.Location = new Point(66, 310);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(171, 184, 196);
            label4.Location = new Point(66, 290);
            label4.Name = "label4";
            label4.Size = new Size(89, 17);
            label4.TabIndex = 29;
            label4.Text = "Appointment";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(171, 184, 196);
            label5.Location = new Point(66, 358);
            label5.Name = "label5";
            label5.Size = new Size(122, 17);
            label5.TabIndex = 30;
            label5.Text = "Available Time Slot";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(20, 61, 96);
            button2.Location = new Point(744, 578);
            button2.Name = "button2";
            button2.Size = new Size(156, 34);
            button2.TabIndex = 59;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(36, 174, 124);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(744, 529);
            button1.Name = "button1";
            button1.Size = new Size(156, 34);
            button1.TabIndex = 58;
            button1.Text = "Book Appointment";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(54, 58, 61);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(66, 455);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(601, 157);
            richTextBox1.TabIndex = 57;
            richTextBox1.Text = "Add a Note";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(171, 184, 196);
            label17.Location = new Point(66, 435);
            label17.Name = "label17";
            label17.Size = new Size(108, 17);
            label17.TabIndex = 56;
            label17.Text = "Allergies / Notes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(55, 21);
            label6.Name = "label6";
            label6.Size = new Size(350, 47);
            label6.TabIndex = 60;
            label6.Text = "Book Appointments";
            label6.Click += label6_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(54, 58, 61);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "10.00", "10.30", "11.00", "11.30", "12.00", "12.30", "13.00", "13.30", "14.00", "14.30", "15.00", "15.30", "16.00", "16.30", "17.00", "17.30", "18.00", "18.30", "19.00", "19.30", "20.00", "20.30", "21.00", "21.30", "22.00" });
            comboBox1.Location = new Point(66, 378);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(292, 23);
            comboBox1.TabIndex = 61;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.FromArgb(54, 58, 61);
            comboBox3.ForeColor = Color.White;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(66, 174);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(292, 23);
            comboBox3.TabIndex = 63;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(54, 58, 61);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(66, 240);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 16);
            textBox2.TabIndex = 64;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // bookApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(0, 60);
            BackColor = Color.FromArgb(19, 22, 25);
            Controls.Add(textBox2);
            Controls.Add(comboBox3);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label17);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Name = "bookApp";
            Size = new Size(860, 543);
            Load += bookApp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private Button button2;
        private Button button1;
        private RichTextBox richTextBox1;
        private Label label17;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
        private TextBox textBox2;
    }
}
