using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

//楽天　パスワード　OIBC34089@

namespace API {
    public partial class Form1 : Form {
        List<itemData> nodes;
        List<string> topics = new List<string>();
        string baseUrl = @"https://app.rakuten.co.jp/services/api/Travel/SimpleHotelSearch/20170426?format=xml&hotelNo=123456&applicationId=e06e2a5afcf14b52139c1fb6c58e9dbc";
        private HttpClient httpClient;

        public Form1() {
            InitializeComponent();
            topics = GetList("RssUrl.txt");
            httpClient = new HttpClient();
        }

        //RssのUrlを取得
        private List<string> GetList(string Path) {
            List<string> Topics = new List<string>();
            if (File.Exists(Path)) {
                using (var reader = new StreamReader(Path, Encoding.UTF8)) {
                    while (!reader.EndOfStream) {
                        var line = reader.ReadLine();
                        Topics.Add(line);
                    }
                }
            }
            return Topics;
        }

        //取得ボタンクリック
        private void btGet_Click(object sender, EventArgs e) {
            
            var list =XDocument.Load("https://app.rakuten.co.jp/services/api/Travel/SimpleHotelSearch/20170426?format=xml&hotelNo=123456&applicationId=e06e2a5afcf14b52139c1fb6c58e9dbc&hotelNo=123456");
            var names = list.Descendants();

            //lbRssTitle.Items.Clear();
            //nodes = null;
            //using (var wc = new WebClient()) {
            //    var url = wc.OpenRead(@"");
            //    XDocument xdoc = XDocument.Load(url);
            //    //nodes = xdoc.Root.Descendants("item").Select(x => new itemData {
            //    //    Title = x.Element("title").Value,
            //    //    Link = x.Element("link").Value
            //    //}).ToList();
            //    foreach (var node in nodes) {
            //        lbRssTitle.Items.Add(node.Title);
            //    }
            //}
        }

        //登録ボタンクリック
        private void btRegister_Click(object sender, EventArgs e) {
            if (tbLink.Text == "") return;
            if (tbRegister.Text == "") return;

            var data = new itemData {
                Title = tbRegister.Text,
                Link = tbLink.Text,
            };

            if (itemsContains(data)) cbUrl.Items.Add(data);

            tbRegister.Text = "";
            tbLink.Text = "";
        }

        //ListBoxが選択された時
        private void lbRssTitle_Click(object sender, EventArgs e) {
            if (lbRssTitle.SelectedIndex == -1) return;
            wbBrowser.Navigate(nodes[lbRssTitle.SelectedIndex].Link);
        }

        //RadioButtonが選択された時
        private void rb_CheckedChanged(object sender, EventArgs e) {
            if (topics.Count != 0) {
                foreach (RadioButton item in gbTopics.Controls) {
                    if (item.Checked)
                        tbLink.Text = topics[int.Parse(item.Tag.ToString())];
                }
            }
            else {
                MessageBox.Show("URLが登録されていません");
            }
            cbUrl.SelectedIndex = -1;
        }

        //登録されたItemが選択された時
        private void cbUrl_SelectionChangeCommitted(object sender, EventArgs e) {
            var item = (itemData)((ComboBox)sender).SelectedItem;
            if (item == null) return;
            tbLink.Text = item.Link;
        }

        //登録する名前とURLが重複しているか調べる
        private bool itemsContains(itemData data) {
            foreach (itemData item in cbUrl.Items) {
                if (item.Title.Contains(data.Title) || item.Link.Contains(data.Link))
                    return false;
            }
            return true;
        }
    }
}
