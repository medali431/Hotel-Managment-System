using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestionEmp
{
    public partial class ResrvationManagment : Form
    {
        private string CONNECTIONN_STRING = @"Data Source=localhost\sqlexpress;Initial Catalog=db1;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection conn = new SqlConnection();
        public ResrvationManagment()
        {
            InitializeComponent();
            dt = new DataTable();
            adpt = new SqlDataAdapter();
        }

        private void ResrvationManagment_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool reservationidSearchSelected = radioButtonreservationid.Checked;
            bool customeridSearchSelected = radioButtoncustomerid.Checked;
            bool SearchSelectedAllreservation = radioButtonAllreservation.Checked;
            conn.ConnectionString = CONNECTIONN_STRING;
            SqlCommand cmd = new SqlCommand();

            string textToSearch = this.textToSearch.Text.ToString();

            if (reservationidSearchSelected)
            {

                //cmd.CommandText = "SELECT * FROM customers WHERE identityno = '"+textToSearch+"' ";
                //MessageBox.Show("indentity search selected");
                adpt = new SqlDataAdapter("SELECT * FROM reservation WHERE reservationid = '" + textToSearch + "' ", conn);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridViewSearchResult.DataSource = dt;
            }
            else if (customeridSearchSelected)
            {
                adpt = new SqlDataAdapter("SELECT * FROM reservation WHERE customerid = '" + textToSearch + "' ", conn);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridViewSearchResult.DataSource = dt;
                //MessageBox.Show("Name search selected"); 
            }

            else if (SearchSelectedAllreservation)
            {
                adpt = new SqlDataAdapter("SELECT * FROM reservation ", conn);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridViewSearchResult.DataSource = dt;

                // MessageBox.Show("phone search selected");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string customer_id, number_ofpeople, periode_oftime, customer_roomnumber;
            customer_id = customerid.Text.ToString();
            number_ofpeople = numberofpeople.Text.ToString();
            periode_oftime = periodeoftime.Text.ToString();
            customer_roomnumber = reservationroomnumber.Text.ToString();
            if (string.IsNullOrEmpty(customer_id) || string.IsNullOrEmpty(number_ofpeople) || string.IsNullOrEmpty(periode_oftime) || string.IsNullOrEmpty(customer_roomnumber))
            {
                MessageBox.Show("No empty field allowed except email adress of the customer ");

            }
            else
            {

                conn.ConnectionString = CONNECTIONN_STRING;

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO reservation (customerid,roomnumber,periodeoftime,nbofpeople) VALUES ('" + customer_id + "','" + customer_roomnumber + "','" + periode_oftime + "','" + periode_oftime + "')";
                cmd.Connection = conn;
                int a = cmd.ExecuteNonQuery();
                conn.Close();
                if (a > 0)
                {
                    MessageBox.Show("Reservation secessfully registered ");
                    customerid.Text = "";
                    numberofpeople.Text = "";
                    periodeoftime.Text = "";
                    reservationroomnumber.Text = "";
                }
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string customer_id, reservation_roomnumber, periode_oftime, number_ofpeople;
            customer_id = customerid.Text.ToString();
            reservation_roomnumber = reservationroomnumber.Text.ToString();
            periode_oftime = periodeoftime.Text.ToString();
            number_ofpeople = numberofpeople.Text.ToString();
            if (string.IsNullOrEmpty(customer_id))
            {
                MessageBox.Show("No empty field allowed except email adress of the customer ");

            }
            else
            {

                conn.ConnectionString = CONNECTIONN_STRING;

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "DELETE FROM reservation WHERE customerid = '" + customer_id + "'";
                cmd.Connection = conn;
                int a = cmd.ExecuteNonQuery();
                conn.Close();
                if (a > 0)
                {
                    MessageBox.Show("customer secessfully delete ");
                    customerid.Text = "";
                    reservationroomnumber.Text = "";
                    periodeoftime.Text = "";
                    numberofpeople.Text = "";
                }
            }
        }

        
        
    }
}
