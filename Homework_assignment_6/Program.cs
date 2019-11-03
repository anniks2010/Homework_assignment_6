using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string userBirthday;

            Console.WriteLine("Please enter your birthday and year with format dd.mm.yyyy:");
            userBirthday= Console.ReadLine();

            GetAgeInSeconds(userBirthday);
            
            Console.ReadLine();
           

        }
        public static void GetAgeInSeconds (string userBirthOfDate)
        {
            string[] userData = userBirthOfDate.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

            int day = int.Parse(userData[0]);
            int month = int.Parse(userData[1]);
            int year = int.Parse(userData[2]);
            double userAgeInSeconds;

            /*foreach (string data in userData)
            {
                Console.WriteLine(data);
            }*/
            var userBirthday = new DateTime(year, month, day);
            TimeSpan userAge = DateTime.Now - userBirthday;
            userAgeInSeconds = Math.Round(userAge.TotalSeconds,2);

            Console.WriteLine($"You are {userAgeInSeconds} seconds old.");


        }

    }
}
