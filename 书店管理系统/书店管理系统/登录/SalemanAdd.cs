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
    public partial class SalemanAdd : Form
    {
        public SalemanAdd()
        {
            InitializeComponent();
        }
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
        /// <summary>
        /// 添加员工
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
            Saleman saleman = new Saleman()
                {
                    SalesmanName = this.txt_name.Text,
                    Mobile = this.txt_mobile.Text,
                    Pwd = this.txt_pwd.Text,
                    Gender = this.cbo_sex.Text,
                    BaseSalary = this.txt_money.Text,
                    CommissionRate = this.txt_ticheng.Text,
                    Work = this.cbo_work.Text
                };
            if (saleman.SalesmanName == ""&&TextBoxBll.Intextnull(this.txt_name.Text,1))
            {
                MessageBox.Show("姓名格式不正确", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (saleman.Mobile == "")
            {
                MessageBox.Show("电话号码不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (TextBoxBll.Intextnull(this.txt_name.Text,1))
            {
                MessageBox.Show("姓名格式错误","温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (TextBoxBll.Intextnull(this.txt_mobile.Text,3))
            {
                MessageBox.Show("请输入正确的电话号码", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (saleman.Pwd == "")
            {
                MessageBox.Show("密码不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (saleman.Gender == "")
            {
                MessageBox.Show("性别不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (saleman.BaseSalary == "")
            {
                MessageBox.Show("底薪不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (saleman.CommissionRate == "")
            {
                MessageBox.Show("提成不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (TextBoxBll.Intextnull(this.txt_ticheng.Text,4))
            {
                MessageBox.Show("提成必须是0~1的小数！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (TextBoxBll.Intextnull(this.txt_money.Text,2))
            {
                MessageBox.Show("工资必须为正整数", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                //判断是否存在               
                if (SalemanBll.SelectSalemanByMobile(saleman.Mobile))
                {
                    MessageBox.Show("员工以存在 请勿重复添加 如需修改请至管理界面", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    //添加员工      
                    //如果添加成功则初始化数据
                    if (SalemanBll.InsertSalesman(saleman))
                    {
                        this.txt_name.Text = "";
                        this.txt_mobile.Text = "";
                        this.txt_pwd.Text = "";
                        this.cbo_sex.SelectedIndex =0;
                        this.txt_money.Text = "";
                        this.txt_ticheng.Text = "";
                        this.cbo_work.SelectedIndex = 0;
                        MessageBox.Show("添加成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }                   
                }
            }

        }
        //隐藏该界面
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select*from Saleman where Mobile='{0}'", this.txt_mobile.Text);
            DataTable dt = DBHelper.GetDataTable(sql);
            if (SalemanBll.SelectSalemanByMobile(this.txt_mobile.Text))
            {
                MessageBox.Show("员工已存在", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txt_money.Text = dt.Rows[0]["BaseSalary"].ToString();
                this.txt_name.Text = dt.Rows[0]["SalesmanName"].ToString();
                this.txt_pwd.Text = dt.Rows[0]["Pwd"].ToString();
                this.txt_ticheng.Text = dt.Rows[0]["CommissionRate"].ToString();
                this.cbo_sex.Text = dt.Rows[0]["Gender"].ToString();
                this.cbo_work.Text = dt.Rows[0]["Work"].ToString();
                //this.txt_mobile.ReadOnly = true;
                //this.txt_money.ReadOnly = true;
                //this.txt_name.ReadOnly = true;
                //this.txt_pwd.ReadOnly = true;
                //this.txt_ticheng.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("员工不存在，请添加", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void SalemanAdd_Load(object sender, EventArgs e)
        {
            
            this.cbo_work.SelectedIndex = 0;
            this.cbo_sex.SelectedIndex = 0;
        }
    }
}
