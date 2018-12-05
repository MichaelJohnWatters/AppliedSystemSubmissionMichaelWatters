using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applied2
{
    class Policy
    {
        private DateTime startDate;
        private ArrayList drivers;
        double price = 0;

        string youngestDriverName = "";
        string oldestDriverName = "";

        int youngestDriver = 0;
        int oldestDriver = 0;

        DateTime youngestDOB;
        DateTime oldestDOB;

        bool policyDeclined = false;
        string declineMessage = "";

        public Policy(DateTime startDate, ArrayList drivers)
        {
            this.startDate = startDate;
            this.drivers = drivers;

        }//Constructor

        //Process all drivers per rule
        public void predefinedRules()
        {
            //Rule a1
            price = 500.00;
            //Rule a2
            occupationRules();
            //Rule a3
            ageRules();
            //Rule a4
            claimRules();
            //Rule b 1-5
            declineRules();

        }//predefinedRules

        //Process all Rules per driver.
        public void predefinedRulesAlternative() { }
        /*occupationRules*/
        private void occupationRules()
        {
            Console.WriteLine("---- Occupation Rules ----");
            int driverNum = 0;
            foreach (Driver driver in drivers)
            {
                switch (driver.getOccupation())
                {
                    case "Chauffeur":
                        price = price * 1.1;
                        //Console Log
                        Console.WriteLine("Occupation Rules --- Driver: " + driverNum
                            + " - " + "Chauffeaur" + " - " + " increase 10% - New Price:" + price);
                        break;

                    case "Accountant":
                        price = price * 0.9;
                        //Console Log
                        Console.WriteLine("Occupation Rules --- Driver: " + driverNum
                            + " - " + "Accountant" + " - " + " decrease 10% - New Price:" + price);
                        break;
                }//switch

                driverNum++;

            }//foreach

        }//occupationRules

        /*ageRules*/
        private void ageRules()
        {
            Console.WriteLine("---- Age Rules ----");
            //Todays Date.
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));

            //Set oldest/youngest varibles/names
            //incase only 1 driver is input.
            youngestDOB = (drivers[0] as Driver).getDob();
            oldestDOB = (drivers[0] as Driver).getDob();
            youngestDriverName = (drivers[0] as Driver).getFirstName() + " " + (drivers[0] as Driver).getSecondName();
            oldestDriverName = (drivers[0] as Driver).getFirstName() + " " + (drivers[0] as Driver).getSecondName();
            int dobFirstDriver = int.Parse(youngestDOB.ToString("yyyyMMdd"));
            int ageFirstDriver = (now - dobFirstDriver) / 10000;
            youngestDriver = ageFirstDriver;
            oldestDriver = ageFirstDriver;

            //For each Driver Work out which is the oldest and youngest.
            foreach (Driver driver in drivers)
            {
                int dob = int.Parse(driver.getDob().ToString("yyyyMMdd"));
                int age = (now - dob) / 10000;

                if (age < youngestDriver)
                {
                    youngestDriver = age;
                    youngestDOB = driver.getDob();
                    youngestDriverName = driver.getFirstName() + " " + driver.getSecondName();
                }
                else if (age > oldestDriver)
                {
                    oldestDriver = age;
                    oldestDOB = driver.getDob();
                    oldestDriverName = driver.getFirstName() + " " + driver.getSecondName();

                }

            }//foreach

            //Console Log - youngest driver
            Console.WriteLine("Youngest Driver: " + youngestDriver +"\n Oldest Driver: " + oldestDriver);

            if (youngestDriver > 20 && youngestDriver < 26)
            {
                price = price * 1.2;

                //Console Log
                Console.WriteLine("Age Rule --- Increase Premium by 20% : youngest driver(driver > 20 && driver < 26) : "
                    + youngestDriver + " - New Price: " + price);
            }
            else if (youngestDriver > 25 && youngestDriver < 76)
            {
                price = price * 0.9;

                //Console Log
                Console.WriteLine("Age Rule --- Decrease Premium by 10% : youngest driver( driver > 25 && driver < 76) : "
                    + youngestDriver + " - New Price: " + price);
            }

        }//agesRules

        private void claimRules()
        {
            Console.WriteLine("---- Claim Rules ----");
            int driverNum = 0;
            int oneYear = 365;
            //extra day included for leap years.
            int fiveYears = 1826;

            foreach (Driver driver in drivers)
            {
                    foreach (Claim claim in driver.listClaims)
                    {
                        if ((startDate - claim.getDate()).TotalDays <= oneYear)
                        {
                            price = price * 1.2;

                            //Console Log
                            Console.WriteLine("Claim Rules --- Driver: " + driverNum
                                + " - Claim made less than 1 year ago - Premium increased 20% - New Price: " + price);
                        }
                        else if ((startDate - claim.getDate()).TotalDays > oneYear && (startDate - claim.getDate()).TotalDays <= fiveYears)
                        {
                            price = price * 1.1;

                            //Console Log
                            Console.WriteLine("Claim Rules --- Driver: " + driverNum
                                + " - Claim made between 2-5 years - Premium increased 10% - New Price: " + price);
                        }
                    }//foreach claim
                driverNum++;
            }//foreach driver

        }
        private void declineRules()
        {
            Console.WriteLine("---- Decline Rules ----");

            //Decline Rule b1 - If start date is before current day decline the policy.
            if (startDate.ToShortDateString() == DateTime.Now.ToShortDateString())
            {
                //Console Log
                Console.WriteLine("Policy Rule b1 - Pass - Start date is not less than todays date.");
            }
            // Decline Rule b1 
            else if (DateTime.Parse(startDate.ToShortDateString()) < DateTime.Parse(DateTime.Now.ToShortDateString()))
            {
                policyDeclined = true;
                declineMessage += "\nStart Date of Policy - Cannot be a date before today.";

                //Console Log
                Console.WriteLine(" Policy Rule b1 - Fail - policy start date cannot be a date before today.");
            }
            else if (DateTime.Parse(startDate.ToShortDateString()) > DateTime.Parse(DateTime.Now.ToShortDateString()))
            {
                //Console Log
                Console.WriteLine(" Policy Rule b1 - Pass");
            }

            //Decline Rule b2 and b3 Process youngest and oldest ages at the start of the policy
            //Calculate the age of the youngest Driver based on the policy start date.
            int now = int.Parse(startDate.ToString("yyyyMMdd"));
            int dobYoung = int.Parse(youngestDOB.ToString("yyyyMMdd"));
            int ageOfYoungestDriverAtPolicyStartDate = (now - dobYoung) / 10000;

            //Calculate the age of the Oldest Driver based on the polcy start date.
            int dobOld = int.Parse(oldestDOB.ToString("yyyyMMdd"));
            int ageOfOldestDriverAtPolicyStartDate = (now - dobOld) / 10000;

            //Console Log Message
            Console.WriteLine("youngest Driver at time of policy Start:" + ageOfYoungestDriverAtPolicyStartDate);
            Console.WriteLine("Oldest Driver at time of policy Start:" + ageOfOldestDriverAtPolicyStartDate);

            //Decline Rule b2 - If The youngest driver is under 21 before the start of the policy.
            if (ageOfYoungestDriverAtPolicyStartDate < 21)
            {
                policyDeclined = true;
                declineMessage += "\nAge Of Youngest Driver: " + youngestDriverName + " - cannot be below 21";

                //Console Log Message
                Console.WriteLine("Policy Rule b2 - Fail - Age Of Youngest Driver: " + youngestDriverName + " - cannot be below 21");
            }
            //Decline rule b3 - If oldest driver is older than 75 at the start date of the policy.
            if (ageOfOldestDriverAtPolicyStartDate > 75)
            {
                policyDeclined = true;
                declineMessage += "\nAge Of Oldest Driver: " + oldestDriverName + " - cannot be above 75";

                //Console Log Message
                Console.WriteLine("Policy Rule b3 - Fail - Age Of Oldest Driver:"  + oldestDriverName +  "cannot be above 75");
            }

            //Decline Rule b4 - if a driver has more than 2 claims decline the policy
            int totalNumOfClaims = 0;
            foreach (Driver driver in drivers)
            {
                if (driver.listClaims.Count > 2)
                {
                    totalNumOfClaims += driver.listClaims.Count;
                    policyDeclined = true;
                    declineMessage += "\n Driver has more than 2 claims: " + driver.getFirstName() + " " + driver.getSecondName();

                    //Console Log Message
                    Console.WriteLine("Policy Rule b4 - Fail - Driver: " 
                        + driver.getFirstName() 
                        + " " 
                        + driver.getSecondName() 
                        + " - Current Number of Claims: " 
                        + driver.listClaims.Count 
                        + " - exceeds maxium number of claims.");
                }
                else
                {
                    //Console Log Message
                    totalNumOfClaims += driver.listClaims.Count;
                    Console.WriteLine("Policy Rule b4 - Pass - Driver: " 
                        + driver.getFirstName() 
                        + " " 
                        + driver.getSecondName() 
                        + " - Claims Number: " 
                        + driver.listClaims.Count);
                }

            }//foreach

            //Decline Rule 5 - If the total number of claims made by all the drivers combined is greater than 3 decline policy.
            if (totalNumOfClaims > 3)
            {
                policyDeclined = true;
                declineMessage += "\nPolicy has more than 3 claims.";

                //Console Log Message
                Console.WriteLine("Policy Declined - Total number of Claims: " + totalNumOfClaims + " Maxium of 3.");
            }

            //Process Final Decision if policy is declined
            if (policyDeclined == false)
            {
                MessageBox.Show("-- Policy Accepted -- \n" + "Quoted Price : £" + price);

                //Console Log Message
                Console.WriteLine("Policy Successful - Price $: " + price);
            }
            else
            {
                MessageBox.Show("-- Policy Declined -- \n" + declineMessage);

                //Console Log Message
                Console.WriteLine("Policy UnSuccessful");
            }

        }//declineRules

    }//class

}//namespace
