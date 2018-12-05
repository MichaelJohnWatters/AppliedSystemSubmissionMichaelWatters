using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;

namespace Applied2
{
    public partial class InputControl : UserControl
    {
        int currentDriver = 0;
        DateTime policyStartDate;
        ArrayList listDrivers = new ArrayList();

        public InputControl()
        {
            InitializeComponent();

            //Set Policy Start Date too current day.
            dtpStartDate.Value = DateTime.Now;
            DateTime policyStartDate = DateTime.Now;

            //Add the first Driver
            listDrivers.Add(new Driver(false));

            ddlSelectDriver.SelectedIndex = 0;
        }

        public ArrayList getListDrivers()
        {
            return listDrivers;
        }
        public DateTime getPolicyStartDate()
        {
            return policyStartDate;
        }

        private bool validateNameTextBoxes(string text)
        {
            bool valid;
            valid = Regex.IsMatch(text, @"^[a-zA-Z]+$");
            return valid;
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            policyStartDate = dtpStartDate.Value;

            //Console Log
            Console.WriteLine("Policy Start Date - set policyStartDate: " + policyStartDate.ToShortDateString());
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            //if less than 18 throw error message
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(dtpDOB.Value.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;

            if ((age > 17 && age < 101) == true)
            {
                Console.WriteLine("dtpDOB: " + age);

                (listDrivers[currentDriver] as Driver).setDob(dtpDOB.Value);

                //Console Log
                Console.WriteLine("Driver: " + currentDriver + " - set dob: " + (listDrivers[currentDriver] as Driver).getDob().ToShortDateString());
            }
            else
            {
                Console.WriteLine("dtpDOB: " + age);
                MessageBox.Show("Invalid input DOB too young (less than 18) or too old (more than 100).");
            }

          
        }
        //REMOVE
        private void dtpClaimDate_ValueChanged(object sender, EventArgs e)
        {

        }

        /*
        spnNumberOfDrivers_ValueChanged
        -Sets the correct Values for the ddlSelectDriver control,
        based on the number selected by spnNumberOfDrivers.
        */
        private void spnNumberOfDrivers_ValueChanged(object sender, EventArgs e)
        {
            //clear Items in Control
            ddlSelectDriver.Items.Clear();

            int numberOfDrivers = (int)spnNumberOfDrivers.Value;

            //add a new driver items, dependant on the number selected in spnNumberOfDrivers.
            for (int index = 0; index < numberOfDrivers; index++)
            {
                ddlSelectDriver.Items.Add("Driver " + (index + 1));
            }//for

            //add or remove driver from arraylist as required.
            if (listDrivers.Count > numberOfDrivers)
            {
                //remove Driver
                listDrivers.RemoveAt(listDrivers.Count - 1);

                //Console Log
                Console.WriteLine("Driver: " + listDrivers.Count + " - Removed");
            }
            else
            {
                listDrivers.Add(new Driver(false));

                //Console Log
                Console.WriteLine("New Driver added");
            }

            ddlSelectDriver.SelectedIndex = 0;

        }//spnNumberOfDrivers_ValueChanged

        private void ddlSelectDriver_SelectedIndexChanged(object sender, EventArgs e)
        {

            currentDriver = ddlSelectDriver.SelectedIndex;

            //This if else controls the content of the Input controls.
            if ((((listDrivers[currentDriver] as Driver).getFirstName()) != null)
            && (((listDrivers[currentDriver] as Driver).getSecondName()) != null)
            && (((listDrivers[currentDriver] as Driver).getDob()) != null)
            && (((listDrivers[currentDriver] as Driver).getOccupation()) != null
            && ((listDrivers[currentDriver] as Driver).getOccupation()) != "Select"))
            {
                txtFirstName.Text = (listDrivers[currentDriver] as Driver).getFirstName();
                txtLastName.Text = (listDrivers[currentDriver] as Driver).getSecondName();
                ddlOccupation.SelectedItem = (listDrivers[currentDriver] as Driver).getOccupation();
                dtpDOB.Value = (listDrivers[currentDriver] as Driver).getDob();
                txtDisplayClaims.Text = displayClaims((listDrivers[currentDriver] as Driver).listClaims);
            }
            else
            {
                txtFirstName.Text = null;
                txtLastName.Text = null;
                ddlOccupation.SelectedItem = "Select";
                // WANT TO SEE TO 1/1/2000 and change max date back to 1/1/2100 to show validation.
                dtpDOB.Value = new DateTime(2000, 1, 1);
                dtpClaimDate.Value = DateTime.Now;
                txtDisplayClaims.Text = "";
            }

            //Console Log
            Console.WriteLine("Current Driver : " + currentDriver + " " + (listDrivers[currentDriver] as Driver).getFirstName());
        }

        private void txtDriverFirstName_TextChanged(object sender, EventArgs e)
        {
            if (validateNameTextBoxes(txtFirstName.Text) == true)
            {
                (listDrivers[currentDriver] as Driver).setfirstName(txtFirstName.Text);

                //Console Log
                Console.WriteLine("Driver: " + currentDriver + " - set firstName: " + (listDrivers[currentDriver] as Driver).getFirstName());
            }
            else
            {
                //MessageBox.Show("Invalid Input - First Name");

                txtFirstName.Text = (listDrivers[currentDriver] as Driver).getFirstName();
                txtFirstName.SelectionStart = txtFirstName.Text.Length;

                //Console Log
                Console.WriteLine("Driver: " + currentDriver + " No Match Invalid input. Value: " + (listDrivers[currentDriver] as Driver).getFirstName());
            }
            
            //Only letters and numbers:
            //Regex.IsMatch(txtFirstName.Text, @"^[a-zA-Z0-9]+$");
            
            //Only letters, numbers and underscore:
            //Regex.IsMatch(txtFirstName.Text, @"^[a-zA-Z0-9_]+$");
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (validateNameTextBoxes(txtLastName.Text) == true)
            {
                (listDrivers[currentDriver] as Driver).setsecondName(txtLastName.Text);

                //Console Log
                Console.WriteLine("Driver: " + currentDriver + " - set firstName: " + (listDrivers[currentDriver] as Driver).getSecondName());
            }
            else
            {
                //MessageBox.Show("Invalid Input - First Name");

                txtLastName.Text = (listDrivers[currentDriver] as Driver).getSecondName();
                txtLastName.SelectionStart = txtLastName.Text.Length;

                //Console Log
                Console.WriteLine("Driver: " + currentDriver + " No Match Invalid input. Value: " + (listDrivers[currentDriver] as Driver).getSecondName());
            }

            (listDrivers[currentDriver] as Driver).setsecondName(txtLastName.Text);

            //Console Log
            Console.WriteLine("Driver: " + currentDriver + " - set lastName: " + (listDrivers[currentDriver] as Driver).getSecondName());
        }

        private void ddlOccupation_SelectedIndexChanged(object sender, EventArgs e)
        {
            (listDrivers[currentDriver] as Driver).setoccupation(ddlOccupation.SelectedItem.ToString());

            //Console Log
            Console.WriteLine("Driver: " + currentDriver + " - set occupation: " + (listDrivers[currentDriver] as Driver).getOccupation());
        }

        //Creates the String used to display the claims that the driver has.
        private string displayClaims(ArrayList lstClaims)
        {
            string display = "";
            bool first = true;
            foreach (Claim claim in lstClaims)
            {
                if (first)
                {
                    display += "Amount: £" + claim.getAmount() + " - Claim Made:" + claim.getDate().ToShortDateString();
                    first = false;
                }
                else
                {
                    display += "\nAmount: £" + claim.getAmount() + " - Claim Made:" + claim.getDate().ToShortDateString();
                }
            }//foreach

            return display;

        }//displayClaims
        private void btnAddClaim_Click(object sender, EventArgs e)
        {
            //Add claims to drivers claims list.
            try
            {
                (listDrivers[currentDriver] as Driver).addClaim(dtpClaimDate.Value, Convert.ToDouble(txtAmount.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input for your claim amount. Correct Example - 1000.00");

                //Console Log
                Console.WriteLine("Invalid input - txtAmount");
            }

            //update claims display - txtDisplayClaims
            txtDisplayClaims.Text = displayClaims((listDrivers[currentDriver] as Driver).listClaims);

            //reset textboxes/datetimepickers
            dtpClaimDate.Value = DateTime.Now;
            txtAmount.Text = "";

            //Console Log
            Console.WriteLine("Driver: "+ currentDriver + " Number of Claims: " + (listDrivers[currentDriver] as Driver).listClaims.Count);
        }

        private void btnDeleteClaim_Click(object sender, EventArgs e)
        {
            //Remove the most recently added list item
            if ((listDrivers[currentDriver] as Driver).listClaims.Count == 0)
            {
                MessageBox.Show("You have no more claims to remove.");
            }
            else
            {
                (listDrivers[currentDriver] as Driver).listClaims.RemoveAt((listDrivers[currentDriver] as Driver).listClaims.Count - 1);
            }

            //update claims display - txtDisplayClaims
            txtDisplayClaims.Text = displayClaims((listDrivers[currentDriver] as Driver).listClaims);

            //Console Log
            Console.WriteLine("Driver: " + currentDriver + " - Number of Claims: " + (listDrivers[currentDriver] as Driver).listClaims.Count);
        }//btnDeleteClaim_Click

    }//class

}//namespace
