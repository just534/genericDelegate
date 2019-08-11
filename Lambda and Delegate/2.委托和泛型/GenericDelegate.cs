using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_and_Delegate
{
    public class GenericDelegate
    {
        GenericDelagate<int> dg;
       public void Test()
        {
            dg = Add;
            GenericDelagate<double> dg1 = delegate (double a, double b) { return a + b; };
            GenericDelagate<double>dg2=(double a, double b)=>{ return a + b; };
            GenericDelagate<double>dg3 = (a, b) => (a + b);
            Console.WriteLine("泛型委托:"+dg(10,20));
            Console.WriteLine("泛型委托1:" + dg1(10, 20));
            Console.WriteLine("泛型委托2:" + dg2(10, 20));
            Console.WriteLine("泛型委托3:" + dg3(10, 20));
        }
        private int Add(int a,int b)
        {
            return a + b;
        }
    }
    public delegate T GenericDelagate<T>(T a, T b);
}
