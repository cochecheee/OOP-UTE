namespace PhoneStore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lb_tenThietBi = new Label();
            lb_namSanXuat = new Label();
            lb__Color = new Label();
            lb_seriesNum = new Label();
            lb_Producer = new Label();
            lb_Price = new Label();
            textBox_deviceName = new TextBox();
            textBox_year = new TextBox();
            textBox_Color = new TextBox();
            textBox_seriesNum = new TextBox();
            textBox_producer = new TextBox();
            textBox_price = new TextBox();
            btn_Input = new Button();
            btn_display = new Button();
            lb_View = new ListBox();
            label2 = new Label();
            textBox_soLuong = new TextBox();
            btn_Set = new Button();
            comboBox_setYearorPrice = new ComboBox();
            btn_decrease = new Button();
            btn_encrease = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox_lienhe = new TextBox();
            textBox_diachi = new TextBox();
            textBox_search = new TextBox();
            button_searchtenmay = new Button();
            button_searchhang = new Button();
            button_searchgia = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 15);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // lb_tenThietBi
            // 
            lb_tenThietBi.AutoSize = true;
            lb_tenThietBi.Location = new Point(66, 88);
            lb_tenThietBi.Name = "lb_tenThietBi";
            lb_tenThietBi.Size = new Size(83, 20);
            lb_tenThietBi.TabIndex = 1;
            lb_tenThietBi.Text = "Tên thiết bị";
            // 
            // lb_namSanXuat
            // 
            lb_namSanXuat.AutoSize = true;
            lb_namSanXuat.Location = new Point(66, 140);
            lb_namSanXuat.Name = "lb_namSanXuat";
            lb_namSanXuat.Size = new Size(99, 20);
            lb_namSanXuat.TabIndex = 1;
            lb_namSanXuat.Text = "Năm sản xuất";
            // 
            // lb__Color
            // 
            lb__Color.AutoSize = true;
            lb__Color.Location = new Point(66, 186);
            lb__Color.Name = "lb__Color";
            lb__Color.Size = new Size(63, 20);
            lb__Color.TabIndex = 1;
            lb__Color.Text = "Màu sắc";
            // 
            // lb_seriesNum
            // 
            lb_seriesNum.AutoSize = true;
            lb_seriesNum.Location = new Point(66, 227);
            lb_seriesNum.Name = "lb_seriesNum";
            lb_seriesNum.Size = new Size(67, 20);
            lb_seriesNum.TabIndex = 1;
            lb_seriesNum.Text = "Số series";
            // 
            // lb_Producer
            // 
            lb_Producer.AutoSize = true;
            lb_Producer.Location = new Point(66, 276);
            lb_Producer.Name = "lb_Producer";
            lb_Producer.Size = new Size(103, 20);
            lb_Producer.TabIndex = 1;
            lb_Producer.Text = "Hãng sản xuất";
            // 
            // lb_Price
            // 
            lb_Price.AutoSize = true;
            lb_Price.Location = new Point(66, 312);
            lb_Price.Name = "lb_Price";
            lb_Price.Size = new Size(31, 20);
            lb_Price.TabIndex = 2;
            lb_Price.Text = "Giá";
            // 
            // textBox_deviceName
            // 
            textBox_deviceName.Location = new Point(243, 85);
            textBox_deviceName.Name = "textBox_deviceName";
            textBox_deviceName.Size = new Size(208, 27);
            textBox_deviceName.TabIndex = 3;
            // 
            // textBox_year
            // 
            textBox_year.Location = new Point(243, 133);
            textBox_year.Name = "textBox_year";
            textBox_year.Size = new Size(208, 27);
            textBox_year.TabIndex = 3;
            // 
            // textBox_Color
            // 
            textBox_Color.Location = new Point(243, 183);
            textBox_Color.Name = "textBox_Color";
            textBox_Color.Size = new Size(208, 27);
            textBox_Color.TabIndex = 3;
            // 
            // textBox_seriesNum
            // 
            textBox_seriesNum.Location = new Point(243, 227);
            textBox_seriesNum.Name = "textBox_seriesNum";
            textBox_seriesNum.Size = new Size(208, 27);
            textBox_seriesNum.TabIndex = 3;
            // 
            // textBox_producer
            // 
            textBox_producer.Location = new Point(243, 269);
            textBox_producer.Name = "textBox_producer";
            textBox_producer.Size = new Size(208, 27);
            textBox_producer.TabIndex = 3;
            // 
            // textBox_price
            // 
            textBox_price.Location = new Point(243, 312);
            textBox_price.Name = "textBox_price";
            textBox_price.Size = new Size(208, 27);
            textBox_price.TabIndex = 3;
            // 
            // btn_Input
            // 
            btn_Input.Location = new Point(525, 30);
            btn_Input.Name = "btn_Input";
            btn_Input.Size = new Size(94, 29);
            btn_Input.TabIndex = 4;
            btn_Input.Text = "Input";
            btn_Input.UseVisualStyleBackColor = true;
            btn_Input.Click += btn_Input_Click;
            // 
            // btn_display
            // 
            btn_display.Location = new Point(525, 88);
            btn_display.Name = "btn_display";
            btn_display.Size = new Size(94, 29);
            btn_display.TabIndex = 4;
            btn_display.Text = "Display";
            btn_display.UseVisualStyleBackColor = true;
            btn_display.Click += btn_display_Click;
            // 
            // lb_View
            // 
            lb_View.FormattingEnabled = true;
            lb_View.HorizontalScrollbar = true;
            lb_View.ItemHeight = 20;
            lb_View.Location = new Point(525, 143);
            lb_View.Name = "lb_View";
            lb_View.Size = new Size(247, 164);
            lb_View.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(66, 35);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Số lượng";
            // 
            // textBox_soLuong
            // 
            textBox_soLuong.Location = new Point(243, 32);
            textBox_soLuong.Name = "textBox_soLuong";
            textBox_soLuong.Size = new Size(61, 27);
            textBox_soLuong.TabIndex = 3;
            // 
            // btn_Set
            // 
            btn_Set.Location = new Point(338, 32);
            btn_Set.Name = "btn_Set";
            btn_Set.Size = new Size(49, 29);
            btn_Set.TabIndex = 7;
            btn_Set.Text = "Set";
            btn_Set.UseVisualStyleBackColor = true;
            btn_Set.Click += btn_Set_Click;
            // 
            // comboBox_setYearorPrice
            // 
            comboBox_setYearorPrice.FormattingEnabled = true;
            comboBox_setYearorPrice.Location = new Point(637, 30);
            comboBox_setYearorPrice.Name = "comboBox_setYearorPrice";
            comboBox_setYearorPrice.Size = new Size(151, 28);
            comboBox_setYearorPrice.TabIndex = 8;
            // 
            // btn_decrease
            // 
            btn_decrease.Location = new Point(713, 88);
            btn_decrease.Name = "btn_decrease";
            btn_decrease.Size = new Size(75, 29);
            btn_decrease.TabIndex = 9;
            btn_decrease.Text = "Giảm";
            btn_decrease.UseVisualStyleBackColor = true;
            btn_decrease.Click += btn_decrease_Click;
            // 
            // btn_encrease
            // 
            btn_encrease.Location = new Point(637, 88);
            btn_encrease.Name = "btn_encrease";
            btn_encrease.Size = new Size(70, 29);
            btn_encrease.TabIndex = 9;
            btn_encrease.Text = "Tăng";
            btn_encrease.UseVisualStyleBackColor = true;
            btn_encrease.Click += btn_encrease_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 357);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 10;
            label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 400);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 10;
            label4.Text = "Liên hệ";
            // 
            // textBox_lienhe
            // 
            textBox_lienhe.Location = new Point(243, 400);
            textBox_lienhe.Name = "textBox_lienhe";
            textBox_lienhe.Size = new Size(208, 27);
            textBox_lienhe.TabIndex = 11;
            // 
            // textBox_diachi
            // 
            textBox_diachi.Location = new Point(243, 354);
            textBox_diachi.Name = "textBox_diachi";
            textBox_diachi.Size = new Size(208, 27);
            textBox_diachi.TabIndex = 11;
            // 
            // textBox_search
            // 
            textBox_search.Location = new Point(525, 354);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(147, 27);
            textBox_search.TabIndex = 12;
            // 
            // button_searchtenmay
            // 
            button_searchtenmay.Location = new Point(678, 324);
            button_searchtenmay.Name = "button_searchtenmay";
            button_searchtenmay.Size = new Size(94, 29);
            button_searchtenmay.TabIndex = 13;
            button_searchtenmay.Text = "Tên máy";
            button_searchtenmay.UseVisualStyleBackColor = true;
            button_searchtenmay.Click += button_search_Click;
            // 
            // button_searchhang
            // 
            button_searchhang.Location = new Point(678, 359);
            button_searchhang.Name = "button_searchhang";
            button_searchhang.Size = new Size(94, 29);
            button_searchhang.TabIndex = 14;
            button_searchhang.Text = "Hãng";
            button_searchhang.UseVisualStyleBackColor = true;
            button_searchhang.Click += button_searchhang_Click;
            // 
            // button_searchgia
            // 
            button_searchgia.Location = new Point(678, 396);
            button_searchgia.Name = "button_searchgia";
            button_searchgia.Size = new Size(94, 29);
            button_searchgia.TabIndex = 15;
            button_searchgia.Text = "Giá";
            button_searchgia.UseVisualStyleBackColor = true;
            button_searchgia.Click += button_searchgia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_searchgia);
            Controls.Add(button_searchhang);
            Controls.Add(button_searchtenmay);
            Controls.Add(textBox_search);
            Controls.Add(textBox_diachi);
            Controls.Add(textBox_lienhe);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_encrease);
            Controls.Add(btn_decrease);
            Controls.Add(comboBox_setYearorPrice);
            Controls.Add(btn_Set);
            Controls.Add(lb_View);
            Controls.Add(btn_display);
            Controls.Add(btn_Input);
            Controls.Add(textBox_price);
            Controls.Add(textBox_producer);
            Controls.Add(textBox_seriesNum);
            Controls.Add(textBox_Color);
            Controls.Add(textBox_year);
            Controls.Add(textBox_soLuong);
            Controls.Add(textBox_deviceName);
            Controls.Add(lb_Price);
            Controls.Add(lb_Producer);
            Controls.Add(lb_seriesNum);
            Controls.Add(lb__Color);
            Controls.Add(lb_namSanXuat);
            Controls.Add(label2);
            Controls.Add(lb_tenThietBi);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lb_tenThietBi;
        private Label lb_namSanXuat;
        private Label lb__Color;
        private Label lb_seriesNum;
        private Label lb_Producer;
        private Label lb_Price;
        private TextBox textBox_deviceName;
        private TextBox textBox_year;
        private TextBox textBox_Color;
        private TextBox textBox_seriesNum;
        private TextBox textBox_producer;
        private TextBox textBox_price;
        private Button btn_Input;
        private Button btn_display;
        private ListBox lb_View;
        private Label label2;
        private TextBox textBox_soLuong;
        private Button btn_Set;
        private ComboBox comboBox_setYearorPrice;
        private Button btn_decrease;
        private Button btn_encrease;
        private Label label3;
        private Label label4;
        private TextBox textBox_lienhe;
        private TextBox textBox_diachi;
        private TextBox textBox_search;
        private Button button_searchtenmay;
        private Button button_searchhang;
        private Button button_searchgia;
    }
}