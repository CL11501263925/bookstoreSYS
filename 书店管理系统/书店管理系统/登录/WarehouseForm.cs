using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//导入命名空间
using model;
using BLL;
using System.Text.RegularExpressions;

namespace 书店管理系统
{
    public partial class WarehouseForm : Form
    {
        public WarehouseForm()
        {
            InitializeComponent();
        }
        int id;       //保存选取项的ID
        int booktype;  //保存当前书本类型
        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            //显示所有书本                      
            //不允许自动创建列
            this.dgv_goods.AutoGenerateColumns = false;
            //绑定数据源
            this.dgv_goods.DataSource = BooksBLL.GetBooksandType();
            //初始最大化
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //设置为可编辑状态
            // dgv_goods.BeginEdit(false);
            //查询类型
            DataTable dt = TypeBLL.selecttype();
            //遍历出所有类型
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.cbo_type.Items.Add(dt.Rows[i][1]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        bool error = true;//判断是否
        bool flag = false;
        /// <summary>
        /// 添加书本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton2_Click(object sender, EventArgs e)
        {


            //获取类型ID  
            try
            {
               
                booktype = TypeBLL.GetTypeIDByTypeName(this.cbo_type.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("请先去添加书本类型", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            try
            {
                //添加书本
                if (this.txt_goodname.Text == "" || this.txt_jinjia.Text == "" || this.txt_kucun.Text == "" || this.txt_shoujia.Text == "" || this.txt_tiaoxingma.Text == "" || this.txt_zhekou.Text == "")
                {
                    MessageBox.Show("带*号不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else if (TextBoxBll.Intextnull(this.txt_kucun.Text, 2))
                {
                    MessageBox.Show("库存必须为正整数", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (TextBoxBll.Intextnull(this.txt_zhekou.Text, 4))
                {
                    MessageBox.Show("折扣请输入0~1的数字", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else if (BooksBLL.SelectBooksTypeByBarCode(this.txt_tiaoxingma.Text).Rows.Count > 0)
                {
                    MessageBox.Show("该条形码已存在", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else if (TextBoxBll.Intextnull(this.txt_tiaoxingma.Text, 1))
                {
                    MessageBox.Show("条形码长度过长", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {

                    Books gs = new Books();
                    gs.BooksName = this.txt_goodname.Text;
                    gs.TypeID = booktype;
                    gs.BarCode = this.txt_tiaoxingma.Text;
                    gs.StorePrice = decimal.Parse(this.txt_jinjia.Text.ToString());
                    gs.SalePrice = decimal.Parse(this.txt_shoujia.Text.ToString());
                    gs.Discount = decimal.Parse(this.txt_zhekou.Text.ToString());
                    gs.StockNum = int.Parse(this.txt_kucun.Text);
                    gs.StockDate = DateTime.Parse(this.dtp_riqi.Text.ToString());
                    if (BooksBLL.InsertBooks(gs))
                    {
                        MessageBox.Show("添加成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //绑定数据源
                        this.dgv_goods.DataSource = BooksBLL.GetBooksandType();
                        //初始化文本框数据                        
                        this.txt_goodsname.Text = null;
                        this.txt_jinjia.Text = null;
                        this.txt_kucun.Text = null;
                        this.txt_shoujia.Text = null;
                        this.txt_tiaoxingma.Text = null;
                        this.txt_zhekou.Text = null;
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("请正确填写信息", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }


        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 模糊查询书本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_chaxun_Click(object sender, EventArgs e)
        {
            this.dgv_goods.DataSource = BooksBLL.GetBooksLikeName(txt_goodsname.Text);
        }


        /// <summary>
        /// 修改书本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton3_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                return;
            }
            //获取类型ID
            booktype = TypeBLL.GetTypeIDByTypeName(this.cbo_type.Text);
            if (booktype==0)
            {
                MessageBox.Show("请选择书本类型","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                return;
            }                        
            try
            {
                if (error)
                {
                    //修改书本
                    string pattern = @"^[0]+(\.[0-9]{1,3})?$";
                    Match m = Regex.Match(this.txt_zhekou.Text, pattern);   // 匹配正则表达式

                    if (this.txt_goodname.Text == "" || this.txt_jinjia.Text == "" || this.txt_kucun.Text == "" || this.txt_shoujia.Text == "" || this.txt_tiaoxingma.Text == "" || this.txt_zhekou.Text == "")
                    {
                        MessageBox.Show("带*号不能为空", "温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    }
                    else if (float.Parse(txt_zhekou.Text) > 1 || float.Parse(txt_zhekou.Text) < 0)
                    {
                        MessageBox.Show("折扣必须输入0~1的数", "温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    }
                    else if (this.txt_tiaoxingma.Text.Length >= 50)
                    {
                        MessageBox.Show("条形码长度过长", "温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    }
                    else if (!m.Success && this.txt_zhekou.Text != "1" && this.txt_zhekou.Text != "1.0")
                    {
                        MessageBox.Show("折扣请输入0~1的数字", "温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        return;
                    }
                    else
                    {
                        if (int.Parse(this.txt_kucun.Text) >= 0)
                        {
                            Books gs = new Books();
                            gs.BooksName = this.txt_goodname.Text;
                            gs.TypeID = booktype;
                            gs.BarCode = this.txt_tiaoxingma.Text;
                            gs.StorePrice = decimal.Parse(this.txt_jinjia.Text.ToString());
                            gs.SalePrice = decimal.Parse(this.txt_shoujia.Text.ToString());
                            gs.Discount = decimal.Parse(this.txt_zhekou.Text.ToString());
                            gs.StockNum = int.Parse(this.txt_kucun.Text);
                            gs.StockDate = DateTime.Parse(this.dtp_riqi.Text.ToString());
                            gs.BooksID = id;
                            if (BooksBLL.UpdateBooks(gs))
                            {
                                MessageBox.Show("修改成功","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                                flag = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("库存必须为正整数,请重新操作","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("书本信息填写失误", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("请联系管理员:" + ex.Message,"温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

            }
            finally
            {
                if (flag)
                {
                    //绑定数据源
                    this.dgv_goods.DataSource = BooksBLL.GetBooksandType();
                }

            }
        }
        /// <summary>
        /// 删除书本
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton4_Click(object sender, EventArgs e)
        {
            try
            {
                //删除书本              
                if (BooksBLL.DeleteBooks(id))
                {
                    MessageBox.Show("删除成功", "温馨提示");
                }
                else
                {
                    MessageBox.Show("请选择您要删除的书本", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("请联系管理员" + ex,"温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                throw;
            }
            finally
            {
                //绑定数据源
                //初始化文本框数据
                this.dgv_goods.DataSource = BooksBLL.GetBooksandType();
                this.txt_goodsname.Text = null;
                this.txt_jinjia.Text = null;
                this.txt_kucun.Text = null;
                this.txt_shoujia.Text = null;
                this.txt_tiaoxingma.Text = null;
                this.txt_zhekou.Text = null;

            }

        }

        private void dgv_goods_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //保存书本ID以便于维护
                id = int.Parse(dgv_goods.Rows[e.RowIndex].Cells[0].Value.ToString());
                //将选中单元格中书本信息提出
                this.txt_goodname.Text = dgv_goods.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txt_tiaoxingma.Text = dgv_goods.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.txt_jinjia.Text = dgv_goods.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.txt_shoujia.Text = dgv_goods.Rows[e.RowIndex].Cells[5].Value.ToString();
                this.txt_zhekou.Text = dgv_goods.Rows[e.RowIndex].Cells[6].Value.ToString();
                this.txt_kucun.Text = dgv_goods.Rows[e.RowIndex].Cells[7].Value.ToString();
                this.dtp_riqi.Text = dgv_goods.Rows[e.RowIndex].Cells[8].Value.ToString();
                this.cbo_type.Text = dgv_goods.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("请点击正确的位置", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void exportButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            ExportDGVToExcel exportDataToExcel = new ExportDGVToExcel();
            int ret = exportDataToExcel.ExportExcel("项目总表", dgv_goods, dialog);
            if (ret == 0)
            {
                MessageBox.Show("导出项目总表成功");
            }
            else if (ret != 100)
            {
                MessageBox.Show("导出项目总表失败");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (int.Parse(BooksBLL.GetBooksLikeName(BooksBLL.GetMinStockBooksName()).Rows[0][7].ToString()) < 6)
            {
                MessageBox.Show("《" + BooksBLL.GetMinStockBooksName() + "》" + " 库存不足6本！", "库存警告", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
