namespace GestionEmp
{
    partial class FormLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being 
        /// </summary>
        /// <param name="disposing">true if managed resourcshould disposed; otherwi false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(36, 24);
            label1.Name = "label1";
            label1.Size = new Size(663, 45);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Hotel managment System\r\n";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(textBoxUsername);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(65, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(634, 351);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Please Login to continue";
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.WindowText;
            button2.Location = new Point(215, 270);
            button2.Name = "button2";
            button2.Size = new Size(348, 29);
            button2.TabIndex = 6;
            button2.Text = "Add New Username,password";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.WindowText;
            button1.Location = new Point(215, 228);
            button1.Name = "button1";
            button1.Size = new Size(348, 36);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Cursor = Cursors.IBeam;
            textBoxPassword.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(215, 154);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(348, 43);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Cursor = Cursors.IBeam;
            textBoxUsername.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.Location = new Point(215, 63);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(348, 43);
            textBoxUsername.TabIndex = 4;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(51, 154);
            label3.Name = "label3";
            label3.Size = new Size(132, 38);
            label3.TabIndex = 3;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(51, 63);
            label2.Name = "label2";
            label2.Size = new Size(132, 38);
            label2.TabIndex = 2;
            label2.Text = "Usename";
            label2.Click += label2_Click;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(801, 472);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.Coral;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel";
            Load += FormLogIn_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Button button1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button button2;
    }
}
