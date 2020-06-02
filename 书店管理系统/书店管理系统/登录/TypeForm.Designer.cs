namespace 书店管理系统
{
    partial class TypeForm
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
            this.dgv_xiangqing = new System.Windows.Forms.DataGridView();
            this.TypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new CCWin.SkinControl.SkinButton();
            this.btn_update = new CCWin.SkinControl.SkinButton();
            this.btn_delete = new CCWin.SkinControl.SkinButton();
            this.txt_typename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_chaxun = new System.Windows.Forms.TextBox();
            this.btn_chaxun = new CCWin.SkinControl.SkinButton();
            this.exportButton1 = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xiangqing)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_xiangqing
            // 
            this.dgv_xiangqing.AllowUserToAddRows = false;
            this.dgv_xiangqing.AllowUserToDeleteRows = false;
            this.dgv_xiangqing.BackgroundColor = System.Drawing.Color.White;
            this.dgv_xiangqing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_xiangqing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeID,
            this.TypeName});
            this.dgv_xiangqing.Location = new System.Drawing.Point(16, 222);
            this.dgv_xiangqing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_xiangqing.Name = "dgv_xiangqing";
            this.dgv_xiangqing.ReadOnly = true;
            this.dgv_xiangqing.RowTemplate.Height = 23;
            this.dgv_xiangqing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_xiangqing.Size = new System.Drawing.Size(1163, 300);
            this.dgv_xiangqing.TabIndex = 9;
            this.dgv_xiangqing.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_xiangqing_CellMouseClick);
            // 
            // TypeID
            // 
            this.TypeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeID.DataPropertyName = "TypeID";
            this.TypeID.HeaderText = "类型编号";
            this.TypeID.Name = "TypeID";
            this.TypeID.ReadOnly = true;
            // 
            // TypeName
            // 
            this.TypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeName.DataPropertyName = "TypeName";
            this.TypeName.HeaderText = "类型名称";
            this.TypeName.Name = "TypeName";
            this.TypeName.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "类型名称:";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.BaseColor = System.Drawing.Color.DarkGray;
            this.btn_add.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_add.DownBack = null;
            this.btn_add.DownBaseColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(52, 45);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.MouseBack = null;
            this.btn_add.MouseBaseColor = System.Drawing.Color.White;
            this.btn_add.Name = "btn_add";
            this.btn_add.NormlBack = null;
            this.btn_add.Size = new System.Drawing.Size(100, 29);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.BaseColor = System.Drawing.Color.DarkGray;
            this.btn_update.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_update.DownBack = null;
            this.btn_update.DownBaseColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(235, 46);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_update.MouseBack = null;
            this.btn_update.MouseBaseColor = System.Drawing.Color.White;
            this.btn_update.Name = "btn_update";
            this.btn_update.NormlBack = null;
            this.btn_update.Size = new System.Drawing.Size(100, 29);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "修改";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.BaseColor = System.Drawing.Color.DarkGray;
            this.btn_delete.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_delete.DownBack = null;
            this.btn_delete.DownBaseColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(419, 45);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.MouseBack = null;
            this.btn_delete.MouseBaseColor = System.Drawing.Color.White;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.NormlBack = null;
            this.btn_delete.Size = new System.Drawing.Size(100, 29);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_1);
            // 
            // txt_typename
            // 
            this.txt_typename.Location = new System.Drawing.Point(181, 135);
            this.txt_typename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_typename.Name = "txt_typename";
            this.txt_typename.Size = new System.Drawing.Size(152, 25);
            this.txt_typename.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(733, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "根据名称查询:";
            // 
            // txt_chaxun
            // 
            this.txt_chaxun.Location = new System.Drawing.Point(859, 135);
            this.txt_chaxun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_chaxun.Name = "txt_chaxun";
            this.txt_chaxun.Size = new System.Drawing.Size(152, 25);
            this.txt_chaxun.TabIndex = 14;
            // 
            // btn_chaxun
            // 
            this.btn_chaxun.BackColor = System.Drawing.Color.White;
            this.btn_chaxun.BaseColor = System.Drawing.Color.DarkGray;
            this.btn_chaxun.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_chaxun.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_chaxun.DownBack = null;
            this.btn_chaxun.DownBaseColor = System.Drawing.Color.White;
            this.btn_chaxun.Location = new System.Drawing.Point(1055, 132);
            this.btn_chaxun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_chaxun.MouseBack = null;
            this.btn_chaxun.MouseBaseColor = System.Drawing.Color.White;
            this.btn_chaxun.Name = "btn_chaxun";
            this.btn_chaxun.NormlBack = null;
            this.btn_chaxun.Size = new System.Drawing.Size(100, 29);
            this.btn_chaxun.TabIndex = 13;
            this.btn_chaxun.Text = "查询";
            this.btn_chaxun.UseVisualStyleBackColor = false;
            this.btn_chaxun.Click += new System.EventHandler(this.btn_chaxun_Click);
            // 
            // exportButton1
            // 
            this.exportButton1.BackColor = System.Drawing.Color.White;
            this.exportButton1.BaseColor = System.Drawing.Color.DarkGray;
            this.exportButton1.BorderColor = System.Drawing.Color.DarkGray;
            this.exportButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.exportButton1.DownBack = null;
            this.exportButton1.DownBaseColor = System.Drawing.Color.White;
            this.exportButton1.Location = new System.Drawing.Point(595, 46);
            this.exportButton1.Margin = new System.Windows.Forms.Padding(4);
            this.exportButton1.MouseBack = null;
            this.exportButton1.MouseBaseColor = System.Drawing.Color.White;
            this.exportButton1.Name = "exportButton1";
            this.exportButton1.NormlBack = null;
            this.exportButton1.Size = new System.Drawing.Size(100, 29);
            this.exportButton1.TabIndex = 16;
            this.exportButton1.Text = "导出";
            this.exportButton1.UseVisualStyleBackColor = false;
            this.exportButton1.Click += new System.EventHandler(this.exportButton1_Click);
            // 
            // TypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 538);
            this.Controls.Add(this.exportButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_chaxun);
            this.Controls.Add(this.txt_typename);
            this.Controls.Add(this.btn_chaxun);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_xiangqing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TypeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xiangqing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_xiangqing;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinButton btn_add;
        private CCWin.SkinControl.SkinButton btn_update;
        private CCWin.SkinControl.SkinButton btn_delete;
        private System.Windows.Forms.TextBox txt_typename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_chaxun;
        private CCWin.SkinControl.SkinButton btn_chaxun;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private CCWin.SkinControl.SkinButton exportButton1;

    }
}