namespace HMS
{
    partial class loginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginPage));
            imageList1 = new ImageList(components);
            panel3 = new Panel();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label7 = new Label();
            password = new TextBox();
            label6 = new Label();
            username = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(checkBox1);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(password);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(username);
            panel3.Location = new Point(60, 132);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 283);
            panel3.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 8F);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(39, 181);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(107, 17);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(36, 174, 124);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(74, 217);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(140, 32);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(39, 144);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 5;
            label7.Text = "Password";
            // 
            // password
            // 
            password.BackColor = Color.FromArgb(54, 58, 61);
            password.BorderStyle = BorderStyle.None;
            password.ForeColor = Color.White;
            password.Location = new Point(39, 161);
            password.Margin = new Padding(3, 2, 3, 2);
            password.Name = "password";
            password.Size = new Size(201, 16);
            password.TabIndex = 4;
            password.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.White;
            label6.Location = new Point(39, 93);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 3;
            label6.Text = "Username";
            // 
            // username
            // 
            username.BackColor = Color.FromArgb(54, 58, 61);
            username.BorderStyle = BorderStyle.None;
            username.ForeColor = Color.White;
            username.Location = new Point(39, 110);
            username.Margin = new Padding(3, 2, 3, 2);
            username.Name = "username";
            username.Size = new Size(201, 16);
            username.TabIndex = 2;
            username.TextChanged += username_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(42, 539);
            label5.Name = "label5";
            label5.Size = new Size(258, 15);
            label5.TabIndex = 5;
            label5.Text = "© 2025 Nipuna Lakruwan. All rights reserved.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(128, 54);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 22, 25);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 566);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 561);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "loginPage";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private Panel panel3;
        private TextBox username;
        private Button button1;
        private Label label7;
        private TextBox password;
        private Label label6;
        private CheckBox checkBox1;
        private Label label5;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
