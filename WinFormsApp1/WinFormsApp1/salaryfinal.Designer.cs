namespace WinFormsApp1
{
    partial class salaryfinal
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
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            label9 = new Label();
            panel2 = new Panel();
            salary_clearBtn = new Button();
            salary_updateBtn = new Button();
            salary_name = new TextBox();
            label8 = new Label();
            salary_salary = new TextBox();
            label7 = new Label();
            salary_position = new TextBox();
            label5 = new Label();
            salary_employeeID = new TextBox();
            emp_id = new Label();
            panel3 = new Panel();
            label6 = new Label();
            exit = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            salary_signout = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(dataGridView1);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(539, 53);
            panel4.Name = "panel4";
            panel4.Size = new Size(543, 529);
            panel4.TabIndex = 30;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(24, 54);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(503, 438);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 23);
            label9.Name = "label9";
            label9.Size = new Size(87, 20);
            label9.TabIndex = 0;
            label9.Text = "EMPLOYEES";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(salary_clearBtn);
            panel2.Controls.Add(salary_updateBtn);
            panel2.Controls.Add(salary_name);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(salary_salary);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(salary_position);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(salary_employeeID);
            panel2.Controls.Add(emp_id);
            panel2.Location = new Point(239, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(282, 529);
            panel2.TabIndex = 29;
            // 
            // salary_clearBtn
            // 
            salary_clearBtn.BackColor = Color.FromArgb(36, 11, 97);
            salary_clearBtn.Cursor = Cursors.Hand;
            salary_clearBtn.ForeColor = SystemColors.ButtonHighlight;
            salary_clearBtn.Location = new Point(140, 403);
            salary_clearBtn.Name = "salary_clearBtn";
            salary_clearBtn.Size = new Size(88, 37);
            salary_clearBtn.TabIndex = 11;
            salary_clearBtn.Text = "CLEAR";
            salary_clearBtn.UseVisualStyleBackColor = false;
            salary_clearBtn.Click += salary_clearBtn_Click_1;
            // 
            // salary_updateBtn
            // 
            salary_updateBtn.BackColor = Color.FromArgb(36, 11, 97);
            salary_updateBtn.Cursor = Cursors.Hand;
            salary_updateBtn.ForeColor = SystemColors.ButtonHighlight;
            salary_updateBtn.Location = new Point(27, 403);
            salary_updateBtn.Name = "salary_updateBtn";
            salary_updateBtn.Size = new Size(88, 37);
            salary_updateBtn.TabIndex = 9;
            salary_updateBtn.Text = "UPDATE";
            salary_updateBtn.UseVisualStyleBackColor = false;
            salary_updateBtn.Click += salary_updateBtn_Click_1;
            // 
            // salary_name
            // 
            salary_name.Location = new Point(23, 154);
            salary_name.Name = "salary_name";
            salary_name.Size = new Size(205, 27);
            salary_name.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(18, 127);
            label8.Name = "label8";
            label8.Size = new Size(89, 18);
            label8.TabIndex = 6;
            label8.Text = "FULL NAME:";
            // 
            // salary_salary
            // 
            salary_salary.Location = new Point(23, 316);
            salary_salary.Name = "salary_salary";
            salary_salary.Size = new Size(205, 27);
            salary_salary.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(18, 289);
            label7.Name = "label7";
            label7.Size = new Size(65, 18);
            label7.TabIndex = 4;
            label7.Text = "SALARY:";
            // 
            // salary_position
            // 
            salary_position.Location = new Point(23, 236);
            salary_position.Name = "salary_position";
            salary_position.Size = new Size(205, 27);
            salary_position.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 209);
            label5.Name = "label5";
            label5.Size = new Size(83, 18);
            label5.TabIndex = 2;
            label5.Text = "POSITION:";
            // 
            // salary_employeeID
            // 
            salary_employeeID.Location = new Point(23, 75);
            salary_employeeID.Name = "salary_employeeID";
            salary_employeeID.Size = new Size(205, 27);
            salary_employeeID.TabIndex = 1;
            // 
            // emp_id
            // 
            emp_id.AutoSize = true;
            emp_id.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            emp_id.Location = new Point(18, 48);
            emp_id.Name = "emp_id";
            emp_id.Size = new Size(97, 18);
            emp_id.TabIndex = 0;
            emp_id.Text = "Employee ID:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(36, 11, 97);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(exit);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(225, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(875, 35);
            panel3.TabIndex = 28;
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
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            exit.ForeColor = Color.White;
            exit.Location = new Point(847, 7);
            exit.Name = "exit";
            exit.Size = new Size(20, 23);
            exit.TabIndex = 1;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(841, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 11, 97);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(salary_signout);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 600);
            panel1.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(48, 238);
            label1.Name = "label1";
            label1.Size = new Size(122, 22);
            label1.TabIndex = 14;
            label1.Text = "Welcome User";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.download2;
            pictureBox3.Location = new Point(15, 564);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Image = Properties.Resources.icon;
            pictureBox4.Location = new Point(51, 97);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(113, 128);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // salary_signout
            // 
            salary_signout.AutoSize = true;
            salary_signout.Cursor = Cursors.Hand;
            salary_signout.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            salary_signout.ForeColor = Color.White;
            salary_signout.Location = new Point(52, 564);
            salary_signout.Name = "salary_signout";
            salary_signout.Size = new Size(60, 18);
            salary_signout.TabIndex = 11;
            salary_signout.Text = "Sign out";
            salary_signout.Click += salary_signout_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(75, 8, 138);
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(12, 424);
            button4.Name = "button4";
            button4.Size = new Size(200, 40);
            button4.TabIndex = 10;
            button4.Text = "SALARY";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(33, 11, 97);
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(12, 364);
            button5.Name = "button5";
            button5.Size = new Size(200, 40);
            button5.TabIndex = 9;
            button5.Text = "ADD EMPLOYEE";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(33, 11, 97);
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(12, 305);
            button6.Name = "button6";
            button6.Size = new Size(200, 40);
            button6.TabIndex = 8;
            button6.Text = "DASHBOARD";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // salaryfinal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "salaryfinal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "salaryfinal";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private DataGridView dataGridView1;
        private Label label9;
        private Panel panel2;
        private Button salary_clearBtn;
        private Button salary_updateBtn;
        private TextBox salary_name;
        private Label label8;
        private TextBox salary_salary;
        private Label label7;
        private TextBox salary_position;
        private Label label5;
        private TextBox salary_employeeID;
        private Label emp_id;
        private Panel panel3;
        private Label label6;
        private Label exit;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label salary_signout;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}