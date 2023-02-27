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

namespace lab8
{
    public partial class Form_main : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\BBDB.mdf;Integrated Security=True";

        public Form_main()
        {
            InitializeComponent();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            // confirm before logout
            var result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //if yes, hide this form
                this.Hide();
                Form_login fl = new Form_login();
                // show login window
                fl.Show();
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\BBDB.mdf;Integrated Security=True";

            //create sql connection called "con", used to connect to Students database
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Bank SET Bank.bphone = @bphone, Bank.baddress = @baddress WHERE Bank.bid = @bid;", con);
            cmd.Parameters.AddWithValue("@bid", label_sid.Text);
            cmd.Parameters.AddWithValue("@bphone", textBox_phone.Text);
            cmd.Parameters.AddWithValue("@baddress", textBox_saddr.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Information Updated Successfully");
        }

        private void Form_main_Load(object sender, EventArgs e)
        {

            string username = Form_login.username;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT Bank.bid, Bank.bname, Bank.bphone, Bank.baddress FROM Bank", con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@baddress", textBox_saddr.Text);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Close();
            label_sid.Text = dt.Rows[0]["bid"].ToString();
            label_sname.Text = dt.Rows[0]["bname"].ToString();
            textBox_phone.Text = dt.Rows[0]["bphone"].ToString();
            textBox_saddr.Text = dt.Rows[0]["baddress"].ToString();
        }

        private void label_sid_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(connectionString);

            if (textBox_name.Text == "")
            {
                MessageBox.Show("Please provide Bank name");
                return;
            }

            con1.Open();
            // search the student based on the student name
            SqlCommand cmd = new SqlCommand("EXEC PatientAge @bsearch= @name;", con1);
            cmd.Parameters.AddWithValue("@name", textBox_name.Text);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView_grades.DataSource = dt;
            SqlCommand cmd2 = new SqlCommand("SELECT Bank.bid FROM Bank WHERE Bank.bname LIKE '%" + textBox_name.Text + "%'", con1);


            if (cmd2.ExecuteScalar() == null)
            {
                label_sid.Text = "";
                textBox_saddr.Text = "";
                textBox_phone.Text = "";
                label_sname.Text = "";
            }
            else
            {
                label_sid.Text = cmd2.ExecuteScalar().ToString();


                cmd2 = new SqlCommand("SELECT Bank.bname FROM Bank WHERE Bank.bname LIKE '%" + textBox_name.Text + "%'", con1);

                label_sname.Text = cmd2.ExecuteScalar().ToString();


                cmd2 = new SqlCommand("SELECT Bank.bphone FROM Bank WHERE Bank.bname LIKE '%" + textBox_name.Text + "%'", con1);
                textBox_phone.Text = cmd2.ExecuteScalar().ToString();

                cmd2 = new SqlCommand("SELECT Bank.baddress FROM Bank WHERE Bank.bname LIKE '%" + textBox_name.Text + "%'", con1);
                textBox_saddr.Text = cmd2.ExecuteScalar().ToString();
            }
            con1.Close();
            }

        private void dataGridView_grades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\BBDB.mdf;Integrated Security=True";

            //create sql connection called "con", used to connect to Students database
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Bank WHERE Bank.bid = @bid;", con);
            cmd.Parameters.AddWithValue("@bid", label_sid.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Information Deleted Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con4 = new SqlConnection(connectionString);

            if (label_sid.Text == "")
            {
                MessageBox.Show("Please provide a valid Bank");
                return;
            }
            con4.Open();
            // SQL used to find MAX grade
            SqlCommand cmd3 = new SqlCommand("EXEC PatientAgeMax @bmaxsearchid = @mbid", con4);
            cmd3.Parameters.AddWithValue("@mbid", label_sid.Text);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd3);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            if (dt.Rows.Count == 0)
            {

                MessageBox.Show("Can not find this Bank");
                con4.Close();
                return;
            }
            // show query result
            MessageBox.Show("MAX AGE: " + dt.Rows[0]["MAX_AGE"].ToString());
            con4.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con4 = new SqlConnection(connectionString);

            if (label_sid.Text == "")
            {
                MessageBox.Show("Please provide a valid Bank");
                return;
            }
            con4.Open();
            // SQL used to find MAX grade
            SqlCommand cmd3 = new SqlCommand("EXEC PatientAgeAvg @bavgsearchid = @mbid", con4);
            cmd3.Parameters.AddWithValue("@mbid", label_sid.Text);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd3);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            if (dt.Rows.Count == 0)
            {

                MessageBox.Show("Can not find this Bank");
                con4.Close();
                return;
            }
            // show query result
            MessageBox.Show("AVG AGE: " + dt.Rows[0]["AVG_AGE"].ToString());
            con4.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con4 = new SqlConnection(connectionString);

            if (label_sid.Text == "")
            {
                MessageBox.Show("Please provide a valid Bank");
                return;
            }
            con4.Open();
            // SQL used to find MAX grade
            SqlCommand cmd3 = new SqlCommand("EXEC PatientAgeMin @bminsearchid = @mbid", con4);
            cmd3.Parameters.AddWithValue("@mbid", label_sid.Text);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd3);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            if (dt.Rows.Count == 0)
            {

                MessageBox.Show("Can not find this Bank");
                con4.Close();
                return;
            }
            // show query result
            MessageBox.Show("MIN AGE: " + dt.Rows[0]["MIN_AGE"].ToString());
            con4.Close();

        }
    }
}
