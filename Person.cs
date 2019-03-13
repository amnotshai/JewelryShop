using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using JewelryShop;

namespace JewelryShop
{
    public class Person
    {
        public string FirstName;
        public string MiddleInitial;
        public string LastName;
        public string BirthDate;
        public string Address;

        public Person(string firstName, string lastName, string middleName = " ")
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleInitial = middleName;

        }
        public string GetFullName()
        {
            return ConvertFirstName() + " " + Convert.ToString(MiddleInitial[0]).ToUpper() + ". " + ConvertLastName();
        }
        public string ConvertFirstName()
        {
            TextInfo currentTextInfo = new CultureInfo("en-US", false).TextInfo;

            return currentTextInfo.ToTitleCase(FirstName);
        }
        public string ConvertLastName()
        {

            TextInfo currentTextInfo = new CultureInfo("en-US", false).TextInfo;

            return currentTextInfo.ToTitleCase(LastName);
        }
        static string ConvertToUppercaseFirst(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return string.Empty;
            }
            else
                return char.ToUpper(name[0]) + name.Substring(1);
        }
    }
}
