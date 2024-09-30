using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAcademyDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            //student's name
            Console.Write("What is your name? ");
            string studentName = Console.ReadLine();

            //course the student is on
            Console.Write("What course are you on? ");
            string courseName = Console.ReadLine();

            //page number, convert the input to an integer
            Console.Write("What page number? ");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            //if the student needs help with anything, expecting a true or false answer
            Console.Write("Do you need help with anything? Please answer \"true\" or \"false\": ");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());

            //positive experiences the student would like to share
            Console.Write("Were there any positive experiences you'd like to share? Please give specifics: ");
            string positiveExperience = Console.ReadLine();

            //feedback
            Console.Write("Is there any other feedback you'd like to provide? Please be specific: ");
            string otherFeedback = Console.ReadLine();

            //hours the student studied today, convert the input to int
            Console.Write("How many hours did you study today? ");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.ReadLine();
        }
    }
}
