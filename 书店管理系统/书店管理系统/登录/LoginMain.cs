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
using BLL;
using model;


namespace 书店管理系统
{
    public partial class LoginForm : Form
    {
       
        ///// <summary>
        ///// 重写WndProc方法,实现窗体移动和禁止双击最大化
        ///// </summary>
        ///// <param name="m">Windows 消息</param>
        ///// //拖动以及禁止双击最大化
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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //获取用户输入的用户名和密码
                string userName = this.txt_name.Text;
                string password = this.txt_pwd.Text;
                name.Name = SalemanBll.GetSalemanNameByPhone(userName);
                //职务
                string work = this.rdo_guanli.Checked ? this.rdo_guanli.Text : this.rdo_saler.Text;
                bool flag = false;//判断是否选择权限
                if (this.rdo_guanli.Checked || this.rdo_saler.Checked)
                {
                    flag = true;
                }
                //非空验证
                if (userName != "" && password != "" && flag == true)
                {
                    int result = SalemanBll.LoginUserInfo(userName, password, work);
                    if (result == 0)
                    {
                        //账号不存在
                        MessageBox.Show("账号不存在", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    if (result == 1)
                    {
                        //密码错误
                        MessageBox.Show("密码错误", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    } if (result == 2)
                    {

                        if (this.rdo_saler.Checked)
                        {
                            SalerForm sa = new SalerForm();
                            sa.Show();
                            this.Hide();

                        }
                        else
                        {

                            //登录成功
                            MainForm main = new MainForm();
                            main.Show();
                            this.Hide();

                        }

                    }
                }
                else
                {
                    MessageBox.Show("请正确填写登录信息", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("请正确填写登录信息", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

       // public object groupBox1 { get; set; }
        //退出
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //关闭提醒
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Show();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("制作");
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void 换班ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

       
       
    }
}
