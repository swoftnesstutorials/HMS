namespace HMS
{
    partial class DoctorForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Doc_ID = new System.Windows.Forms.TextBox();
            this.Doc_Exp = new System.Windows.Forms.TextBox();
            this.Doc_Name = new System.Windows.Forms.TextBox();
            this.Doc_Pass = new System.Windows.Forms.TextBox();
            this.DocPass = new System.Windows.Forms.Label();
            this.DocName = new System.Windows.Forms.Label();
            this.DocExp = new System.Windows.Forms.Label();
            this.DocID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.DoctorGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGV)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(542, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "DOCTOR";
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
            // Doc_ID
            // 
            this.Doc_ID.Location = new System.Drawing.Point(244, 241);
            this.Doc_ID.Multiline = true;
            this.Doc_ID.Name = "Doc_ID";
            this.Doc_ID.Size = new System.Drawing.Size(164, 26);
            this.Doc_ID.TabIndex = 1;
            // 
            // Doc_Exp
            // 
            this.Doc_Exp.Location = new System.Drawing.Point(244, 335);
            this.Doc_Exp.Multiline = true;
            this.Doc_Exp.Name = "Doc_Exp";
            this.Doc_Exp.Size = new System.Drawing.Size(164, 26);
            this.Doc_Exp.TabIndex = 1;
            // 
            // Doc_Name
            // 
            this.Doc_Name.Location = new System.Drawing.Point(244, 288);
            this.Doc_Name.Multiline = true;
            this.Doc_Name.Name = "Doc_Name";
            this.Doc_Name.Size = new System.Drawing.Size(164, 26);
            this.Doc_Name.TabIndex = 1;
            // 
            // Doc_Pass
            // 
            this.Doc_Pass.Location = new System.Drawing.Point(244, 377);
            this.Doc_Pass.Multiline = true;
            this.Doc_Pass.Name = "Doc_Pass";
            this.Doc_Pass.Size = new System.Drawing.Size(164, 26);
            this.Doc_Pass.TabIndex = 1;
            // 
            // DocPass
            // 
            this.DocPass.AutoSize = true;
            this.DocPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocPass.Location = new System.Drawing.Point(31, 378);
            this.DocPass.Name = "DocPass";
            this.DocPass.Size = new System.Drawing.Size(98, 25);
            this.DocPass.TabIndex = 2;
            this.DocPass.Text = "Password";
            // 
            // DocName
            // 
            this.DocName.AutoSize = true;
            this.DocName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocName.Location = new System.Drawing.Point(31, 288);
            this.DocName.Name = "DocName";
            this.DocName.Size = new System.Drawing.Size(132, 25);
            this.DocName.TabIndex = 2;
            this.DocName.Text = "Doctor_Name";
            // 
            // DocExp
            // 
            this.DocExp.AutoSize = true;
            this.DocExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocExp.Location = new System.Drawing.Point(31, 336);
            this.DocExp.Name = "DocExp";
            this.DocExp.Size = new System.Drawing.Size(182, 25);
            this.DocExp.TabIndex = 2;
            this.DocExp.Text = "YearsOfExperiance";
            // 
            // DocID
            // 
            this.DocID.AutoSize = true;
            this.DocID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocID.Location = new System.Drawing.Point(31, 240);
            this.DocID.Name = "DocID";
            this.DocID.Size = new System.Drawing.Size(99, 25);
            this.DocID.TabIndex = 2;
            this.DocID.Text = "Doctor_ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(165, 540);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 65);
            this.button2.TabIndex = 3;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Purple;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(322, 540);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 65);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Purple;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(165, 647);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DoctorGV
            // 
            this.DoctorGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DoctorGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorGV.Location = new System.Drawing.Point(512, 190);
            this.DoctorGV.Name = "DoctorGV";
            this.DoctorGV.RowHeadersWidth = 62;
            this.DoctorGV.RowTemplate.Height = 28;
            this.DoctorGV.Size = new System.Drawing.Size(795, 568);
            this.DoctorGV.TabIndex = 4;
            this.DoctorGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorGV_CellContentClick);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 798);
            this.Controls.Add(this.DoctorGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DocID);
            this.Controls.Add(this.DocExp);
            this.Controls.Add(this.DocName);
            this.Controls.Add(this.DocPass);
            this.Controls.Add(this.Doc_Name);
            this.Controls.Add(this.Doc_Pass);
            this.Controls.Add(this.Doc_Exp);
            this.Controls.Add(this.Doc_ID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Doc_ID;
        private System.Windows.Forms.TextBox Doc_Exp;
        private System.Windows.Forms.TextBox Doc_Name;
        private System.Windows.Forms.TextBox Doc_Pass;
        private System.Windows.Forms.Label DocPass;
        private System.Windows.Forms.Label DocName;
        private System.Windows.Forms.Label DocExp;
        private System.Windows.Forms.Label DocID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView DoctorGV;
    }
}