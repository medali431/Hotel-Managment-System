using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GestionEmp
{
    public partial class Password_to_Add : Form
    {
        public Password_to_Add()
        {
            InitializeComponent();
        }

        private void Password_to_Add_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string passwordd = Password.Text.ToString();
            if (string.IsNullOrEmpty(passwordd))
            {
                DialogResult dialogResult = MessageBox.Show("no empty", "you cannot continue", MessageBoxButtons.OK);

            }
            else if (passwordd == "12345")
            {
                Add_username_password add = new Add_username_password();
                add.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLogIn form1 = new FormLogIn();
            form1.Show();
            this.Close();
        }
    }
}
