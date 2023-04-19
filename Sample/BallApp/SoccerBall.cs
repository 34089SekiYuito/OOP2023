using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class SoccerBall {
        //フィールド
        private Image image;    //画像データ System.DrawingのImageクラス

        private double posX;    //X座標
        private double posY;    //Y座標

        private double moveX;  //移動量(X方向)
        private double moveY;  //移動量(Y方向)



        //コンストラクタ
        public SoccerBall(double Xp, double Yp) {
            Image = Image.FromFile(@"pic\soccer_ball.png"); //@を書くと\が文字列として認識される
            PosX = Xp - 25;
            PosY = Yp - 25;
            Random rm = new Random();   //乱数インスタンス

            moveX = rm.Next(1, 50); //乱数で移動量を設定
            moveY = rm.Next(1, 50); //乱数で移動量を設定

            Console.WriteLine("X:" + moveX + "Y:" + moveY);
        }

        //プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image = value; }

        //メソッド
        public void Move(Form form, PictureBox pb) {

            if (posX > (form.Width - pb.Width) || posX < 0)
            {
                moveX = -(moveX);
            }

            if (posY > (form.Height - pb.Height) || posY < 0)
            {
                moveY = -(moveY);
            }
            posX += moveX;
            posY += moveY;
        }


    }
}
