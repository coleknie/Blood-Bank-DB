namespace lab8
{
    partial class Form_main
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
            this.button_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_sname = new System.Windows.Forms.Label();
            this.label_sid = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_saddr = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.dataGridView_grades = new System.Windows.Forms.DataGridView();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_grades)).BeginInit();
            this.SuspendLayout();
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(520, 29);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(75, 23);
            this.button_logout.TabIndex = 0;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bank Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bank ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // label_sname
            // 
            this.label_sname.AutoSize = true;
            this.label_sname.Location = new System.Drawing.Point(169, 351);
            this.label_sname.Name = "label_sname";
            this.label_sname.Size = new System.Drawing.Size(35, 13);
            this.label_sname.TabIndex = 5;
            this.label_sname.Text = "label5";
            // 
            // label_sid
            // 
            this.label_sid.AutoSize = true;
            this.label_sid.Location = new System.Drawing.Point(169, 316);
            this.label_sid.Name = "label_sid";
            this.label_sid.Size = new System.Drawing.Size(35, 13);
            this.label_sid.TabIndex = 6;
            this.label_sid.Text = "label6";
            this.label_sid.Click += new System.EventHandler(this.label_sid_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Address";
            // 
            // textBox_saddr
            // 
            this.textBox_saddr.Location = new System.Drawing.Point(172, 425);
            this.textBox_saddr.Name = "textBox_saddr";
            this.textBox_saddr.Size = new System.Drawing.Size(365, 20);
            this.textBox_saddr.TabIndex = 8;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(172, 387);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(365, 20);
            this.textBox_phone.TabIndex = 9;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(53, 465);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(158, 23);
            this.button_update.TabIndex = 10;
            this.button_update.Text = "Update Information";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Search Term";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(462, 88);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 13;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // dataGridView_grades
            // 
            this.dataGridView_grades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_grades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_grades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_grades.Location = new System.Drawing.Point(54, 115);
            this.dataGridView_grades.Name = "dataGridView_grades";
            this.dataGridView_grades.Size = new System.Drawing.Size(483, 170);
            this.dataGridView_grades.TabIndex = 14;
            this.dataGridView_grades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_grades_CellContentClick);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(153, 90);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(303, 20);
            this.textBox_name.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Delete Information";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(580, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "MAX";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(580, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "AVG";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(580, 351);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "MIN";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 512);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.dataGridView_grades);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_saddr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_sid);
            this.Controls.Add(this.label_sname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_logout);
            this.Name = "Form_main";
            this.Text = "Blood Bank Information";
            this.Load += new System.EventHandler(this.Form_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_grades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_sname;
        private System.Windows.Forms.Label label_sid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_saddr;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.DataGridView dataGridView_grades;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}