using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingExercise
{
    public class Subtracting
    {


        public Subtracting()
        {

        }
        public Subtracting(int num1, int num2)
        {
            FirstNum = num1;
            SecondNum = num2;
        }
        public int FirstNum { get; set; }
        public int SecondNum { get; set; }
       
        public int GetAnswer(int x, int y)
        {
            return x - y;
        }
    }    
}
