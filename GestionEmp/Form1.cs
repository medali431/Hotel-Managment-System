using System;
using System.Data;
using System.Windows.Forms;


using Microsoft.Data.SqlClient;





using System.Xml.Serialization;



namespace GestionEmp
{
    public partial class FormLogIn : Form
    {
        private string CONNECTION_STRING = @"Data Source=localhost\sqlexpress;Initial Catalog=db1;Integrated Security=True;Trust Server Certificate=True";

        public FormLogIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormLogIn_Load(object sender, EventArgs e)
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
                cmd.CommandText = "SELECT * FROM user_table WHERE username = '" + username + "' AND password ='" + password + "' ";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    //while (reader.Read()) { 
                    //MessageBox.Show("user found id: "+ reader.GetInt32(0).ToString());}
                    Formhome formhome = new Formhome();
                    formhome.Show();
                    this.Hide();



                }
                else
                {
                    MessageBox.Show("User or password is incorrect");
                }





                conn.Close();
            }

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            Password_to_Add pass = new Password_to_Add();
            pass.Show();
            this.Hide();
        }
    }
}
