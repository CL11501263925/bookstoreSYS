namespace 书店管理系统
{
    partial class Booksadd
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
            this.grp_add = new System.Windows.Forms.GroupBox();
            this.cbo_type = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_kucun = new System.Windows.Forms.Label();
            this.btn_JianSuo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_goodsnum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_zhekou = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_maijia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_jinjia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_goodsname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tiaoxingma = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_queding = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.grp_add.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_add
            // 
            this.grp_add.Controls.Add(this.cbo_type);
            this.grp_add.Controls.Add(this.label8);
            this.grp_add.Controls.Add(this.lbl_kucun);
            this.grp_add.Controls.Add(this.btn_JianSuo);
            this.grp_add.Controls.Add(this.label7);
            this.grp_add.Controls.Add(this.txt_goodsnum);
            this.grp_add.Controls.Add(this.label6);
            this.grp_add.Controls.Add(this.txt_zhekou);
            this.grp_add.Controls.Add(this.label5);
            this.grp_add.Controls.Add(this.txt_maijia);
            this.grp_add.Controls.Add(this.label4);
            this.grp_add.Controls.Add(this.txt_jinjia);
            this.grp_add.Controls.Add(this.label3);
            this.grp_add.Controls.Add(this.label2);
            this.grp_add.Controls.Add(this.txt_goodsname);
            this.grp_add.Controls.Add(this.label1);
            this.grp_add.Controls.Add(this.txt_tiaoxingma);
            this.grp_add.Controls.Add(this.lbl_id);
            this.grp_add.Location = new System.Drawing.Point(12, 12);
            this.grp_add.Name = "grp_add";
            this.grp_add.Size = new System.Drawing.Size(497, 330);
            this.grp_add.TabIndex = 0;
            this.grp_add.TabStop = false;
            this.grp_add.Text = "添加书本";
            this.grp_add.Enter += new System.EventHandler(this.grp_add_Enter);
            // 
            // cbo_type
            // 
            this.cbo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_type.FormattingEnabled = true;
            this.cbo_type.Location = new System.Drawing.Point(128, 110);
            this.cbo_type.Name = "cbo_type";
            this.cbo_type.Size = new System.Drawing.Size(87, 20);
            this.cbo_type.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 12);
            this.label8.TabIndex = 7;
            // 
            // lbl_kucun
            // 
            this.lbl_kucun.AutoSize = true;
            this.lbl_kucun.Location = new System.Drawing.Point(383, 274);
            this.lbl_kucun.Name = "lbl_kucun";
            this.lbl_kucun.Size = new System.Drawing.Size(0, 12);
            this.lbl_kucun.TabIndex = 6;
            // 
            // btn_JianSuo
            // 
            this.btn_JianSuo.Location = new System.Drawing.Point(308, 34);
            this.btn_JianSuo.Name = "btn_JianSuo";
            this.btn_JianSuo.Size = new System.Drawing.Size(75, 23);
            this.btn_JianSuo.TabIndex = 5;
            this.btn_JianSuo.Text = "检索信息";
            this.btn_JianSuo.UseVisualStyleBackColor = true;
            this.btn_JianSuo.Click += new System.EventHandler(this.btn_JianSuo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "（0~1之间的小数，如0.1表示一折）";
            // 
            // txt_goodsnum
            // 
            this.txt_goodsnum.Location = new System.Drawing.Point(128, 271);
            this.txt_goodsnum.Name = "txt_goodsnum";
            this.txt_goodsnum.Size = new System.Drawing.Size(157, 21);
            this.txt_goodsnum.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "本次入库数量：";
            // 
            // txt_zhekou
            // 
            this.txt_zhekou.Location = new System.Drawing.Point(128, 228);
            this.txt_zhekou.Name = "txt_zhekou";
            this.txt_zhekou.Size = new System.Drawing.Size(75, 21);
            this.txt_zhekou.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "折扣：";
            // 
            // txt_maijia
            // 
            this.txt_maijia.Location = new System.Drawing.Point(128, 190);
            this.txt_maijia.Name = "txt_maijia";
            this.txt_maijia.Size = new System.Drawing.Size(157, 21);
            this.txt_maijia.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "零售价格：";
            // 
            // txt_jinjia
            // 
            this.txt_jinjia.Location = new System.Drawing.Point(128, 148);
            this.txt_jinjia.Name = "txt_jinjia";
            this.txt_jinjia.Size = new System.Drawing.Size(157, 21);
            this.txt_jinjia.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "进货价格：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "分类：";
            // 
            // txt_goodsname
            // 
            this.txt_goodsname.Location = new System.Drawing.Point(128, 71);
            this.txt_goodsname.Name = "txt_goodsname";
            this.txt_goodsname.Size = new System.Drawing.Size(157, 21);
            this.txt_goodsname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "书本名称：";
            // 
            // txt_tiaoxingma
            // 
            this.txt_tiaoxingma.Location = new System.Drawing.Point(128, 34);
            this.txt_tiaoxingma.Name = "txt_tiaoxingma";
            this.txt_tiaoxingma.Size = new System.Drawing.Size(157, 21);
            this.txt_tiaoxingma.TabIndex = 1;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(33, 37);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(83, 12);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "书号/条形码：";
            // 
            // btn_queding
            // 
            this.btn_queding.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_queding.Location = new System.Drawing.Point(89, 372);
            this.btn_queding.Name = "btn_queding";
            this.btn_queding.Size = new System.Drawing.Size(113, 41);
            this.btn_queding.TabIndex = 1;
            this.btn_queding.Text = "确  定";
            this.btn_queding.UseVisualStyleBackColor = true;
            this.btn_queding.Click += new System.EventHandler(this.btn_queding_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Location = new System.Drawing.Point(320, 372);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(113, 41);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "取  消";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Booksadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 440);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_queding);
            this.Controls.Add(this.grp_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Booksadd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "书本入库";
            this.Load += new System.EventHandler(this.Goodsadd_Load);
            this.grp_add.ResumeLayout(false);
            this.grp_add.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_add;
        private System.Windows.Forms.Button btn_queding;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_tiaoxingma;
        private System.Windows.Forms.TextBox txt_goodsnum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_zhekou;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_maijia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_jinjia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_goodsname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_JianSuo;
        private System.Windows.Forms.Label lbl_kucun;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_type;

    }
}