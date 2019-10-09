using System;
using System.Globalization;
using System.Windows.Forms;

namespace MildAtlanticBusTours
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        // Set fares for different types of passengers
        const decimal FULL_FARE_AMOUNT = 5.50m;
        const decimal STUDENT_FARE_AMOUNT = 4.50m;
        const decimal DISCOUNT_FARE_AMOUNT = 3.75m;

        // Create field variables to hold running totals for COMPANY SUMMARY DATA
        int driversCount = 0;
        int passengersCount = 0;
        decimal receiptsCount = 0.0m;
        decimal receiptsAverage = 0.0m;

        //Hide the group boxes on form loading
        private void MainForm_Load(object sender, EventArgs e)
        {
            companySummaryDataGroupBox.Visible = false;
            driverSummaryDataGroupBox.Visible = false;
        }

        // To handle calculate button clicks
        private void Calculate_Click(object sender, EventArgs e)
        {
            // Create local variables for current Driver                
            int driverTotalPassengers = 0; //To store total passenger provided by the current driver 
            int driverFullFareRiders = 0;  //To store full fare riders provided by the current driver
            int driverStudentRiders = 0; //To store student riders provided by the current driver
            int driverDiscountRiders = 0; //To store discount riders provided by the current driver
            decimal driverTotalReceipts = 0.0m; //To store total receipts of the current driver => (driverFullFareRiders * FULL_FARE_AMOUNT) + (driverStudentRiders * STUDENT_FARE_AMOUNT) + (driverDiscountRiders * DISCOUNT_FARE_AMOUNT)
            decimal driverAveragePassengersReceipt = 0.0m; //To store average passenger receipts of the current driver => (driverTotalReceipts/driverTotalPassengers)
            
            //To handle number format exception for full fare rider textbox
            try
            {
                driverFullFareRiders = int.Parse(fullFareRiders.Text);

                //To handle number format exception for student rider textbox
                try
                {
                    driverStudentRiders = int.Parse(studentRiders.Text);

                    //To handle number format exception for discount rider textbox
                    try
                    {
                        driverDiscountRiders = int.Parse(discountRiders.Text);
                        //Hide any previous driverSummaryDataGroupBox, enable driverLevelEntriesPanel 
                        driverSummaryDataGroupBox.Visible = true;
                        companySummaryDataGroupBox.Visible = false;
                        driverLevelEntriesPanel.Enabled = false;
                        summary.Enabled = true;
                        calculate.Enabled = false;                        
                        driverNameLabel.Text = driversName.Text;
                        driversCount += 1;// Increasing the driversCount value

                        // Calculate and display the total passengers of the driver
                        driverTotalPassengers = driverFullFareRiders + driverStudentRiders + driverDiscountRiders;
                        totalPassengersLabel.Text = driverTotalPassengers.ToString("");

                        // Calculate and display the total reciepts of the driver
                        driverTotalReceipts = Decimal.Round(((driverFullFareRiders * FULL_FARE_AMOUNT) + (driverStudentRiders * STUDENT_FARE_AMOUNT) + (driverDiscountRiders * DISCOUNT_FARE_AMOUNT)),2); //Round into two decimal places
                        totalrecieptsLabel.Text = driverTotalReceipts.ToString("C2", CultureInfo.CreateSpecificCulture("ga-IE"));

                        // Calculate and display the average passenger reciept of the driver
                        driverAveragePassengersReceipt = Decimal.Round((driverTotalReceipts / driverTotalPassengers),2);//Round into two decimal places
                        averagePassengerReceiptLabel.Text = driverAveragePassengersReceipt.ToString("C2", CultureInfo.CreateSpecificCulture("ga-IE"));

                        passengersCount += driverTotalPassengers;// Increasing the passengersCount value
                        receiptsCount += driverTotalReceipts;// Increasing the receiptsCount value
                    }
                    catch
                    {
                        //Catches the thrown exception for the discountRiders Textbox
                        MessageBox.Show("Please enter numerical data for Discount Riders", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        discountRiders.Focus();
                        discountRiders.SelectAll();
                    }
                }
                catch
                {
                    //Catches the thrown exception for the studentRiders Textbox
                    MessageBox.Show("Please enter numerical data for Student Riders", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    studentRiders.Focus();
                    studentRiders.SelectAll();
                }
            }
            catch
            {
                //Catches the thrown exception for the fullFareRiders Textbox
                MessageBox.Show("Please enter numerical data for Full Fare Riders", "Data Entry  Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fullFareRiders.Focus();
                fullFareRiders.SelectAll();
            }

        }

        //To handle summary button click
        private void Summary_Click(object sender, EventArgs e)
        {

            //Hide any previous driverLevelEntriesPanel, enable companySummaryDataGroupBox 
            companySummaryDataGroupBox.Visible = true;
            driverLevelEntriesPanel.Visible = false;
            calculate.Enabled = false;
            companyTotalDriversLabel.Text = driversCount.ToString();// To display no of total drivers of comapny
            companyTotalPassengersLabel.Text = passengersCount.ToString();// To display no of total passengers of the comapny
            companyTotalReceiptsLabel.Text = receiptsCount.ToString("C2", CultureInfo.CreateSpecificCulture("ga-IE"));// To display the total reciepts of the company 
            receiptsAverage = Decimal.Round((receiptsCount / passengersCount), 2);//Round into two decimal places
            companyAveragePassengerReceiptLabel.Text = receiptsAverage.ToString("C2", CultureInfo.CreateSpecificCulture("ga-IE"));//To display average passengers receipt for all drivers

        }

        //To handle clear button click
        private void Clear_Click(object sender, EventArgs e)
        {
            //Hide driverSummaryDataGroupBox and companySummaryDataGroupBox, enable driverLevelEntriesPanel and revert buttons's text color to black
            companySummaryDataGroupBox.Visible = false;
            driverSummaryDataGroupBox.Visible = false;
            driverLevelEntriesPanel.Enabled = true;
            driverLevelEntriesPanel.Visible = true;
            summary.Enabled = true;
            calculate.Enabled = true;

            //Resetting the driverLevelEntriesPanel text fields and setting the focus to driver's name
            driversName.Text = "";
            fullFareRiders.Text = "";
            studentRiders.Text = "";
            discountRiders.Text = "";
            driversName.Focus();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();// Quit the application
        }

    }
}
