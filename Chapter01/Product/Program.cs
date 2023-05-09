using System;

namespace ProductSample {
    class Program {
        static void Main(string[] args) {
            #region P26のサンプルプログラム
            //インスタンスの生成
            //Product karinto = new Product(123, "かりんとう", 180);
            //Product daifuku = new Product(235, "大福もち", 160);
            //Console.WriteLine("税込価格：" + karinto.GetPriceIncludingTax());
            //Console.WriteLine("税込価格：" + daifuku.GetPriceIncludingTax());
            #endregion
#if false

            //演習１
            //DateTime date = new DateTime(2023, 5, 8);
            DateTime date = DateTime.Today;
            //10日後を求める
            DateTime daysAfter10 = date.AddDays(10);
            //10日前を求める
            DateTime daysBefor10 = date.AddDays(-10);

            Console.WriteLine("今日の日付：" + date.ToString("yyyy年M月d日"));
            Console.WriteLine("10日後：" + daysAfter10.ToString("yyyy年M月d日"));
            Console.WriteLine("10日前：" + daysBefor10.ToString("yyyy年M月d日"));
#else
            //曜日の配列
            string[] week = { "日", "月", "火", "水", "木", "金", "土" };

            Console.WriteLine("誕生日を入力");
            //西暦の入力
            Console.Write("西暦：");
            int year = int.Parse(Console.ReadLine());
            //月の入力
            Console.Write("月：");
            int mon = int.Parse(Console.ReadLine());
            //日の入力
            Console.Write("日：");
            int day = int.Parse(Console.ReadLine());

            //誕生日
            DateTime birthday = new DateTime(year, mon, day);
            //生まれてからの時間を求める
            TimeSpan ts = DateTime.Today - birthday;

            Console.WriteLine("あなたは生まれてから今日まで{0}日目です。", ts.Days);
            Console.WriteLine("あなたは{0}曜日に生まれました。", week[(int)birthday.DayOfWeek]);
            
#endif

        }
    }
}
