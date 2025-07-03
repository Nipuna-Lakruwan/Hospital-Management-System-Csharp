namespace HMS
{
    partial class viewdoctor1
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
            comboBox2 = new ComboBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            label5 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label6 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(54, 39);
            label1.Name = "label1";
            label1.Size = new Size(382, 47);
            label1.TabIndex = 28;
            label1.Text = "View Doctor Schedule";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(54, 58, 61);
            comboBox2.ForeColor = Color.White;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(54, 139);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(292, 23);
            comboBox2.TabIndex = 64;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(171, 184, 196);
            label2.Location = new Point(54, 173);
            label2.Name = "label2";
            label2.Size = new Size(89, 17);
            label2.TabIndex = 63;
            label2.Text = "Specialization";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(427, 136);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(292, 23);
            dateTimePicker1.TabIndex = 66;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(171, 184, 196);
            label4.Location = new Point(427, 116);
            label4.Name = "label4";
            label4.Size = new Size(36, 17);
            label4.TabIndex = 65;
            label4.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(20, 61, 96);
            label3.Location = new Point(-168, 79);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 67;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(36, 174, 124);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(427, 183);
            button1.Name = "button1";
            button1.Size = new Size(124, 33);
            button1.TabIndex = 69;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(20, 61, 96);
            label5.Location = new Point(-168, 79);
            label5.Name = "label5";
            label5.Size = new Size(49, 17);
            label5.TabIndex = 70;
            label5.Text = "Doctor";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 61, 96);
            panel1.Location = new Point(54, 246);
            panel1.Name = "panel1";
            panel1.Size = new Size(732, 3);
            panel1.TabIndex = 72;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(54, 58, 61);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 279);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(665, 150);
            dataGridView1.TabIndex = 73;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.FromArgb(19, 22, 25);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(996, 594);
            panel2.TabIndex = 74;
            panel2.Paint += panel2_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(171, 184, 196);
            label6.Location = new Point(54, 116);
            label6.Name = "label6";
            label6.Size = new Size(49, 17);
            label6.TabIndex = 74;
            label6.Text = "Doctor";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(54, 58, 61);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(54, 193);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 23);
            textBox2.TabIndex = 71;
            // 
            // viewdoctor1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "viewdoctor1";
            Size = new Size(996, 594);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private ComboBox comboBox2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label3;
        private Button button1;
        private Label label5;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label6;
        private TextBox textBox2;
    }
}
