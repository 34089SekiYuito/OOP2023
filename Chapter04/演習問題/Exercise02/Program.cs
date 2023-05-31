using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            var ymCollection = new YearMonth[] {
                new YearMonth(1980, 1),
                new YearMonth(1990, 4),
                new YearMonth(2000, 7),
                new YearMonth(2010, 9),
                new YearMonth(2020, 12),
            };

            // 4.2.2
            Console.WriteLine("\n- 4.2.2 ---");
            Exercise2_2(ymCollection);
            Console.WriteLine("\n- 4.2.4 ---");

            // 4.2.4
            var ym = Exercise2_4(ymCollection);
            Console.WriteLine(ym?.ToString() ?? "21世紀のデータはありません。");
            Console.WriteLine("\n- 4.2.5 ---");

            // 4.2.5
            Exercise2_5(ymCollection);

        }

        //配列の要素を列挙
        private static void Exercise2_2(YearMonth[] ymCollection) {
            foreach (var item in ymCollection) {
                Console.WriteLine(item);
            }
        }

        //最初の21世紀のオブジェクトを返すメソッド
        private static YearMonth Exercise2_4(YearMonth[] yearMonths) {
            foreach (var ym in yearMonths) {
                if (ym.Is21Century) {
                    return ym;
                }
            }
            return null;
        }

        //1か月後を新たな配列に格納し、年月順に並び替え
        private static void Exercise2_5(YearMonth[] ymCollection) {
            var nextMonthYm = new YearMonth[ymCollection.Length];
            for (int i = 0; i < ymCollection.Length; i++) {
                nextMonthYm[i] = ymCollection[i].AddOneMonth();
            }
            var sortYm = nextMonthYm.OrderBy(ym => ym.Year).ThenBy(ym => ym.Month).ToArray();
            Exercise2_2(sortYm);
        }
    }
}
