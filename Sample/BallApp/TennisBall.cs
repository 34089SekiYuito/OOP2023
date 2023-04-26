using System.Drawing;
using System.Windows.Forms;

namespace BallApp {
    class TennisBall : Obj {

        //フィールド
        private static int count;   //ballの個数

        //プロパティ
        public static int Count { get => count; set => count = value; }

        //コンストラクタ
        public TennisBall(double Xp, double Yp) : base(Xp - 12.5, Yp - 12.5, @"pic\tennis_ball.png") {
            Count++;
        }

        //メソッド
        public override void Move(Form form, PictureBox pb, Bar bar) {
            if (PosX > (form.Width - pb.Width) || PosX < 0)
            {
                MoveX = -(MoveX);
            }
            if (PosY > (form.Height - pb.Height) || PosY < 0 || ((PosX >= bar.PosX && PosX < bar.PosX + 150) && PosY >= bar.PosY - 40))
            {
                MoveY = -(MoveY);
            }
            PosX += MoveX;
            PosY += MoveY;
        }

        public override void Move(PictureBox pbBar, PictureBox pbBall) {

            Rectangle rBar = new Rectangle(pbBar.Location.X, pbBar.Location.Y, pbBar.Width, pbBar.Height);
            Rectangle rBall = new Rectangle(pbBall.Location.X, pbBall.Location.Y, pbBall.Width, pbBall.Height);

            if (PosY > 520 || PosY < 0 || rBar.IntersectsWith(rBall))
            {
                MoveY = -MoveY;
            }
            if (PosX > 730 || PosX < 0)
            {
                MoveX = -MoveX;
            }
            PosX += MoveX;
            PosY += MoveY;
        }
    }
}
