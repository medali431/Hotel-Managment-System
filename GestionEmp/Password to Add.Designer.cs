namespace GestionEmp
{
    partial class Password_to_Add
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
            Password = new TextBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(Password);
            groupBox1.Location = new Point(35, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 156);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Password";
            // 
            // button1
            // 
            button1.Location = new Point(72, 90);
            button1.Name = "button1";
            button1.Size = new Size(314, 29);
            button1.TabIndex = 1;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Password
            // 
            Password.Font = new Font("Segoe UI", 14.25F);
            Password.Location = new Point(72, 45);
            Password.Name = "Password";
            Password.Size = new Size(314, 39);
            Password.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(408, 212);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Return";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Password_to_Add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 264);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Name = "Password_to_Add";
            Text = "Password_to_Add";
            Load += Password_to_Add_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox Password;
        private Button button2;
    }
}