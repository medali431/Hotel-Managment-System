using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;

using System.Windows.Forms;








using System.Xml.Serialization;

namespace GestionEmp
{
    public partial class Form2 : Form
    {
        private string CONNECTIONN_STRING = @"Data Source=localhost\sqlexpress;Initial Catalog=db1;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection conn = new SqlConnection();

        public Form2()
        {
            InitializeComponent();
            // Fournir une valeur par défaut
            dt = new DataTable();
            adpt = new SqlDataAdapter();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showDatacustomer();
        }

        private void showDatacustomer()
        {

            conn.ConnectionString = CONNECTIONN_STRING;
            adpt = new SqlDataAdapter("SELECT * FROM customers ", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewAllcustomers.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string customer_name, customeridentityno, customeremail, customerphone;
            customer_name = name.Text.ToString();
            customeridentityno = identity.Text.ToString();
            customeremail = email.Text.ToString();
            customerphone = phone.Text.ToString();
            if (string.IsNullOrEmpty(customer_name) || string.IsNullOrEmpty(customeridentityno) || string.IsNullOrEmpty(customeremail) || string.IsNullOrEmpty(customerphone))
            {
                MessageBox.Show("No empty field allowed except email adress of the customer ");

            }
            else
            {

                conn.ConnectionString = CONNECTIONN_STRING;

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO customers (customername,customeremail,customerphone,identityno) VALUES ('" + customer_name + "','" + customeremail + "','" + customerphone + "','" + customeridentityno + "')";
                cmd.Connection = conn;
                int a = cmd.ExecuteNonQuery();
                conn.Close();
                if (a > 0)
                {
                    MessageBox.Show("customer secessfully registered ");
                    name.Text = "";
                    identity.Text = "";
                    email.Text = "";
                    phone.Text = "";
                }


            }

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool idSearchSelected = radioButtonIdentity.Checked;
            bool nameSearchSelected = radioButtonName.Checked;
            bool phoneNoSearchSelected = radioButtonPhone.Checked;
            bool Allcustomerr = radioButtonAllcustomer.Checked;
            conn.ConnectionString = CONNECTIONN_STRING;
            SqlCommand cmd = new SqlCommand();

            string textToSearch = textBoxSearch.Text.ToString();

            if (idSearchSelected)
            {

                //cmd.CommandText = "SELECT * FROM customers WHERE identityno = '"+textToSearch+"' ";
                //MessageBox.Show("indentity search selected");
                adpt = new SqlDataAdapter("SELECT * FROM customers WHERE identityno = '" + textToSearch + "' ", conn);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridViewSearchResult.DataSource = dt;
            }
            else if (nameSearchSelected)
            {
                adpt = new SqlDataAdapter("SELECT * FROM customers WHERE customername = '" + textToSearch + "' ", conn);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridViewSearchResult.DataSource = dt;
                //MessageBox.Show("Name search selected"); 
            }
            else if (phoneNoSearchSelected)
            {
                adpt = new SqlDataAdapter("SELECT * FROM customers WHERE customerphone = '" + textToSearch + "' ", conn);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridViewSearchResult.DataSource = dt;

                // MessageBox.Show("phone search selected");
            }
            else if (Allcustomerr)
            {
                adpt = new SqlDataAdapter("SELECT * FROM customers ", conn);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridViewSearchResult.DataSource = dt;

                // MessageBox.Show("phone search selected");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string customer_name, customeridentityno, customeremail, customerphone;
            customer_name = name.Text.ToString();
            customeridentityno = identity.Text.ToString();
            customeremail = email.Text.ToString();
            customerphone = phone.Text.ToString();
            if ( string.IsNullOrEmpty(customeridentityno) || string.IsNullOrEmpty(customeremail) || string.IsNullOrEmpty(customerphone))
            {
                MessageBox.Show("No empty field allowed except email adress of the customer ");

            }
            else
            {

                conn.ConnectionString = CONNECTIONN_STRING;

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "DELETE FROM customers WHERE customeremail = '" + customeremail + "'";
                cmd.Connection = conn;
                int a = cmd.ExecuteNonQuery();
                conn.Close();
                if (a > 0)
                {
                    MessageBox.Show("customer secessfully delete ");
                    name.Text = "";
                    identity.Text = "";
                    email.Text = "";
                    phone.Text = "";
                }
            }
        }
    }
}
