using System;

namespace Sample201 {
    class Program {
        static void Main(string[] args) {
            //演算子
            //Console.WriteLine("{0} + {1} = {2}", 5, 2, 5 + 2);
            //Console.WriteLine("{0} - {1} = {2}", 5, 2, 5 - 2);
            //Console.WriteLine("{0} * {1} = {2}", 5, 2, 5 * 2);
            //Console.WriteLine("{0} / {1} = {2}　余り　{3}", 5, 2, 5 / 2, 5 % 2);

            //変数
            //int a;
            //int b = 3;
            //int add, sub;
            //double avg;
            //a = 6;
            //add = a + b;
            //sub = a - b;
            //avg = (a + b) / 2.0;
            //Console.WriteLine("{0} + {1} = {2}", a, b, add);
            //Console.WriteLine("{0} - {1} = {2}", a, b, sub);
            //Console.WriteLine("{0}と{1}の平均値{2}", a, b, avg);

            //条件式
            //Console.Write("整数値を入力");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("a=" + a);
            //if (a > 0) {
            //    Console.WriteLine("aは正の数");
            //} else {
            //    Console.WriteLine("aは負の数");
            //}

            Console.Write("1から3の整数を入力");
            int num = int.Parse(Console.ReadLine());
            switch (num) {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                default:
                    Console.WriteLine("不適切な値です");
                    break;
            }
        }
    }
}
