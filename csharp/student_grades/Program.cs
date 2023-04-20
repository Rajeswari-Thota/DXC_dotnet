using System.Diagnostics.Metrics;
using System.Security.Principal;

namespace student_grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please! enter StudentId");
            int StudentId= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please! enter StudentName");
            String StudentName = Console.ReadLine();
            Console.WriteLine("please! enter StudentAge");
            int StudentAge= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks1 of " + StudentName);
            int marks1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks2 of " + StudentName);
            int marks2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks3 of " + StudentName);
            int marks3= Convert.ToInt32(Console.ReadLine());
            int studentscore=marks1 + marks2 + marks3;
            
            Console.WriteLine("your total score is " + studentscore);
            float percentage = (studentscore / 3.0f);
            Console.WriteLine("your total percentage is "+  percentage);
            if(percentage >= 90) 
            {
                Console.WriteLine("your grade is A");
            }
            else if(percentage >=80 &&  percentage <90)
            {
                Console.WriteLine("your grade is B");
            }
            else if (percentage >=60 &&  percentage < 80)
            {
                Console.WriteLine("your grade is C");
            }
            else if(percentage >=50 && percentage < 60)
            {
                Console.WriteLine("your grade is D");
            }
            else
            {
                Console.WriteLine("your grade is E");
            }
            if(percentage >= 50)
            {
                Console.WriteLine("your exam result is PASS");
            }
            else 
            { 
                Console.WriteLine("your exam result is FAIL"); 
            }

        }
    }
}