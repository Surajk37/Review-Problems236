using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1st
{
    public class Factorial
    {
        public void CalFactorial()
        {
            int num, fact;
            Console.WriteLine("Enter A Number");
            num= Convert.ToInt32(Console.ReadLine());
            fact = num;
            for (int i = num -1 ; i >= 1; i--)
            {
                
                fact = fact * i;
            }
            Console.WriteLine("Factorial :{0}", fact);

        }
    }
}
