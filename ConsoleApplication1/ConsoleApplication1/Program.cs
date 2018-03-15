using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "BMI计算器";
            Console.WriteLine("请输入您的身高：");
            string heigh = Console.ReadLine();
            Console.WriteLine("请输入您的体重:");
            string weight = Console.ReadLine();
            double BMI = double.Parse(heigh) / double.Parse(weight) * double.Parse(weight);
            Console.WriteLine("您的BMI值是: " + BMI );
            Console.ReadLine();
        }

    }
}
