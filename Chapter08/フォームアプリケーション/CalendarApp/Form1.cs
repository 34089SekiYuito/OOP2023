using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btDayCalc_Click(object sender, EventArgs e) {
            TimeSpan ts = DateTime.Now - dtpDate.Value;
            tbMessage.Text = "指定した日付から" + ts.Days + "日経過";
        }

        private void subYear_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddYears(-1);
        }

        private void addYear_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddYears(1);
        }

        private void subMon_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddMonths(-1);
        }

        private void addMon_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddMonths(1);
        }

        private void subDay_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddDays(-1);
        }

        private void addDay_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddDays(1);
        }

        private void btAge_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            var now = DateTime.Now;
            var age = now.Year - dtp.Year;
            if (now < dtp.AddYears(age))
                age--;
            tbMessage.Text = "年齢は" + age + "歳";
        }

        //実行時に一度だけ呼び出されるメソッド
        private void Form1_Load(object sender, EventArgs e) {
            tbTimeNow.Text = DateTime.Now.ToString("yyyy年MM月dd日(dddd) HH時mm分ss秒");
            tmTimeDisp.Start();
        }

        //タイマーイベントハンドラー
        private void tmTimeDisp_Tick(object sender, EventArgs e) {
            tbTimeNow.Text = DateTime.Now.ToString("yyyy年MM月dd日(dddd) HH時mm分ss秒");
        }
    }
}
