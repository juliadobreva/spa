using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juliaproject2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();

            this.Hide();
            form5.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC20\SQLEXPRESS; Initial Catalog=spainfo; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // Check if the room is available
                string availabilityQuery = "SELECT availability_status FROM spa_management WHERE service_id = @service_id";

                SqlCommand availabilityCmd = new SqlCommand(availabilityQuery, sqlCon);
                availabilityCmd.Parameters.AddWithValue("@service_id", service_id.Text);
                string availabilityResult = availabilityCmd.ExecuteScalar().ToString().Trim();

                if (availabilityResult.Equals("Available", StringComparison.OrdinalIgnoreCase))
                {
                    string insertQuery = "INSERT INTO booking VALUES (@service_id, @customer_name, @customer_phone, @treatment_date, @treatment_start, @treatment_end)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, sqlCon);

                    // Set parameters based on selected values
                    insertCmd.Parameters.AddWithValue("@service_id", service_id.Text);
                    insertCmd.Parameters.AddWithValue("@customer_name", customer_name.Text);
                    insertCmd.Parameters.AddWithValue("@treatment_start", treatment_start.Text);
                    insertCmd.Parameters.AddWithValue("@treatment_end", treatment_end.Text);
                    insertCmd.Parameters.AddWithValue("@treatment_date", treatment_date.Value);
                    insertCmd.Parameters.AddWithValue("@customer_phone", customer_phone.Text);

                    insertCmd.ExecuteNonQuery();

                    // Update room availability status
                    string updateAvailabilityQuery = "UPDATE spa_management SET availability_status = 'Not Available' WHERE service_id = @service_id";
                    SqlCommand updateAvailabilityCmd = new SqlCommand(updateAvailabilityQuery, sqlCon);
                    updateAvailabilityCmd.Parameters.AddWithValue("@service_id", service_id.Text);
                    updateAvailabilityCmd.ExecuteNonQuery();

                    MessageBox.Show("Booking Successful!");
                }
                else
                {
                    // Room is not available
                    MessageBox.Show("Sorry, the room is not available for booking.");
                }
            }
        }
    }
}
