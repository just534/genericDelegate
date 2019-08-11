using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_and_Delegate
{
    public class SuperFuncDemo
    {
        //计算数组中从指定位置开始到指定结束位置处的 计算结果
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private int Add(int[] nums, int from, int to)
        {
            int result = 0;
            for (int i = from; i <= to; i++)
            {
                result = result + nums[i];
            }
            return result;
        }

        private int Operate(Func<int, int, int> mothed, int[] nums, int from, int to)//第一个参数是传入一个方法参数也可以是匿名方法或者lambda表达式
        {
            int result = 0;
            for (int i = from; i <= to; i++)
            {
                result = mothed(result, nums[i]);
            }
            return result;
        }

        private int Add(int a,int b)
        {
            return a + b;
        }

        public void Test()
        {
            int result = Operate((a, b) => (a + b), nums, 3, 5);
            Console.WriteLine("结果是:" + result); ;
            result = Operate(Add, nums, 3, 5);//传入方法名
            Console.WriteLine("结果是:" + result); ;
        }
    }
}
