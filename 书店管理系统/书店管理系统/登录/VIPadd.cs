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

namespace 书店管理系统
{
    public partial class VIPadd : Form
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
        public VIPadd()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //隐藏界面
            this.Hide();
        }

        public  void 添加会员()
        {
            Vip vip = new Vip()
            { 
            VipName = this.txt_name.Text,
            Mobile = this.txt_phone.Text,
            Gender = this.cbo_sex.Text,
             jifen=0
            };                    
            //编写SQL语句（添加会员信息）
           
            //执行命令
            if (vip.VipName == "")
            {
                MessageBox.Show("姓名不能为空", "温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else if (vip.Mobile == ""&&TextBoxBll.Intextnull(this.txt_phone.Text,3))
            {
                MessageBox.Show("电话不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (vip.Gender == "")
            {
                MessageBox.Show("请选择性别", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (TextBoxBll.Intextnull(this.txt_name.Text,1))
            {
                MessageBox.Show("名字格式不正确", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }           
            else
            {
                if (VipBll.InsertVip(vip))
                {
                    MessageBox.Show("添加成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.txt_name.Text = "";
                    this.txt_phone.Text = "";                 
                    this.cbo_sex.Text = "";    
                } 
            }
                       
        }
        private void btn_queding_Click(object sender, EventArgs e)
        {
            try
            {              
                    添加会员();                                               
            }
            catch (Exception)
            {
                MessageBox.Show("请联系管理员", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txt_name.Text = "";
                this.txt_phone.Text = "";             
                this.cbo_sex.Text= "";               
            }
            
            
        }

        private void btn_duqu_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VipBll.SelectVipBymobilebool(this.txt_phone.Text))
            {
                MessageBox.Show("会员已存在", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txt_name.Text = "";
                this.txt_phone.Text = "";
                
                this.cbo_sex.Text = "";      
            }
        }

        private void grp_add_Enter(object sender, EventArgs e)
        {

        }
    }
}
