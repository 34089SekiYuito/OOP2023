using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        List<itemData> nodes;
        List<string> topics = new List<string>();

        public Form1() {
            InitializeComponent();
            topics = GetList("RssUrl.txt");
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
            if (tbLink.Text == "") return;
            try {
                lbRssTitle.Items.Clear();
                nodes = null;
                using (var wc = new WebClient()) {
                    var url = wc.OpenRead(tbLink.Text);
                    XDocument xdoc = XDocument.Load(url);
                    nodes = xdoc.Root.Descendants("item").Select(x => new itemData {
                        Title = x.Element("title").Value,
                        Link = x.Element("link").Value
                    }).ToList();
                    foreach (var node in nodes) {
                        lbRssTitle.Items.Add(node.Title);
                    }
                }
            }
            catch {
                MessageBox.Show("URlが正しくありません");
            }
            
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
            if(topics.Count != 0) {
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
