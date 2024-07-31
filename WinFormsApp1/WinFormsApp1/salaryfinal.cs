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
    public partial class salaryfinal : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\emp2.mdf;Integrated Security=True;Connect Timeout=30");
        public salaryfinal()
        {
            InitializeComponent();
            displayEmployees();
            disableFields();
        }

        public void disableFields()
        {
            salary_employeeID.Enabled = false;
            salary_name.Enabled = false;
            salary_position.Enabled = false;
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        public void clearFields()
        {
            salary_employeeID.Text = "";
            salary_name.Text = "";
            salary_position.Text = "";
            salary_salary.Text = "";
        }

        public void displayEmployees()
        {
            SalaryData ed = new SalaryData();
            List<SalaryData> listData = ed.salaryEmployeeListData();

            dataGridView1.DataSource = listData;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                salary_employeeID.Text = row.Cells[0].Value.ToString();
                salary_name.Text = row.Cells[1].Value.ToString();
                salary_position.Text = row.Cells[4].Value.ToString();
                salary_salary.Text = row.Cells[5].Value.ToString();
            }
        }

        private void salary_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddEmployeefinal addemp = new AddEmployeefinal();
            addemp.Show();
            this.Hide();
        }

        private void salary_clearBtn_Click_1(object sender, EventArgs e)
        {
            clearFields();
        }

        private void salary_updateBtn_Click_1(object sender, EventArgs e)
        {
            {
                if (salary_employeeID.Text == ""
                    || salary_name.Text == ""
                    || salary_position.Text == ""
                    || salary_salary.Text == "")
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Employee ID: "
                        + salary_employeeID.Text.Trim() + "?", "Confirmation Message"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        if (connect.State == ConnectionState.Closed)
                        {
                            try
                            {
                                connect.Open();
                                DateTime today = DateTime.Today;

                                string updateData = "UPDATE employees SET salary = @salary" +
                                    ", update_date = @updateData WHERE employee_id = @employeeID";

                                using (SqlCommand cmd = new SqlCommand(updateData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@salary", salary_salary.Text.Trim());
                                    cmd.Parameters.AddWithValue("@updateData", today);
                                    cmd.Parameters.AddWithValue("@employeeID", salary_employeeID.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    displayEmployees();

                                    MessageBox.Show("Updated successfully!"
                                        , "Information Message", MessageBoxButtons.OK
                                        , MessageBoxIcon.Information);

                                    clearFields();

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
                    else
                    {
                        MessageBox.Show("Cancelled", "Information Message"
                        , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dashboard_3 dash = new dashboard_3();
            dash.Show();
            this.Hide();
        }

        private void salary_signout_Click(object sender, EventArgs e)
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
    }
}

