using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using model;
using BLL;
using DAL;


namespace 书店管理系统
{

    public partial class Booksadd : Form
    {
        /// <summary>
        /// 重写WndProc方法,实现窗体移动和禁止双击最大化
        /// </summary>
        /// <param name="m">Windows 消息</param>
        /// //拖动以及禁止双击最大化
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x4e:
                case 0xd:
                case 0xe:
                case 0x14:
                    base.WndProc(ref m);
                    break;
                case 0x84://鼠标点任意位置后可以拖动窗体
                    this.DefWndProc(ref m);
                    if (m.Result.ToInt32() == 0x01)
                    {
                        m.Result = new IntPtr(0x02);
                    }
                    break;
                case 0xA3://禁止双击最大化
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        public Booksadd()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 添加书本
        /// </summary>
        public void 添加书本()
        {
            

            
            //执行命令
            if (this.txt_goodsname.Text == "")
            {
                MessageBox.Show("书名不能为空","温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (this.txt_tiaoxingma.Text == "")
            {
                MessageBox.Show("书的条形码不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (this.txt_tiaoxingma.Text == "")
            {
                MessageBox.Show("书的条形码不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (TextBoxBll.Intextnull(this.txt_zhekou.Text,4))
            {
                MessageBox.Show("折扣必须为0~1的小数", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (TextBoxBll.Intextnull(this.txt_goodsnum.Text,2))
            {
                MessageBox.Show("书的数量错误", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (decimal.Parse(this.txt_jinjia.Text.ToString()) < 0 || this.txt_jinjia.Text == "")
            {
                MessageBox.Show("请正确填写书的进价", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if ( decimal.Parse(this.txt_maijia.Text.ToString()) < 0 || this.txt_maijia.Text == "")
            {
                MessageBox.Show("请正确填写书的售价", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (decimal.Parse(this.txt_zhekou.Text.ToString()) > 0 && decimal.Parse(this.txt_zhekou.Text.ToString()) < 1 || this.txt_zhekou.Text == "")
            {
                MessageBox.Show("请正确填写书的折扣", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);              
                
                return;
            }
            else if (int.Parse(this.txt_goodsnum.Text.ToString())< 0)
            {
                MessageBox.Show("进货数量不正确", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            Books gs = new Books();
            gs.BooksName = this.txt_goodsname.Text;
            gs.TypeID = TypeBLL.GetTypeIDByTypeName(this.cbo_type.Text);
            gs.BarCode = this.txt_tiaoxingma.Text;
            gs.StorePrice = decimal.Parse(this.txt_jinjia.Text.ToString());
            gs.SalePrice = decimal.Parse(this.txt_maijia.Text.ToString());
            gs.Discount = decimal.Parse(this.txt_zhekou.Text.ToString());
            gs.StockNum = int.Parse(this.txt_goodsnum.Text);
            gs.StockDate = DateTime.Parse(DateTime.Now.ToString("yyyy年MM月dd日HH:mm:ss"));
            DataTable dt = BooksBLL.SelectBooksTypeByBarCode(this.txt_tiaoxingma.Text);                    
            //进货
            if (dt.Rows.Count == 1)
            {
                try
                {

                    //进货
                    int newGoods = int.Parse(this.txt_goodsnum.Text);
                    int oldGoods = int.Parse(dt.Rows[0]["StockNum"].ToString());
                    BooksBLL.InsertbooksByBarCod(newGoods, oldGoods, this.txt_tiaoxingma.Text);
                    MessageBox.Show("进货成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.txt_goodsname.ReadOnly = false;
                    this.txt_jinjia.ReadOnly = false;
                    this.txt_maijia.ReadOnly = false;
                    this.txt_tiaoxingma.ReadOnly = false;
                    this.txt_zhekou.ReadOnly = false;
                    this.cbo_type.Enabled = true;
                    //初始化数据
                    this.cbo_type.Text = "";
                    this.txt_goodsname.Text = "";
                    this.txt_goodsnum.Text = "";
                    this.txt_jinjia.Text = "";
                    this.txt_maijia.Text = "";
                    this.txt_tiaoxingma.Text = "";
                    this.txt_zhekou.Text = "";
                }
            }
            else
            {
                try
                {
                    //执行添加操作                
                    if (BooksBLL.InsertBooks(gs))
                    {
                        MessageBox.Show("添加成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    //初始化数据
                    this.cbo_type.SelectedIndex = 0;
                    this.txt_goodsname.Text = "";
                    this.txt_goodsnum.Text = "";
                    this.txt_jinjia.Text = "";
                    this.txt_maijia.Text = "";
                    this.txt_tiaoxingma.Text = "";
                    this.txt_zhekou.Text = "";
                }
            }
        }
        //退出
        private void btn_exit_Click(object sender, EventArgs e)
        {
            //隐藏窗体
            this.Hide();
        }
        //进货书本
        private void btn_queding_Click(object sender, EventArgs e)
        {
            添加书本();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btn_JianSuo_Click(object sender, EventArgs e)
        {
            //检索条形码是否存在  如果存在则将数据显示出来
            DataTable dt = BooksBLL.SelectBooksTypeByBarCode(txt_tiaoxingma.Text);
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("当前书本已存在", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_goodsname.Text = dt.Rows[0]["BooksName"].ToString();
                this.cbo_type.Text = dt.Rows[0]["TypeName"].ToString();
                txt_jinjia.Text = dt.Rows[0]["StorePrice"].ToString();
                txt_maijia.Text = dt.Rows[0]["SalePrice"].ToString();
                txt_zhekou.Text = dt.Rows[0]["Discount"].ToString();
                lbl_kucun.Text = dt.Rows[0]["StockNum"].ToString();
                label8.Text = "当前库存数：";
                this.txt_goodsname.ReadOnly = true;
                this.txt_jinjia.ReadOnly = true;
                this.txt_maijia.ReadOnly = true;
                this.txt_tiaoxingma.ReadOnly = true;
                this.txt_zhekou.ReadOnly = true;
                this.cbo_type.Enabled = false;

            }
            else
            {
                MessageBox.Show("书本不存在，请填写信息", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void Goodsadd_Load(object sender, EventArgs e)
        {
            DataTable type = TypeBLL.selecttype();
            if (type.Rows.Count!=0)
            {
            
            foreach (DataRow row in type.Rows)
            {
                this.cbo_type.Items.Add(row[1].ToString());
            }
            this.cbo_type.SelectedIndex = 0;

            }
                 
        }

        private void grp_add_Enter(object sender, EventArgs e)
        {

        }
    }
}

