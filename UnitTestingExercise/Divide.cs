using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingExercise
{
    public class Divide
    {
        public Divide()
        {

        }
        public Divide(int num1, int num2)
        {
            FirstNum = num1;
            SecondNum = num2;
        }
        public int FirstNum { get; set; }
        public int SecondNum { get; set; }

        public int  GetAnswer(int x, int y)
        {
            
            do
            {
                if (x == 0)
                {
                    Console.WriteLine("Cannot Divide by 0");
                    Console.WriteLine($"What number do you want to divide by {y}");
                    x = int.Parse(Console.ReadLine());
                }
                
            }
            while (x == 0);
            return x / y;
        }
    }
}
