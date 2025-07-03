namespace HMS
{
    partial class addViewAppo
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
            panel4 = new Panel();
            button2 = new Button();
            dateTimePicker2 = new DateTimePicker();
            label15 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label14 = new Label();
            label13 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(20, 61, 96);
            panel4.Location = new Point(113, 150);
            panel4.Name = "panel4";
            panel4.Size = new Size(732, 3);
            panel4.TabIndex = 167;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(36, 174, 124);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(721, 78);
            button2.Name = "button2";
            button2.Size = new Size(124, 31);
            button2.TabIndex = 173;
            button2.Text = "Load Details";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(456, 86);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 172;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Transparent;
            label15.Location = new Point(402, 90);
            label15.Name = "label15";
            label15.Size = new Size(31, 17);
            label15.TabIndex = 171;
            label15.Text = "To :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(167, 86);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 170;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Transparent;
            label14.Location = new Point(113, 90);
            label14.Name = "label14";
            label14.Size = new Size(48, 17);
            label14.TabIndex = 169;
            label14.Text = "From :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Transparent;
            label13.Location = new Point(113, 42);
            label13.Name = "label13";
            label13.Size = new Size(208, 30);
            label13.TabIndex = 168;
            label13.Text = "View Appointments";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoScrollMargin = new Size(0, 30);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(61, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 383);
            panel1.TabIndex = 174;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(52, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(732, 270);
            dataGridView1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(36, 174, 124);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(61, 548);
            button3.Name = "button3";
            button3.Size = new Size(124, 31);
            button3.TabIndex = 175;
            button3.Text = "Back To Dashboard";
            button3.UseVisualStyleBackColor = false;
            // 
            // addViewAppo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 22, 25);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(button2);
            Controls.Add(dateTimePicker2);
            Controls.Add(label15);
            Controls.Add(dateTimePicker1);
            Controls.Add(label14);
            Controls.Add(label13);
            Name = "addViewAppo";
            Size = new Size(996, 594);
            Load += addViewAppo_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel4;
        private Button button2;
        private DateTimePicker dateTimePicker2;
        private Label label15;
        private DateTimePicker dateTimePicker1;
        private Label label14;
        private Label label13;
        private Panel panel1;
        private Button button3;
        private DataGridView dataGridView1;
    }
}
