
namespace API {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.cbUrl = new System.Windows.Forms.ComboBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.gbTopics = new System.Windows.Forms.GroupBox();
            this.rb地域 = new System.Windows.Forms.RadioButton();
            this.rb科学 = new System.Windows.Forms.RadioButton();
            this.rbIT = new System.Windows.Forms.RadioButton();
            this.rbスポーツ = new System.Windows.Forms.RadioButton();
            this.rbエンタメ = new System.Windows.Forms.RadioButton();
            this.rb経済 = new System.Windows.Forms.RadioButton();
            this.rb国際 = new System.Windows.Forms.RadioButton();
            this.rb国内 = new System.Windows.Forms.RadioButton();
            this.rb主要 = new System.Windows.Forms.RadioButton();
            this.tbRegister = new System.Windows.Forms.TextBox();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbTopics.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(842, 17);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(83, 31);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 16;
            this.lbRssTitle.Location = new System.Drawing.Point(14, 146);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(913, 116);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.Click += new System.EventHandler(this.lbRssTitle_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(12, 268);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(913, 407);
            this.wbBrowser.TabIndex = 3;
            this.wbBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // cbUrl
            // 
            this.cbUrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUrl.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbUrl.FormattingEnabled = true;
            this.cbUrl.Location = new System.Drawing.Point(14, 54);
            this.cbUrl.Name = "cbUrl";
            this.cbUrl.Size = new System.Drawing.Size(505, 32);
            this.cbUrl.TabIndex = 5;
            this.cbUrl.SelectionChangeCommitted += new System.EventHandler(this.cbUrl_SelectionChangeCommitted);
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(842, 54);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(83, 31);
            this.btRegister.TabIndex = 6;
            this.btRegister.Text = "登録";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // gbTopics
            // 
            this.gbTopics.Controls.Add(this.rb地域);
            this.gbTopics.Controls.Add(this.rb科学);
            this.gbTopics.Controls.Add(this.rbIT);
            this.gbTopics.Controls.Add(this.rbスポーツ);
            this.gbTopics.Controls.Add(this.rbエンタメ);
            this.gbTopics.Controls.Add(this.rb経済);
            this.gbTopics.Controls.Add(this.rb国際);
            this.gbTopics.Controls.Add(this.rb国内);
            this.gbTopics.Controls.Add(this.rb主要);
            this.gbTopics.Location = new System.Drawing.Point(14, 92);
            this.gbTopics.Name = "gbTopics";
            this.gbTopics.Size = new System.Drawing.Size(913, 48);
            this.gbTopics.TabIndex = 7;
            this.gbTopics.TabStop = false;
            this.gbTopics.Text = "Topics";
            // 
            // rb地域
            // 
            this.rb地域.AutoSize = true;
            this.rb地域.Location = new System.Drawing.Point(847, 19);
            this.rb地域.Name = "rb地域";
            this.rb地域.Size = new System.Drawing.Size(47, 16);
            this.rb地域.TabIndex = 8;
            this.rb地域.TabStop = true;
            this.rb地域.Tag = "8";
            this.rb地域.Text = "地域";
            this.rb地域.UseVisualStyleBackColor = true;
            this.rb地域.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb科学
            // 
            this.rb科学.AutoSize = true;
            this.rb科学.Location = new System.Drawing.Point(630, 18);
            this.rb科学.Name = "rb科学";
            this.rb科学.Size = new System.Drawing.Size(47, 16);
            this.rb科学.TabIndex = 7;
            this.rb科学.TabStop = true;
            this.rb科学.Tag = "6";
            this.rb科学.Text = "科学";
            this.rb科学.UseVisualStyleBackColor = true;
            this.rb科学.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbIT
            // 
            this.rbIT.AutoSize = true;
            this.rbIT.Location = new System.Drawing.Point(529, 18);
            this.rbIT.Name = "rbIT";
            this.rbIT.Size = new System.Drawing.Size(33, 16);
            this.rbIT.TabIndex = 6;
            this.rbIT.TabStop = true;
            this.rbIT.Tag = "5";
            this.rbIT.Text = "IT";
            this.rbIT.UseVisualStyleBackColor = true;
            this.rbIT.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbスポーツ
            // 
            this.rbスポーツ.AutoSize = true;
            this.rbスポーツ.Location = new System.Drawing.Point(410, 18);
            this.rbスポーツ.Name = "rbスポーツ";
            this.rbスポーツ.Size = new System.Drawing.Size(61, 16);
            this.rbスポーツ.TabIndex = 5;
            this.rbスポーツ.TabStop = true;
            this.rbスポーツ.Tag = "4";
            this.rbスポーツ.Text = "スポーツ";
            this.rbスポーツ.UseVisualStyleBackColor = true;
            this.rbスポーツ.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbエンタメ
            // 
            this.rbエンタメ.AutoSize = true;
            this.rbエンタメ.Location = new System.Drawing.Point(305, 18);
            this.rbエンタメ.Name = "rbエンタメ";
            this.rbエンタメ.Size = new System.Drawing.Size(57, 16);
            this.rbエンタメ.TabIndex = 4;
            this.rbエンタメ.TabStop = true;
            this.rbエンタメ.Tag = "3";
            this.rbエンタメ.Text = "エンタメ";
            this.rbエンタメ.UseVisualStyleBackColor = true;
            this.rbエンタメ.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb経済
            // 
            this.rb経済.AutoSize = true;
            this.rb経済.Location = new System.Drawing.Point(209, 18);
            this.rb経済.Name = "rb経済";
            this.rb経済.Size = new System.Drawing.Size(47, 16);
            this.rb経済.TabIndex = 3;
            this.rb経済.TabStop = true;
            this.rb経済.Tag = "2";
            this.rb経済.Text = "経済";
            this.rb経済.UseVisualStyleBackColor = true;
            this.rb経済.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb国際
            // 
            this.rb国際.AutoSize = true;
            this.rb国際.Location = new System.Drawing.Point(104, 18);
            this.rb国際.Name = "rb国際";
            this.rb国際.Size = new System.Drawing.Size(47, 16);
            this.rb国際.TabIndex = 2;
            this.rb国際.TabStop = true;
            this.rb国際.Tag = "1";
            this.rb国際.Text = "国際";
            this.rb国際.UseVisualStyleBackColor = true;
            this.rb国際.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb国内
            // 
            this.rb国内.AutoSize = true;
            this.rb国内.Location = new System.Drawing.Point(6, 18);
            this.rb国内.Name = "rb国内";
            this.rb国内.Size = new System.Drawing.Size(47, 16);
            this.rb国内.TabIndex = 1;
            this.rb国内.TabStop = true;
            this.rb国内.Tag = "0";
            this.rb国内.Text = "国内";
            this.rb国内.UseVisualStyleBackColor = true;
            this.rb国内.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb主要
            // 
            this.rb主要.AutoSize = true;
            this.rb主要.Location = new System.Drawing.Point(742, 19);
            this.rb主要.Name = "rb主要";
            this.rb主要.Size = new System.Drawing.Size(48, 16);
            this.rb主要.TabIndex = 0;
            this.rb主要.TabStop = true;
            this.rb主要.Tag = "7";
            this.rb主要.Text = "ライフ";
            this.rb主要.UseVisualStyleBackColor = true;
            this.rb主要.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // tbRegister
            // 
            this.tbRegister.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbRegister.Location = new System.Drawing.Point(525, 54);
            this.tbRegister.Name = "tbRegister";
            this.tbRegister.Size = new System.Drawing.Size(311, 31);
            this.tbRegister.TabIndex = 8;
            this.toolTip1.SetToolTip(this.tbRegister, "登録する名前");
            // 
            // tbLink
            // 
            this.tbLink.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbLink.Location = new System.Drawing.Point(12, 12);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(824, 31);
            this.tbLink.TabIndex = 9;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 699);
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.tbRegister);
            this.Controls.Add(this.gbTopics);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.cbUrl);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbTopics.ResumeLayout(false);
            this.gbTopics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.ComboBox cbUrl;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.GroupBox gbTopics;
        private System.Windows.Forms.RadioButton rb科学;
        private System.Windows.Forms.RadioButton rbIT;
        private System.Windows.Forms.RadioButton rbスポーツ;
        private System.Windows.Forms.RadioButton rbエンタメ;
        private System.Windows.Forms.RadioButton rb経済;
        private System.Windows.Forms.RadioButton rb国際;
        private System.Windows.Forms.RadioButton rb国内;
        private System.Windows.Forms.RadioButton rb主要;
        private System.Windows.Forms.RadioButton rb地域;
        private System.Windows.Forms.TextBox tbRegister;
        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

