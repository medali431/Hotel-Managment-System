namespace GestionEmp
{
    partial class ResrvationManagment
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
            groupBox3 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            numberofpeople = new TextBox();
            periodeoftime = new TextBox();
            reservationroomnumber = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            customerid = new TextBox();
            dataGridViewSearchResult = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            radioButtonAllreservation = new RadioButton();
            radioButtoncustomerid = new RadioButton();
            radioButtonreservationid = new RadioButton();
            Search = new Button();
            label1 = new Label();
            textToSearch = new TextBox();
            groupBox2 = new GroupBox();
            dataGridViewAllcustomers = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchResult).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllcustomers).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(numberofpeople);
            groupBox3.Controls.Add(periodeoftime);
            groupBox3.Controls.Add(reservationroomnumber);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(customerid);
            groupBox3.Location = new Point(76, 560);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1006, 412);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Reservation";
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
            // numberofpeople
            // 
            numberofpeople.Font = new Font("Segoe UI", 14.25F);
            numberofpeople.Location = new Point(220, 274);
            numberofpeople.Name = "numberofpeople";
            numberofpeople.Size = new Size(674, 39);
            numberofpeople.TabIndex = 7;
            // 
            // periodeoftime
            // 
            periodeoftime.Font = new Font("Segoe UI", 14.25F);
            periodeoftime.Location = new Point(220, 198);
            periodeoftime.Name = "periodeoftime";
            periodeoftime.Size = new Size(674, 39);
            periodeoftime.TabIndex = 6;
            // 
            // reservationroomnumber
            // 
            reservationroomnumber.Font = new Font("Segoe UI", 14.25F);
            reservationroomnumber.Location = new Point(220, 132);
            reservationroomnumber.Name = "reservationroomnumber";
            reservationroomnumber.Size = new Size(674, 39);
            reservationroomnumber.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(6, 139);
            label5.Name = "label5";
            label5.Size = new Size(177, 32);
            label5.TabIndex = 4;
            label5.Text = "Room_number ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(6, 205);
            label4.Name = "label4";
            label4.Size = new Size(165, 32);
            label4.TabIndex = 3;
            label4.Text = "Period of time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(6, 281);
            label3.Name = "label3";
            label3.Size = new Size(208, 32);
            label3.TabIndex = 2;
            label3.Text = "number of people";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(6, 70);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 1;
            label2.Text = "Customer id";
            // 
            // customerid
            // 
            customerid.Font = new Font("Segoe UI", 14.25F);
            customerid.Location = new Point(220, 63);
            customerid.Name = "customerid";
            customerid.Size = new Size(674, 39);
            customerid.TabIndex = 0;
            customerid.TextChanged += name_TextChanged;
            // 
            // dataGridViewSearchResult
            // 
            dataGridViewSearchResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearchResult.Location = new Point(76, 295);
            dataGridViewSearchResult.Name = "dataGridViewSearchResult";
            dataGridViewSearchResult.RowHeadersWidth = 51;
            dataGridViewSearchResult.Size = new Size(450, 188);
            dataGridViewSearchResult.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(Search);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textToSearch);
            groupBox1.Location = new Point(76, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1008, 212);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search customers";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButtonAllreservation);
            groupBox4.Controls.Add(radioButtoncustomerid);
            groupBox4.Controls.Add(radioButtonreservationid);
            groupBox4.Location = new Point(41, 134);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(637, 67);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Search by";
            // 
            // radioButtonAllreservation
            // 
            radioButtonAllreservation.AutoSize = true;
            radioButtonAllreservation.Location = new Point(386, 26);
            radioButtonAllreservation.Name = "radioButtonAllreservation";
            radioButtonAllreservation.Size = new Size(113, 24);
            radioButtonAllreservation.TabIndex = 3;
            radioButtonAllreservation.TabStop = true;
            radioButtonAllreservation.Text = "Allresrvation";
            radioButtonAllreservation.UseVisualStyleBackColor = true;
            // 
            // radioButtoncustomerid
            // 
            radioButtoncustomerid.AutoSize = true;
            radioButtoncustomerid.Location = new Point(206, 26);
            radioButtoncustomerid.Name = "radioButtoncustomerid";
            radioButtoncustomerid.Size = new Size(126, 24);
            radioButtoncustomerid.TabIndex = 1;
            radioButtoncustomerid.TabStop = true;
            radioButtoncustomerid.Text = "By Customerid";
            radioButtoncustomerid.UseVisualStyleBackColor = true;
            // 
            // radioButtonreservationid
            // 
            radioButtonreservationid.AutoSize = true;
            radioButtonreservationid.Location = new Point(29, 26);
            radioButtonreservationid.Name = "radioButtonreservationid";
            radioButtonreservationid.Size = new Size(136, 24);
            radioButtonreservationid.TabIndex = 0;
            radioButtonreservationid.TabStop = true;
            radioButtonreservationid.Text = "By reservationid";
            radioButtonreservationid.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            Search.BackColor = SystemColors.AppWorkspace;
            Search.Font = new Font("Segoe UI", 14.25F);
            Search.Location = new Point(718, 146);
            Search.Name = "Search";
            Search.Size = new Size(126, 45);
            Search.TabIndex = 2;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = false;
            Search.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 42);
            label1.Name = "label1";
            label1.Size = new Size(498, 31);
            label1.TabIndex = 1;
            label1.Text = "Search reservation By Customerid,Reservationid";
            // 
            // textToSearch
            // 
            textToSearch.Font = new Font("Segoe UI", 14F);
            textToSearch.Location = new Point(27, 89);
            textToSearch.Name = "textToSearch";
            textToSearch.Size = new Size(956, 39);
            textToSearch.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewAllcustomers);
            groupBox2.Location = new Point(626, 257);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(458, 252);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "All Reservation";
            // 
            // dataGridViewAllcustomers
            // 
            dataGridViewAllcustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllcustomers.Location = new Point(15, 37);
            dataGridViewAllcustomers.Name = "dataGridViewAllcustomers";
            dataGridViewAllcustomers.RowHeadersWidth = 51;
            dataGridViewAllcustomers.Size = new Size(437, 188);
            dataGridViewAllcustomers.TabIndex = 5;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // ResrvationManagment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 984);
            Controls.Add(groupBox3);
            Controls.Add(dataGridViewSearchResult);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "ResrvationManagment";
            Text = "ResrvationManagment";
            Load += ResrvationManagment_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchResult).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllcustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Button button4;
        private Button button3;
        private Button button1;
        private TextBox numberofpeople;
        private TextBox periodeoftime;
        private TextBox reservationroomnumber;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox customerid;
        private DataGridView dataGridViewSearchResult;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private RadioButton radioButtonAllreservation;
        private RadioButton radioButtoncustomerid;
        private RadioButton radioButtonreservationid;
        private Button Search;
        private Label label1;
        private TextBox textToSearch;
        private GroupBox groupBox2;
        private DataGridView dataGridViewAllcustomers;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}