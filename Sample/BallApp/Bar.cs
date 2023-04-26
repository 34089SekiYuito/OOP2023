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
        public override void Move(Form form, PictureBox pb,Bar bar) {
            ;
        }
        public override void Move(PictureBox pbBar, PictureBox pbBall) {
            ;
        }

        //KeyEventArgsを引数に追加したMove(オーバーロード)
        public void Move(Form form, PictureBox pb, KeyEventArgs e) {

            if(e.KeyData == Keys.Left)
            {
                MoveX = -30;
            }else if(e.KeyData == Keys.Right)
            {
                MoveX = 30;
            }
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

