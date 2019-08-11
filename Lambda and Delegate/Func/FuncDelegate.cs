using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_and_Delegate
{
    public class FuncDelegate
    {
        
        public void Test()
        {
            Func<int,int,int> func = Add;
            Console.WriteLine("FuncAdd:"+func(10,20));
            Func<int, int, double> func1 = (a, b) => (a + b);
            Console.WriteLine("Func匿名方法:"+func1(20,10));
        }
        private int Add(int a,int b)
        {
            return a + b;
        }
    }
}
