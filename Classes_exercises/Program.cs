using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_exercises
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Car[] cars = new Car[3];
        //    cars[0] = new Car(Color.Red);
        //    cars[1] = new Car(Color.Blue);
        //    cars[2] = new Car(Color.Green);

        //    foreach (Car car in cars)
        //    {
        //        car.DisplayColor();
        //    }
        //    Console.Read();
        //}

        static void Main(string[] args)
        {
            Student[] GolanClass = new Student[5];
            GolanClass[0] = new Student(90, "Ovadia Nisimov", GradeLevel.SophomoreFreshman);
            GolanClass[1] = new Student(90, "Yehonatan  Perlman", GradeLevel.Junior);
            GolanClass[2] = new Student(100, "Yael Perlman", GradeLevel.Senior);
            GolanClass[3] = new Student(100, "Yal Perl", GradeLevel.Senior);
            GolanClass[4] = new Student(100, "Yel Pe", GradeLevel.Senior);

            foreach (Student student in GolanClass)
            {
                student.DisplayInfo();
            }
            Console.Read();
        }
    }
}
