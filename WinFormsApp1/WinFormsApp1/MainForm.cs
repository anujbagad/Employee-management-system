using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?"
                , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard_final dashboard_ = new dashboard_final();
            dashboard_.Show();
            this.Hide();
        }

        private void Dashboard_btn_Click_1(object sender, EventArgs e)
        {
            dashboard_final next = new dashboard_final();
            next.Show();
            this.Hide();
        }

        private void addemp_btn_Click(object sender, EventArgs e)
        {
            AddEmployeefinal next = new AddEmployeefinal();
            next.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            salaryfinal salary = new salaryfinal();
            salary.Show();
            this.Hide();
        }
    }
}
