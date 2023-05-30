using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    public class YearMonth {

        public int Year { get; private set; }   //年
        public int Month { get; private set; }  //月
        public bool Is21Century => (2001 <= Year && Year <= 2100);  //21世紀か


        //コンストラクタ
        public YearMonth(int year, int month) {
            Year = year;
            Month = month;
        }

        //1か月後を求めるメソッド
        public YearMonth AddOneMonth() {
            if (Month == 12) {
                return new YearMonth(Year + 1, 1);
            }
            else {
                return new YearMonth(Year, Month + 1);
            }
        }

        //ToStringのオーバーライド
        public override string ToString() {
            return Year + "年" + Month + "月";
        }
    }
}
