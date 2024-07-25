using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_exercises
{
    public enum GradeLevel
    {
        Junior,
        SophomoreFreshman,
        Senior
    }
    public class Student
    {
        private string name { get; set; }
        private GradeLevel grade { get; set; }
        private int scores { get; set; }
        
        public Student(int scoresOfStudent, string nameOfStudent, GradeLevel gradeOfStudent)
            {
                scores = scoresOfStudent;   
                name = nameOfStudent;
                grade = gradeOfStudent; 
            }
        public void DisplayInfo()
        {
            Console.WriteLine($"The student's name is: {name.ToString()}, His level is: {grade}, and his grade point average is: {scores}");

            switch (grade)
            {
                case GradeLevel.SophomoreFreshman:
                    if (scores >= 0 && scores <= 55)
                    {
                        Console.WriteLine("Failed");
                    }
                    else if (scores > 55 && scores <= 70)
                    {
                        Console.WriteLine("Passed");
                    }
                    else if (scores > 70 && scores <= 100)
                    {
                        Console.WriteLine("Excellent");
                    }
                    break;
                case GradeLevel.Junior:
                    if (scores >= 0 && scores <= 50)
                    {
                        Console.WriteLine("Failed");
                    }
                    else if (scores > 50 && scores <= 80)
                    {
                        Console.WriteLine("Passed");
                    }
                    else if (scores > 80 && scores <= 100)
                    {
                        Console.WriteLine("Excellent");
                    }
                    break;
                case GradeLevel.Senior:
                    if (scores >= 0 && scores <= 40)
                    {
                        Console.WriteLine("Failed");
                    }
                    else if (scores > 40 && scores <= 85)
                    {
                        Console.WriteLine("Passed");
                    }
                    else if (scores > 85 && scores <= 100)
                    {
                        Console.WriteLine("Excellent");
                    }
                    break;
            }
        }


    }
}



