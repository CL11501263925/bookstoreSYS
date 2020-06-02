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
using System.IO;
using BLL;
using model;

namespace 书店管理系统
{
    public partial class SalerForm : Form
    {


        public SalerForm()
        {
            InitializeComponent();
        }

        private void SalerForm_Load(object sender, EventArgs e)
        {
            //生成流水号
            liushuihao();
            //初始最大化
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.lbl_yuangong.Text = name.Name;
            DataTable dt = VipBll.SetVipByMobile(this.txt_vip.Text);
            checkBox1.Enabled = false;

        }
        //
        private void btn_huanban_Click(object sender, EventArgs e)
        {
            //重启程序
            Application.Exit();
            Application.Restart();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //退出程序
            Application.Exit();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //显示添加书本窗体
            Booksadd add = new Booksadd();
            add.Show();

        }

        //书本数量
        int num = 1;
        //定义价格和折扣全局变量
        public static double discount;
        public static double price;

        /// <summary>
        /// 导入书本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_daoru_Click(object sender, EventArgs e)
        {

            int allNum = 0;  //统计书本总数
            bool b = true;  //用于判断书本是否存在
            //如果按的是“回车键”            
            //获取条形码
            string barCode = this.txt_shangping.Text;
            if (true)
            {
                //购物列表中不存在该书本
                //根据输入的条形码，查询书本信息
                DataTable dt_books = BooksBLL.SelectBooksTypeByBarCode(barCode);
                //未查询到书本
                if (dt_books.Rows.Count == 0)
                {
                    MessageBox.Show("书本未找到，请检查条形码是否正确！", "温馨提示：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dt_books.Rows[0]["StockNum"].ToString() == "0")
                {
                    MessageBox.Show("书本以售空,请及时补货", "温馨提示");
                    return;
                }

                bool flag = true;
                //书本是否存在于购物车 计算书本数量
                for (int i = 0; i < this.lv_sales.Items.Count; i++)
                {
                    //判断添加书本数量是否超过库存
                    if (dt_books.Rows[0]["BooksName"].ToString() == this.lv_sales.Items[i].SubItems[2].Text)
                    {
                        string goodsName = dt_books.Rows[0]["BooksName"].ToString();
                        int stockNum = BooksBLL.GetStockNumByBooksName(goodsName); ;
                        if (stockNum == num)
                        {
                            MessageBox.Show("库存数不足", "温馨提示");
                            b = false;
                            flag = false;
                            break;
                        }
                        else
                        {
                            if (flag)
                            {
                                this.lv_sales.Items[i].SubItems[6].Text = (int.Parse(this.lv_sales.Items[i].SubItems[6].Text) + 1).ToString();
                                num++;//书本存在则数量加  1
                                b = false;//如果书本存在则把布尔变量b--赋值为false              
                                discount = double.Parse(dt_books.Rows[0]["Discount"].ToString());
                                price = double.Parse(dt_books.Rows[0]["SalePrice"].ToString()) * discount;
                                //显示金额信息
                                this.lbl_money.Text = sum.ToString();
                            }

                        }
                    }
                    else
                    {
                        //初始化数量
                        num = 1;
                    }
                }
                if (b)
                {
                    //创建购物项
                    ListViewItem item = new ListViewItem(dt_books.Rows[0]["BarCode"].ToString());
                    item.SubItems.Add(dt_books.Rows[0]["BooksID"].ToString());
                    item.SubItems.Add(dt_books.Rows[0]["BooksName"].ToString());
                    item.SubItems.Add(dt_books.Rows[0]["TypeName"].ToString());
                    item.SubItems.Add(dt_books.Rows[0]["SalePrice"].ToString());
                    item.SubItems.Add(dt_books.Rows[0]["Discount"].ToString());
                    item.SubItems.Add(num.ToString());

                    //for (int i = 0; i < lv_sales.Items.Count; i++)
                    //{
                    //    //记录书本ID，结算时需要用到该值                           
                    //    id1[i] = int.Parse(dt_goods.Rows[0]["BooksID"].ToString());
                    //}
                    //添加至购物车列表
                    this.lv_sales.Items.Add(item);
                }
                //获取ListView（书本）中所有行并显示
                for (int i = 0; i < this.lv_sales.Items.Count; i++)
                {
                    allNum += int.Parse(this.lv_sales.Items[i].SubItems[6].Text);
                }
                DataTable dt = VipBll.SetVipByMobile(this.txt_vip.Text);
                if (flag)
                {
                    allGoodsNum = allNum;
                    lbl_goods.Text = allNum.ToString();
                    discount = double.Parse(dt_books.Rows[0]["Discount"].ToString());
                    price = double.Parse(dt_books.Rows[0]["SalePrice"].ToString()) * discount;
                    //求和
                    sum += (price);//得到真实总价
                    
                    sum4 = sum;//将现在的总价赋给临时变量，sum4来处理积分抵扣显示数据
                    if (checkBox1.Checked == true )//若选择抵扣
                    {
                        if (sum > int.Parse(dt.Rows[0][4].ToString()) * 0.1)//如果真实总价大于积分抵扣
                        {
                            sum4 -= int.Parse(dt.Rows[0][4].ToString()) * 0.1;//临时总价被抵扣
                            this.jifenxianshi.Text = "积分已抵扣" + int.Parse(dt.Rows[0][4].ToString()) * 0.1;//显示抵扣积分
                        }
                        if (sum <= int.Parse(dt.Rows[0][4].ToString()) * 0.1)//表示总价小于积分
                        {
                            sum4 = 0;
                            this.jifenxianshi.Text = "积分已抵扣" + sum;//显示抵扣积分
                            bijiao = false;//标记 总价小于积分
                        }
                    }
                    if (checkBox1.Checked == false)
                    {
                        sum4 = sum;//还原价格
                    }
                    this.lbl_money.Text = sum4.ToString();//显示改变的价格
                }


            }


        }
        public double sum4;
        //生成流水单号
        private void liushuihao()
        {
            this.lbl_danhao.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
        }
        /// <summary>
        /// 修改书本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        //定义全局变量，接收价格总和
        double sum = 0;

        int allGoodsNum = 0;
        //在条形码文本框获得焦点时，按下键盘任意键并释放时触发事件
        /// <summary>
        /// 导入书本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_shangping_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        //查询VIP表获取VIP姓名
        private void btn_chaxun_Click(object sender, EventArgs e)
        {

        }

        bool messge;//销售成功
        int stocknum = 0;//库存
        /// <summary>
        /// 确定购买按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_jiezhang_Click(object sender, EventArgs e)
        {
            if (this.lv_sales.Items.Count == 0)
            {
                MessageBox.Show("当前无添加书本", "温馨提示");
                return;
            }
            else
            {
                //检索是否能否成功销售
                int error = 0;
                for (int i = 0; i < this.lv_sales.Items.Count; i++)
                {
                    stocknum = int.Parse(this.lv_sales.Items[i].SubItems[6].Text.ToString());
                    if (!BooksBLL.UpdateBooksStockNum(this.lv_sales.Items[i].SubItems[2].Text.ToString(), stocknum))
                    {
                        error++;
                    }
                }
                if (error > 0)
                {
                    MessageBox.Show("库存数可能不足", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    //存已买的书本的信息
                    string info = "单号：" + lbl_danhao.Text +"\r\n";
                    //将书本信息存入字符变量info
                    for (int i = 0; i < this.lv_sales.Items.Count; i++)
                    {

                        info += "书本名字:" + this.lv_sales.Items[i].SubItems[2].Text + "\r\n书本价格:" + this.lv_sales.Items[i].SubItems[4].Text + "\r\n书本折扣:" + this.lv_sales.Items[i].SubItems[5].Text + "\r\n书本数量:" + this.lv_sales.Items[i].SubItems[6].Text + "\r\n";
                    }
                    info += "总金额：" + lbl_money.Text + "\r\n";
                    info += "购物员：" + lbl_yuangong.Text;
                    //创建打印信息
                    for (int i = 0; i < this.lv_sales.Items.Count; i++)
                    {
                        if (stocknum >= 0)
                        {
                            using (StreamWriter st = new StreamWriter(@"D:\小票.txt", false, Encoding.UTF8))
                            {
                                if (!TextBoxBll.Intextnull(this.txt_shishou.Text, 2)||TextBoxBll.Intextnull(this.txt_shishou.Text,1))
                                {
                                    if (this.txt_shishou.Text == "")
                                    {
                                        MessageBox.Show("请输入实收金额", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                        return;
                                    }
                                    else if (this.txt_shishou.Text != null && double.Parse(this.txt_shishou.Text.ToString()) >= double.Parse(this.lbl_money.Text.ToString()))
                                    {
                                        this.lbl_zhaoling.Text = (double.Parse(this.txt_shishou.Text.ToString()) - double.Parse(this.lbl_money.Text.ToString())).ToString();
                                        st.Write(info);
                                        st.Flush();
                                        messge = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("实收金额小于应付金额", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("请正确输入预收金额", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                }

                            }
                        }
                    }


                }

                //结算成功
                if (messge)
                {
                    //将信息保存至销售表
                    int Salesmanid = SalemanBll.SelectSalemanByName(this.lbl_yuangong.Text);
                    DateTime time = DateTime.Parse(DateTime.Now.ToString("yyyy年MM月dd日"));
                    SaleBll.InsertSale(this.lbl_danhao.Text, time, sum, Salesmanid);
                    for (int j = 0; j < lv_sales.Items.Count; j++)
                    {
                        //将信息保存至销售详情表
                        SalesDetail sale = new SalesDetail()
                        {
                            BooksID = BooksBLL.GetBooksIDbyBooksName(this.lv_sales.Items[j].SubItems[2].Text),
                            Quantity = num,
                            SalesID = SaleBll.GetSDIDByTime(this.lbl_danhao.Text),
                            AloneAmount = decimal.Parse(this.lv_sales.Items[j].SubItems[4].Text) * decimal.Parse(this.lv_sales.Items[j].SubItems[5].Text)
                        };
                        SalesDailBLL.InsertSaleDail(sale);
                    }
                    DataTable dt = VipBll.SetVipByMobile(this.txt_vip.Text);
                    if (isVIP)
                    {
                        if (bijiao == true)//总价大于积分，默认为true
                        {
                            double sum2 = sum / 10;// 1:10积分产生
                            int sum1 = (int)sum2;//积分取整
                            if (checkBox1.Checked  == true )//若使用积分抵扣
                            {
                                sum = sum - double.Parse(dt.Rows[0][4].ToString()) * 0.1;//真实价格处理
                                    VipBll.ClearjifenByPhone(this.txt_vip.Text);//积分已抵扣完，现将vip积分清空
                            }
                            VipBll.UpdatejifenByPhone(this.txt_vip.Text, int.Parse(sum1.ToString()));//正常积分增加
                            this.jifenshu.Text = sum1.ToString();//显示结账后的积分
                            
                        }
                        if (bijiao == false)//总价小于积分抵扣。积分有剩
                        {
                            double sum2 =  sum * 10;//花费的积分
                            int sum5 = (int)(double.Parse(dt.Rows[0][4].ToString()) - sum2);//抵扣后的积分
                            if (checkBox1.Checked == true)//若使用积分
                            {
                                sum = 0;//真实价格处理
                                    VipBll.DecreasejifenByPhone(this.txt_vip.Text, int.Parse(sum2.ToString()));//之前积分减去抵扣积分
                            }
                            VipBll.UpdatejifenByPhone(this.txt_vip.Text, int.Parse(sum.ToString()));//正常积分增加，不过总价以为0，积分不会增加
                            this.jifenshu.Text = sum5.ToString();//显示结账后的积分

                        }
                    }
                    MessageBox.Show("结算成功，祝您生活愉快", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //信息初始化
                    this.lv_sales.Items.Clear();
                    this.lbl_goods.Text = "0";
                    liushuihao();
                    this.lbl_money.Text = "0.0000";
                    num = 1;
                    this.lbl_zhaoling.Text = "0.0";
                    this.txt_shishou.Text = "";
                    this.jifenxianshi.Text = "";
                    error = 0;
                    sum = 0;
                    sum3 = 0;
                    sum4 = 0;
                    bijiao = true;
                }


            }
        }
        /// <summary>
        /// 删除购物车所选项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.lv_sales.Items.Clear();
            this.lbl_goods.Text = "0";
            this.lbl_money.Text = "0.00";
            this.txt_shangping.Text = "";
            this.jifenxianshi.Text = "";
            sum = 0;
            price = 0;
            //信息初始化                             
            this.lbl_money.Text = "0.00";
            num = 1;
            this.lbl_zhaoling.Text = "0.0";
            this.txt_shishou.Text = "";
            this.checkBox1.Checked = false;
            sum = 0;
            sum3 = 0;
            sum4 = 0;
            bijiao = true;
        }


        private void txt_shishou_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F1)
                {
                    double Money;
                    Money = double.Parse(this.txt_shishou.Text);
                    if (Money < sum)
                    {
                        MessageBox.Show("您的余额不足", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        lbl_zhaoling.Text = (Money - sum).ToString();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("请输入实收金额", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        bool isVIP=false;//是否为会员
        private void btn_jiansuo_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxBll.Intextnull(this.txt_vip.Text, 3))
                {
                    MessageBox.Show("请正确填写电话号码", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    if (VipBll.SelectVipBymobilebool(this.txt_vip.Text))
                    {
                        isVIP = true;
                        DataTable dt = VipBll.SetVipByMobile(this.txt_vip.Text);
                        MessageBox.Show("尊敬的会员：" + dt.Rows[0][1].ToString() + ",你好！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        checkBox1.Enabled = true;
                        jifenshu.Text = dt.Rows[0][4].ToString();
                    }
                    
                }
            }
            catch (Exception )
            {              
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = VipBll.SetVipByMobile(this.txt_vip.Text);
            sum = sum - int.Parse(dt.Rows[0][4].ToString()) * 0.1;
            this.lbl_money.Text = sum.ToString();
        }


        public bool bijiao = true;
        public double sum3;
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            double sum2=sum;//将真实总价赋给临时价格
            DataTable dt = VipBll.SetVipByMobile(this.txt_vip.Text);//读取数据
            if (checkBox1.CheckState == CheckState.Checked)//如果打勾
            {
                if (sum > int.Parse(dt.Rows[0][4].ToString()) * 0.1 || sum == 0)//总价大于积分抵扣，或还没加入购物车
                {
                    bijiao = true;//标志
                    sum2 = sum2 - int.Parse(dt.Rows[0][4].ToString()) * 0.1;//临时价格调整
                    if (sum == 0)//还没加入购物车
                    {
                        this.jifenxianshi.Text = "积分可抵扣" + int.Parse(dt.Rows[0][4].ToString()) * 0.1;//积分显示
                    }
                    if (sum != 0)//已有东西加入了购物车
                    {
                        this.jifenxianshi.Text = "积分已抵扣" + int.Parse(dt.Rows[0][4].ToString()) * 0.1;//积分显示
                    }
                    if (sum >= int.Parse(dt.Rows[0][4].ToString()) * 0.1)
                    {
                        this.lbl_money.Text = sum2.ToString();//总价改变现实
                    }
                }
                if (sum <= int.Parse(dt.Rows[0][4].ToString()) * 0.1 && sum!=0)//总价小于积分
                {
                    this.jifenxianshi.Text = "积分已抵扣" + sum;//积分显示
                    sum3 = 0;//临时总价就是0
                    this.lbl_money.Text = sum3.ToString();
                    bijiao = false;//标记
                }
            }
            else if (checkBox1.CheckState != CheckState.Checked)//checkbox还原操作
            {
                this.jifenxianshi.Text = "";//积分显示
                this.lbl_money.Text = sum.ToString();//价格还原
                bijiao = true;//还原标记
            }
        }





    }
}
