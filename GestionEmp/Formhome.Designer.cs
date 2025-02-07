namespace GestionEmp
{
    partial class Formhome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// daliiii
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
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(977, 23);
            button1.Name = "button1";
            button1.Size = new Size(167, 54);
            button1.TabIndex = 0;
            button1.Text = "Exist";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F);
            button2.Location = new Point(23, 37);
            button2.Name = "button2";
            button2.Size = new Size(364, 43);
            button2.TabIndex = 1;
            button2.Text = "Open Customer Form";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(54, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(404, 115);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Managment";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(502, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(396, 115);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Reservation Managment";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F);
            button3.Location = new Point(26, 37);
            button3.Name = "button3";
            button3.Size = new Size(364, 43);
            button3.TabIndex = 2;
            button3.Text = "Open Reservation Form";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(977, 121);
            button4.Name = "button4";
            button4.Size = new Size(167, 54);
            button4.TabIndex = 4;
            button4.Text = "Return";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Formhome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1156, 650);
            ControlBox = false;
            Controls.Add(button4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "Formhome";
            Text = "Formhome";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button3;
        private Button button4;
    }
}