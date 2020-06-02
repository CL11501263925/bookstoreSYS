namespace 书店管理系统
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.stu = new System.Windows.Forms.StatusStrip();
            this.lbl_1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.名称 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmr_1 = new System.Windows.Forms.Timer(this.components);
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsp_jinhuo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_sale = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_kucun = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_huiyuan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_qita = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除销售记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kucunwarn = new System.Windows.Forms.Label();
            this.btn_warehouse = new System.Windows.Forms.Button();
            this.btn_yuangong = new System.Windows.Forms.Button();
            this.btn_Type = new System.Windows.Forms.Button();
            this.huiyuan = new System.Windows.Forms.Button();
            this.btn_cangku = new System.Windows.Forms.Button();
            this.btn_jinhuo = new System.Windows.Forms.Button();
            this.tc_form = new System.Windows.Forms.TabControl();
            this.btn_kucun = new System.Windows.Forms.Button();
            this.btn_saleteils = new System.Windows.Forms.Button();
            this.btn_xiaoshou = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_kehuguanli = new System.Windows.Forms.Button();
            this.btn_huanban = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.showbooknum = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tc_form.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stu
            // 
            this.stu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.stu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_1,
            this.toolStripStatusLabel2,
            this.lbl_2,
            this.lbl_3,
            this.名称,
            this.lbl_4});
            this.stu.Location = new System.Drawing.Point(4, 608);
            this.stu.Name = "stu";
            this.stu.Size = new System.Drawing.Size(892, 22);
            this.stu.TabIndex = 1;
            this.stu.Text = "statusStrip1";
            // 
            // lbl_1
            // 
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(68, 17);
            this.lbl_1.Text = "当前时间：";
            this.lbl_1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // lbl_2
            // 
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(15, 17);
            this.lbl_2.Text = "2";
            // 
            // lbl_3
            // 
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(68, 17);
            this.lbl_3.Text = "当前用户：";
            // 
            // 名称
            // 
            this.名称.Name = "名称";
            this.名称.Size = new System.Drawing.Size(0, 17);
            // 
            // lbl_4
            // 
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(15, 17);
            this.lbl_4.Text = "4";
            // 
            // tmr_1
            // 
            this.tmr_1.Enabled = true;
            this.tmr_1.Interval = 2000;
            this.tmr_1.Tick += new System.EventHandler(this.tmr_1_Tick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.Location = new System.Drawing.Point(24, 289);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(157, 55);
            this.button9.TabIndex = 0;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Location = new System.Drawing.Point(24, 211);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(157, 55);
            this.button8.TabIndex = 0;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Location = new System.Drawing.Point(24, 132);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(157, 55);
            this.button7.TabIndex = 0;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Location = new System.Drawing.Point(24, 54);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 55);
            this.button6.TabIndex = 0;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.menuStrip1.BackgroundImage = global::书店管理系统.Properties.Resources.背景图3;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsp_jinhuo,
            this.tsp_sale,
            this.tsp_kucun,
            this.tsp_huiyuan,
            this.tsp_qita});
            this.menuStrip1.Location = new System.Drawing.Point(4, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tsp_jinhuo
            // 
            this.tsp_jinhuo.Image = ((System.Drawing.Image)(resources.GetObject("tsp_jinhuo.Image")));
            this.tsp_jinhuo.Name = "tsp_jinhuo";
            this.tsp_jinhuo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tsp_jinhuo.Size = new System.Drawing.Size(103, 24);
            this.tsp_jinhuo.Text = "图书入库(&T)";
            this.tsp_jinhuo.Click += new System.EventHandler(this.商品进货ToolStripMenuItem_Click);
            // 
            // tsp_sale
            // 
            this.tsp_sale.Image = ((System.Drawing.Image)(resources.GetObject("tsp_sale.Image")));
            this.tsp_sale.Name = "tsp_sale";
            this.tsp_sale.Size = new System.Drawing.Size(105, 24);
            this.tsp_sale.Text = "书本售卖(&U)";
            this.tsp_sale.Click += new System.EventHandler(this.tsp_sale_Click);
            // 
            // tsp_kucun
            // 
            this.tsp_kucun.Image = ((System.Drawing.Image)(resources.GetObject("tsp_kucun.Image")));
            this.tsp_kucun.Name = "tsp_kucun";
            this.tsp_kucun.Size = new System.Drawing.Size(104, 24);
            this.tsp_kucun.Text = "库存管理(&X)";
            this.tsp_kucun.Click += new System.EventHandler(this.tsp_kucun_Click);
            // 
            // tsp_huiyuan
            // 
            this.tsp_huiyuan.Image = ((System.Drawing.Image)(resources.GetObject("tsp_huiyuan.Image")));
            this.tsp_huiyuan.Name = "tsp_huiyuan";
            this.tsp_huiyuan.Size = new System.Drawing.Size(108, 24);
            this.tsp_huiyuan.Text = "员工管理(&W)";
            this.tsp_huiyuan.Click += new System.EventHandler(this.tsp_huiyuan_Click);
            // 
            // tsp_qita
            // 
            this.tsp_qita.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem,
            this.清除销售记录ToolStripMenuItem});
            this.tsp_qita.Image = ((System.Drawing.Image)(resources.GetObject("tsp_qita.Image")));
            this.tsp_qita.Name = "tsp_qita";
            this.tsp_qita.Size = new System.Drawing.Size(103, 24);
            this.tsp_qita.Text = "其他操作(&Z)";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 清除销售记录ToolStripMenuItem
            // 
            this.清除销售记录ToolStripMenuItem.Name = "清除销售记录ToolStripMenuItem";
            this.清除销售记录ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.清除销售记录ToolStripMenuItem.Text = "清除数据";
            this.清除销售记录ToolStripMenuItem.Click += new System.EventHandler(this.清除销售记录ToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = global::书店管理系统.Properties.Resources.背景图2;
            this.tabPage1.Controls.Add(this.kucunwarn);
            this.tabPage1.Controls.Add(this.btn_warehouse);
            this.tabPage1.Controls.Add(this.btn_yuangong);
            this.tabPage1.Controls.Add(this.btn_Type);
            this.tabPage1.Controls.Add(this.huiyuan);
            this.tabPage1.Controls.Add(this.btn_cangku);
            this.tabPage1.Controls.Add(this.btn_jinhuo);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(896, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "功能导航";
            // 
            // kucunwarn
            // 
            this.kucunwarn.AutoEllipsis = true;
            this.kucunwarn.Font = new System.Drawing.Font("方正姚体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kucunwarn.ForeColor = System.Drawing.Color.Red;
            this.kucunwarn.Location = new System.Drawing.Point(449, 103);
            this.kucunwarn.Name = "kucunwarn";
            this.kucunwarn.Size = new System.Drawing.Size(281, 30);
            this.kucunwarn.TabIndex = 2;
            this.kucunwarn.Text = "仓库库存检查中...";
            // 
            // btn_warehouse
            // 
            this.btn_warehouse.BackgroundImage = global::书店管理系统.Properties.Resources.仓库设置;
            this.btn_warehouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_warehouse.FlatAppearance.BorderSize = 0;
            this.btn_warehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_warehouse.Location = new System.Drawing.Point(601, 200);
            this.btn_warehouse.Name = "btn_warehouse";
            this.btn_warehouse.Size = new System.Drawing.Size(151, 47);
            this.btn_warehouse.TabIndex = 1;
            this.btn_warehouse.UseVisualStyleBackColor = true;
            this.btn_warehouse.Click += new System.EventHandler(this.btn_warehouse_Click);
            // 
            // btn_yuangong
            // 
            this.btn_yuangong.BackgroundImage = global::书店管理系统.Properties.Resources.员工设置;
            this.btn_yuangong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_yuangong.FlatAppearance.BorderSize = 0;
            this.btn_yuangong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yuangong.Location = new System.Drawing.Point(339, 200);
            this.btn_yuangong.Name = "btn_yuangong";
            this.btn_yuangong.Size = new System.Drawing.Size(151, 47);
            this.btn_yuangong.TabIndex = 1;
            this.btn_yuangong.UseVisualStyleBackColor = true;
            this.btn_yuangong.Click += new System.EventHandler(this.btn_yuangong_Click);
            // 
            // btn_Type
            // 
            this.btn_Type.BackgroundImage = global::书店管理系统.Properties.Resources.书本类型;
            this.btn_Type.FlatAppearance.BorderSize = 0;
            this.btn_Type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Type.Location = new System.Drawing.Point(0, 250);
            this.btn_Type.Name = "btn_Type";
            this.btn_Type.Size = new System.Drawing.Size(190, 52);
            this.btn_Type.TabIndex = 0;
            this.btn_Type.UseVisualStyleBackColor = true;
            this.btn_Type.Click += new System.EventHandler(this.btn_Type_Click);
            // 
            // huiyuan
            // 
            this.huiyuan.BackgroundImage = global::书店管理系统.Properties.Resources.会员管理;
            this.huiyuan.FlatAppearance.BorderSize = 0;
            this.huiyuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.huiyuan.Location = new System.Drawing.Point(0, 179);
            this.huiyuan.Name = "huiyuan";
            this.huiyuan.Size = new System.Drawing.Size(190, 52);
            this.huiyuan.TabIndex = 0;
            this.huiyuan.UseVisualStyleBackColor = true;
            this.huiyuan.Click += new System.EventHandler(this.huiyuan_Click);
            // 
            // btn_cangku
            // 
            this.btn_cangku.BackgroundImage = global::书店管理系统.Properties.Resources.库存管理;
            this.btn_cangku.FlatAppearance.BorderSize = 0;
            this.btn_cangku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cangku.Location = new System.Drawing.Point(0, 103);
            this.btn_cangku.Name = "btn_cangku";
            this.btn_cangku.Size = new System.Drawing.Size(190, 52);
            this.btn_cangku.TabIndex = 0;
            this.btn_cangku.UseVisualStyleBackColor = true;
            this.btn_cangku.Click += new System.EventHandler(this.btn_cangku_Click);
            // 
            // btn_jinhuo
            // 
            this.btn_jinhuo.BackgroundImage = global::书店管理系统.Properties.Resources.商品进货;
            this.btn_jinhuo.FlatAppearance.BorderSize = 0;
            this.btn_jinhuo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_jinhuo.Location = new System.Drawing.Point(0, 27);
            this.btn_jinhuo.Name = "btn_jinhuo";
            this.btn_jinhuo.Size = new System.Drawing.Size(190, 52);
            this.btn_jinhuo.TabIndex = 0;
            this.btn_jinhuo.UseVisualStyleBackColor = true;
            this.btn_jinhuo.Click += new System.EventHandler(this.btn_jinhuo_Click);
            // 
            // tc_form
            // 
            this.tc_form.Controls.Add(this.tabPage1);
            this.tc_form.Location = new System.Drawing.Point(0, 156);
            this.tc_form.Name = "tc_form";
            this.tc_form.SelectedIndex = 0;
            this.tc_form.Size = new System.Drawing.Size(904, 456);
            this.tc_form.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tc_form.TabIndex = 4;
            this.tc_form.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tc_form_MouseDoubleClick);
            // 
            // btn_kucun
            // 
            this.btn_kucun.BackColor = System.Drawing.Color.Transparent;
            this.btn_kucun.BackgroundImage = global::书店管理系统.Properties.Resources.库存状况;
            this.btn_kucun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kucun.FlatAppearance.BorderSize = 0;
            this.btn_kucun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kucun.Location = new System.Drawing.Point(121, 67);
            this.btn_kucun.Name = "btn_kucun";
            this.btn_kucun.Size = new System.Drawing.Size(73, 68);
            this.btn_kucun.TabIndex = 3;
            this.btn_kucun.UseVisualStyleBackColor = false;
            this.btn_kucun.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_saleteils
            // 
            this.btn_saleteils.BackColor = System.Drawing.Color.Transparent;
            this.btn_saleteils.BackgroundImage = global::书店管理系统.Properties.Resources.营业报表;
            this.btn_saleteils.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_saleteils.FlatAppearance.BorderSize = 0;
            this.btn_saleteils.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saleteils.Location = new System.Drawing.Point(221, 67);
            this.btn_saleteils.Name = "btn_saleteils";
            this.btn_saleteils.Size = new System.Drawing.Size(73, 68);
            this.btn_saleteils.TabIndex = 3;
            this.btn_saleteils.UseVisualStyleBackColor = false;
            this.btn_saleteils.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_xiaoshou
            // 
            this.btn_xiaoshou.BackColor = System.Drawing.Color.Transparent;
            this.btn_xiaoshou.BackgroundImage = global::书店管理系统.Properties.Resources.前台零售;
            this.btn_xiaoshou.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_xiaoshou.FlatAppearance.BorderSize = 0;
            this.btn_xiaoshou.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xiaoshou.Location = new System.Drawing.Point(421, 67);
            this.btn_xiaoshou.Name = "btn_xiaoshou";
            this.btn_xiaoshou.Size = new System.Drawing.Size(73, 68);
            this.btn_xiaoshou.TabIndex = 3;
            this.btn_xiaoshou.UseVisualStyleBackColor = false;
            this.btn_xiaoshou.Click += new System.EventHandler(this.button5_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem,
            this.显示ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "显示";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click_1);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.显示ToolStripMenuItem.Text = "退出";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.显示ToolStripMenuItem_Click);
            // 
            // btn_kehuguanli
            // 
            this.btn_kehuguanli.BackColor = System.Drawing.Color.Transparent;
            this.btn_kehuguanli.BackgroundImage = global::书店管理系统.Properties.Resources.客户管理;
            this.btn_kehuguanli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kehuguanli.FlatAppearance.BorderSize = 0;
            this.btn_kehuguanli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kehuguanli.Location = new System.Drawing.Point(28, 67);
            this.btn_kehuguanli.Name = "btn_kehuguanli";
            this.btn_kehuguanli.Size = new System.Drawing.Size(73, 68);
            this.btn_kehuguanli.TabIndex = 3;
            this.btn_kehuguanli.UseVisualStyleBackColor = false;
            this.btn_kehuguanli.Click += new System.EventHandler(this.btn_kehuguanli_Click);
            // 
            // btn_huanban
            // 
            this.btn_huanban.BackColor = System.Drawing.Color.Transparent;
            this.btn_huanban.BackgroundImage = global::书店管理系统.Properties.Resources.换班操作;
            this.btn_huanban.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_huanban.FlatAppearance.BorderSize = 0;
            this.btn_huanban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_huanban.Location = new System.Drawing.Point(322, 67);
            this.btn_huanban.Name = "btn_huanban";
            this.btn_huanban.Size = new System.Drawing.Size(79, 68);
            this.btn_huanban.TabIndex = 5;
            this.btn_huanban.UseVisualStyleBackColor = false;
            this.btn_huanban.Click += new System.EventHandler(this.btn_huanban_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::书店管理系统.Properties.Resources.退出系统;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(515, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 68);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.显示ToolStripMenuItem_Click);
            // 
            // showbooknum
            // 
            this.showbooknum.Enabled = true;
            this.showbooknum.Interval = 10000;
            this.showbooknum.Tick += new System.EventHandler(this.showbooknum_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 80000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::书店管理系统.Properties.Resources.背景图;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 634);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_huanban);
            this.Controls.Add(this.tc_form);
            this.Controls.Add(this.btn_xiaoshou);
            this.Controls.Add(this.btn_saleteils);
            this.Controls.Add(this.btn_kucun);
            this.Controls.Add(this.btn_kehuguanli);
            this.Controls.Add(this.stu);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "书店管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.stu.ResumeLayout(false);
            this.stu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tc_form.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stu;
        private System.Windows.Forms.ToolStripStatusLabel lbl_1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lbl_2;
        private System.Windows.Forms.Timer tmr_1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsp_jinhuo;
        private System.Windows.Forms.ToolStripMenuItem tsp_sale;
        private System.Windows.Forms.ToolStripMenuItem tsp_kucun;
        private System.Windows.Forms.ToolStripMenuItem tsp_huiyuan;
        private System.Windows.Forms.ToolStripMenuItem tsp_qita;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tc_form;
        private System.Windows.Forms.Button btn_kucun;
        private System.Windows.Forms.Button btn_saleteils;
        private System.Windows.Forms.Button btn_xiaoshou;
        private System.Windows.Forms.Button btn_jinhuo;
        private System.Windows.Forms.Button btn_cangku;
        private System.Windows.Forms.Button huiyuan;
        private System.Windows.Forms.Button btn_yuangong;
        private System.Windows.Forms.Button btn_warehouse;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Button btn_kehuguanli;
        private System.Windows.Forms.Button btn_huanban;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_3;
        private System.Windows.Forms.ToolStripStatusLabel 名称;
        private System.Windows.Forms.ToolStripStatusLabel lbl_4;
        private System.Windows.Forms.ToolStripMenuItem 清除销售记录ToolStripMenuItem;
        private System.Windows.Forms.Button btn_Type;
        private System.Windows.Forms.Timer showbooknum;
        private System.Windows.Forms.Label kucunwarn;
        private System.Windows.Forms.Timer timer1;

    }
}