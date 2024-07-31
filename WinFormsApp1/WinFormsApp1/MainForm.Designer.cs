namespace WinFormsApp1
{
    partial class MainForm
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
            Exit = new Label();
            panel1 = new Panel();
            Dashboard_btn = new Button();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            button3 = new Button();
            addemp_btn = new Button();
            label1 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.Location = new Point(1070, 9);
            Exit.Name = "Exit";
            Exit.Size = new Size(18, 20);
            Exit.TabIndex = 1;
            Exit.Text = "X";
            Exit.Click += Exit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 11, 97);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Dashboard_btn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(addemp_btn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 600);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // Dashboard_btn
            // 
            Dashboard_btn.BackColor = Color.FromArgb(33, 11, 97);
            Dashboard_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            Dashboard_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            Dashboard_btn.FlatStyle = FlatStyle.Flat;
            Dashboard_btn.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Dashboard_btn.ForeColor = Color.White;
            Dashboard_btn.Location = new Point(11, 303);
            Dashboard_btn.Name = "Dashboard_btn";
            Dashboard_btn.Size = new Size(200, 40);
            Dashboard_btn.TabIndex = 8;
            Dashboard_btn.Text = "DASHBOARD";
            Dashboard_btn.UseVisualStyleBackColor = false;
            Dashboard_btn.Click += Dashboard_btn_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(48, 238);
            label5.Name = "label5";
            label5.Size = new Size(122, 22);
            label5.TabIndex = 7;
            label5.Text = "Welcome User";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.download2;
            pictureBox2.Location = new Point(15, 564);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.icon;
            pictureBox1.Location = new Point(51, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 0);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(52, 564);
            label2.Name = "label2";
            label2.Size = new Size(60, 18);
            label2.TabIndex = 3;
            label2.Text = "Sign out";
            label2.Click += label2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(33, 11, 97);
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 424);
            button3.Name = "button3";
            button3.Size = new Size(200, 40);
            button3.TabIndex = 2;
            button3.Text = "SALARY";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // addemp_btn
            // 
            addemp_btn.BackColor = Color.FromArgb(33, 11, 97);
            addemp_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            addemp_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            addemp_btn.FlatStyle = FlatStyle.Flat;
            addemp_btn.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addemp_btn.ForeColor = Color.White;
            addemp_btn.Location = new Point(12, 364);
            addemp_btn.Name = "addemp_btn";
            addemp_btn.Size = new Size(200, 40);
            addemp_btn.TabIndex = 1;
            addemp_btn.Text = "ADD EMPLOYEE";
            addemp_btn.UseVisualStyleBackColor = false;
            addemp_btn.Click += addemp_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(231, 12);
            label1.Name = "label1";
            label1.Size = new Size(239, 16);
            label1.TabIndex = 0;
            label1.Text = "EMPLOYEE MANAGEMENT SYSTEM";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(36, 11, 97);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(225, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(875, 35);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(6, 7);
            label6.Name = "label6";
            label6.Size = new Size(242, 20);
            label6.TabIndex = 2;
            label6.Text = "EMPLOYEE MANAGEMENT SYSTEM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(847, 7);
            label4.Name = "label4";
            label4.Size = new Size(20, 23);
            label4.TabIndex = 1;
            label4.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(841, 9);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(225, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(875, 565);
            panel4.TabIndex = 4;
            panel4.Paint += panel4_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(Exit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Exit;
        private Panel panel1;
        private Label label1;
        private Button button3;
        private Button addemp_btn;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button Dashboard_btn;
    }
}