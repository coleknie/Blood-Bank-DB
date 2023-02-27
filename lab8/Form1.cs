﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//====================================================================
// add following namespace that are used to connect SQL Database
using System.Data;
using System.Data.SqlClient;
//====================================================================

namespace lab8
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        public static string username = "";

        private void button_login_Click(object sender, EventArgs e)
        {
            //==========================After clicking the "Login" button, your code will do following===================================


            // check if the username or password are empty
            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                //throw out a message if they are empty
                MessageBox.Show("Please provide Username and Password!");
                return;
            }
            // try: catch the error in your code
            try
            {

                // connection string, it is the path/value used to find the database. It can be found in database properties.
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\BBDB.mdf;Integrated Security=True";

                //create sql connection called "con", used to connect to Students database
                SqlConnection con = new SqlConnection(connectionString);
                // the sql command you want to execute in DBMS
                SqlCommand cmd = new SqlCommand("Select * from stu_login where stu_username = @username and stu_password = @password", con);

                //Assign values to variables. Give TextBox: username -> @username; TextBox: password-> @password
                username = textBox_username.Text;
                cmd.Parameters.AddWithValue("@username", textBox_username.Text);
                cmd.Parameters.AddWithValue("@password", textBox_password.Text);

                //open the connection to DB
                con.Open();

                //select records from a database and populate a DataSet with the selected rows.
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                //add rows in data adapter
                adapt.Fill(ds);

                // close the connection after query
                con.Close();

                //get the collection of tables in the DataSet.
                int count = ds.Tables[0].Rows.Count;

                //if count is equal to 1, that means the SQL query get the record., then show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    Form_main fm = new Form_main();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed: Could Not Find Your Account!");
                }
            }
            // catch trow out error message if there is an error
            catch (Exception ex)
            {
                //show the error message
                MessageBox.Show(ex.Message);
            }
            //====================================================================
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_register fr = new Form_register();
            fr.Show();
        }
    }
}
