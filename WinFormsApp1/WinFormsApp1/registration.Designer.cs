namespace WinFormsApp1
{
    partial class registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registration));
            Signup_Btn = new Button();
            signup_showPass = new CheckBox();
            signup_password = new TextBox();
            label4 = new Label();
            signup_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            Exit = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            signin_btn = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Signup_Btn
            // 
            Signup_Btn.BackColor = Color.FromArgb(33, 11, 97);
            Signup_Btn.FlatAppearance.BorderSize = 0;
            Signup_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            Signup_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            Signup_Btn.FlatStyle = FlatStyle.Flat;
            Signup_Btn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Signup_Btn.ForeColor = Color.White;
            Signup_Btn.Location = new Point(289, 315);
            Signup_Btn.Name = "Signup_Btn";
            Signup_Btn.Size = new Size(93, 34);
            Signup_Btn.TabIndex = 16;
            Signup_Btn.Text = "SIGN UP";
            Signup_Btn.UseVisualStyleBackColor = false;
            Signup_Btn.Click += signup_Btn_Click;
            // 
            // signup_showPass
            // 
            signup_showPass.AutoSize = true;
            signup_showPass.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            signup_showPass.Location = new Point(424, 269);
            signup_showPass.Name = "signup_showPass";
            signup_showPass.Size = new Size(130, 22);
            signup_showPass.TabIndex = 15;
            signup_showPass.Text = "Show password";
            signup_showPass.UseVisualStyleBackColor = true;
            signup_showPass.CheckedChanged += signup_showPass_CheckedChanged;
            // 
            // signup_password
            // 
            signup_password.BackColor = Color.White;
            signup_password.BorderStyle = BorderStyle.FixedSingle;
            signup_password.Location = new Point(289, 234);
            signup_password.Multiline = true;
            signup_password.Name = "signup_password";
            signup_password.PasswordChar = '*';
            signup_password.Size = new Size(261, 30);
            signup_password.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(287, 213);
            label4.Name = "label4";
            label4.Size = new Size(74, 18);
            label4.TabIndex = 13;
            label4.Text = "Password:";
            // 
            // signup_username
            // 
            signup_username.BorderStyle = BorderStyle.FixedSingle;
            signup_username.Location = new Point(289, 164);
            signup_username.Multiline = true;
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(261, 30);
            signup_username.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(287, 143);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 11;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(281, 53);
            label2.Name = "label2";
            label2.Size = new Size(211, 29);
            label2.TabIndex = 10;
            label2.Text = "Register Account";
            label2.Click += label2_Click;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.Location = new Point(551, 9);
            Exit.Name = "Exit";
            Exit.Size = new Size(18, 20);
            Exit.TabIndex = 8;
            Exit.Text = "X";
            Exit.Click += Exit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 8, 138);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(signin_btn);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 400);
            panel1.TabIndex = 9;
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
            // 
            // signin_btn
            // 
            signin_btn.BackColor = Color.FromArgb(33, 11, 97);
            signin_btn.Cursor = Cursors.Hand;
            signin_btn.FlatAppearance.BorderSize = 0;
            signin_btn.FlatAppearance.MouseDownBackColor = Color.Purple;
            signin_btn.FlatAppearance.MouseOverBackColor = Color.Purple;
            signin_btn.FlatStyle = FlatStyle.Flat;
            signin_btn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            signin_btn.ForeColor = Color.White;
            signin_btn.Location = new Point(15, 361);
            signin_btn.Name = "signin_btn";
            signin_btn.Size = new Size(218, 28);
            signin_btn.TabIndex = 1;
            signin_btn.Text = "SIGN IN";
            signin_btn.UseVisualStyleBackColor = false;
            signin_btn.Click += signin_btn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(47, 330);
            label5.Name = "label5";
            label5.Size = new Size(152, 18);
            label5.TabIndex = 0;
            label5.Text = "Login to your Account";
            // 
            // registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 400);
            Controls.Add(Signup_Btn);
            Controls.Add(signup_showPass);
            Controls.Add(signup_password);
            Controls.Add(label4);
            Controls.Add(signup_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "registration";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Signup_Btn;
        private CheckBox signup_showPass;
        private TextBox signup_password;
        private Label label4;
        private TextBox signup_username;
        private Label label3;
        private Label label2;
        private Label Exit;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private Button signin_btn;
        private Label label5;
    }
}