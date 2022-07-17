namespace StockMarket
{
    partial class MainStockMarket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.stockview = new System.Windows.Forms.ListView();
            this.stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.updown = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.updownrate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.situation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mystockview = new System.Windows.Forms.ListView();
            this.stock_my = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price_my = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount_my = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.min = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.save = new System.Windows.Forms.Button();
            this.show_price_label = new System.Windows.Forms.Label();
            this.show_price = new System.Windows.Forms.Label();
            this.trade_text_price = new System.Windows.Forms.TextBox();
            this.trade_stock_sele = new System.Windows.Forms.Button();
            this.trade_stock_buy = new System.Windows.Forms.Button();
            this.trade_stock_total = new System.Windows.Forms.Label();
            this.trade_total = new System.Windows.Forms.Label();
            this.trade_amount = new System.Windows.Forms.Label();
            this.trade_stock_amount = new System.Windows.Forms.NumericUpDown();
            this.user_money = new System.Windows.Forms.Label();
            this.user_money_label = new System.Windows.Forms.Label();
            this.trade_price = new System.Windows.Forms.Label();
            this.trade_stock_name = new System.Windows.Forms.Label();
            this.trade_name = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stock_timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trade_stock_amount)).BeginInit();
            this.SuspendLayout();
            // 
            // stockview
            // 
            this.stockview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stockview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stock,
            this.price,
            this.updown,
            this.updownrate,
            this.situation});
            this.stockview.Location = new System.Drawing.Point(19, 32);
            this.stockview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stockview.Name = "stockview";
            this.stockview.Size = new System.Drawing.Size(1253, 290);
            this.stockview.TabIndex = 0;
            this.stockview.UseCompatibleStateImageBehavior = false;
            this.stockview.View = System.Windows.Forms.View.Details;
            this.stockview.SelectedIndexChanged += new System.EventHandler(this.stockview_SelectedIndexChanged);
            this.stockview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stockview_MouseClick);
            // 
            // stock
            // 
            this.stock.Text = "STOCK";
            this.stock.Width = 300;
            // 
            // price
            // 
            this.price.Text = "PRICE";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price.Width = 300;
            // 
            // updown
            // 
            this.updown.Text = "UpDown";
            this.updown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updown.Width = 300;
            // 
            // updownrate
            // 
            this.updownrate.Text = "UpDownRate";
            this.updownrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updownrate.Width = 300;
            // 
            // situation
            // 
            this.situation.Text = "Situation";
            this.situation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.situation.Width = 230;
            // 
            // mystockview
            // 
            this.mystockview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mystockview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stock_my,
            this.price_my,
            this.amount_my});
            this.mystockview.Location = new System.Drawing.Point(19, 385);
            this.mystockview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mystockview.Name = "mystockview";
            this.mystockview.Size = new System.Drawing.Size(933, 278);
            this.mystockview.TabIndex = 1;
            this.mystockview.UseCompatibleStateImageBehavior = false;
            this.mystockview.View = System.Windows.Forms.View.Details;
            this.mystockview.SelectedIndexChanged += new System.EventHandler(this.mystockview_SelectedIndexChanged);
            this.mystockview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mystockview_MouseClick);
            // 
            // stock_my
            // 
            this.stock_my.Text = "STOCK";
            this.stock_my.Width = 350;
            // 
            // price_my
            // 
            this.price_my.Text = "PRICE";
            this.price_my.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price_my.Width = 350;
            // 
            // amount_my
            // 
            this.amount_my.Text = "AMOUNT";
            this.amount_my.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amount_my.Width = 364;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.min);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.hour);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.month);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.year);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.user_name);
            this.groupBox1.Controls.Add(this.mystockview);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.stockview);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(5, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1284, 674);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Market";
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(775, 346);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(64, 12);
            this.min.TabIndex = 14;
            this.min.Text = "MINUTE : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(844, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(710, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "*";
            // 
            // hour
            // 
            this.hour.AutoSize = true;
            this.hour.Location = new System.Drawing.Point(658, 346);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(50, 12);
            this.hour.TabIndex = 11;
            this.hour.Text = "HOUR : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "*";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(516, 346);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(49, 12);
            this.date.TabIndex = 9;
            this.date.Text = "DATE : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "*";
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Location = new System.Drawing.Point(335, 346);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(62, 12);
            this.month.TabIndex = 7;
            this.month.Text = "MONTH : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "*";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(160, 346);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(49, 12);
            this.year.TabIndex = 5;
            this.year.Text = "YEAR : ";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(67, 346);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(11, 12);
            this.name.TabIndex = 4;
            this.name.Text = "*";
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Location = new System.Drawing.Point(17, 346);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(49, 12);
            this.user_name.TabIndex = 3;
            this.user_name.Text = "USER : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(5, 368);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(959, 299);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "My Stock";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.save);
            this.groupBox4.Controls.Add(this.show_price_label);
            this.groupBox4.Controls.Add(this.show_price);
            this.groupBox4.Controls.Add(this.trade_text_price);
            this.groupBox4.Controls.Add(this.trade_stock_sele);
            this.groupBox4.Controls.Add(this.trade_stock_buy);
            this.groupBox4.Controls.Add(this.trade_stock_total);
            this.groupBox4.Controls.Add(this.trade_total);
            this.groupBox4.Controls.Add(this.trade_amount);
            this.groupBox4.Controls.Add(this.trade_stock_amount);
            this.groupBox4.Controls.Add(this.user_money);
            this.groupBox4.Controls.Add(this.user_money_label);
            this.groupBox4.Controls.Add(this.trade_price);
            this.groupBox4.Controls.Add(this.trade_stock_name);
            this.groupBox4.Controls.Add(this.trade_name);
            this.groupBox4.Location = new System.Drawing.Point(970, 327);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(308, 340);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trade";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(28, 312);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(227, 23);
            this.save.TabIndex = 30;
            this.save.Text = "Save and Close";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // show_price_label
            // 
            this.show_price_label.AutoSize = true;
            this.show_price_label.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.show_price_label.Location = new System.Drawing.Point(157, 86);
            this.show_price_label.Name = "show_price_label";
            this.show_price_label.Size = new System.Drawing.Size(15, 16);
            this.show_price_label.TabIndex = 29;
            this.show_price_label.Text = "*";
            // 
            // show_price
            // 
            this.show_price.AutoSize = true;
            this.show_price.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.show_price.Location = new System.Drawing.Point(12, 86);
            this.show_price.Name = "show_price";
            this.show_price.Size = new System.Drawing.Size(131, 16);
            this.show_price.TabIndex = 28;
            this.show_price.Text = "SHOW PRICE : ";
            // 
            // trade_text_price
            // 
            this.trade_text_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trade_text_price.Location = new System.Drawing.Point(157, 119);
            this.trade_text_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trade_text_price.Name = "trade_text_price";
            this.trade_text_price.Size = new System.Drawing.Size(94, 14);
            this.trade_text_price.TabIndex = 27;
            this.trade_text_price.TextChanged += new System.EventHandler(this.trade_text_price_TextChanged);
            // 
            // trade_stock_sele
            // 
            this.trade_stock_sele.Location = new System.Drawing.Point(160, 249);
            this.trade_stock_sele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trade_stock_sele.Name = "trade_stock_sele";
            this.trade_stock_sele.Size = new System.Drawing.Size(95, 45);
            this.trade_stock_sele.TabIndex = 26;
            this.trade_stock_sele.Text = "SELL";
            this.trade_stock_sele.UseVisualStyleBackColor = true;
            this.trade_stock_sele.Click += new System.EventHandler(this.trade_stock_sele_Click);
            // 
            // trade_stock_buy
            // 
            this.trade_stock_buy.Location = new System.Drawing.Point(28, 249);
            this.trade_stock_buy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trade_stock_buy.Name = "trade_stock_buy";
            this.trade_stock_buy.Size = new System.Drawing.Size(95, 45);
            this.trade_stock_buy.TabIndex = 25;
            this.trade_stock_buy.Text = "BUY";
            this.trade_stock_buy.UseVisualStyleBackColor = true;
            this.trade_stock_buy.Click += new System.EventHandler(this.trade_stock_buy_Click);
            // 
            // trade_stock_total
            // 
            this.trade_stock_total.AutoSize = true;
            this.trade_stock_total.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.trade_stock_total.Location = new System.Drawing.Point(153, 219);
            this.trade_stock_total.Name = "trade_stock_total";
            this.trade_stock_total.Size = new System.Drawing.Size(15, 16);
            this.trade_stock_total.TabIndex = 24;
            this.trade_stock_total.Text = "*";
            // 
            // trade_total
            // 
            this.trade_total.AutoSize = true;
            this.trade_total.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.trade_total.Location = new System.Drawing.Point(64, 219);
            this.trade_total.Name = "trade_total";
            this.trade_total.Size = new System.Drawing.Size(80, 16);
            this.trade_total.TabIndex = 23;
            this.trade_total.Text = "TOTAL : ";
            // 
            // trade_amount
            // 
            this.trade_amount.AutoSize = true;
            this.trade_amount.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.trade_amount.Location = new System.Drawing.Point(48, 177);
            this.trade_amount.Name = "trade_amount";
            this.trade_amount.Size = new System.Drawing.Size(98, 16);
            this.trade_amount.TabIndex = 22;
            this.trade_amount.Text = "AMOUNT : ";
            // 
            // trade_stock_amount
            // 
            this.trade_stock_amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trade_stock_amount.Location = new System.Drawing.Point(157, 177);
            this.trade_stock_amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trade_stock_amount.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.trade_stock_amount.Name = "trade_stock_amount";
            this.trade_stock_amount.Size = new System.Drawing.Size(43, 17);
            this.trade_stock_amount.TabIndex = 21;
            this.trade_stock_amount.ValueChanged += new System.EventHandler(this.trade_stock_amount_ValueChanged);
            // 
            // user_money
            // 
            this.user_money.AutoSize = true;
            this.user_money.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_money.Location = new System.Drawing.Point(6, 149);
            this.user_money.Name = "user_money";
            this.user_money.Size = new System.Drawing.Size(138, 16);
            this.user_money.TabIndex = 19;
            this.user_money.Text = "USER MONEY : ";
            // 
            // user_money_label
            // 
            this.user_money_label.AutoSize = true;
            this.user_money_label.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_money_label.Location = new System.Drawing.Point(153, 149);
            this.user_money_label.Name = "user_money_label";
            this.user_money_label.Size = new System.Drawing.Size(15, 16);
            this.user_money_label.TabIndex = 18;
            this.user_money_label.Text = "*";
            // 
            // trade_price
            // 
            this.trade_price.AutoSize = true;
            this.trade_price.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.trade_price.Location = new System.Drawing.Point(73, 116);
            this.trade_price.Name = "trade_price";
            this.trade_price.Size = new System.Drawing.Size(75, 16);
            this.trade_price.TabIndex = 17;
            this.trade_price.Text = "PRICE : ";
            // 
            // trade_stock_name
            // 
            this.trade_stock_name.AutoSize = true;
            this.trade_stock_name.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.trade_stock_name.Location = new System.Drawing.Point(157, 58);
            this.trade_stock_name.Name = "trade_stock_name";
            this.trade_stock_name.Size = new System.Drawing.Size(15, 16);
            this.trade_stock_name.TabIndex = 16;
            this.trade_stock_name.Text = "*";
            // 
            // trade_name
            // 
            this.trade_name.AutoSize = true;
            this.trade_name.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.trade_name.Location = new System.Drawing.Point(62, 58);
            this.trade_name.Name = "trade_name";
            this.trade_name.Size = new System.Drawing.Size(83, 16);
            this.trade_name.TabIndex = 15;
            this.trade_name.Text = "STOCK : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(3, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1275, 314);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock Info";
            // 
            // stock_timer
            // 
            this.stock_timer.Enabled = true;
            this.stock_timer.Interval = 5000;
            this.stock_timer.Tick += new System.EventHandler(this.stock_timer_Tick);
            // 
            // MainStockMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 679);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(200, 200);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainStockMarket";
            this.Text = "MainStockMarket";
            this.Load += new System.EventHandler(this.MainStockMarket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trade_stock_amount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView stockview;
        private System.Windows.Forms.ListView mystockview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer stock_timer;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label hour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Button trade_stock_sele;
        private System.Windows.Forms.Button trade_stock_buy;
        private System.Windows.Forms.Label trade_stock_total;
        private System.Windows.Forms.Label trade_total;
        private System.Windows.Forms.Label trade_amount;
        private System.Windows.Forms.NumericUpDown trade_stock_amount;
        private System.Windows.Forms.Label user_money;
        private System.Windows.Forms.Label user_money_label;
        private System.Windows.Forms.Label trade_price;
        private System.Windows.Forms.Label trade_stock_name;
        private System.Windows.Forms.Label trade_name;
        public System.Windows.Forms.ColumnHeader stock;
        public System.Windows.Forms.ColumnHeader price;
        public System.Windows.Forms.ColumnHeader updown;
        public System.Windows.Forms.ColumnHeader updownrate;
        public System.Windows.Forms.ColumnHeader situation;
        public System.Windows.Forms.ColumnHeader stock_my;
        public System.Windows.Forms.ColumnHeader price_my;
        public System.Windows.Forms.ColumnHeader amount_my;
        private System.Windows.Forms.TextBox trade_text_price;
        private System.Windows.Forms.Label show_price_label;
        private System.Windows.Forms.Label show_price;
        private System.Windows.Forms.Button save;
    }
}