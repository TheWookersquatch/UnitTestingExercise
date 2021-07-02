using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingExercise
{
    public class Adding
    {
        public Adding()
        {

        }
        public Adding(int num1, int num2, int num3)
        {
            FirstNum = num1;
            SecondNum = num2;
            ThirdNum = num3;
        }
        public int FirstNum { get; set; }
        public int SecondNum { get; set; }
        public int ThirdNum { get; set; }

        public  int GetAnswer(int x, int y, int z)
        {
            return x + y + z;
        }
    }
  

}
