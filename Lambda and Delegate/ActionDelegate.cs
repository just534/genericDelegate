
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_and_Delegate
{
    //action委托没有返回值
    class ActionDelegate
    {
        public void Test()
        {
            Action<string> action = (name) => Console.WriteLine($"欢迎参加【{name}】的课程");
            action("常老师");
        }
    }
}
