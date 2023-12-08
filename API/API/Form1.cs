using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

//楽天　パスワード　OIBC34089@

namespace API
{
    public partial class Form1 : Form
    {
        List<itemData> nodes;
        List<string> topics = new List<string>();
        //SampleServiceHttpClient test;

        public Form1()
        {
            InitializeComponent();
            topics = GetList("RssUrl.txt");
            //test = new SampleServiceHttpClient(@"https://app.rakuten.co.jp/services/api/Travel/SimpleHotelSearch/20170426?format=xml&applicationId=1079385179510929202");
        }

        //RssのUrlを取得
        private List<string> GetList(string Path)
        {
            List<string> Topics = new List<string>();
            if (File.Exists(Path))
            {
                using (var reader = new StreamReader(Path, Encoding.UTF8))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        Topics.Add(line);
                    }
                }
            }
            return Topics;
        }

        //取得ボタンクリック
        private void btGet_Click(object sender, EventArgs e)
        {



            //var str = test.GetSample("a");

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
        private void btRegister_Click(object sender, EventArgs e)
        {
            if (tbLink.Text == "") return;
            if (tbRegister.Text == "") return;

            var data = new itemData
            {
                Title = tbRegister.Text,
                Link = tbLink.Text,
            };

            if (itemsContains(data)) cbUrl.Items.Add(data);

            tbRegister.Text = "";
            tbLink.Text = "";
        }

        //ListBoxが選択された時
        private void lbRssTitle_Click(object sender, EventArgs e)
        {
            if (lbRssTitle.SelectedIndex == -1) return;
            wbBrowser.Navigate(nodes[lbRssTitle.SelectedIndex].Link);
        }

        //RadioButtonが選択された時
        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            if (topics.Count != 0)
            {
                foreach (RadioButton item in gbTopics.Controls)
                {
                    if (item.Checked)
                        tbLink.Text = topics[int.Parse(item.Tag.ToString())];
                }
            }
            else
            {
                MessageBox.Show("URLが登録されていません");
            }
            cbUrl.SelectedIndex = -1;
        }

        //登録されたItemが選択された時
        private void cbUrl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var item = (itemData)((ComboBox)sender).SelectedItem;
            if (item == null) return;
            tbLink.Text = item.Link;
        }

        //登録する名前とURLが重複しているか調べる
        private bool itemsContains(itemData data)
        {
            foreach (itemData item in cbUrl.Items)
            {
                if (item.Title.Contains(data.Title) || item.Link.Contains(data.Link))
                    return false;
            }
            return true;
        }
    }

    #region API
    //internal class SampleServiceHttpClient
    //{
    //    /// <summary>
    //    /// 通信先のベースURL
    //    /// </summary>
    //    public string baseUrl;
    //    /// <summary>
    //    /// C#側のHttpクライアント
    //    /// </summary>
    //    public HttpClient httpClient;

    //    /// <summary>
    //    /// デフォルトコンストラクタ。外部からは呼び出せません。
    //    /// </summary>
    //    private SampleServiceHttpClient()
    //    {
    //    }

    //    /// <summary>
    //    /// 引数付きのコンストラクタ。こちらを使用します。
    //    /// 引数には正しいURLが入っていることが前提です。
    //    /// </summary>
    //    /// <param name="baseUrl">ベースのURL</param>
    //    public SampleServiceHttpClient(string baseUrl)
    //    {
    //        this.baseUrl = baseUrl;
    //        // 通信するメソッドでその都度HttpClientをnewすると毎回ソケットを
    //        // 開いてリソースを消費するため、
    //        // メンバ変数で使い回す手法を取っています。
    //        this.httpClient = new HttpClient();
    //    }

    //    public string GetSample(string someId)
    //    {
    //        String requestEndPoint = this.baseUrl + "/some/search/?someId=" + "&largeClassCode=japan&middleClassCode=nagasaki&smallClassCode=nagasaki";
    //        HttpRequestMessage request
    //            = new HttpRequestMessage(HttpMethod.Get, requestEndPoint);

    //        string resBodyStr;
    //        HttpStatusCode resStatusCoode = HttpStatusCode.NotFound;
    //        Task<HttpResponseMessage> response;
    //        // 通信実行。メンバ変数でhttpClientを持っているので、using(～)で囲いません。
    //        // 囲うと通信後にオブジェクトが破棄されます。
    //        // 引数にrequestを取る場合はGetAsyncやPostAsyncでなくSendAsyncメソッドになります。
    //        // 戻り値はTask<HttpResponseMessage>で、変数名.Resultとすると
    //        // System.Net.Http.HttpResponseMessageクラスが取れます。
    //        try
    //        {
    //            response = httpClient.SendAsync(request);
    //            resBodyStr = response.Result.Content.ReadAsStringAsync().Result;
    //            resStatusCoode = response.Result.StatusCode;
    //        }
    //        catch (HttpRequestException e)
    //        {
    //            // UNDONE: 通信失敗のエラー処理
    //            return null;
    //        }

    //        if (!resStatusCoode.Equals(HttpStatusCode.OK))
    //        {
    //            // UNDONE: レスポンスが200 OK以外の場合のエラー処理
    //            return null;
    //        }
    //        if (String.IsNullOrEmpty(resBodyStr))
    //        {
    //            // UNDONE: レスポンスのボディが空の場合のエラー処理
    //            return null;
    //        }
    //        // 中身のチェックなどを経て終了。
    //        return resBodyStr;
    //    }
    //}
    #endregion
}
