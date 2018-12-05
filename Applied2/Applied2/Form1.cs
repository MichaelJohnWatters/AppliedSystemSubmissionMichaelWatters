using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applied2
{
    public partial class Form1 : Form
    {
        InputControl inputControl = new InputControl();
        Welcome welcomeControl = new Welcome();
        Summary summaryControl = new Summary();

        int currentScreen = 0;

        public Form1()
        {
            InitializeComponent();

            //add user controls required.
            pnlMain.Controls.Add(inputControl);
            pnlMain.Controls.Add(welcomeControl);
            pnlMain.Controls.Add(summaryControl);

            welcomeControl.Dock = DockStyle.Fill;
            inputControl.Dock = DockStyle.Fill;
            summaryControl.Dock = DockStyle.Fill;

            welcomeControl.BringToFront();
        }//Form1

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentScreen == 1)
            {
                btnPrevious.Visible = false;
                btnNext.Text = "Next";

                welcomeControl.BringToFront();
                
                currentScreen = 0;
            }
            else if (currentScreen == 2)
            {
                //Submit Policy for processing.

                btnNext.Text = "Next";
                inputControl.BringToFront();

                currentScreen = 1;
            }
        }//btnPrevious_Clicks

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (btnNext.Text == "Submit") {

                bool allDriverFieldsContainData = true;
                int driverNum = 0;

                // Check that all the Drivers Fields contain data
                //IF they contain data then the driver is set to active.
                foreach (Driver driver in inputControl.getListDrivers())
                {
                    if (
                        (String.IsNullOrEmpty(driver.getFirstName()))
                        || (String.IsNullOrWhiteSpace(driver.getFirstName()))
                        || (String.IsNullOrEmpty(driver.getSecondName()))
                        || (String.IsNullOrWhiteSpace(driver.getSecondName()))
                        || (driver.getOccupation().Equals("Select"))
                        || (String.IsNullOrEmpty(driver.getOccupation()))
                        || (String.IsNullOrWhiteSpace(driver.getOccupation()))
                        || (driver.getDob() == null)
                        )
                    {
                        driver.setActive(false);
                        allDriverFieldsContainData = false;

                        //Console Log
                        Console.WriteLine("Driver: " + driverNum + " - set active = false");
                    }
                    else
                    {
                        driver.setActive(true);

                        //Console Log
                        Console.WriteLine("Driver: " + driverNum + " - set active = true");
                    }

                    driverNum++;
                }

                // Calculate Policy if all drivers in the lists fields are true
                if (allDriverFieldsContainData == true)
                {
                    Policy policy = new Policy(inputControl.getPolicyStartDate(), inputControl.getListDrivers());
                    policy.predefinedRules();
                }
                else
                {
                    MessageBox.Show("Policy not calculated invalid inputs.");
                }
            }// if Submit

            if (currentScreen == 0)
            {
                btnPrevious.Visible = true;

                inputControl.BringToFront();

                //set screen Number.
                currentScreen = 1;
            }
            else if (currentScreen == 1)
            {
                btnNext.Text = "Submit";

                summaryControl.BringToFront();
                
                //set screen Number.
                currentScreen = 2;

            }
        }//btnNext_Click
    }//class
}//namespace
