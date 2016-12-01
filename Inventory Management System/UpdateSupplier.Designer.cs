namespace Inventory_Management_System
{
    partial class UpdateSupplier
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
            this.tabUpdateDelete = new System.Windows.Forms.TabControl();
            this.pgUpdateDelete = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtbPhone = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.combMarSt = new System.Windows.Forms.ComboBox();
            this.combGender = new System.Windows.Forms.ComboBox();
            this.txtbSupAddr = new System.Windows.Forms.RichTextBox();
            this.txtbCompAddr = new System.Windows.Forms.RichTextBox();
            this.txtbCntctFname = new System.Windows.Forms.TextBox();
            this.txtbCntctSname = new System.Windows.Forms.TextBox();
            this.txtbCompName = new System.Windows.Forms.TextBox();
            this.txtbSupID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pgSearch = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtbSearch = new System.Windows.Forms.TextBox();
            this.gridSearchSup = new System.Windows.Forms.DataGridView();
            this.new_emp = new System.Windows.Forms.Label();
            this.tabUpdateDelete.SuspendLayout();
            this.pgUpdateDelete.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pgSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchSup)).BeginInit();
            this.SuspendLayout();
            // 
            // tabUpdateDelete
            // 
            this.tabUpdateDelete.Controls.Add(this.pgUpdateDelete);
            this.tabUpdateDelete.Controls.Add(this.pgSearch);
            this.tabUpdateDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabUpdateDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabUpdateDelete.Location = new System.Drawing.Point(0, 52);
            this.tabUpdateDelete.Name = "tabUpdateDelete";
            this.tabUpdateDelete.SelectedIndex = 0;
            this.tabUpdateDelete.Size = new System.Drawing.Size(792, 433);
            this.tabUpdateDelete.TabIndex = 0;
            // 
            // pgUpdateDelete
            // 
            this.pgUpdateDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pgUpdateDelete.Controls.Add(this.groupBox1);
            this.pgUpdateDelete.Location = new System.Drawing.Point(4, 29);
            this.pgUpdateDelete.Name = "pgUpdateDelete";
            this.pgUpdateDelete.Padding = new System.Windows.Forms.Padding(3);
            this.pgUpdateDelete.Size = new System.Drawing.Size(784, 400);
            this.pgUpdateDelete.TabIndex = 0;
            this.pgUpdateDelete.Text = "Update or Delete";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtbPhone);
            this.groupBox1.Controls.Add(this.txtbEmail);
            this.groupBox1.Controls.Add(this.combMarSt);
            this.groupBox1.Controls.Add(this.combGender);
            this.groupBox1.Controls.Add(this.txtbSupAddr);
            this.groupBox1.Controls.Add(this.txtbCompAddr);
            this.groupBox1.Controls.Add(this.txtbCntctFname);
            this.groupBox1.Controls.Add(this.txtbCntctSname);
            this.groupBox1.Controls.Add(this.txtbCompName);
            this.groupBox1.Controls.Add(this.txtbSupID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 389);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suppliers Details";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(593, 329);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 40);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(688, 329);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 40);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(502, 329);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(65, 40);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtbPhone
            // 
            this.txtbPhone.Location = new System.Drawing.Point(564, 166);
            this.txtbPhone.Name = "txtbPhone";
            this.txtbPhone.Size = new System.Drawing.Size(189, 24);
            this.txtbPhone.TabIndex = 19;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(564, 128);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(189, 24);
            this.txtbEmail.TabIndex = 18;
            // 
            // combMarSt
            // 
            this.combMarSt.FormattingEnabled = true;
            this.combMarSt.Location = new System.Drawing.Point(564, 88);
            this.combMarSt.Name = "combMarSt";
            this.combMarSt.Size = new System.Drawing.Size(189, 26);
            this.combMarSt.TabIndex = 17;
            // 
            // combGender
            // 
            this.combGender.FormattingEnabled = true;
            this.combGender.Location = new System.Drawing.Point(564, 54);
            this.combGender.Name = "combGender";
            this.combGender.Size = new System.Drawing.Size(189, 26);
            this.combGender.TabIndex = 16;
            // 
            // txtbSupAddr
            // 
            this.txtbSupAddr.Location = new System.Drawing.Point(187, 264);
            this.txtbSupAddr.Name = "txtbSupAddr";
            this.txtbSupAddr.Size = new System.Drawing.Size(566, 38);
            this.txtbSupAddr.TabIndex = 15;
            this.txtbSupAddr.Text = "";
            // 
            // txtbCompAddr
            // 
            this.txtbCompAddr.Location = new System.Drawing.Point(187, 212);
            this.txtbCompAddr.Name = "txtbCompAddr";
            this.txtbCompAddr.Size = new System.Drawing.Size(566, 36);
            this.txtbCompAddr.TabIndex = 14;
            this.txtbCompAddr.Text = "";
            // 
            // txtbCntctFname
            // 
            this.txtbCntctFname.Location = new System.Drawing.Point(187, 167);
            this.txtbCntctFname.Name = "txtbCntctFname";
            this.txtbCntctFname.Size = new System.Drawing.Size(215, 24);
            this.txtbCntctFname.TabIndex = 13;
            // 
            // txtbCntctSname
            // 
            this.txtbCntctSname.Location = new System.Drawing.Point(187, 128);
            this.txtbCntctSname.Name = "txtbCntctSname";
            this.txtbCntctSname.Size = new System.Drawing.Size(215, 24);
            this.txtbCntctSname.TabIndex = 12;
            // 
            // txtbCompName
            // 
            this.txtbCompName.Location = new System.Drawing.Point(187, 90);
            this.txtbCompName.Name = "txtbCompName";
            this.txtbCompName.Size = new System.Drawing.Size(215, 24);
            this.txtbCompName.TabIndex = 11;
            // 
            // txtbSupID
            // 
            this.txtbSupID.BackColor = System.Drawing.Color.PowderBlue;
            this.txtbSupID.Location = new System.Drawing.Point(187, 54);
            this.txtbSupID.Name = "txtbSupID";
            this.txtbSupID.ReadOnly = true;
            this.txtbSupID.Size = new System.Drawing.Size(215, 24);
            this.txtbSupID.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Suppliers Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(451, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Phone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Marital Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Company Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suppliers ID";
            // 
            // pgSearch
            // 
            this.pgSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pgSearch.Controls.Add(this.label11);
            this.pgSearch.Controls.Add(this.btnSearch);
            this.pgSearch.Controls.Add(this.txtbSearch);
            this.pgSearch.Controls.Add(this.gridSearchSup);
            this.pgSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgSearch.Location = new System.Drawing.Point(4, 29);
            this.pgSearch.Name = "pgSearch";
            this.pgSearch.Padding = new System.Windows.Forms.Padding(3);
            this.pgSearch.Size = new System.Drawing.Size(784, 400);
            this.pgSearch.TabIndex = 1;
            this.pgSearch.Text = "Search Supplier";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(307, 16);
            this.label11.TabIndex = 46;
            this.label11.Text = "Enter either employee name or ID to search";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(360, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 25);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtbSearch
            // 
            this.txtbSearch.BackColor = System.Drawing.Color.PowderBlue;
            this.txtbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSearch.Location = new System.Drawing.Point(36, 42);
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.Size = new System.Drawing.Size(276, 26);
            this.txtbSearch.TabIndex = 44;
            this.txtbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbSearch_KeyDown);
            // 
            // gridSearchSup
            // 
            this.gridSearchSup.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridSearchSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSearchSup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridSearchSup.Location = new System.Drawing.Point(3, 76);
            this.gridSearchSup.Name = "gridSearchSup";
            this.gridSearchSup.RowHeadersVisible = false;
            this.gridSearchSup.Size = new System.Drawing.Size(778, 321);
            this.gridSearchSup.TabIndex = 0;
            this.gridSearchSup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSearchSup_CellContentClick);
            // 
            // new_emp
            // 
            this.new_emp.AutoSize = true;
            this.new_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_emp.Location = new System.Drawing.Point(225, 9);
            this.new_emp.Name = "new_emp";
            this.new_emp.Size = new System.Drawing.Size(331, 25);
            this.new_emp.TabIndex = 42;
            this.new_emp.Text = "Update or Delete Supplier Details";
            // 
            // UpdateSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(792, 485);
            this.Controls.Add(this.new_emp);
            this.Controls.Add(this.tabUpdateDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Supplier Form";
            this.Load += new System.EventHandler(this.UpdateSupplier_Load);
            this.tabUpdateDelete.ResumeLayout(false);
            this.pgUpdateDelete.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pgSearch.ResumeLayout(false);
            this.pgSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchSup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabUpdateDelete;
        private System.Windows.Forms.TabPage pgUpdateDelete;
        private System.Windows.Forms.TabPage pgSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtbPhone;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.ComboBox combMarSt;
        private System.Windows.Forms.ComboBox combGender;
        private System.Windows.Forms.RichTextBox txtbSupAddr;
        private System.Windows.Forms.RichTextBox txtbCompAddr;
        private System.Windows.Forms.TextBox txtbCntctFname;
        private System.Windows.Forms.TextBox txtbCntctSname;
        private System.Windows.Forms.TextBox txtbCompName;
        private System.Windows.Forms.TextBox txtbSupID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridSearchSup;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtbSearch;
        private System.Windows.Forms.Label new_emp;
    }
}