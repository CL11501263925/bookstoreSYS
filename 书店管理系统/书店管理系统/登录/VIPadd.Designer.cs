namespace 书店管理系统
{
    partial class VIPadd
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_queding = new System.Windows.Forms.Button();
            this.grp_add = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbo_sex = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.grp_add.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Location = new System.Drawing.Point(308, 343);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(113, 41);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "取  消";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_queding
            // 
            this.btn_queding.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_queding.Location = new System.Drawing.Point(62, 343);
            this.btn_queding.Name = "btn_queding";
            this.btn_queding.Size = new System.Drawing.Size(113, 41);
            this.btn_queding.TabIndex = 3;
            this.btn_queding.Text = "确  定";
            this.btn_queding.UseVisualStyleBackColor = true;
            this.btn_queding.Click += new System.EventHandler(this.btn_queding_Click);
            // 
            // grp_add
            // 
            this.grp_add.Controls.Add(this.button1);
            this.grp_add.Controls.Add(this.cbo_sex);
            this.grp_add.Controls.Add(this.label2);
            this.grp_add.Controls.Add(this.txt_phone);
            this.grp_add.Controls.Add(this.label1);
            this.grp_add.Controls.Add(this.txt_name);
            this.grp_add.Controls.Add(this.lbl_id);
            this.grp_add.Location = new System.Drawing.Point(38, 29);
            this.grp_add.Name = "grp_add";
            this.grp_add.Size = new System.Drawing.Size(428, 257);
            this.grp_add.TabIndex = 2;
            this.grp_add.TabStop = false;
            this.grp_add.Text = "添加VIP";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(308, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "检索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbo_sex
            // 
            this.cbo_sex.FormattingEnabled = true;
            this.cbo_sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbo_sex.Location = new System.Drawing.Point(121, 154);
            this.cbo_sex.Name = "cbo_sex";
            this.cbo_sex.Size = new System.Drawing.Size(72, 20);
            this.cbo_sex.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "性别：";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(121, 32);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(157, 21);
            this.txt_phone.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "电话：";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(121, 93);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(157, 21);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(74, 96);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(41, 12);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "姓名：";
            // 
            // VIPadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 440);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_queding);
            this.Controls.Add(this.grp_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VIPadd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIP";
            this.grp_add.ResumeLayout(false);
            this.grp_add.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_queding;
        private System.Windows.Forms.GroupBox grp_add;
        private System.Windows.Forms.ComboBox cbo_sex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button button1;
    }
}