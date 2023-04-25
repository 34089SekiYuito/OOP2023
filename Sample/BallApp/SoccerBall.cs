using System;
using System.Windows.Forms;

namespace BallApp {
    class SoccerBall : Obj {

        //フィールド
        private double moveX;  //移動量(X方向)
        private double moveY;  //移動量(Y方向)

        //プロパティ
        public double MoveX { get => moveX; set => moveX = value; }
        public double MoveY { get => moveY; set => moveY = value; }

        //コンストラクタ
        public SoccerBall(double Xp, double Yp) : base(Xp - 25, Yp - 25, @"pic\soccer_ball.png") {

            Random rm = new Random();   //乱数インスタンス

            MoveX = returnRan(rm);  //乱数を代入
            MoveY = returnRan(rm);  //乱数を代入

            Console.WriteLine("X:" + MoveX + "Y:" + MoveY);

            Count++;
        }

        //メソッド
        public override void Move(Form form, PictureBox pb) {
            if (PosX > (form.Width - pb.Width) || PosX < 0)
            {
                MoveX = -(MoveX);
            }
            if (PosY > (form.Height - pb.Height) || PosY < 0)
            {
                MoveY = -(MoveY);
            }
            PosX += MoveX;
            PosY += MoveY;
        }
    }
}
