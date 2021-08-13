using System;

namespace Sample301 {
    class Program {
        static void Main(string[] args) {
            //繰り返し処理
            //for (int i = 1; i <= 5; i++) {
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

            //Random rnd = new Random();
            //Console.WriteLine("6が出たら終了");
            //while (true) {
            //    int dice = rnd.Next(1, 7);
            //    Console.WriteLine(dice);
            //    if(dice == 6) {
            //        break;
            //    }
            //}
            //Console.WriteLine("終了");

            //配列
            //double[] d = new double[3];
            //d[0] = 1.2;
            //d[1] = 3.7;
            //d[2] = 4.1;
            //double sum, avg;
            //sum = 0.0;
            //for(int i = 0; i < d.Length; i++) {
            //    Console.Write(d[i] + " ");
            //    sum += d[i];
            //}
            //Console.WriteLine();
            //avg = sum / d.Length;
            //Console.WriteLine("合計値：" + sum);
            //Console.WriteLine("平均値：" + avg);

            int[,] a = new int[3, 4];
            int m, n;
            for (m = 0; m < 3; m++) {
                for (n = 0; n < 4; n++) {
                    a[m, n] = m + n;
                }
            }
            for(m = 0; m < 3; m++) {
                for(n = 0; n < 4; n++) {
                    Console.Write("a[{0},{1}]={2}", m, n, a[m, n]);
                }
                Console.WriteLine();
            }
        }
    }
}
