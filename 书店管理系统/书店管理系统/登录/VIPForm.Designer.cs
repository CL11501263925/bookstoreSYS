namespace 书店管理系统
{
    partial class VIPForm
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
            this.dgv_VIP = new System.Windows.Forms.DataGridView();
            this.VIPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jifen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_zengjia = new CCWin.SkinControl.SkinButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_chaxun = new System.Windows.Forms.TextBox();
            this.btn_xiugai = new CCWin.SkinControl.SkinButton();
            this.btn_shanchu = new CCWin.SkinControl.SkinButton();
            this.btn_chaxun = new CCWin.SkinControl.SkinButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_zhekou = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbo_gander = new System.Windows.Forms.ComboBox();
            this.exportButton1 = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VIP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_VIP
            // 
            this.dgv_VIP.AllowUserToAddRows = false;
            this.dgv_VIP.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_VIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_VIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VIP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VIPID,
            this.VIPName,
            this.Mobile,
            this.Gender,
            this.jifen});
            this.dgv_VIP.Location = new System.Drawing.Point(19, 234);
            this.dgv_VIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_VIP.Name = "dgv_VIP";
            this.dgv_VIP.RowTemplate.Height = 23;
            this.dgv_VIP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_VIP.Size = new System.Drawing.Size(1136, 270);
            this.dgv_VIP.TabIndex = 0;
            this.dgv_VIP.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_VIP_CellMouseClick);
            // 
            // VIPID
            // 
            this.VIPID.DataPropertyName = "VipID";
            this.VIPID.HeaderText = "会员编号";
            this.VIPID.Name = "VIPID";
            this.VIPID.Width = 163;
            // 
            // VIPName
            // 
            this.VIPName.DataPropertyName = "VipName";
            this.VIPName.HeaderText = "会员名称";
            this.VIPName.Name = "VIPName";
            this.VIPName.Width = 162;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "电话";
            this.Mobile.Name = "Mobile";
            this.Mobile.Width = 163;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            this.Gender.Width = 162;
            // 
            // jifen
            // 
            this.jifen.DataPropertyName = "jifen";
            this.jifen.HeaderText = "积分";
            this.jifen.Name = "jifen";
            this.jifen.Width = 157;
            // 
            // btn_zengjia
            // 
            this.btn_zengjia.BackColor = System.Drawing.Color.Transparent;
            this.btn_zengjia.BaseColor = System.Drawing.Color.DarkGray;
            this.btn_zengjia.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_zengjia.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_zengjia.DownBack = null;
            this.btn_zengjia.Location = new System.Drawing.Point(40, 41);
            this.btn_zengjia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_zengjia.MouseBack = null;
            this.btn_zengjia.Name = "btn_zengjia";
            this.btn_zengjia.NormlBack = null;
            this.btn_zengjia.Size = new System.Drawing.Size(103, 38);
            this.btn_zengjia.TabIndex = 1;
            this.btn_zengjia.Text = "增加";
            this.btn_zengjia.UseVisualStyleBackColor = false;
            this.btn_zengjia.Click += new System.EventHandler(this.btn_zengjia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(671, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "请输入手机号或名字：";
            // 
            // txt_chaxun
            // 
            this.txt_chaxun.Location = new System.Drawing.Point(872, 49);
            this.txt_chaxun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_chaxun.Name = "txt_chaxun";
            this.txt_chaxun.Size = new System.Drawing.Size(132, 25);
            this.txt_chaxun.TabIndex = 3;
            // 
            // btn_xiugai
            // 
            this.btn_xiugai.BackColor = System.Drawing.Color.Transparent;
            this.btn_xiugai.BaseColor = System.Drawing.Color.DarkGray;
            this.btn_xiugai.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xiugai.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_xiugai.DownBack = null;
            this.btn_xiugai.Location = new System.Drawing.Point(210, 41);
            this.btn_xiugai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xiugai.MouseBack = null;
            this.btn_xiugai.Name = "btn_xiugai";
            this.btn_xiugai.NormlBack = null;
            this.btn_xiugai.Size = new System.Drawing.Size(103, 38);
            this.btn_xiugai.TabIndex = 1;
            this.btn_xiugai.Text = "修改";
            this.btn_xiugai.UseVisualStyleBackColor = false;
            this.btn_xiugai.Click += new System.EventHandler(this.btn_xiugai_Click);
            // 
            // btn_shanchu
            // 
            this.btn_shanchu.BackColor = System.Drawing.Color.Transparent;
            this.btn_shanchu.BaseColor = System.Drawing.Color.DarkGray;
            this.btn_shanchu.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_shanchu.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_shanchu.DownBack = null;
            this.btn_shanchu.Location = new System.Drawing.Point(383, 40);
            this.btn_shanchu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_shanchu.MouseBack = null;
            this.btn_shanchu.Name = "btn_shanchu";
            this.btn_shanchu.NormlBack = null;
            this.btn_shanchu.Size = new System.Drawing.Size(103, 38);
            this.btn_shanchu.TabIndex = 1;
            this.btn_shanchu.Text = "删除";
            this.btn_shanchu.UseVisualStyleBackColor = false;
            this.btn_shanchu.Click += new System.EventHandler(this.btn_shanchu_Click);
            // 
            // btn_chaxun
            // 
            this.btn_chaxun.BackColor = System.Drawing.Color.Transparent;
            this.btn_chaxun.BaseColor = System.Drawing.Color.DarkGray;
            this.btn_chaxun.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_chaxun.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_chaxun.DownBack = null;
            this.btn_chaxun.Location = new System.Drawing.Point(1052, 41);
            this.btn_chaxun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_chaxun.MouseBack = null;
            this.btn_chaxun.Name = "btn_chaxun";
            this.btn_chaxun.NormlBack = null;
            this.btn_chaxun.Size = new System.Drawing.Size(103, 38);
            this.btn_chaxun.TabIndex = 1;
            this.btn_chaxun.Text = "查询";
            this.btn_chaxun.UseVisualStyleBackColor = false;
            this.btn_chaxun.Click += new System.EventHandler(this.btn_chaxun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "名称：";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(291, 111);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(132, 25);
            this.txt_name.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(709, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "积分：";
            // 
            // txt_zhekou
            // 
            this.txt_zhekou.Location = new System.Drawing.Point(795, 169);
            this.txt_zhekou.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_zhekou.Name = "txt_zhekou";
            this.txt_zhekou.Size = new System.Drawing.Size(132, 25);
            this.txt_zhekou.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "性别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(709, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "电话：";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(795, 111);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(132, 25);
            this.txt_phone.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(952, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(952, 172);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(447, 172);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "*";
            // 
            // cbo_gander
            // 
            this.cbo_gander.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_gander.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_gander.FormattingEnabled = true;
            this.cbo_gander.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbo_gander.Location = new System.Drawing.Point(291, 169);
            this.cbo_gander.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_gander.Name = "cbo_gander";
            this.cbo_gander.Size = new System.Drawing.Size(129, 23);
            this.cbo_gander.TabIndex = 7;
            // 
            // exportButton1
            // 
            this.exportButton1.BackColor = System.Drawing.Color.Transparent;
            this.exportButton1.BaseColor = System.Drawing.Color.DarkGray;
            this.exportButton1.BorderColor = System.Drawing.Color.DarkGray;
            this.exportButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.exportButton1.DownBack = null;
            this.exportButton1.Location = new System.Drawing.Point(549, 41);
            this.exportButton1.Margin = new System.Windows.Forms.Padding(4);
            this.exportButton1.MouseBack = null;
            this.exportButton1.Name = "exportButton1";
            this.exportButton1.NormlBack = null;
            this.exportButton1.Size = new System.Drawing.Size(103, 38);
            this.exportButton1.TabIndex = 8;
            this.exportButton1.Text = "导出";
            this.exportButton1.UseVisualStyleBackColor = false;
            this.exportButton1.Click += new System.EventHandler(this.exportButton1_Click);
            // 
            // VIPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 538);
            this.Controls.Add(this.exportButton1);
            this.Controls.Add(this.cbo_gander);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_zhekou);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_chaxun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_chaxun);
            this.Controls.Add(this.btn_shanchu);
            this.Controls.Add(this.btn_xiugai);
            this.Controls.Add(this.btn_zengjia);
            this.Controls.Add(this.dgv_VIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VIPForm";
            this.Text = "VIP1Form";
            this.Load += new System.EventHandler(this.VIP1Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VIP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_VIP;
        private CCWin.SkinControl.SkinButton btn_zengjia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_chaxun;
        private CCWin.SkinControl.SkinButton btn_xiugai;
        private CCWin.SkinControl.SkinButton btn_shanchu;
        private CCWin.SkinControl.SkinButton btn_chaxun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_zhekou;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbo_gander;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn jifen;
        private CCWin.SkinControl.SkinButton exportButton1;
    }
}