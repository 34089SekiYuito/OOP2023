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
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //using (var wc = new WebClient()) {
            //    wc.Encoding = Encoding.UTF8;
            //    var url = wc.OpenRead(@"https://news.yahoo.co.jp/rss");
            //    XDocument xdoc = XDocument.Load(url);
            //    var topics = xdoc.Descendants("li").Descendants("a");
            //    foreach (var topic in topics) {
            //        if (topic.FirstAttribute.Value.Contains(".xml")
            //            && !cbCategory.Items.Contains(topic.Value)) {
            //            cbCategory.Items.Add(topic.Value);
            //        }
            //    }
            //}
        }

        private void btGet_Click(object sender, EventArgs e) {
            if (cbUrl.Text == "") return;
            lbRssTitle.Items.Clear();
            nodes = null;
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(cbUrl.Text);
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
            if (cbUrl.Text == "") return;
            
        }
    }
}
