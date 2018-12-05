using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applied2
{
    class Driver
    {
        //active if all fields contain data.
        bool active;
        string firstName;
        string secondName;
        string occupation;
        DateTime dob;
        public ArrayList listClaims = new ArrayList();

        //Constructors
        public Driver(bool active) {
            this.active = active;
        }
        public Driver(bool active, string firstName, string secondName, string occupation, DateTime dob) {
            this.active = active;
            this.firstName = firstName;
            this.secondName = secondName;
            this.dob = dob;
        }

        ////Method used to Check if all field contain a value
        //public bool completedFields()
        //{

        //    bool completed = true;
        //    string messageBoxText = "";

        //    if (validation(firstName) == false || firstName.Equals(null))
        //    {
        //        completed = false;
        //        messageBoxText += "invalid or empty First Name field.";
        //    }
        //    else if (validation(secondName) == false || secondName.Equals(null))
        //    {
        //        completed = false;
        //        messageBoxText += "invalid or empty Last Name field.";
        //    }
        //    else if (validation(occupation) == false || occupation.Equals(null))
        //    {
        //        completed = false;
        //        messageBoxText += "invalid or empty Occupation field.";
        //    }
        //    else if (dob.Equals(null) || dob.Equals(null))
        //    {
        //        completed = false;
        //        messageBoxText += "invalid or D.O.B";
        //    }
        //    if (completed == false)
        //    {
        //        MessageBox.Show(messageBoxText);
        //    }
        //    return completed;
        //}
        //private bool validation(string text)
        //{
        //    if ((validateForSpace(text) || validateForBannedChars(text)) == true)
        //    {
        //        //return false because white space or banned chars have been found.
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        //private bool validateForBannedChars(string text)
        //{
        //    bool foundBannedChar = false;
        //    char[] bannedChars = { '!', '@', '#', '$','%','^','&','*','(',')','-','_','=','+','[',']','{','}',
        //                          ':',';','"',',','.','<','>','/','?','`','~','£'};

        //    char[] arrChars = text.ToCharArray();

        //    foreach (char item in arrChars)
        //    {
        //        foreach (char bannedItem in bannedChars)
        //        {
        //            if (item == bannedItem)
        //            {
        //                //return true as banned Item found.
        //                foundBannedChar = true;
        //            }
        //        }
        //    }
        //    //display message if Banned char found.
        //    return foundBannedChar;
        //}
        //private bool validateForSpace(string text)
        //{
        //    if (text.Contains(" ") || text.Equals(""))
        //    {
        //        //Contains Space there for true as space found.
        //        //MessageBox.Show("No Spaces or empty values allowed.");
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //Getters
        public bool getActive() { return active; }
        public string getFirstName() { return firstName; }
        public string getSecondName() { return secondName; }
        public string getOccupation() { return occupation; }
        public DateTime getDob() { return dob; }

        //Setters
        public void setActive(bool value) {  }
        public void setfirstName(string firstName) { this.firstName = firstName; }
        public void setsecondName(string secondName) { this.secondName = secondName; }
        public void setoccupation(string occupation) { this.occupation = occupation; }
        public void setDob(DateTime dob) { this.dob = dob; }

        public void addClaim(DateTime time, double amount) {
            Claim claim = new Claim(amount, time);
            listClaims.Add(claim);
        }

    }//class

}//namespace
