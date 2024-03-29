using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace juliaproject2
{
    public partial class Form3 : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Connecting to the database
            using (cn = new SqlConnection(@"Data Source=LAB109PC20\SQLEXPRESS; Initial Catalog=spainfo; Integrated Security=True;"))
            {
                cn.Open();
                // Checking if the username already exists
                using (cmd = new SqlCommand("SELECT username FROM clientinfo where username = @username ", cn))
                {
                    cmd.Parameters.AddWithValue("@username", textBox1.Text);
                    using (dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            MessageBox.Show("Username already exists, please try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dr.Close();

                            // Inserting user information into the database
                            using (cmd = new SqlCommand("INSERT INTO clientinfo (username, password, email) VALUES (@username, @password, @email)", cn))
                            {
                                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                                cmd.Parameters.AddWithValue("@password", textBox3.Text);
                                cmd.Parameters.AddWithValue("@email", textBox2.Text);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Your Account is created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Hide();
                                Form4 login = new Form4();
                                login.Show();
                            }
                        }




                    }
                }
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Length <= 6)
            {
                MessageBox.Show("username must be longer than 5", "Error", MessageBoxButtons.OK);
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text != string.Empty)
            {
                if (!IsValidEmail(textBox2.Text))
                {
                    MessageBox.Show("email not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (!(textBox3.Text.Length > 8 && textBox3.Text.Any(char.IsUpper) && textBox3.Text.Any(char.IsLower) && textBox3.Text.Any(char.IsDigit)))
            {
                MessageBox.Show("One or more password criteria(s) hasn't been met", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.SelectAll();
                e.Cancel = true;
            }
        }

        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email))
                return false;

            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            length.Show();
            capital.Show();
            number.Show();

            if (textBox3.Text.Length > 8)
                length.ForeColor = Color.Green;
            else
                length.ForeColor = Color.Red;

            if (textBox3.Text.Any(char.IsUpper))
                capital.ForeColor = Color.Green;
            else
                capital.ForeColor = Color.Red;

            if (textBox3.Text.Any(char.IsDigit))
                number.ForeColor = Color.Green;
            else
                number.ForeColor = Color.Red;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form4 login = new Form4();

            this.Hide();
            login.Show();
        }
    }
}
