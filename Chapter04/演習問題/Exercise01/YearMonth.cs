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
            int afterYear = Year;
            int afterMonth = Month;
            if (Month == 12) {
                afterYear++;
                afterMonth = 1;
            }
            else {
                afterMonth++;
            }
            return new YearMonth(afterYear, afterMonth);
        }

        //ToStringのオーバーライド
        public override string ToString() {
            return Year + "年" + Month + "月";
        }
    }
}
