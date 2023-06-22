using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

            var Prefectures = new Dictionary<string, string>();  //県庁所在地のDictionary
            string key, value;

            //入力処理
            Console.WriteLine("県庁所在地の登録");
            Console.Write("県名:");   //県名の入力
            key = Console.ReadLine();

            while (key != "999") {
                if (Prefectures.ContainsKey(key))
                    Console.WriteLine("すでに登録されています。");  //入力された県がすでに存在する場合
                else {
                    Console.Write("所在地:");  //市の入力
                    value = Console.ReadLine();
                    Prefectures[key] = value;    //登録
                }
                Console.Write("県名:");   //県名の入力
                key = Console.ReadLine();
            }

            //出力処理
            Console.Write("県名を入力:");
            var select = Console.ReadLine();
            if (Prefectures.ContainsKey(select))
                Console.WriteLine("{0}です。", Prefectures[select]);
            else
                Console.WriteLine("登録されていません。");

            #region  7-1-1
            //var flowerDict = new Dictionary<string, int>() {
            //    ["sunflower"] = 400,
            //    ["pansy"] = 300,
            //    ["tulip"] = 350,
            //    ["rose"] = 500,
            //    ["dahlia"] = 450,
            //};

            ////morning glory(あさがお)【250円】を追加
            //flowerDict.Add("morning glory", 250);
            ////flowerDict["morning glory"] = 250;

            //Console.WriteLine("ひまわりの価格は{0}円です。", flowerDict["sunflower"]);
            //Console.WriteLine("チューリップの価格は{0}円です。", flowerDict["tulip"]);
            //Console.WriteLine("あさがおの価格は{0}円です。", flowerDict["morning glory"]);
            #endregion
        }
    }
}
