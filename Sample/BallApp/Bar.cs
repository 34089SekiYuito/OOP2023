using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Bar : Obj {

        //コンストラクタ
        public Bar(double Xp, double Yp) : base(Xp, Yp, @"pic\bar.png") {
            MoveX = 30;
            MoveY = 30;
        }

        //メソッド
        public override void Move(Form form, PictureBox pb) {
            if (PosX + MoveX < 0)
            {
                PosX = 0;
            }
            else if (PosX + MoveX > form.Width - pb.Width)
            {
                PosX = form.Width - pb.Width;
            }
            else
            {
                PosX += MoveX;
            }
        }
    }
}

