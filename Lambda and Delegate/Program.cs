using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_and_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //LambdaDemo ld = new LambdaDemo();
            //ld.Test();
            //Console.Read();
            GenericDelegate dg = new GenericDelegate();
            dg.Test();
            Console.Read();
        }
    }

}
