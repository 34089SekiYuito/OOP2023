
namespace CalendarApp {
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btDayCalc = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.subYear = new System.Windows.Forms.Button();
            this.subMon = new System.Windows.Forms.Button();
            this.subDay = new System.Windows.Forms.Button();
            this.addYear = new System.Windows.Forms.Button();
            this.addMon = new System.Windows.Forms.Button();
            this.addDay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTimeNow = new System.Windows.Forms.TextBox();
            this.btAge = new System.Windows.Forms.Button();
            this.tmTimeDisp = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpDate.Location = new System.Drawing.Point(104, 18);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 31);
            this.dtpDate.TabIndex = 1;
            // 
            // btDayCalc
            // 
            this.btDayCalc.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDayCalc.Location = new System.Drawing.Point(104, 68);
            this.btDayCalc.Name = "btDayCalc";
            this.btDayCalc.Size = new System.Drawing.Size(116, 38);
            this.btDayCalc.TabIndex = 2;
            this.btDayCalc.Text = "日数計算";
            this.btDayCalc.UseVisualStyleBackColor = true;
            this.btDayCalc.Click += new System.EventHandler(this.btDayCalc_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMessage.Location = new System.Drawing.Point(310, 18);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(300, 241);
            this.tbMessage.TabIndex = 3;
            // 
            // subYear
            // 
            this.subYear.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.subYear.Location = new System.Drawing.Point(104, 179);
            this.subYear.Name = "subYear";
            this.subYear.Size = new System.Drawing.Size(87, 39);
            this.subYear.TabIndex = 4;
            this.subYear.Text = "-年";
            this.subYear.UseVisualStyleBackColor = true;
            this.subYear.Click += new System.EventHandler(this.subYear_Click);
            // 
            // subMon
            // 
            this.subMon.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.subMon.Location = new System.Drawing.Point(104, 224);
            this.subMon.Name = "subMon";
            this.subMon.Size = new System.Drawing.Size(87, 39);
            this.subMon.TabIndex = 5;
            this.subMon.Text = "-月";
            this.subMon.UseVisualStyleBackColor = true;
            this.subMon.Click += new System.EventHandler(this.subMon_Click);
            // 
            // subDay
            // 
            this.subDay.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.subDay.Location = new System.Drawing.Point(104, 269);
            this.subDay.Name = "subDay";
            this.subDay.Size = new System.Drawing.Size(87, 39);
            this.subDay.TabIndex = 6;
            this.subDay.Text = "-日";
            this.subDay.UseVisualStyleBackColor = true;
            this.subDay.Click += new System.EventHandler(this.subDay_Click);
            // 
            // addYear
            // 
            this.addYear.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.addYear.Location = new System.Drawing.Point(206, 179);
            this.addYear.Name = "addYear";
            this.addYear.Size = new System.Drawing.Size(87, 39);
            this.addYear.TabIndex = 7;
            this.addYear.Text = "+年";
            this.addYear.UseVisualStyleBackColor = true;
            this.addYear.Click += new System.EventHandler(this.addYear_Click);
            // 
            // addMon
            // 
            this.addMon.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.addMon.Location = new System.Drawing.Point(206, 224);
            this.addMon.Name = "addMon";
            this.addMon.Size = new System.Drawing.Size(87, 39);
            this.addMon.TabIndex = 8;
            this.addMon.Text = "+月";
            this.addMon.UseVisualStyleBackColor = true;
            this.addMon.Click += new System.EventHandler(this.addMon_Click);
            // 
            // addDay
            // 
            this.addDay.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.addDay.Location = new System.Drawing.Point(206, 269);
            this.addDay.Name = "addDay";
            this.addDay.Size = new System.Drawing.Size(87, 39);
            this.addDay.TabIndex = 9;
            this.addDay.Text = "+日";
            this.addDay.UseVisualStyleBackColor = true;
            this.addDay.Click += new System.EventHandler(this.addDay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "現在時刻：";
            // 
            // tbTimeNow
            // 
            this.tbTimeNow.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTimeNow.Location = new System.Drawing.Point(162, 368);
            this.tbTimeNow.Multiline = true;
            this.tbTimeNow.Name = "tbTimeNow";
            this.tbTimeNow.Size = new System.Drawing.Size(448, 29);
            this.tbTimeNow.TabIndex = 11;
            // 
            // btAge
            // 
            this.btAge.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAge.Location = new System.Drawing.Point(104, 121);
            this.btAge.Name = "btAge";
            this.btAge.Size = new System.Drawing.Size(116, 38);
            this.btAge.TabIndex = 12;
            this.btAge.Text = "年齢";
            this.btAge.UseVisualStyleBackColor = true;
            this.btAge.Click += new System.EventHandler(this.btAge_Click);
            // 
            // tmTimeDisp
            // 
            this.tmTimeDisp.Interval = 500;
            this.tmTimeDisp.Tick += new System.EventHandler(this.tmTimeDisp_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.btAge);
            this.Controls.Add(this.tbTimeNow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addDay);
            this.Controls.Add(this.addMon);
            this.Controls.Add(this.addYear);
            this.Controls.Add(this.subDay);
            this.Controls.Add(this.subMon);
            this.Controls.Add(this.subYear);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btDayCalc);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "カレンダーアプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btDayCalc;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button subYear;
        private System.Windows.Forms.Button subMon;
        private System.Windows.Forms.Button subDay;
        private System.Windows.Forms.Button addYear;
        private System.Windows.Forms.Button addMon;
        private System.Windows.Forms.Button addDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTimeNow;
        private System.Windows.Forms.Button btAge;
        private System.Windows.Forms.Timer tmTimeDisp;
    }
}

