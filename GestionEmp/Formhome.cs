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

namespace GestionEmp
{
    public partial class Formhome : Form
    {
        public Formhome()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 customersForm = new Form2();
            customersForm.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();




        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResrvationManagment ResrvationManagment = new ResrvationManagment();
            ResrvationManagment.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormLogIn form1 = new FormLogIn(); 
            form1.Show();              
            this.Close();
        }
    }
}
