using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eexercise02 {
    //インチとメートルの単位変換クラス
    class InchConverter {
        //定数
        private const double ratio = 0.0254;

        //インチからメートルを求める
        public static double FromMeter(double inch) {
            return inch * ratio;
        }

        //メートルからインチを求める
        public static double ToMeter(double inch) {
            return inch / ratio;
        }
    }
}
