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

namespace GestionEmp
{
    public partial class Add_username_password : Form
    {
        private string CONNECTION_STRING = @"Data Source=localhost\sqlexpress;Initial Catalog=db1;Integrated Security=True;Trust Server Certificate=True";
        public Add_username_password()
        {
            InitializeComponent();
        }

        private void Add_username_password_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.ToString();
            string password = textBoxPassword.Text.ToString();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                DialogResult dialogResult = MessageBox.Show("no empty", "you cannot continue", MessageBoxButtons.OK);

            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = CONNECTION_STRING;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO user_table (username,password) VALUES ('" + username + "','" + password + "')";
                SqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("username,password secessfully Add ");

            }
        }
    }
}
