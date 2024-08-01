using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class dashboard_3 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\emp2.mdf;Integrated Security=True;Connect Timeout=30");
        public dashboard_3()
        {
            InitializeComponent();
            displayTE();
            displayAE();
            displayIE();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void displayTE()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM employees WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_TE.Text = count.ToString();
                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void displayAE()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM employees WHERE status = @status " +
                        "AND delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Active");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_AE.Text = count.ToString();
                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void displayIE()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM employees WHERE status = @status " +
                        "AND delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Inactive");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_IE.Text = count.ToString();
                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddEmployeefinal next = new AddEmployeefinal();
            next.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            salaryfinal salary = new salaryfinal();
            salary.Show();
            this.Hide();
        }

        private void dashboard_TE_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AddEmployeefinal nextForm = new AddEmployeefinal();
            nextForm.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            salaryfinal regForm = new salaryfinal();
            regForm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
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

        private void label4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
