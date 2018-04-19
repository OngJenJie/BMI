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
            // 宣告變數
            string result = "";
            double BMI;

            // 收取資料（身高跟體重）
            Console.Title = "BMI计算器";
            Console.WriteLine("請輸入您的身高：");
            string heigh = Console.ReadLine();
            Console.WriteLine("請輸入您的体重:");
            string weight = Console.ReadLine();

            // BMI 計算 
            double mheigh = double.Parse(heigh) / 100;
            double hh = mheigh * mheigh;
            BMI = double.Parse(weight) / hh ;

            // 判斷體位
            if(BMI<16.5)
            {
            result = "免役體位";
            }
            else if (16.5 <= BMI&& BMI<17)
            {
             result = "替代役體位";
            }
            else if (17 <= BMI && BMI <= 31)
            {
                result = "常備役體位";
            }
            else if (31 < BMI && BMI <= 31.5)
            {
                result = "替代役體位";
            }
            else if (31.5 < BMI)
            {
                result = "免役體位";
            }

            // 輸出結果
            Console.WriteLine("您的BMI值是: {0:00} 您的體位是： {1}",BMI , result);
            Console.ReadKey();
        }

    }
}
