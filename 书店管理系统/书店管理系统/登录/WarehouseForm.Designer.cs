namespace 书店管理系统
{
    partial class WarehouseForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exportButton1 = new CCWin.SkinControl.SkinButton();
            this.dgv_goods = new System.Windows.Forms.DataGridView();
            this.BooksID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BooksName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StorePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_chaxun = new CCWin.SkinControl.SkinButton();
            this.txt_goodsname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_shanchu = new CCWin.SkinControl.SkinButton();
            this.btn_add = new CCWin.SkinControl.SkinButton();
            this.btn_xiugai = new CCWin.SkinControl.SkinButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbo_type = new System.Windows.Forms.ComboBox();
            this.dtp_riqi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_shoujia = new System.Windows.Forms.TextBox();
            this.txt_jinjia = new System.Windows.Forms.TextBox();
            this.txt_tiaoxingma = new System.Windows.Forms.TextBox();
            this.txt_kucun = new System.Windows.Forms.TextBox();
            this.txt_zhekou = new System.Windows.Forms.TextBox();
            this.txt_goodname = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_goods)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.exportButton1);
            this.panel1.Controls.Add(this.dgv_goods);
            this.panel1.Controls.Add(this.btn_chaxun);
            this.panel1.Controls.Add(this.txt_goodsname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_shanchu);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_xiugai);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(-2, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 277);
            this.panel1.TabIndex = 2;
            // 
            // exportButton1
            // 
            this.exportButton1.BackColor = System.Drawing.Color.Transparent;
            this.exportButton1.BaseColor = System.Drawing.Color.Transparent;
            this.exportButton1.BorderColor = System.Drawing.Color.Transparent;
            this.exportButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.exportButton1.DownBack = null;
            this.exportButton1.Location = new System.Drawing.Point(362, 15);
            this.exportButton1.MouseBack = null;
            this.exportButton1.Name = "exportButton1";
            this.exportButton1.NormlBack = null;
            this.exportButton1.Size = new System.Drawing.Size(65, 23);
            this.exportButton1.TabIndex = 10;
            this.exportButton1.Text = "导出";
            this.exportButton1.UseVisualStyleBackColor = false;
            this.exportButton1.Click += new System.EventHandler(this.exportButton1_Click);
            // 
            // dgv_goods
            // 
            this.dgv_goods.AllowDrop = true;
            this.dgv_goods.BackgroundColor = System.Drawing.Color.White;
            this.dgv_goods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_goods.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_goods.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_goods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_goods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BooksID,
            this.BooksName,
            this.type,
            this.BarCode,
            this.StorePrice,
            this.SalePrice,
            this.Discount,
            this.StockNum,
            this.StockDate});
            this.dgv_goods.Location = new System.Drawing.Point(3, 50);
            this.dgv_goods.Name = "dgv_goods";
            this.dgv_goods.RowTemplate.Height = 23;
            this.dgv_goods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_goods.Size = new System.Drawing.Size(903, 207);
            this.dgv_goods.TabIndex = 9;
            this.dgv_goods.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_goods_CellMouseClick);
            // 
            // BooksID
            // 
            this.BooksID.DataPropertyName = "BooksID";
            this.BooksID.HeaderText = "编号";
            this.BooksID.Name = "BooksID";
            this.BooksID.Visible = false;
            this.BooksID.Width = 80;
            // 
            // BooksName
            // 
            this.BooksName.DataPropertyName = "BooksName";
            this.BooksName.HeaderText = "书本名称";
            this.BooksName.Name = "BooksName";
            this.BooksName.Width = 105;
            // 
            // type
            // 
            this.type.DataPropertyName = "TypeName";
            this.type.HeaderText = "类型";
            this.type.Name = "type";
            // 
            // BarCode
            // 
            this.BarCode.DataPropertyName = "BarCode";
            this.BarCode.HeaderText = "条形码";
            this.BarCode.Name = "BarCode";
            // 
            // StorePrice
            // 
            this.StorePrice.DataPropertyName = "StorePrice";
            this.StorePrice.HeaderText = "进价";
            this.StorePrice.Name = "StorePrice";
            // 
            // SalePrice
            // 
            this.SalePrice.DataPropertyName = "SalePrice";
            this.SalePrice.HeaderText = "售价";
            this.SalePrice.Name = "SalePrice";
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "折扣";
            this.Discount.Name = "Discount";
            // 
            // StockNum
            // 
            this.StockNum.DataPropertyName = "StockNum";
            this.StockNum.HeaderText = "库存数量";
            this.StockNum.Name = "StockNum";
            this.StockNum.Width = 105;
            // 
            // StockDate
            // 
            this.StockDate.DataPropertyName = "StockDate";
            this.StockDate.HeaderText = "入库日期";
            this.StockDate.Name = "StockDate";
            this.StockDate.Width = 148;
            // 
            // btn_chaxun
            // 
            this.btn_chaxun.BackColor = System.Drawing.Color.Transparent;
            this.btn_chaxun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_chaxun.BaseColor = System.Drawing.Color.Transparent;
            this.btn_chaxun.BorderColor = System.Drawing.Color.Transparent;
            this.btn_chaxun.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_chaxun.DownBack = null;
            this.btn_chaxun.DownBaseColor = System.Drawing.Color.Transparent;
            this.btn_chaxun.Location = new System.Drawing.Point(751, 12);
            this.btn_chaxun.MouseBack = null;
            this.btn_chaxun.Name = "btn_chaxun";
            this.btn_chaxun.NormlBack = global::书店管理系统.Properties.Resources.换班操作;
            this.btn_chaxun.Size = new System.Drawing.Size(100, 32);
            this.btn_chaxun.TabIndex = 8;
            this.btn_chaxun.Text = "查询";
            this.btn_chaxun.UseVisualStyleBackColor = false;
            this.btn_chaxun.Click += new System.EventHandler(this.btn_chaxun_Click);
            // 
            // txt_goodsname
            // 
            this.txt_goodsname.Location = new System.Drawing.Point(570, 19);
            this.txt_goodsname.Name = "txt_goodsname";
            this.txt_goodsname.Size = new System.Drawing.Size(162, 21);
            this.txt_goodsname.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "请输入书本的名称：";
            // 
            // btn_shanchu
            // 
            this.btn_shanchu.BackColor = System.Drawing.Color.Transparent;
            this.btn_shanchu.BaseColor = System.Drawing.Color.Transparent;
            this.btn_shanchu.BorderColor = System.Drawing.Color.Transparent;
            this.btn_shanchu.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_shanchu.DownBack = null;
            this.btn_shanchu.Location = new System.Drawing.Point(266, 15);
            this.btn_shanchu.MouseBack = null;
            this.btn_shanchu.Name = "btn_shanchu";
            this.btn_shanchu.NormlBack = null;
            this.btn_shanchu.Size = new System.Drawing.Size(65, 23);
            this.btn_shanchu.TabIndex = 6;
            this.btn_shanchu.Text = "删除";
            this.btn_shanchu.UseVisualStyleBackColor = false;
            this.btn_shanchu.Click += new System.EventHandler(this.skinButton4_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BaseColor = System.Drawing.Color.Transparent;
            this.btn_add.BorderColor = System.Drawing.Color.Transparent;
            this.btn_add.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_add.DownBack = null;
            this.btn_add.Location = new System.Drawing.Point(51, 15);
            this.btn_add.MouseBack = null;
            this.btn_add.Name = "btn_add";
            this.btn_add.NormlBack = null;
            this.btn_add.Size = new System.Drawing.Size(65, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // btn_xiugai
            // 
            this.btn_xiugai.BackColor = System.Drawing.Color.Transparent;
            this.btn_xiugai.BaseColor = System.Drawing.Color.Transparent;
            this.btn_xiugai.BorderColor = System.Drawing.Color.Transparent;
            this.btn_xiugai.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_xiugai.DownBack = null;
            this.btn_xiugai.Location = new System.Drawing.Point(158, 15);
            this.btn_xiugai.MouseBack = null;
            this.btn_xiugai.Name = "btn_xiugai";
            this.btn_xiugai.NormlBack = null;
            this.btn_xiugai.Size = new System.Drawing.Size(65, 23);
            this.btn_xiugai.TabIndex = 6;
            this.btn_xiugai.Text = "修改";
            this.btn_xiugai.UseVisualStyleBackColor = false;
            this.btn_xiugai.Click += new System.EventHandler(this.skinButton3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BackgroundImage = global::书店管理系统.Properties.Resources.背景4;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cbo_type);
            this.panel2.Controls.Add(this.dtp_riqi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_shoujia);
            this.panel2.Controls.Add(this.txt_jinjia);
            this.panel2.Controls.Add(this.txt_tiaoxingma);
            this.panel2.Controls.Add(this.txt_kucun);
            this.panel2.Controls.Add(this.txt_zhekou);
            this.panel2.Controls.Add(this.txt_goodname);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 171);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(658, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 12);
            this.label17.TabIndex = 11;
            this.label17.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(809, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 12);
            this.label16.TabIndex = 11;
            this.label16.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(809, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 12);
            this.label15.TabIndex = 11;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(597, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(415, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 12);
            this.label13.TabIndex = 11;
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(415, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(204, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(204, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "*";
            // 
            // cbo_type
            // 
            this.cbo_type.FormattingEnabled = true;
            this.cbo_type.Location = new System.Drawing.Point(98, 106);
            this.cbo_type.Name = "cbo_type";
            this.cbo_type.Size = new System.Drawing.Size(100, 20);
            this.cbo_type.TabIndex = 10;
            this.cbo_type.Text = "-请选择类型-";
            // 
            // dtp_riqi
            // 
            this.dtp_riqi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_riqi.Location = new System.Drawing.Point(527, 103);
            this.dtp_riqi.Name = "dtp_riqi";
            this.dtp_riqi.Size = new System.Drawing.Size(125, 21);
            this.dtp_riqi.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(689, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "售价：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(467, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "进价：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(249, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "条形码：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(443, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "入库日期：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(237, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "库存数量：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(38, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "类型：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(690, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "折扣：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "书本名称：";
            // 
            // txt_shoujia
            // 
            this.txt_shoujia.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_shoujia.Location = new System.Drawing.Point(750, 54);
            this.txt_shoujia.Name = "txt_shoujia";
            this.txt_shoujia.Size = new System.Drawing.Size(53, 21);
            this.txt_shoujia.TabIndex = 7;
            // 
            // txt_jinjia
            // 
            this.txt_jinjia.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_jinjia.Location = new System.Drawing.Point(527, 54);
            this.txt_jinjia.Name = "txt_jinjia";
            this.txt_jinjia.Size = new System.Drawing.Size(64, 21);
            this.txt_jinjia.TabIndex = 7;
            // 
            // txt_tiaoxingma
            // 
            this.txt_tiaoxingma.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_tiaoxingma.Location = new System.Drawing.Point(309, 54);
            this.txt_tiaoxingma.Name = "txt_tiaoxingma";
            this.txt_tiaoxingma.Size = new System.Drawing.Size(100, 21);
            this.txt_tiaoxingma.TabIndex = 7;
            // 
            // txt_kucun
            // 
            this.txt_kucun.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_kucun.Location = new System.Drawing.Point(309, 106);
            this.txt_kucun.Name = "txt_kucun";
            this.txt_kucun.Size = new System.Drawing.Size(100, 21);
            this.txt_kucun.TabIndex = 7;
            // 
            // txt_zhekou
            // 
            this.txt_zhekou.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_zhekou.Location = new System.Drawing.Point(750, 106);
            this.txt_zhekou.Name = "txt_zhekou";
            this.txt_zhekou.Size = new System.Drawing.Size(53, 21);
            this.txt_zhekou.TabIndex = 7;
            // 
            // txt_goodname
            // 
            this.txt_goodname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_goodname.Location = new System.Drawing.Point(98, 54);
            this.txt_goodname.Name = "txt_goodname";
            this.txt_goodname.Size = new System.Drawing.Size(100, 21);
            this.txt_goodname.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 8000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(904, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarehouseForm";
            this.Text = "WarehouseForm";
            this.Load += new System.EventHandler(this.WarehouseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_goods)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_goodsname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private CCWin.SkinControl.SkinButton btn_chaxun;
        private CCWin.SkinControl.SkinButton btn_add;
        private CCWin.SkinControl.SkinButton btn_xiugai;
        private CCWin.SkinControl.SkinButton btn_shanchu;
        private System.Windows.Forms.DataGridView dgv_goods;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_shoujia;
        private System.Windows.Forms.TextBox txt_jinjia;
        private System.Windows.Forms.TextBox txt_tiaoxingma;
        private System.Windows.Forms.TextBox txt_kucun;
        private System.Windows.Forms.TextBox txt_zhekou;
        private System.Windows.Forms.TextBox txt_goodname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_riqi;
        private System.Windows.Forms.ComboBox cbo_type;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn BooksID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BooksName;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn StorePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockDate;
        private CCWin.SkinControl.SkinButton exportButton1;
        private System.Windows.Forms.Timer timer1;
       
    }
}