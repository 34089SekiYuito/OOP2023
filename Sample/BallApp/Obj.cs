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
        private static int count;   //ballの個数

        //プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image = value; }
        public static int Count { get => count; set => count = value; }


        //コンストラクタ
        public Obj(double Xp, double Yp, string Path) {

            PosX = Xp;
            PosY = Yp;
            image = Image.FromFile(Path);

        }

        //Moveの抽象メソッド
        public abstract void Move(Form form, PictureBox pb);


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

