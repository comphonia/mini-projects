namespace AKW.Banking.UI
{
    partial class frmBanking
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.dgvdeposit = new System.Windows.Forms.DataGridView();
            this.btnHistory = new System.Windows.Forms.Button();
            this.dgvwithdrawl = new System.Windows.Forms.DataGridView();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnWriteToFile = new System.Windows.Forms.Button();
            this.btnDeposits = new System.Windows.Forms.Button();
            this.btnWithdrawls = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwithdrawl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SSN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "BirthDate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID:";
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(278, 29);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(100, 20);
            this.txtSSN.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(278, 55);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(278, 81);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 8;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(278, 133);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(100, 20);
            this.txtBirthDate.TabIndex = 9;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(278, 107);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 10;
            // 
            // dgvdeposit
            // 
            this.dgvdeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdeposit.Location = new System.Drawing.Point(12, 253);
            this.dgvdeposit.Name = "dgvdeposit";
            this.dgvdeposit.Size = new System.Drawing.Size(403, 150);
            this.dgvdeposit.TabIndex = 12;
            this.dgvdeposit.SelectionChanged += new System.EventHandler(this.dgvdeposit_SelectionChanged);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(2, 580);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(75, 23);
            this.btnHistory.TabIndex = 13;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click_1);
            // 
            // dgvwithdrawl
            // 
            this.dgvwithdrawl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwithdrawl.Location = new System.Drawing.Point(12, 424);
            this.dgvwithdrawl.Name = "dgvwithdrawl";
            this.dgvwithdrawl.Size = new System.Drawing.Size(403, 150);
            this.dgvwithdrawl.TabIndex = 16;
            this.dgvwithdrawl.SelectionChanged += new System.EventHandler(this.dgvwithdrawl_SelectionChanged);
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.Location = new System.Drawing.Point(15, 15);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(168, 134);
            this.lstNames.TabIndex = 17;
            this.lstNames.SelectedIndexChanged += new System.EventHandler(this.lstNames_SelectedIndexChanged);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(15, 170);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 18;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(96, 170);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(177, 170);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(96, 199);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnWriteToFile
            // 
            this.btnWriteToFile.Location = new System.Drawing.Point(177, 199);
            this.btnWriteToFile.Name = "btnWriteToFile";
            this.btnWriteToFile.Size = new System.Drawing.Size(75, 23);
            this.btnWriteToFile.TabIndex = 22;
            this.btnWriteToFile.Text = "Write To File";
            this.btnWriteToFile.UseVisualStyleBackColor = true;
            this.btnWriteToFile.Click += new System.EventHandler(this.btnWriteToFile_Click);
            // 
            // btnDeposits
            // 
            this.btnDeposits.Location = new System.Drawing.Point(221, 597);
            this.btnDeposits.Name = "btnDeposits";
            this.btnDeposits.Size = new System.Drawing.Size(75, 23);
            this.btnDeposits.TabIndex = 23;
            this.btnDeposits.Text = "Deposits";
            this.btnDeposits.UseVisualStyleBackColor = true;
            // 
            // btnWithdrawls
            // 
            this.btnWithdrawls.Location = new System.Drawing.Point(302, 597);
            this.btnWithdrawls.Name = "btnWithdrawls";
            this.btnWithdrawls.Size = new System.Drawing.Size(75, 23);
            this.btnWithdrawls.TabIndex = 24;
            this.btnWithdrawls.Text = "Withdrawls";
            this.btnWithdrawls.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(383, 597);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Deposits";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Withdrawls";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(275, 9);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(13, 13);
            this.lblid.TabIndex = 28;
            this.lblid.Text = "0";
            // 
            // frmBanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 689);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnWithdrawls);
            this.Controls.Add(this.btnDeposits);
            this.Controls.Add(this.btnWriteToFile);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.dgvwithdrawl);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.dgvdeposit);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBanking";
            this.Text = "Banking";
            this.Load += new System.EventHandler(this.frmBanking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwithdrawl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.DataGridView dgvdeposit;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.DataGridView dgvwithdrawl;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnWriteToFile;
        private System.Windows.Forms.Button btnDeposits;
        private System.Windows.Forms.Button btnWithdrawls;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblid;
    }
}

