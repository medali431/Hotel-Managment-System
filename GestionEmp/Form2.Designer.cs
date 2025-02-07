namespace GestionEmp
{
    partial class Form2
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
            textBoxSearch = new TextBox();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            radioButtonAllcustomer = new RadioButton();
            radioButtonPhone = new RadioButton();
            radioButtonName = new RadioButton();
            radioButtonIdentity = new RadioButton();
            button2 = new Button();
            label1 = new Label();
            dataGridViewSearchResult = new DataGridView();
            dataGridViewAllcustomers = new DataGridView();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            identity = new TextBox();
            email = new TextBox();
            phone = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            name = new TextBox();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllcustomers).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 14F);
            textBoxSearch.Location = new Point(27, 89);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(956, 39);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxSearch);
            groupBox1.Location = new Point(34, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1008, 212);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search customers";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButtonAllcustomer);
            groupBox4.Controls.Add(radioButtonPhone);
            groupBox4.Controls.Add(radioButtonName);
            groupBox4.Controls.Add(radioButtonIdentity);
            groupBox4.Location = new Point(41, 134);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(637, 67);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Search by";
            // 
            // radioButtonAllcustomer
            // 
            radioButtonAllcustomer.AutoSize = true;
            radioButtonAllcustomer.Location = new Point(386, 26);
            radioButtonAllcustomer.Name = "radioButtonAllcustomer";
            radioButtonAllcustomer.Size = new Size(109, 24);
            radioButtonAllcustomer.TabIndex = 3;
            radioButtonAllcustomer.TabStop = true;
            radioButtonAllcustomer.Text = "Allcustomer";
            radioButtonAllcustomer.UseVisualStyleBackColor = true;
            // 
            // radioButtonPhone
            // 
            radioButtonPhone.AutoSize = true;
            radioButtonPhone.Location = new Point(268, 26);
            radioButtonPhone.Name = "radioButtonPhone";
            radioButtonPhone.Size = new Size(112, 24);
            radioButtonPhone.TabIndex = 2;
            radioButtonPhone.TabStop = true;
            radioButtonPhone.Text = "By Phone no";
            radioButtonPhone.UseVisualStyleBackColor = true;
            radioButtonPhone.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButtonName
            // 
            radioButtonName.AutoSize = true;
            radioButtonName.Location = new Point(152, 26);
            radioButtonName.Name = "radioButtonName";
            radioButtonName.Size = new Size(90, 24);
            radioButtonName.TabIndex = 1;
            radioButtonName.TabStop = true;
            radioButtonName.Text = "By Name";
            radioButtonName.UseVisualStyleBackColor = true;
            // 
            // radioButtonIdentity
            // 
            radioButtonIdentity.AutoSize = true;
            radioButtonIdentity.Location = new Point(29, 26);
            radioButtonIdentity.Name = "radioButtonIdentity";
            radioButtonIdentity.Size = new Size(100, 24);
            radioButtonIdentity.TabIndex = 0;
            radioButtonIdentity.TabStop = true;
            radioButtonIdentity.Text = "By identity";
            radioButtonIdentity.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.Font = new Font("Segoe UI", 14.25F);
            button2.Location = new Point(718, 146);
            button2.Name = "button2";
            button2.Size = new Size(126, 45);
            button2.TabIndex = 2;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 42);
            label1.Name = "label1";
            label1.Size = new Size(562, 31);
            label1.TabIndex = 1;
            label1.Text = "Search customers by Name,ID,Email or Phone number";
            label1.Click += label1_Click;
            // 
            // dataGridViewSearchResult
            // 
            dataGridViewSearchResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearchResult.Location = new Point(34, 318);
            dataGridViewSearchResult.Name = "dataGridViewSearchResult";
            dataGridViewSearchResult.RowHeadersWidth = 51;
            dataGridViewSearchResult.Size = new Size(450, 188);
            dataGridViewSearchResult.TabIndex = 4;
            dataGridViewSearchResult.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridViewAllcustomers
            // 
            dataGridViewAllcustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllcustomers.Location = new Point(6, 38);
            dataGridViewAllcustomers.Name = "dataGridViewAllcustomers";
            dataGridViewAllcustomers.RowHeadersWidth = 51;
            dataGridViewAllcustomers.Size = new Size(437, 188);
            dataGridViewAllcustomers.TabIndex = 5;
            dataGridViewAllcustomers.CellContentClick += dataGridView2_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewAllcustomers);
            groupBox2.Location = new Point(584, 280);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(458, 252);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "All customers";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(identity);
            groupBox3.Controls.Add(email);
            groupBox3.Controls.Add(phone);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(name);
            groupBox3.Location = new Point(34, 583);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1006, 412);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Customer ";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ScrollBar;
            button4.Font = new Font("Segoe UI", 14.25F);
            button4.Location = new Point(525, 339);
            button4.Name = "button4";
            button4.Size = new Size(119, 44);
            button4.TabIndex = 10;
            button4.Text = "Insert";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ScrollBar;
            button3.Font = new Font("Segoe UI", 14.25F);
            button3.Location = new Point(650, 339);
            button3.Name = "button3";
            button3.Size = new Size(119, 44);
            button3.TabIndex = 9;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Font = new Font("Segoe UI", 14.25F);
            button1.Location = new Point(775, 339);
            button1.Name = "button1";
            button1.Size = new Size(119, 44);
            button1.TabIndex = 8;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // identity
            // 
            identity.Font = new Font("Segoe UI", 14.25F);
            identity.Location = new Point(220, 274);
            identity.Name = "identity";
            identity.Size = new Size(674, 39);
            identity.TabIndex = 7;
            // 
            // email
            // 
            email.Font = new Font("Segoe UI", 14.25F);
            email.Location = new Point(220, 198);
            email.Name = "email";
            email.Size = new Size(674, 39);
            email.TabIndex = 6;
            // 
            // phone
            // 
            phone.Font = new Font("Segoe UI", 14.25F);
            phone.Location = new Point(220, 132);
            phone.Name = "phone";
            phone.Size = new Size(674, 39);
            phone.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(6, 139);
            label5.Name = "label5";
            label5.Size = new Size(199, 32);
            label5.TabIndex = 4;
            label5.Text = "Customer Phone ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(6, 205);
            label4.Name = "label4";
            label4.Size = new Size(181, 32);
            label4.TabIndex = 3;
            label4.Text = "Customer Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(6, 281);
            label3.Name = "label3";
            label3.Size = new Size(205, 32);
            label3.TabIndex = 2;
            label3.Text = "Customer Identity";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(6, 70);
            label2.Name = "label2";
            label2.Size = new Size(188, 32);
            label2.TabIndex = 1;
            label2.Text = "Customer Name";
            label2.Click += label2_Click_1;
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 14.25F);
            name.Location = new Point(220, 63);
            name.Name = "name";
            name.Size = new Size(674, 39);
            name.TabIndex = 0;
            name.TextChanged += name_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1074, 975);
            Controls.Add(groupBox3);
            Controls.Add(dataGridViewSearchResult);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Form2";
            Text = "CustomersForm";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllcustomers).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxSearch;
        private GroupBox groupBox1;
        private Label label1;
        private Button button2;
        private DataGridView dataGridViewSearchResult;
        private DataGridView dataGridViewAllcustomers;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox name;
        private Label label2;
        private TextBox email;
        private TextBox phone;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button1;
        private TextBox identity;
        private Button button4;
        private Button button3;
        private GroupBox groupBox4;
        private RadioButton radioButtonIdentity;
        private RadioButton radioButtonPhone;
        private RadioButton radioButtonName;
        private RadioButton radioButtonAllcustomer;
    }
}