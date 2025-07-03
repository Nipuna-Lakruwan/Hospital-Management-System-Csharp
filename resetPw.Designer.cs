namespace HMS
{
    partial class resetPw
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
            button3 = new Button();
            label9 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(36, 174, 124);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(741, 218);
            button3.Name = "button3";
            button3.Size = new Size(124, 31);
            button3.TabIndex = 173;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(171, 184, 196);
            label9.Location = new Point(497, 130);
            label9.Name = "label9";
            label9.Size = new Size(122, 17);
            label9.TabIndex = 171;
            label9.Text = "Re-enter Password";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(54, 58, 61);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(497, 150);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(292, 23);
            textBox5.TabIndex = 172;
            textBox5.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(171, 184, 196);
            label7.Location = new Point(84, 130);
            label7.Name = "label7";
            label7.Size = new Size(66, 17);
            label7.TabIndex = 169;
            label7.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(54, 58, 61);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(84, 150);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(292, 23);
            textBox3.TabIndex = 170;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(171, 184, 196);
            label8.Location = new Point(84, 67);
            label8.Name = "label8";
            label8.Size = new Size(118, 17);
            label8.TabIndex = 167;
            label8.Text = "NIC / Passport No";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(54, 58, 61);
            textBox6.ForeColor = Color.White;
            textBox6.Location = new Point(84, 87);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(292, 23);
            textBox6.TabIndex = 168;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(84, 26);
            label2.Name = "label2";
            label2.Size = new Size(103, 17);
            label2.TabIndex = 155;
            label2.Text = "Reset Password";
            // 
            // resetPw
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 22, 25);
            Controls.Add(button3);
            Controls.Add(label9);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label2);
            ForeColor = Color.White;
            Name = "resetPw";
            Size = new Size(959, 424);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label label9;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox6;
        private Label label2;
    }
}
