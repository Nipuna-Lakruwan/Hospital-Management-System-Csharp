namespace HMS
{
    partial class recsearch
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
            recsearch1 = new Panel();
            appsearch1 = new appsearch();
            userdetails1 = new userdetails();
            comboBox1 = new ComboBox();
            label2 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            recsearch1.SuspendLayout();
            SuspendLayout();
            // 
            // recsearch1
            // 
            recsearch1.AutoScroll = true;
            recsearch1.AutoScrollMargin = new Size(0, 80);
            recsearch1.BackColor = Color.FromArgb(19, 22, 25);
            recsearch1.Controls.Add(appsearch1);
            recsearch1.Controls.Add(userdetails1);
            recsearch1.Controls.Add(comboBox1);
            recsearch1.Controls.Add(label2);
            recsearch1.Controls.Add(panel2);
            recsearch1.Controls.Add(button1);
            recsearch1.Controls.Add(label3);
            recsearch1.Controls.Add(textBox1);
            recsearch1.Controls.Add(label1);
            recsearch1.Dock = DockStyle.Fill;
            recsearch1.Location = new Point(0, 0);
            recsearch1.Name = "recsearch1";
            recsearch1.Size = new Size(996, 594);
            recsearch1.TabIndex = 0;
            recsearch1.Paint += recsearch1_Paint;
            // 
            // appsearch1
            // 
            appsearch1.Location = new Point(71, 242);
            appsearch1.Name = "appsearch1";
            appsearch1.Size = new Size(856, 479);
            appsearch1.TabIndex = 111;
            // 
            // userdetails1
            // 
            userdetails1.Location = new Point(71, 242);
            userdetails1.Name = "userdetails1";
            userdetails1.Size = new Size(856, 479);
            userdetails1.TabIndex = 110;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(54, 58, 61);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Appointment", "Details" });
            comboBox1.Location = new Point(152, 181);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 23);
            comboBox1.TabIndex = 109;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(171, 184, 196);
            label2.Location = new Point(71, 182);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 108;
            label2.Text = "Search By :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(20, 61, 96);
            panel2.Location = new Point(71, 218);
            panel2.Name = "panel2";
            panel2.Size = new Size(732, 3);
            panel2.TabIndex = 107;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(36, 174, 124);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(463, 133);
            button1.Name = "button1";
            button1.Size = new Size(124, 31);
            button1.TabIndex = 106;
            button1.Text = "Load Details";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(171, 184, 196);
            label3.Location = new Point(71, 121);
            label3.Name = "label3";
            label3.Size = new Size(117, 17);
            label3.TabIndex = 104;
            label3.Text = "Patient ID / Name";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(54, 58, 61);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(71, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 23);
            textBox1.TabIndex = 105;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(71, 44);
            label1.Name = "label1";
            label1.Size = new Size(138, 50);
            label1.TabIndex = 103;
            label1.Text = "Search";
            // 
            // recsearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(recsearch1);
            Name = "recsearch";
            Size = new Size(996, 594);
            recsearch1.ResumeLayout(false);
            recsearch1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel recsearch1;
        private ComboBox comboBox1;
        private Label label2;
        private Panel panel2;
        private Button button1;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private userdetails userdetails1;
        private appsearch appsearch1;
        

    }
}
