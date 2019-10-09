namespace MildAtlanticBusTours
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.formTitle = new System.Windows.Forms.Label();
            this.driverLevelEntriesPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.fullFareRidersLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.discountRiders = new System.Windows.Forms.TextBox();
            this.driversName = new System.Windows.Forms.TextBox();
            this.studentRidersLabel = new System.Windows.Forms.Label();
            this.studentRiders = new System.Windows.Forms.TextBox();
            this.discountRidersLabel = new System.Windows.Forms.Label();
            this.fullFareRiders = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.summary = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.driverSummaryDataGroupBox = new System.Windows.Forms.GroupBox();
            this.averagePassengerReceiptLabel = new System.Windows.Forms.Label();
            this.totalrecieptsLabel = new System.Windows.Forms.Label();
            this.totalPassengersLabel = new System.Windows.Forms.Label();
            this.driverNameLabel = new System.Windows.Forms.Label();
            this.driverAvgPassengerReceipt = new System.Windows.Forms.Label();
            this.driverTotalReceipt = new System.Windows.Forms.Label();
            this.driverTotalPassenger = new System.Windows.Forms.Label();
            this.driverName = new System.Windows.Forms.Label();
            this.companySummaryDataGroupBox = new System.Windows.Forms.GroupBox();
            this.companyAveragePassengerReceiptLabel = new System.Windows.Forms.Label();
            this.companyTotalReceiptsLabel = new System.Windows.Forms.Label();
            this.companyTotalPassengersLabel = new System.Windows.Forms.Label();
            this.companyTotalDriversLabel = new System.Windows.Forms.Label();
            this.companyAvgPassengerReciept = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comapnyTotalPassengers = new System.Windows.Forms.Label();
            this.totalDrivers = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.driverLevelEntriesPanel.SuspendLayout();
            this.driverSummaryDataGroupBox.SuspendLayout();
            this.companySummaryDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.Location = new System.Drawing.Point(208, 37);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(304, 32);
            this.formTitle.TabIndex = 0;
            this.formTitle.Text = "Daily Tours Summary";
            // 
            // driverLevelEntriesPanel
            // 
            this.driverLevelEntriesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.driverLevelEntriesPanel.Controls.Add(this.label1);
            this.driverLevelEntriesPanel.Controls.Add(this.fullFareRidersLabel);
            this.driverLevelEntriesPanel.Controls.Add(this.nameLabel);
            this.driverLevelEntriesPanel.Controls.Add(this.discountRiders);
            this.driverLevelEntriesPanel.Controls.Add(this.driversName);
            this.driverLevelEntriesPanel.Controls.Add(this.studentRidersLabel);
            this.driverLevelEntriesPanel.Controls.Add(this.studentRiders);
            this.driverLevelEntriesPanel.Controls.Add(this.discountRidersLabel);
            this.driverLevelEntriesPanel.Controls.Add(this.fullFareRiders);
            this.driverLevelEntriesPanel.Location = new System.Drawing.Point(126, 94);
            this.driverLevelEntriesPanel.Name = "driverLevelEntriesPanel";
            this.driverLevelEntriesPanel.Size = new System.Drawing.Size(448, 215);
            this.driverLevelEntriesPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(55, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 1);
            this.label1.TabIndex = 5;
            // 
            // fullFareRidersLabel
            // 
            this.fullFareRidersLabel.AutoSize = true;
            this.fullFareRidersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullFareRidersLabel.Location = new System.Drawing.Point(105, 78);
            this.fullFareRidersLabel.Name = "fullFareRidersLabel";
            this.fullFareRidersLabel.Size = new System.Drawing.Size(137, 20);
            this.fullFareRidersLabel.TabIndex = 4;
            this.fullFareRidersLabel.Text = "Full Fare Riders";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(69, 27);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(116, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Drivers Name";
            // 
            // discountRiders
            // 
            this.discountRiders.Location = new System.Drawing.Point(293, 165);
            this.discountRiders.Name = "discountRiders";
            this.discountRiders.Size = new System.Drawing.Size(67, 26);
            this.discountRiders.TabIndex = 3;
            this.discountRiders.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // driversName
            // 
            this.driversName.Location = new System.Drawing.Point(222, 24);
            this.driversName.Name = "driversName";
            this.driversName.Size = new System.Drawing.Size(172, 26);
            this.driversName.TabIndex = 0;
            this.driversName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // studentRidersLabel
            // 
            this.studentRidersLabel.AutoSize = true;
            this.studentRidersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentRidersLabel.Location = new System.Drawing.Point(105, 124);
            this.studentRidersLabel.Name = "studentRidersLabel";
            this.studentRidersLabel.Size = new System.Drawing.Size(130, 20);
            this.studentRidersLabel.TabIndex = 3;
            this.studentRidersLabel.Text = "Student Riders";
            // 
            // studentRiders
            // 
            this.studentRiders.Location = new System.Drawing.Point(293, 118);
            this.studentRiders.Name = "studentRiders";
            this.studentRiders.Size = new System.Drawing.Size(67, 26);
            this.studentRiders.TabIndex = 2;
            this.studentRiders.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // discountRidersLabel
            // 
            this.discountRidersLabel.AutoSize = true;
            this.discountRidersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountRidersLabel.Location = new System.Drawing.Point(104, 171);
            this.discountRidersLabel.Name = "discountRidersLabel";
            this.discountRidersLabel.Size = new System.Drawing.Size(137, 20);
            this.discountRidersLabel.TabIndex = 2;
            this.discountRidersLabel.Text = "Discount Riders";
            // 
            // fullFareRiders
            // 
            this.fullFareRiders.Location = new System.Drawing.Point(293, 72);
            this.fullFareRiders.Name = "fullFareRiders";
            this.fullFareRiders.Size = new System.Drawing.Size(67, 26);
            this.fullFareRiders.TabIndex = 1;
            this.fullFareRiders.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.SystemColors.Info;
            this.calculate.ForeColor = System.Drawing.SystemColors.MenuText;
            this.calculate.Location = new System.Drawing.Point(126, 342);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(89, 49);
            this.calculate.TabIndex = 1;
            this.calculate.Text = "C&alculate";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.Info;
            this.clear.Location = new System.Drawing.Point(247, 342);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(89, 49);
            this.clear.TabIndex = 2;
            this.clear.Text = "&Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // summary
            // 
            this.summary.BackColor = System.Drawing.SystemColors.Info;
            this.summary.Enabled = false;
            this.summary.Location = new System.Drawing.Point(360, 342);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(94, 49);
            this.summary.TabIndex = 3;
            this.summary.Text = "&Summary";
            this.toolTip1.SetToolTip(this.summary, "Press for Company Summary Data");
            this.summary.UseVisualStyleBackColor = false;
            this.summary.Click += new System.EventHandler(this.Summary_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.Info;
            this.exit.Location = new System.Drawing.Point(480, 342);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(94, 49);
            this.exit.TabIndex = 4;
            this.exit.Text = "E&xit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // driverSummaryDataGroupBox
            // 
            this.driverSummaryDataGroupBox.Controls.Add(this.averagePassengerReceiptLabel);
            this.driverSummaryDataGroupBox.Controls.Add(this.totalrecieptsLabel);
            this.driverSummaryDataGroupBox.Controls.Add(this.totalPassengersLabel);
            this.driverSummaryDataGroupBox.Controls.Add(this.driverNameLabel);
            this.driverSummaryDataGroupBox.Controls.Add(this.driverAvgPassengerReceipt);
            this.driverSummaryDataGroupBox.Controls.Add(this.driverTotalReceipt);
            this.driverSummaryDataGroupBox.Controls.Add(this.driverTotalPassenger);
            this.driverSummaryDataGroupBox.Controls.Add(this.driverName);
            this.driverSummaryDataGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverSummaryDataGroupBox.Location = new System.Drawing.Point(126, 431);
            this.driverSummaryDataGroupBox.Name = "driverSummaryDataGroupBox";
            this.driverSummaryDataGroupBox.Size = new System.Drawing.Size(448, 207);
            this.driverSummaryDataGroupBox.TabIndex = 7;
            this.driverSummaryDataGroupBox.TabStop = false;
            this.driverSummaryDataGroupBox.Text = "Driver Summary Data";
            // 
            // averagePassengerReceiptLabel
            // 
            this.averagePassengerReceiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averagePassengerReceiptLabel.Location = new System.Drawing.Point(284, 158);
            this.averagePassengerReceiptLabel.Name = "averagePassengerReceiptLabel";
            this.averagePassengerReceiptLabel.Size = new System.Drawing.Size(93, 25);
            this.averagePassengerReceiptLabel.TabIndex = 12;
            // 
            // totalrecieptsLabel
            // 
            this.totalrecieptsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalrecieptsLabel.Location = new System.Drawing.Point(284, 118);
            this.totalrecieptsLabel.Name = "totalrecieptsLabel";
            this.totalrecieptsLabel.Size = new System.Drawing.Size(93, 25);
            this.totalrecieptsLabel.TabIndex = 11;
            // 
            // totalPassengersLabel
            // 
            this.totalPassengersLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPassengersLabel.Location = new System.Drawing.Point(284, 78);
            this.totalPassengersLabel.Name = "totalPassengersLabel";
            this.totalPassengersLabel.Size = new System.Drawing.Size(93, 25);
            this.totalPassengersLabel.TabIndex = 10;
            // 
            // driverNameLabel
            // 
            this.driverNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.driverNameLabel.Location = new System.Drawing.Point(284, 42);
            this.driverNameLabel.Name = "driverNameLabel";
            this.driverNameLabel.Size = new System.Drawing.Size(93, 25);
            this.driverNameLabel.TabIndex = 9;
            // 
            // driverAvgPassengerReceipt
            // 
            this.driverAvgPassengerReceipt.AutoSize = true;
            this.driverAvgPassengerReceipt.Location = new System.Drawing.Point(52, 163);
            this.driverAvgPassengerReceipt.Margin = new System.Windows.Forms.Padding(3);
            this.driverAvgPassengerReceipt.Name = "driverAvgPassengerReceipt";
            this.driverAvgPassengerReceipt.Size = new System.Drawing.Size(196, 20);
            this.driverAvgPassengerReceipt.TabIndex = 7;
            this.driverAvgPassengerReceipt.Text = "Avg Passenger Receipt";
            // 
            // driverTotalReceipt
            // 
            this.driverTotalReceipt.AutoSize = true;
            this.driverTotalReceipt.Location = new System.Drawing.Point(52, 123);
            this.driverTotalReceipt.Margin = new System.Windows.Forms.Padding(3);
            this.driverTotalReceipt.Name = "driverTotalReceipt";
            this.driverTotalReceipt.Size = new System.Drawing.Size(125, 20);
            this.driverTotalReceipt.TabIndex = 6;
            this.driverTotalReceipt.Text = "Total Receipts";
            // 
            // driverTotalPassenger
            // 
            this.driverTotalPassenger.AutoSize = true;
            this.driverTotalPassenger.Location = new System.Drawing.Point(52, 83);
            this.driverTotalPassenger.Margin = new System.Windows.Forms.Padding(3);
            this.driverTotalPassenger.Name = "driverTotalPassenger";
            this.driverTotalPassenger.Size = new System.Drawing.Size(148, 20);
            this.driverTotalPassenger.TabIndex = 5;
            this.driverTotalPassenger.Text = "Total Passengers";
            // 
            // driverName
            // 
            this.driverName.AutoSize = true;
            this.driverName.Location = new System.Drawing.Point(52, 42);
            this.driverName.Margin = new System.Windows.Forms.Padding(3);
            this.driverName.Name = "driverName";
            this.driverName.Size = new System.Drawing.Size(107, 20);
            this.driverName.TabIndex = 8;
            this.driverName.Text = "Driver Name";
            // 
            // companySummaryDataGroupBox
            // 
            this.companySummaryDataGroupBox.Controls.Add(this.companyAveragePassengerReceiptLabel);
            this.companySummaryDataGroupBox.Controls.Add(this.companyTotalReceiptsLabel);
            this.companySummaryDataGroupBox.Controls.Add(this.companyTotalPassengersLabel);
            this.companySummaryDataGroupBox.Controls.Add(this.companyTotalDriversLabel);
            this.companySummaryDataGroupBox.Controls.Add(this.companyAvgPassengerReciept);
            this.companySummaryDataGroupBox.Controls.Add(this.label10);
            this.companySummaryDataGroupBox.Controls.Add(this.comapnyTotalPassengers);
            this.companySummaryDataGroupBox.Controls.Add(this.totalDrivers);
            this.companySummaryDataGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companySummaryDataGroupBox.Location = new System.Drawing.Point(126, 431);
            this.companySummaryDataGroupBox.Name = "companySummaryDataGroupBox";
            this.companySummaryDataGroupBox.Size = new System.Drawing.Size(448, 207);
            this.companySummaryDataGroupBox.TabIndex = 8;
            this.companySummaryDataGroupBox.TabStop = false;
            this.companySummaryDataGroupBox.Text = "Company Summary Data";
            // 
            // companyAveragePassengerReceiptLabel
            // 
            this.companyAveragePassengerReceiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyAveragePassengerReceiptLabel.Location = new System.Drawing.Point(294, 156);
            this.companyAveragePassengerReceiptLabel.Name = "companyAveragePassengerReceiptLabel";
            this.companyAveragePassengerReceiptLabel.Size = new System.Drawing.Size(93, 25);
            this.companyAveragePassengerReceiptLabel.TabIndex = 12;
            // 
            // companyTotalReceiptsLabel
            // 
            this.companyTotalReceiptsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyTotalReceiptsLabel.Location = new System.Drawing.Point(294, 119);
            this.companyTotalReceiptsLabel.Name = "companyTotalReceiptsLabel";
            this.companyTotalReceiptsLabel.Size = new System.Drawing.Size(93, 25);
            this.companyTotalReceiptsLabel.TabIndex = 11;
            // 
            // companyTotalPassengersLabel
            // 
            this.companyTotalPassengersLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyTotalPassengersLabel.Location = new System.Drawing.Point(294, 78);
            this.companyTotalPassengersLabel.Name = "companyTotalPassengersLabel";
            this.companyTotalPassengersLabel.Size = new System.Drawing.Size(93, 25);
            this.companyTotalPassengersLabel.TabIndex = 10;
            // 
            // companyTotalDriversLabel
            // 
            this.companyTotalDriversLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyTotalDriversLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.companyTotalDriversLabel.Location = new System.Drawing.Point(294, 35);
            this.companyTotalDriversLabel.Name = "companyTotalDriversLabel";
            this.companyTotalDriversLabel.Size = new System.Drawing.Size(93, 25);
            this.companyTotalDriversLabel.TabIndex = 9;
            // 
            // companyAvgPassengerReciept
            // 
            this.companyAvgPassengerReciept.AutoSize = true;
            this.companyAvgPassengerReciept.Location = new System.Drawing.Point(61, 161);
            this.companyAvgPassengerReciept.Name = "companyAvgPassengerReciept";
            this.companyAvgPassengerReciept.Size = new System.Drawing.Size(196, 20);
            this.companyAvgPassengerReciept.TabIndex = 7;
            this.companyAvgPassengerReciept.Text = "Avg Passenger Receipt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Total Receipts";
            // 
            // comapnyTotalPassengers
            // 
            this.comapnyTotalPassengers.AutoSize = true;
            this.comapnyTotalPassengers.Location = new System.Drawing.Point(58, 86);
            this.comapnyTotalPassengers.Name = "comapnyTotalPassengers";
            this.comapnyTotalPassengers.Size = new System.Drawing.Size(148, 20);
            this.comapnyTotalPassengers.TabIndex = 5;
            this.comapnyTotalPassengers.Text = "Total Passengers";
            // 
            // totalDrivers
            // 
            this.totalDrivers.AutoSize = true;
            this.totalDrivers.Location = new System.Drawing.Point(58, 45);
            this.totalDrivers.Name = "totalDrivers";
            this.totalDrivers.Size = new System.Drawing.Size(110, 20);
            this.totalDrivers.TabIndex = 8;
            this.totalDrivers.Text = "Total Drivers";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.companySummaryDataGroupBox);
            this.Controls.Add(this.driverSummaryDataGroupBox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.driverLevelEntriesPanel);
            this.Controls.Add(this.formTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Mild Atlantic Bus Tours";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.driverLevelEntriesPanel.ResumeLayout(false);
            this.driverLevelEntriesPanel.PerformLayout();
            this.driverSummaryDataGroupBox.ResumeLayout(false);
            this.driverSummaryDataGroupBox.PerformLayout();
            this.companySummaryDataGroupBox.ResumeLayout(false);
            this.companySummaryDataGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CompanyTotalDriversLabel_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Panel driverLevelEntriesPanel;
        private System.Windows.Forms.TextBox discountRiders;
        private System.Windows.Forms.TextBox studentRiders;
        private System.Windows.Forms.TextBox fullFareRiders;
        private System.Windows.Forms.Label discountRidersLabel;
        private System.Windows.Forms.Label studentRidersLabel;
        private System.Windows.Forms.Label fullFareRidersLabel;
        private System.Windows.Forms.TextBox driversName;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button summary;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox driverSummaryDataGroupBox;
        private System.Windows.Forms.Label driverAvgPassengerReceipt;
        private System.Windows.Forms.Label driverTotalReceipt;
        private System.Windows.Forms.Label driverTotalPassenger;
        private System.Windows.Forms.Label driverName;
        private System.Windows.Forms.Label averagePassengerReceiptLabel;
        private System.Windows.Forms.Label totalrecieptsLabel;
        private System.Windows.Forms.Label totalPassengersLabel;
        private System.Windows.Forms.Label driverNameLabel;
        private System.Windows.Forms.GroupBox companySummaryDataGroupBox;
        private System.Windows.Forms.Label companyAveragePassengerReceiptLabel;
        private System.Windows.Forms.Label companyTotalReceiptsLabel;
        private System.Windows.Forms.Label companyTotalPassengersLabel;
        private System.Windows.Forms.Label companyTotalDriversLabel;
        private System.Windows.Forms.Label companyAvgPassengerReciept;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label comapnyTotalPassengers;
        private System.Windows.Forms.Label totalDrivers;
        private System.Windows.Forms.Label label1;
    }
}

