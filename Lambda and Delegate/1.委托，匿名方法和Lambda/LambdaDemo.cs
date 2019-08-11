using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_and_Delegate
{
   public class LambdaDemo
    {
        public void Test()
        {
            CalculatorDelegate cal1 = Add;
            CalculatorDelegate cal2 = delegate (int a, int b)
            {
                return a + b;
            };
            CalculatorDelegate cal3 = (int a, int b) => { return a + b; };
            CalculatorDelegate cal4 = (a, b) => a+b;

            Console.WriteLine("通过匿名方法调用："+cal4(10,20));
        }
        


        private int Add(int a, int b)
        {
            return a + b;
        }

    }
    public delegate int CalculatorDelegate(int a, int b);
}
