namespace HMS
{
    partial class manageUsers
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
            panel1 = new Panel();
            resetPw1 = new resetPw();
            addNewDoc1 = new addNewDoc();
            addNewRec1 = new addNewRec();
            panel2 = new Panel();
            button3 = new Button();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 22, 25);
            panel1.Controls.Add(resetPw1);
            panel1.Controls.Add(addNewDoc1);
            panel1.Controls.Add(addNewRec1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 588);
            panel1.TabIndex = 0;
            // 
            // resetPw1
            // 
            resetPw1.BackColor = Color.FromArgb(19, 22, 25);
            resetPw1.ForeColor = Color.White;
            resetPw1.Location = new Point(14, 144);
            resetPw1.Name = "resetPw1";
            resetPw1.Size = new Size(959, 424);
            resetPw1.TabIndex = 120;
            resetPw1.Load += resetPw1_Load;
            // 
            // addNewDoc1
            // 
            addNewDoc1.BackColor = Color.FromArgb(19, 22, 25);
            addNewDoc1.Location = new Point(14, 144);
            addNewDoc1.Name = "addNewDoc1";
            addNewDoc1.Size = new Size(959, 424);
            addNewDoc1.TabIndex = 119;
            addNewDoc1.Load += addNewDoc1_Load;
            // 
            // addNewRec1
            // 
            addNewRec1.BackColor = Color.FromArgb(19, 22, 25);
            addNewRec1.Location = new Point(14, 144);
            addNewRec1.Name = "addNewRec1";
            addNewRec1.Size = new Size(959, 424);
            addNewRec1.TabIndex = 118;
            addNewRec1.Load += addNewRec1_Load;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(20, 61, 96);
            panel2.Location = new Point(125, 135);
            panel2.Name = "panel2";
            panel2.Size = new Size(732, 3);
            panel2.TabIndex = 117;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(36, 174, 124);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(760, 33);
            button3.Name = "button3";
            button3.Size = new Size(124, 31);
            button3.TabIndex = 116;
            button3.Text = "Reset Password";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(171, 184, 196);
            label1.Location = new Point(78, 88);
            label1.Name = "label1";
            label1.Size = new Size(110, 17);
            label1.TabIndex = 115;
            label1.Text = "Add New Doctor";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(36, 174, 124);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(319, 82);
            button2.Name = "button2";
            button2.Size = new Size(124, 31);
            button2.TabIndex = 114;
            button2.Text = "Add new user";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(171, 184, 196);
            label2.Location = new Point(78, 39);
            label2.Name = "label2";
            label2.Size = new Size(158, 17);
            label2.TabIndex = 113;
            label2.Text = "Add a user for reception";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(36, 174, 124);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(319, 33);
            button1.Name = "button1";
            button1.Size = new Size(124, 31);
            button1.TabIndex = 112;
            button1.Text = "Add new user";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // manageUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "manageUsers";
            Size = new Size(996, 594);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button2;
        private Label label2;
        private Button button1;
        private Button button3;
        private Panel panel2;
        private addNewRec addNewRec1;
        private resetPw resetPw1;
        private addNewDoc addNewDoc1;
    }
}
