using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0411 {
    class Program {
        static void Main(string[] args) {

            Console.Write("数字を入力：");
            int count = int.Parse(Console.ReadLine());

            //1番目
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();//改行
            }
            Console.WriteLine();//改行

            //2番目
            for (int i = 0; i < count; i++)
            {
                for (int j = i; j < count - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();//改行
            }
            Console.WriteLine();//改行

            //3番目
            for (int i = 0; i < count; i++)
            {
                for (int j = i; j < count - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();//改行
            }
            Console.WriteLine();//改行

            //4番目
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < count - i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();//改行
            }

            //5番目1

            //金額の入力
            Console.Write("金額：");
            int price = int.Parse(Console.ReadLine());

            //支払いの入力
            Console.Write("支払い：");
            int pay = int.Parse(Console.ReadLine());

            //おつりの計算
            int paybak = (pay - price);

            int num = 0;
            int[] moneys = { 10000, 5000, 2000, 1000, 500, 100, 50, 10, 5, 1 };//お金の種類(数字)
            String[] coins = { "一万円", "五千円", "二千円", "千円", "五百円", "百円", "五十円", "十円", "五円", "一円" };//紙幣の種類
            Console.WriteLine("おつり：" + paybak + "円");//おつりを出力
            for (int i = 0; i < coins.Length; i++)
            {
                num = (paybak / moneys[i]);
                Console.WriteLine($"{coins[i].PadRight(3, '　')}:{num}枚");//3桁、右詰めで出力
                paybak %= moneys[i];
            }

            //5番目2

            //金額の入力
            Console.Write("金額：");
            int price2 = int.Parse(Console.ReadLine());

            //支払いの入力
            Console.Write("支払い：");
            int pay2 = int.Parse(Console.ReadLine());

            //紙幣の枚数を計算、出力
            dispOut(price2, pay2);

        }

        //紙幣の枚数を計算するメゾット
        public static void dispOut(int price, int pay) {

            int paybak = (pay - price); //おつりの計算
            int[] moneys = { 10000, 5000, 2000, 1000, 500, 100, 50, 10, 5, 1 };//お金の種類(数字)
            String[] coins = { "一万円", "五千円", "二千円", "千円", "五百円", "百円", "五十円", "十円", "五円", "一円" };//紙幣の種類
            Console.WriteLine("おつり：" + paybak + "円");//おつりを出力
            for (int i = 0; i < coins.Length; i++)
            {
                Console.Write($"{coins[i].PadRight(3, '　')}:");//3桁、右詰めで出力
                astOut(paybak / moneys[i]); //*を出力するメゾット
                paybak %= moneys[i];
            }
        }

        //引数の数だけ＊を出力するメゾット
        public static void astOut(int count) {
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();//改行
        }
    }


}
