using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT4._2._2
{
    interface iCalculater
    {
        decimal Add(decimal num1, decimal num2);
        decimal Subtract(decimal num1, decimal num2);
        decimal Multiply(decimal num1, decimal num2);
        decimal Divide(decimal num1, decimal num2);

    }
    public class Calculator: iCalculater
    { 
        public decimal Add(decimal num1, decimal num2 )
        {
            return num1 + num2;
        }
        public decimal Subtract(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        public decimal Multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
        public decimal Divide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
    

    }

}
