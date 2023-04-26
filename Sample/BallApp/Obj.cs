using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallApp {
    //抽象クラス
    abstract class Obj {

        //フィールド
        private Image image;    //画像データ System.DrawingのImageクラス
        private double posX;    //X座標
        private double posY;    //Y座標
        private double moveX;  //移動量(X方向)
        private double moveY;  //移動量(Y方向)

        //プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public double MoveX { get => moveX; set => moveX = value; }
        public double MoveY { get => moveY; set => moveY = value; }
        public Image Image { get => image; set => image = value; }

        //コンストラクタ
        public Obj(double Xp, double Yp, string Path) {

            PosX = Xp;
            PosY = Yp;
            image = Image.FromFile(Path);

            Random rm = new Random();   //乱数インスタンス
            MoveX = returnRan(rm);  //乱数を代入
            MoveY = returnRan(rm);  //乱数を代入

            Console.WriteLine("X:" + MoveX + "Y:" + MoveY);

        }

        //Moveの抽象メソッド
        public abstract void Move(Form form, PictureBox pb, Bar bar);

        public abstract void Move(PictureBox pbBar, PictureBox pbBall);

        //0以外のランダムな値を返すメソッド
        public int returnRan(Random rm) {
            int num = rm.Next(-30, 30);
            if (num == 0)
            {
                num = rm.Next(1, 30);
            }
            return num;
        }
    }
}

