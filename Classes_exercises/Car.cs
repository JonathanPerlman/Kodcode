using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_exercises
{
    public enum Color
    {
        Blue,
        Green, 
        Red
    }
    public class Car
    {
        private Color carColor {  get; set; }

        public Car(Color color)
        {
            carColor = color;
        }
        public void DisplayColor()
        {
            Console.WriteLine($"The car color is: {carColor.ToString()}"); 
        }
    }

}
