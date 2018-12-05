namespace Applied2
{
    partial class InputControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSelectStartPolicyDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblNumDrivers = new System.Windows.Forms.Label();
            this.spnNumberOfDrivers = new System.Windows.Forms.NumericUpDown();
            this.ddlSelectDriver = new System.Windows.Forms.ComboBox();
            this.lblSelectDriver = new System.Windows.Forms.Label();
            this.lblDriverDetails = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.ddlOccupation = new System.Windows.Forms.ComboBox();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDriverFirstName = new System.Windows.Forms.Label();
            this.lblClaims = new System.Windows.Forms.Label();
            this.txtDisplayClaims = new System.Windows.Forms.RichTextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblClaimDate = new System.Windows.Forms.Label();
            this.dtpClaimDate = new System.Windows.Forms.DateTimePicker();
            this.lblAddClaim = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.MaskedTextBox();
            this.btnDeleteClaim = new System.Windows.Forms.Button();
            this.btnAddClaim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spnNumberOfDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectStartPolicyDate
            // 
            this.lblSelectStartPolicyDate.AutoSize = true;
            this.lblSelectStartPolicyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectStartPolicyDate.Location = new System.Drawing.Point(20, 30);
            this.lblSelectStartPolicyDate.Name = "lblSelectStartPolicyDate";
            this.lblSelectStartPolicyDate.Size = new System.Drawing.Size(147, 13);
            this.lblSelectStartPolicyDate.TabIndex = 97;
            this.lblSelectStartPolicyDate.Text = "Select Policy Start Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(23, 46);
            this.dtpStartDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(196, 20);
            this.dtpStartDate.TabIndex = 96;
            this.dtpStartDate.Value = new System.DateTime(2018, 10, 6, 0, 0, 0, 0);
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // lblNumDrivers
            // 
            this.lblNumDrivers.AutoSize = true;
            this.lblNumDrivers.Location = new System.Drawing.Point(20, 114);
            this.lblNumDrivers.Name = "lblNumDrivers";
            this.lblNumDrivers.Size = new System.Drawing.Size(92, 13);
            this.lblNumDrivers.TabIndex = 95;
            this.lblNumDrivers.Text = "Number of Drivers";
            // 
            // spnNumberOfDrivers
            // 
            this.spnNumberOfDrivers.Location = new System.Drawing.Point(118, 112);
            this.spnNumberOfDrivers.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spnNumberOfDrivers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnNumberOfDrivers.Name = "spnNumberOfDrivers";
            this.spnNumberOfDrivers.Size = new System.Drawing.Size(41, 20);
            this.spnNumberOfDrivers.TabIndex = 94;
            this.spnNumberOfDrivers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spnNumberOfDrivers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnNumberOfDrivers.ValueChanged += new System.EventHandler(this.spnNumberOfDrivers_ValueChanged);
            // 
            // ddlSelectDriver
            // 
            this.ddlSelectDriver.FormattingEnabled = true;
            this.ddlSelectDriver.Items.AddRange(new object[] {
            "Driver 1"});
            this.ddlSelectDriver.Location = new System.Drawing.Point(103, 143);
            this.ddlSelectDriver.MaxDropDownItems = 5;
            this.ddlSelectDriver.Name = "ddlSelectDriver";
            this.ddlSelectDriver.Size = new System.Drawing.Size(116, 21);
            this.ddlSelectDriver.TabIndex = 92;
            this.ddlSelectDriver.SelectedIndexChanged += new System.EventHandler(this.ddlSelectDriver_SelectedIndexChanged);
            // 
            // lblSelectDriver
            // 
            this.lblSelectDriver.AutoSize = true;
            this.lblSelectDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDriver.Location = new System.Drawing.Point(19, 146);
            this.lblSelectDriver.Name = "lblSelectDriver";
            this.lblSelectDriver.Size = new System.Drawing.Size(85, 13);
            this.lblSelectDriver.TabIndex = 91;
            this.lblSelectDriver.Text = "Select Driver:";
            // 
            // lblDriverDetails
            // 
            this.lblDriverDetails.AutoSize = true;
            this.lblDriverDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverDetails.Location = new System.Drawing.Point(20, 87);
            this.lblDriverDetails.Name = "lblDriverDetails";
            this.lblDriverDetails.Size = new System.Drawing.Size(84, 13);
            this.lblDriverDetails.TabIndex = 90;
            this.lblDriverDetails.Text = "Driver Details";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(103, 248);
            this.dtpDOB.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(218, 20);
            this.dtpDOB.TabIndex = 89;
            this.dtpDOB.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(64, 254);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(33, 13);
            this.lblDOB.TabIndex = 88;
            this.lblDOB.Text = "DOB:";
            // 
            // ddlOccupation
            // 
            this.ddlOccupation.DisplayMember = "Test";
            this.ddlOccupation.FormattingEnabled = true;
            this.ddlOccupation.Items.AddRange(new object[] {
            "Select",
            "Chauffeur",
            "Accountant"});
            this.ddlOccupation.Location = new System.Drawing.Point(103, 221);
            this.ddlOccupation.Name = "ddlOccupation";
            this.ddlOccupation.Size = new System.Drawing.Size(218, 21);
            this.ddlOccupation.TabIndex = 87;
            this.ddlOccupation.SelectedIndexChanged += new System.EventHandler(this.ddlOccupation_SelectedIndexChanged);
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(32, 224);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(65, 13);
            this.lblOccupation.TabIndex = 86;
            this.lblOccupation.Text = "Occupation:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(103, 195);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(218, 20);
            this.txtLastName.TabIndex = 84;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(103, 169);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(218, 20);
            this.txtFirstName.TabIndex = 83;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtDriverFirstName_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(37, 198);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 81;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblDriverFirstName
            // 
            this.lblDriverFirstName.AutoSize = true;
            this.lblDriverFirstName.Location = new System.Drawing.Point(37, 172);
            this.lblDriverFirstName.Name = "lblDriverFirstName";
            this.lblDriverFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblDriverFirstName.TabIndex = 80;
            this.lblDriverFirstName.Text = "First Name:";
            // 
            // lblClaims
            // 
            this.lblClaims.AutoSize = true;
            this.lblClaims.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaims.Location = new System.Drawing.Point(327, 31);
            this.lblClaims.Name = "lblClaims";
            this.lblClaims.Size = new System.Drawing.Size(43, 13);
            this.lblClaims.TabIndex = 103;
            this.lblClaims.Text = "Claims";
            // 
            // txtDisplayClaims
            // 
            this.txtDisplayClaims.BackColor = System.Drawing.Color.White;
            this.txtDisplayClaims.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayClaims.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDisplayClaims.Location = new System.Drawing.Point(330, 47);
            this.txtDisplayClaims.Name = "txtDisplayClaims";
            this.txtDisplayClaims.ReadOnly = true;
            this.txtDisplayClaims.Size = new System.Drawing.Size(313, 103);
            this.txtDisplayClaims.TabIndex = 102;
            this.txtDisplayClaims.Text = "";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(360, 196);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(58, 13);
            this.lblAmount.TabIndex = 98;
            this.lblAmount.Text = "Amount $ :";
            // 
            // lblClaimDate
            // 
            this.lblClaimDate.AutoSize = true;
            this.lblClaimDate.Location = new System.Drawing.Point(327, 170);
            this.lblClaimDate.Name = "lblClaimDate";
            this.lblClaimDate.Size = new System.Drawing.Size(91, 13);
            this.lblClaimDate.TabIndex = 99;
            this.lblClaimDate.Text = "Date Claim Made:";
            // 
            // dtpClaimDate
            // 
            this.dtpClaimDate.Location = new System.Drawing.Point(424, 167);
            this.dtpClaimDate.MaxDate = new System.DateTime(2100, 9, 30, 0, 0, 0, 0);
            this.dtpClaimDate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpClaimDate.Name = "dtpClaimDate";
            this.dtpClaimDate.Size = new System.Drawing.Size(213, 20);
            this.dtpClaimDate.TabIndex = 100;
            this.dtpClaimDate.Value = new System.DateTime(2018, 9, 26, 0, 0, 0, 0);
            this.dtpClaimDate.ValueChanged += new System.EventHandler(this.dtpClaimDate_ValueChanged);
            // 
            // lblAddClaim
            // 
            this.lblAddClaim.AutoSize = true;
            this.lblAddClaim.Location = new System.Drawing.Point(327, 153);
            this.lblAddClaim.Name = "lblAddClaim";
            this.lblAddClaim.Size = new System.Drawing.Size(126, 13);
            this.lblAddClaim.TabIndex = 101;
            this.lblAddClaim.Text = "Add a Claim for this driver";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(424, 193);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(111, 20);
            this.txtAmount.TabIndex = 105;
            // 
            // btnDeleteClaim
            // 
            this.btnDeleteClaim.Location = new System.Drawing.Point(497, 245);
            this.btnDeleteClaim.Name = "btnDeleteClaim";
            this.btnDeleteClaim.Size = new System.Drawing.Size(140, 23);
            this.btnDeleteClaim.TabIndex = 106;
            this.btnDeleteClaim.Text = "Remove Previous Claim";
            this.btnDeleteClaim.UseVisualStyleBackColor = true;
            this.btnDeleteClaim.Click += new System.EventHandler(this.btnDeleteClaim_Click);
            // 
            // btnAddClaim
            // 
            this.btnAddClaim.Location = new System.Drawing.Point(541, 190);
            this.btnAddClaim.Name = "btnAddClaim";
            this.btnAddClaim.Size = new System.Drawing.Size(96, 23);
            this.btnAddClaim.TabIndex = 107;
            this.btnAddClaim.Text = "Add Claim";
            this.btnAddClaim.UseVisualStyleBackColor = true;
            this.btnAddClaim.Click += new System.EventHandler(this.btnAddClaim_Click);
            // 
            // InputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddClaim);
            this.Controls.Add(this.btnDeleteClaim);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblClaims);
            this.Controls.Add(this.txtDisplayClaims);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblClaimDate);
            this.Controls.Add(this.dtpClaimDate);
            this.Controls.Add(this.lblAddClaim);
            this.Controls.Add(this.lblSelectStartPolicyDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblNumDrivers);
            this.Controls.Add(this.spnNumberOfDrivers);
            this.Controls.Add(this.ddlSelectDriver);
            this.Controls.Add(this.lblSelectDriver);
            this.Controls.Add(this.lblDriverDetails);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.ddlOccupation);
            this.Controls.Add(this.lblOccupation);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblDriverFirstName);
            this.Name = "InputControl";
            this.Size = new System.Drawing.Size(656, 287);
            ((System.ComponentModel.ISupportInitialize)(this.spnNumberOfDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectStartPolicyDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblNumDrivers;
        private System.Windows.Forms.NumericUpDown spnNumberOfDrivers;
        private System.Windows.Forms.ComboBox ddlSelectDriver;
        private System.Windows.Forms.Label lblSelectDriver;
        private System.Windows.Forms.Label lblDriverDetails;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.ComboBox ddlOccupation;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDriverFirstName;
        private System.Windows.Forms.Label lblClaims;
        private System.Windows.Forms.RichTextBox txtDisplayClaims;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblClaimDate;
        private System.Windows.Forms.DateTimePicker dtpClaimDate;
        private System.Windows.Forms.Label lblAddClaim;
        private System.Windows.Forms.MaskedTextBox txtAmount;
        private System.Windows.Forms.Button btnDeleteClaim;
        private System.Windows.Forms.Button btnAddClaim;
    }
}
