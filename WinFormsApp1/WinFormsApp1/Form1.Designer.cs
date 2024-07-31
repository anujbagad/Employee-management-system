namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            button2 = new Button();
            label5 = new Label();
            Exit = new Label();
            label2 = new Label();
            label3 = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            label4 = new Label();
            login_showpass = new CheckBox();
            login_signupBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 8, 138);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 400);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 199);
            label6.Name = "label6";
            label6.Size = new Size(244, 20);
            label6.TabIndex = 2;
            label6.Text = "Employee Management System";
            label6.Click += label6_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(33, 11, 97);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Purple;
            button2.FlatAppearance.MouseOverBackColor = Color.Purple;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(15, 361);
            button2.Name = "button2";
            button2.Size = new Size(218, 28);
            button2.TabIndex = 1;
            button2.Text = "SIGNUP";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(47, 330);
            label5.Name = "label5";
            label5.Size = new Size(154, 18);
            label5.TabIndex = 0;
            label5.Text = "Register your Account";
            label5.Click += label5_Click;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.Location = new Point(545, 9);
            Exit.Name = "Exit";
            Exit.Size = new Size(18, 20);
            Exit.TabIndex = 0;
            Exit.Text = "X";
            Exit.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(275, 53);
            label2.Name = "label2";
            label2.Size = new Size(177, 29);
            label2.TabIndex = 1;
            label2.Text = "Login Account";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(281, 143);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // login_username
            // 
            login_username.BorderStyle = BorderStyle.FixedSingle;
            login_username.Location = new Point(283, 164);
            login_username.Multiline = true;
            login_username.Name = "login_username";
            login_username.Size = new Size(261, 30);
            login_username.TabIndex = 3;
            login_username.TextChanged += textBox1_TextChanged;
            // 
            // login_password
            // 
            login_password.BackColor = Color.White;
            login_password.BorderStyle = BorderStyle.FixedSingle;
            login_password.Location = new Point(283, 234);
            login_password.Multiline = true;
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(261, 30);
            login_password.TabIndex = 5;
            login_password.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(281, 213);
            label4.Name = "label4";
            label4.Size = new Size(74, 18);
            label4.TabIndex = 4;
            label4.Text = "Password:";
            label4.Click += label4_Click;
            // 
            // login_showpass
            // 
            login_showpass.AutoSize = true;
            login_showpass.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            login_showpass.Location = new Point(418, 269);
            login_showpass.Name = "login_showpass";
            login_showpass.Size = new Size(130, 22);
            login_showpass.TabIndex = 6;
            login_showpass.Text = "Show password";
            login_showpass.UseVisualStyleBackColor = true;
            login_showpass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // login_signupBtn
            // 
            login_signupBtn.BackColor = Color.FromArgb(33, 11, 97);
            login_signupBtn.FlatAppearance.BorderSize = 0;
            login_signupBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            login_signupBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            login_signupBtn.FlatStyle = FlatStyle.Flat;
            login_signupBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            login_signupBtn.ForeColor = Color.White;
            login_signupBtn.Location = new Point(283, 315);
            login_signupBtn.Name = "login_signupBtn";
            login_signupBtn.Size = new Size(93, 34);
            login_signupBtn.TabIndex = 7;
            login_signupBtn.Text = "LOGIN";
            login_signupBtn.UseVisualStyleBackColor = false;
            login_signupBtn.Click += login_signupBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(575, 400);
            Controls.Add(login_signupBtn);
            Controls.Add(login_showpass);
            Controls.Add(login_password);
            Controls.Add(label4);
            Controls.Add(login_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Exit;
        private Label label2;
        private Label label3;
        private TextBox login_username;
        private TextBox login_password;
        private Label label4;
        private CheckBox login_showpass;
        private Button login_signupBtn;
        private Label label5;
        private Button button2;
        private Label label6;
        private PictureBox pictureBox1;
    }
}
