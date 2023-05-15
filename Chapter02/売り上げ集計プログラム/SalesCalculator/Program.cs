﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    class Program {
        static void Main(string[] args) {
        }

        //売り上げデータを読み込み、Saleオブジェクトのリストを返す
        static List<Sale> ReadSales(String filePath) {
            List<Sale> sales = new List<Sale>();     //売り上げデータを格納する
            string[] lines = File.ReadAllLines(filePath);   //ファイルからすべてのデータを読み込む

            //すべての行から１行ずつ取り出す
            foreach (string line in lines) {
                string[] items = line.Split(',');   //区切りで項目別に分ける
                //Saleインスタンスを生成
                Sale sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);    //Saleインスタンスをコレクションに追加
            }
            return sales;
        }
    }
}
