using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false;   //画像項目非表示
            buttonDisable();
            statasLabelDisp();  //表示クリア
            tsTime.Text = DateTime.Now.ToString("yyyy年MM月dd日(dddd) HH時mm分ss秒");
            tmTimeDisp.Start();
        }

        //追加ボタンがクリックされた時のイベントハンドラ
        private void btAddReport_Click(object sender, EventArgs e) {
            statasLabelDisp();  //表示クリア
            if (string.IsNullOrEmpty(cbAuthor.Text)) {
                statasLabelDisp("記録者が入力されていません");
                return;
            }
            else if (string.IsNullOrEmpty(cbCarName.Text)) {
                statasLabelDisp("車名が入力されていません");
                return;
            }

            //追加処理
            var car = new CarReport {
                Date = dtpDate.Value.Date,
                Author = cbAuthor.Text,
                Maker = getSelectedMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                CarImage = pbCarImage.Image
            };
            CarReports.Add(car);

            //コンボボックスに登録
            if (!cbAuthor.Items.Contains(cbAuthor.Text))
                cbAuthor.Items.Add(cbAuthor.Text);
            if (!cbCarName.Items.Contains(cbCarName.Text))
                cbCarName.Items.Add(cbCarName.Text);

            //各項目のクリア処理
            clearScreen();
        }

        //削除ボタンのイベントハンドラ
        private void btDeleteReport_Click(object sender, EventArgs e) {
            int delete = dgvCarReports.CurrentRow.Index;
            dgvCarReports.Rows.RemoveAt(delete);
            dgvCarReports.ClearSelection();
            clearScreen();
        }


        //修正ボタンイベントハンドラ
        private void btModifyReport_Click(object sender, EventArgs e) {
            statasLabelDisp();  //表示クリア
            if (string.IsNullOrEmpty(cbAuthor.Text)) {
                statasLabelDisp("記録者が入力されていません");
                return;
            }
            else if (string.IsNullOrEmpty(cbCarName.Text)) {
                statasLabelDisp("車名が入力されていません");
                return;
            }
            int select = dgvCarReports.CurrentRow.Index;
            CarReports[select] = new CarReport {
                Date = dtpDate.Value.Date,
                Author = cbAuthor.Text,
                Maker = getSelectedMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                CarImage = pbCarImage.Image
            };
        }

        //レコードの選択時
        private void dgvCarReports_Click(object sender, EventArgs e) {
            if (dgvCarReports.Rows.Count != 0) {
                dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value;
                cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
                checkMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
                cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
                tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
                pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;

                buttonEnabled();
            }
        }

        //ファイルの開くボタンのイベントハンドラ
        private void btImageOpen_Click(object sender, EventArgs e) {
            if (ofdImageFileOpen.ShowDialog() == DialogResult.OK) {
                pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
            }
        }

        //ファイルの削除ボタンのイベントハンドラ
        private void btImageDelete_Click(object sender, EventArgs e) {
            pbCarImage.Image = null;
        }

        //画像変更のイベントハンドラ
        private void btScaleChange_Click(object sender, EventArgs e) {
            int tmp = (int)pbCarImage.SizeMode;
            pbCarImage.SizeMode = (PictureBoxSizeMode)(++tmp % 5);
        }

        //編集 色設定が押された時の色設定
        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cdColor.ShowDialog() == DialogResult.OK) {
                BackColor = cdColor.Color;
            }
        }

        //終了ボタンのイベントハンドラ
        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //ボタンを有効化
        private void buttonEnabled() {
            btDeleteReport.Enabled = true;  //削除ボタン有効
            btModifyReport.Enabled = true;  //修正ボタン有効
        }

        //ボタンを無効化
        private void buttonDisable() {
            btDeleteReport.Enabled = false; //削除ボタン無効
            btModifyReport.Enabled = false; //修正ボタン無効
        }

        //スクリーンを初期化
        private void clearScreen() {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = "";
            rbOther.Checked = true;
            cbCarName.Text = "";
            tbReport.Text = "";
            pbCarImage.Image = null;
            dgvCarReports.ClearSelection();
            buttonDisable();
        }

        //ステータスラベルのテキスト表示・非表示（引数なしはメッセージ非表示）
        private void statasLabelDisp(string msg = "") {
            tsInfoText.Text = msg;
        }

        //ラジオボタンで選択されているメーカーを返却
        private CarReport.MakerGroup getSelectedMaker() {
            foreach (RadioButton item in gbMaker.Controls) {
                if (item.Checked)
                    return (CarReport.MakerGroup)int.Parse(item.Tag.ToString());
            }
            return CarReport.MakerGroup.その他;
        }

        //指定したメーカーのラジオボタンをセット
        private void checkMaker(CarReport.MakerGroup maker) {
            foreach (RadioButton item in gbMaker.Controls) {
                if (int.Parse(item.Tag.ToString()) == (int)maker) {
                    item.Checked = true;
                    break;
                }
            }
        }

        #region CarReportインスタンスを作成してやる方法
        //private void dgvCarReports_Click(object sender, EventArgs e) {
        //    int select = dgvCarReportsCurrentRow.Index;
        //    var car = CarReports[select];
        //    dtpDate.Value = car.Date;
        //    cbAuthor.Text = car.Author;
        //    checkMaker(car.Maker);
        //    cbCarName.Text = car.CarName;
        //    tbReport.Text = car.Report;
        //    pbCarImage.Image = car.CarImage;
        //}
        #endregion

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();    //モーダルダイヤログとして表示
        }

        private void tmTimeDisp_Tick(object sender, EventArgs e) {
            tsTime.Text = DateTime.Now.ToString("yyyy年MM月dd日(dddd) HH時mm分ss秒");
        }

    }
}
