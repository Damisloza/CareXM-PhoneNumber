using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PhoneNumber
{
    public class Program
    {
        public const string finalNumber = "8011001000";

        static void Main(string[] args)
        {

        }

        public static string Number ()
        {
            string phone = finalNumber.Insert(6, "-").Insert(3, "-");
            return phone;
        }

        public static bool test2(string number) =>
            number == finalNumber ? true : false;

        public static string ValidatePhoneNumber ()
        {
            string phone = "801-100-1000";
            if (!Regex.Match(phone, @"^[1-9]\d{2}-[1-9]\d{2}-\d{4}$").Success)
            {

                phone = "Invalid phone number";

            } else
            {
                phone = "Valid phone number";
            }
            return phone;
        }
    }
}
