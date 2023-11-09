using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        List<itemData> nodes;
        List<string> topics = new List<string> {
            @"https://news.yahoo.co.jp/rss/topics/top-picks.xml",
            @"https://news.yahoo.co.jp/rss/topics/domestic.xml",
            @"https://news.yahoo.co.jp/rss/topics/world.xml",
            @"https://news.yahoo.co.jp/rss/topics/business.xml",
            @"https://news.yahoo.co.jp/rss/topics/entertainment.xml",
            @"https://news.yahoo.co.jp/rss/topics/sports.xml",
            @"https://news.yahoo.co.jp/rss/topics/it.xml",
            @"https://news.yahoo.co.jp/rss/topics/science.xml",
            @"https://news.yahoo.co.jp/rss/topics/science.xml",
        };
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            if (tbLink.Text == "") return;
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

        private void lbRssTitle_Click(object sender, EventArgs e) {
            if (lbRssTitle.SelectedIndex == -1) return;
            wbBrowser.Navigate(nodes[lbRssTitle.SelectedIndex].Link);
        }

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

        

        private void rb_CheckedChanged(object sender, EventArgs e) {
            foreach (RadioButton item in gbTopics.Controls) {
                if (item.Checked)
                    tbLink.Text = topics[int.Parse(item.Tag.ToString())];
            }
            cbUrl.SelectedIndex = -1;
        }

        private void cbUrl_SelectionChangeCommitted(object sender, EventArgs e) {
            var item = (itemData)((ComboBox)sender).SelectedItem;
            if (item == null) return;
            tbLink.Text = item.Link;
        }

        private bool itemsContains(itemData data) {
            foreach (itemData item in cbUrl.Items) {
                if (item.Title.Contains(data.Title) || item.Link.Contains(data.Link))
                    return false;
            }
            return true;
        }
    }
}
