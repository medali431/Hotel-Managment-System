namespace GestionEmp
{
    partial class Add_username_password
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(textBoxUsername);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(62, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(634, 351);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add new user";
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.WindowText;
            button1.Location = new Point(215, 228);
            button1.Name = "button1";
            button1.Size = new Size(348, 36);
            button1.TabIndex = 2;
            button1.Text = "Add";
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
            // 
            // textBoxUsername
            // 
            textBoxUsername.Cursor = Cursors.IBeam;
            textBoxUsername.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.Location = new Point(215, 63);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(348, 43);
            textBoxUsername.TabIndex = 4;
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
            // 
            // Add_username_password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 472);
            Controls.Add(groupBox1);
            Name = "Add_username_password";
            Text = " Add user password ";
            Load += Add_username_password_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Label label3;
        private Label label2;
    }
}