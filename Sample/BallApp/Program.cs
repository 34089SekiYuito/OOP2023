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
        private PictureBox pb;  //画像を表示するコントロール
        private List<Obj> balls = new List<Obj>();    //ballを格納するList
        private List<PictureBox> pbs = new List<PictureBox>();    //画面に表示するpbを格納するList
        private Obj ballObj;    //ボールのインスタンス格納用
        private Bar bar;    //Barのインスタンス
        private PictureBox pbBar = new PictureBox();   //画像を表示するコントロール

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
            this.KeyDown += Program_KeyDown;

            //barインスタンスの作成
            bar = new Bar(320, 480);
            pbBar.Image = bar.Image;
            pbBar.Size = new Size(150, 10); //画像の表示サイズ
            pbBar.Location = new Point(320, 480);
            pbBar.Parent = this;   //Formを継承している自分(this)を親に設定する
            pbBar.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード

            //タイマーを生成
            moveTimer = new Timer();
            moveTimer.Interval = 1; //タイマーのインターバル(ms)
            moveTimer.Tick += MoveTimer_Tick;   //デリゲート登録

        }

        //キーが押された時のイベントハンドラ
        private void Program_KeyDown(object sender, KeyEventArgs e) {
            bar.Move(this, pbBar, e);
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);
        }

        //マウスクリック時のイベントハンドラ
        private void Program_MouseClick(object sender, MouseEventArgs e) {

            //ボールインスタンス生成
            pb = new PictureBox();   //画像を表示するコントロール
            if (e.Button == MouseButtons.Left)
            {
                ballObj = new SoccerBall(e.X, e.Y);
                pb.Size = new Size(50, 50); //画像の表示サイズ
            }
            else if (e.Button == MouseButtons.Right)
            {
                ballObj = new TennisBall(e.X, e.Y);
                pb.Size = new Size(25, 25); //画像の表示サイズ
            }
            //画像の登録
            pb.Image = ballObj.Image;
            pb.Location = new Point((int)ballObj.PosX, (int)ballObj.PosY);
            balls.Add(ballObj);
            pb.Parent = this;   //Formを継承している自分(this)を親に設定する
            pb.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード
            moveTimer.Start();  //タイマースタート
            pbs.Add(pb);

            //Textにボールの数を表示
            Text = "BallGame SoccerBall:" + SoccerBall.Count + " TennisBall:" + TennisBall.Count;

        }

        //タイマータイムアウト時のイベントハンドラ
        private void MoveTimer_Tick(object sender, EventArgs e) {
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].Move(pbBar, pbs[i]);  //移動のメッセージを送る
                pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);
            }
        }
    }
}
