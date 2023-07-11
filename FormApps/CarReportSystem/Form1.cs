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

        //追加ボタンがクリックされた時のイベントハンドラ
        private void btAddReport_Click(object sender, EventArgs e) {
            var car = new CarReport {
                Date = dtpDate.Value.Date,
                Author = cbAuthor.Text,
                Maker = getSelectedMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                CarImage = pbCarImage.Image
            };
            CarReports.Add(car);
            if(CarReports.Count > 0) {
                btDeleteReport.Enabled = true;
                btModifyReport.Enabled = true;
            }
        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            ofdImageFileOpen.ShowDialog();
            pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
        }

        //削除ボタンのイベントハンドラ
        private void btDeleteReport_Click(object sender, EventArgs e) {
            int delete = dgvCarReports.CurrentRow.Index;
            dgvCarReports.Rows.RemoveAt(delete);
            if (CarReports.Count == 0) {
                btDeleteReport.Enabled = false;
                btModifyReport.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false;   //画像項目非表示
            btDeleteReport.Enabled = false;
            btModifyReport.Enabled = false;
        }

        //レコードの選択時
        private void dgvCarReports_Click(object sender, EventArgs e) {
            dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value;
            cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
            checkMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
            cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
            tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
            pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;
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

        //修正ボタンイベントハンドラ
        private void btModifyReport_Click(object sender, EventArgs e) {
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
    }
}
