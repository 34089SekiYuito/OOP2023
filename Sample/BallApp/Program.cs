using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program : Form {

        private Timer moveTimer;    //タイマー用
        private SoccerBall soccerBall;  //ボール
        private PictureBox pb;  //画像を表示するコントロール
        private List<SoccerBall> balls = new List<SoccerBall>();    //ballを格納するList
        private List<PictureBox> pbs = new List<PictureBox>();    //画面に表示するpbを格納するList


        static void Main(string[] args) {
            Application.Run(new Program());
        }

        //ctor コンストラクタの自動生成
        public Program() {

            //this.Width = 1200;  //幅プロパティ
            //this.Height = 800;  //高さプロパティ

            this.Size = new Size(800, 600); //System.DrawingのSizeクラス
            this.BackColor = Color.Green;
            this.Text = "BallGame";
            this.MouseClick += Program_MouseClick;

            //タイマーを生成
            moveTimer = new Timer();
            moveTimer.Interval = 1; //タイマーのインターバル(ms)
            moveTimer.Tick += MoveTimer_Tick;   //デリゲート登録

        }

        //マウスクリック時のイベントハンドラ
        private void Program_MouseClick(object sender, MouseEventArgs e) {

            //ボールインスタンス生成
            soccerBall = new SoccerBall(e.X, e.Y);
            pb = new PictureBox();   //画像を表示するコントロール
            pb.Image = soccerBall.Image;
            pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);
            pb.Size = new Size(50, 50); //画像の表示サイズ
            pb.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード

            //画像の登録
            pb.Parent = this;   //Formを継承している自分(this)を親に設定する
            moveTimer.Start();  //タイマースタート

            balls.Add(soccerBall);
            pbs.Add(pb);

            //Textにボールの数を表示
            Text = "BallGame:" + balls.Count;
            
        }

        //タイマータイムアウト時のイベントハンドラ
        private void MoveTimer_Tick(object sender, EventArgs e) {
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].Move(this, pb);  //移動のメッセージを送る
                pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);
            }
        }
    }
}
