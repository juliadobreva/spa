using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace juliaproject2
{
    public partial class Form5 : Form
    {
        private string connectionString = @"Data Source=LAB109PC20\SQLEXPRESS; Initial Catalog=spainfo; Integrated Security=True; Encrypt=False;";
        private DataTable originalDataTable;
        public Form5()
        {
            InitializeComponent();
            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchname = textBox1.Text;

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC20\SQLEXPRESS; Initial Catalog=spainfo; Integrated Security=True; Encrypt=False;"))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT * FROM booking WHERE customer_name LIKE @customer_name";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
                    adapter.SelectCommand.Parameters.AddWithValue("@customer_name", "%" + searchname + "%");
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to delete.");
                return;
            }

            int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
            int service_id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["service_id"].Value);

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC20\SQLEXPRESS; Initial Catalog=spainfo; Integrated Security=True; Encrypt=False;"))
            {
                try
                {
                    sqlCon.Open();
                    string query = "DELETE FROM booking WHERE service_id = @service_id";
                    SqlCommand command = new SqlCommand(query, sqlCon);
                    command.Parameters.AddWithValue("@service_id", service_id);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Booking deleted successfully.");
                        button1_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete booking.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow editedRow = dataGridView1.Rows[e.RowIndex];
            int service_id = Convert.ToInt32(editedRow.Cells["service_id"].Value);
            string updatedCustomerName = Convert.ToString(editedRow.Cells["customer_name"].Value);
            string updatedCustomerPhone = Convert.ToString(editedRow.Cells["customer_phone"].Value);
            string updatedTreatmentDate = Convert.ToString(editedRow.Cells["treatment_date"].Value);
            string updatedStart = Convert.ToString(editedRow.Cells["treatment_start"].Value);
            string updatedEnd = Convert.ToString(editedRow.Cells["treatment_end"].Value);

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE booking SET customer_name = @customer_name, customer_phone = @customer_phone, treatment_date = @treatment_date, treatment_start = @treatment_start, treatment_end = @treatment_end WHERE service_id = @service_id";
                    SqlCommand command = new SqlCommand(query, sqlCon);
                    command.Parameters.AddWithValue("@customer_name", updatedCustomerName);
                    command.Parameters.AddWithValue("@customer_phone", updatedCustomerPhone);
                    command.Parameters.AddWithValue("@treatment_date", updatedTreatmentDate);
                    command.Parameters.AddWithValue("@treatment_start", updatedStart);
                    command.Parameters.AddWithValue("@treatment_end", updatedEnd);
                    command.Parameters.AddWithValue("@service_id", service_id);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Booking updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update booking.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
