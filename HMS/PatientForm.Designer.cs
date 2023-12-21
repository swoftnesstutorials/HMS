namespace HMS
{
    partial class PatientForm
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
            this.Pat_ID = new System.Windows.Forms.Label();
            this.Pat_Address = new System.Windows.Forms.Label();
            this.Pat_Name = new System.Windows.Forms.Label();
            this.Pat_Phone = new System.Windows.Forms.Label();
            this.PatName = new System.Windows.Forms.TextBox();
            this.PatAge = new System.Windows.Forms.TextBox();
            this.PatAddress = new System.Windows.Forms.TextBox();
            this.PatID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.PatientGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Pat_Age = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PatPhone = new System.Windows.Forms.TextBox();
            this.PatBload = new System.Windows.Forms.ComboBox();
            this.PatGender = new System.Windows.Forms.ComboBox();
            this.PatDisease = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Pat_ID
            // 
            this.Pat_ID.AutoSize = true;
            this.Pat_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pat_ID.Location = new System.Drawing.Point(12, 143);
            this.Pat_ID.Name = "Pat_ID";
            this.Pat_ID.Size = new System.Drawing.Size(96, 25);
            this.Pat_ID.TabIndex = 7;
            this.Pat_ID.Text = "Patient ID";
            // 
            // Pat_Address
            // 
            this.Pat_Address.AutoSize = true;
            this.Pat_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pat_Address.Location = new System.Drawing.Point(12, 228);
            this.Pat_Address.Name = "Pat_Address";
            this.Pat_Address.Size = new System.Drawing.Size(145, 25);
            this.Pat_Address.TabIndex = 8;
            this.Pat_Address.Text = "PatientAddress";
            // 
            // Pat_Name
            // 
            this.Pat_Name.AutoSize = true;
            this.Pat_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pat_Name.Location = new System.Drawing.Point(12, 184);
            this.Pat_Name.Name = "Pat_Name";
            this.Pat_Name.Size = new System.Drawing.Size(129, 25);
            this.Pat_Name.TabIndex = 9;
            this.Pat_Name.Text = "Patient Name";
            this.Pat_Name.Click += new System.EventHandler(this.Pat_Name_Click);
            // 
            // Pat_Phone
            // 
            this.Pat_Phone.AutoSize = true;
            this.Pat_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pat_Phone.Location = new System.Drawing.Point(12, 263);
            this.Pat_Phone.Name = "Pat_Phone";
            this.Pat_Phone.Size = new System.Drawing.Size(129, 25);
            this.Pat_Phone.TabIndex = 10;
            this.Pat_Phone.Text = "PatientPhone";
            this.Pat_Phone.Click += new System.EventHandler(this.Pat_Phone_Click);
            // 
            // PatName
            // 
            this.PatName.Location = new System.Drawing.Point(225, 183);
            this.PatName.Multiline = true;
            this.PatName.Name = "PatName";
            this.PatName.Size = new System.Drawing.Size(164, 26);
            this.PatName.TabIndex = 3;
            // 
            // PatAge
            // 
            this.PatAge.Location = new System.Drawing.Point(225, 298);
            this.PatAge.Multiline = true;
            this.PatAge.Name = "PatAge";
            this.PatAge.Size = new System.Drawing.Size(164, 26);
            this.PatAge.TabIndex = 4;
            // 
            // PatAddress
            // 
            this.PatAddress.Location = new System.Drawing.Point(225, 227);
            this.PatAddress.Multiline = true;
            this.PatAddress.Name = "PatAddress";
            this.PatAddress.Size = new System.Drawing.Size(164, 26);
            this.PatAddress.TabIndex = 5;
            // 
            // PatID
            // 
            this.PatID.Location = new System.Drawing.Point(225, 142);
            this.PatID.Multiline = true;
            this.PatID.Name = "PatID";
            this.PatID.Size = new System.Drawing.Size(164, 26);
            this.PatID.TabIndex = 6;
            this.PatID.TextChanged += new System.EventHandler(this.PatID_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1330, 114);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(551, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "PATIENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(828, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Purple;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 567);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 65);
            this.button3.TabIndex = 12;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PatientGV
            // 
            this.PatientGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.PatientGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientGV.Location = new System.Drawing.Point(469, 192);
            this.PatientGV.Name = "PatientGV";
            this.PatientGV.RowHeadersWidth = 62;
            this.PatientGV.RowTemplate.Height = 28;
            this.PatientGV.Size = new System.Drawing.Size(834, 547);
            this.PatientGV.TabIndex = 13;
            this.PatientGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientGV_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(299, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 65);
            this.button1.TabIndex = 14;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(141, 567);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 65);
            this.button2.TabIndex = 15;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Purple;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(141, 674);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 65);
            this.button4.TabIndex = 16;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Pat_Age
            // 
            this.Pat_Age.AutoSize = true;
            this.Pat_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pat_Age.Location = new System.Drawing.Point(12, 299);
            this.Pat_Age.Name = "Pat_Age";
            this.Pat_Age.Size = new System.Drawing.Size(108, 25);
            this.Pat_Age.TabIndex = 10;
            this.Pat_Age.Text = "PatientAge";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 502);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "MijorDisease";
            // 
            // PatPhone
            // 
            this.PatPhone.Location = new System.Drawing.Point(225, 262);
            this.PatPhone.Multiline = true;
            this.PatPhone.Name = "PatPhone";
            this.PatPhone.Size = new System.Drawing.Size(164, 26);
            this.PatPhone.TabIndex = 4;
            // 
            // PatBload
            // 
            this.PatBload.FormattingEnabled = true;
            this.PatBload.Items.AddRange(new object[] {
            "A+",
            "O+",
            "B+",
            "AB+",
            "A-",
            "B-",
            "AB-",
            "O-"});
            this.PatBload.Location = new System.Drawing.Point(17, 467);
            this.PatBload.Name = "PatBload";
            this.PatBload.Size = new System.Drawing.Size(372, 28);
            this.PatBload.TabIndex = 17;
            this.PatBload.Text = "BloadGroup";
            this.PatBload.SelectedIndexChanged += new System.EventHandler(this.PatBload_SelectedIndexChanged);
            // 
            // PatGender
            // 
            this.PatGender.FormattingEnabled = true;
            this.PatGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PatGender.Location = new System.Drawing.Point(17, 433);
            this.PatGender.Name = "PatGender";
            this.PatGender.Size = new System.Drawing.Size(372, 28);
            this.PatGender.TabIndex = 17;
            this.PatGender.Text = "Gender";
            this.PatGender.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // PatDisease
            // 
            this.PatDisease.Location = new System.Drawing.Point(225, 501);
            this.PatDisease.Multiline = true;
            this.PatDisease.Name = "PatDisease";
            this.PatDisease.Size = new System.Drawing.Size(164, 26);
            this.PatDisease.TabIndex = 4;
            this.PatDisease.TextChanged += new System.EventHandler(this.PatDisease_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(551, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 46);
            this.label9.TabIndex = 0;
            this.label9.Text = "Patient List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "DoctorName";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 332);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 26);
            this.textBox1.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(189, 363);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Date";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "8:00AM-9:00AM",
            "9:30AM-10:00AM",
            "10:30AM-11:30AM",
            "1:00PM-2:00PM",
            "2:00PM-3:00PM"});
            this.comboBox1.Location = new System.Drawing.Point(17, 399);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(372, 28);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Text = "Time";
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 798);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PatGender);
            this.Controls.Add(this.PatBload);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PatientGV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pat_ID);
            this.Controls.Add(this.Pat_Address);
            this.Controls.Add(this.Pat_Name);
            this.Controls.Add(this.Pat_Age);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Pat_Phone);
            this.Controls.Add(this.PatName);
            this.Controls.Add(this.PatPhone);
            this.Controls.Add(this.PatDisease);
            this.Controls.Add(this.PatAge);
            this.Controls.Add(this.PatAddress);
            this.Controls.Add(this.PatID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pat_ID;
        private System.Windows.Forms.Label Pat_Address;
        private System.Windows.Forms.Label Pat_Name;
        private System.Windows.Forms.Label Pat_Phone;
        private System.Windows.Forms.TextBox PatName;
        private System.Windows.Forms.TextBox PatAge;
        private System.Windows.Forms.TextBox PatAddress;
        private System.Windows.Forms.TextBox PatID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView PatientGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Pat_Age;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PatPhone;
        private System.Windows.Forms.ComboBox PatBload;
        private System.Windows.Forms.ComboBox PatGender;
        private System.Windows.Forms.TextBox PatDisease;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}