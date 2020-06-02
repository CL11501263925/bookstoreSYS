using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using System.Runtime.InteropServices;
using BLL;


namespace 书店管理系统
{
    public partial class MainForm : CCSkinMain          
    {
        ///清除闪屏
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED 
                return cp;
            }
        }

        public MainForm()
        {
           
            InitializeComponent();
            
            //DataGrid dg = new DataGrid();
            //DataTable db = new DataTable();
            //dg.DataSource = BooksBLL.GetBooksandType();
            //db. = BooksBLL.GetBooksandType();
            //for (int i = 0; i < db.Rows.Count - 1; i++)
            //{
            //    if (int.Parse(db.Rows[i][7].ToString()) <= 5)
            //    {
            //        MessageBox.Show(db.Rows[i][1] + " 库存不足6本！", "库存警告", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    }
            //}

        }
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);

        //标志描述：
        const int AW_SLIDE = 0x40000;//使用滑动类型。缺省则为滚动动画类型。当使用AW_CENTER标志时，这个标志就被忽略。
        const int AW_ACTIVATE = 0x20000;//激活窗口。在使用了AW_HIDE标志后不要使用这个标志。
        const int AW_BLEND = 0x80000;//使用淡出效果。只有当hWnd为顶层窗口的时候才可以使用此标志。
        const int AW_HIDE = 0x10000;//隐藏窗口，缺省则显示窗口。(关闭窗口用)
        const int AW_CENTER = 0x0010;//若使用了AW_HIDE标志，则使窗口向内重叠；若未使用AW_HIDE标志，则使窗口向外扩展。
        const int AW_HOR_POSITIVE = 0x0001;//自左向右显示窗口。该标志可以在滚动动画和滑动动画中使用。当使用AW_CENTER标志时，该标志将被忽略。
        const int AW_VER_POSITIVE = 0x0004;//自顶向下显示窗口。该标志可以在滚动动画和滑动动画中使用。当使用AW_CENTER标志时，该标志将被忽略。
        const int AW_HOR_NEGATIVE = 0x0002;//自右向左显示窗口。该标志可以在滚动动画和滑动动画中使用。当使用AW_CENTER标志时，该标志将被忽略。
        const int AW_VER_NEGATIVE = 0x0008;//自下向上显示窗口。该标志可以在滚动动画和滑动动画中使用。当使用AW_CENTER标志时，该标志将被忽略。

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        //显示时间
        private void tmr_1_Tick(object sender, EventArgs e)
        {
            //显示时间
            lbl_2.Text = DateTime.Now.ToString("yyyy年MM月dd日HH:mm");
            //显示用户名
            
        }       

        private void MainForm_Load(object sender, EventArgs e)
        {
            //窗体动画
            
            AnimateWindow(this.Handle, 500, AW_HIDE);
            lbl_4.Text = name.Name;
            lbl_2.Text = DateTime.Now.ToString("yyyy年MM月dd日HH:mm");
        }

        private void 商品进货ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new一个添加书本对象
            Booksadd Add = new Booksadd();
            //显示窗体
            Add.Show();

        }
        //显示窗体
        private void 退出ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Show();
        }
        //退出窗体
        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 向操作区域内部添加选项卡页,并在选项卡页中展示窗体
        /// </summary>
        /// <param name="TabName">标签文本</param>
        /// <param name="from">需要显示的窗体</param>
        private void AddTabPage(string TabName, Form form)
        {
            //根据标签文本，判断该选项卡页是否已经存在，防止重复
            if (TabPgeIsExist(TabName)) return;
            //选项卡页不存在，需要动态创建
            //创建选项卡页，并设置标签文本
            TabPage page = new TabPage(TabName);
            //将窗体form，添加到选项卡页中
            //注意：在TabPage中添加窗体，需要设置窗体以下两个属性
            form.TopLevel = false;  //设置为非顶级控件，否则运行报错
            form.Visible = true;    //设置为可见，否则窗体内容不显示
            page.Controls.Add(form);//将窗体添加到TabPage中
            //将TabPage对象添加到TabControl中
            this.tc_form.TabPages.Add(page);
            //添加后，选中该选项卡页
            this.tc_form.SelectedTab = page;
        }
        /// <summary>
        /// 判断选项卡页是否已经存在
        /// </summary>
        /// <param name="TabName">判断的依据：标签文本</param>
        /// <returns>是否存在</returns>
        private bool TabPgeIsExist(string TabName)
        {
            //先假设该选项卡不存在
            bool isExist = false;
            //遍历所有的选项卡页，验证假设是否成立
            foreach (TabPage page in this.tc_form.TabPages)
            {
                if (page.Text == TabName)
                {
                    //假设不成立，更改结果
                    isExist = true;
                    //选项卡页已经存在，直接选中该选项卡
                    this.tc_form.SelectedTab = page;
                    break;
                }
            }
            //返回最终结果
            return isExist;
        }
        //在操作区域内部添加选项卡页，显示satffForm窗体
        private void btn_kehuguanli_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示satffForm窗体
           StaffForm staffForm = new StaffForm();
            AddTabPage("人员管理", staffForm);
        }
        //在操作区域内部添加选项卡页，显示WarehouseForm窗体
        private void button1_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示WarehouseForm窗体
            WarehouseForm warehouseForm = new WarehouseForm();
            AddTabPage("仓库管理", warehouseForm);
        }
        //在操作区域内部添加选项卡页，显示SaledetailsForm窗体
        private void button2_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示SaledetailsForm窗体
            SaledetailsForm saledetailsForm = new SaledetailsForm();
            AddTabPage("营业报表", saledetailsForm);
        }
        //在操作区域内部添加选项卡页，显示salerForm窗体
        private void button5_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示salerForm窗体
            SalerForm salerForm = new SalerForm();
            
            AddTabPage("前台销售", salerForm);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //退出系统
            Application.Exit();
        }
        
        //双击移除选项卡
        private void tc_form_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //获取当前选中的Tab标签
            TabPage selectedPage = this.tc_form.SelectedTab;
            //首页标签不允许移除
            if (selectedPage.Text == "功能导航") return;
            //移除选中的标签
            this.tc_form.TabPages.Remove(selectedPage);
        }

        private void btn_jinhuo_Click(object sender, EventArgs e)
        {
            DataTable type = TypeBLL.selecttype();
            if (type.Rows.Count != 0)
            {
                //new一个添加书本对象
                Booksadd Add = new Booksadd();
                //显示窗体
                Add.Show();
            }
            else
            {
                MessageBox.Show("请先去添加书本类型", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                
            }
            
        }
        //在操作区域内部添加选项卡页，显示salerForm窗体
        private void tsp_sale_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示salerForm窗体
            SalerForm salerForm = new SalerForm();
            salerForm.Tag = this.lbl_4.Text;
            AddTabPage("前台销售", salerForm);
            
        }
        //在操作区域内部添加选项卡页，显示WarehouseForm窗体
        private void tsp_kucun_Click(object sender, EventArgs e)
        {
            WarehouseForm warehouseForm = new WarehouseForm();
            AddTabPage("仓库管理", warehouseForm);
        }
        //在操作区域内部添加选项卡页，显示satffForm窗体
        private void tsp_huiyuan_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示satffForm窗体
            SalemanAdd add = new SalemanAdd();
            add.Show();
            //StaffForm staffForm = new StaffForm();
            //AddTabPage("人员管理", staffForm);
        }
        //弹出关于信息
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此为最新版本。", "关于", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        //换班操作
        private void btn_huanban_Click(object sender, EventArgs e)
        {
           //重启程序
            Application.Exit();
            Application.Restart();
        }
        //显示VIPForm窗体
        private void huiyuan_Click(object sender, EventArgs e)
        {
            //显示VIPForm窗体
            VIPForm type = new VIPForm();
            AddTabPage("会员管理", type);
           
        }

        private void 添加会员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //显示VIPForm窗体
            VIPadd vip = new VIPadd();
            vip.Show();
        }
        //在操作区域内部添加选项卡页，显示WarehouseForm窗体
        private void btn_cangku_Click(object sender, EventArgs e)
        {
            DataTable type = TypeBLL.selecttype();
            if (type.Rows.Count != 0)
            {  //在操作区域内部添加选项卡页，显示WarehouseForm窗体
                WarehouseForm warehouseForm = new WarehouseForm();
                AddTabPage("仓库管理", warehouseForm);
            }
            else
            {
                MessageBox.Show("请先去添加书本类型", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
           
        }
        //在操作区域内部添加选项卡页，显示satffForm窗体
        private void btn_yuangong_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示satffForm窗体
            StaffForm staffForm = new StaffForm();
            AddTabPage("人员管理", staffForm);
        }
        //在操作区域内部添加选项卡页，显示WarehouseForm窗体
        private void btn_warehouse_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示WarehouseForm窗体
            WarehouseForm warehouseForm = new WarehouseForm();
            AddTabPage("仓库管理", warehouseForm);
        }

        private void 清除销售记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("");
           // string sql = "delete from sales , books , salesman ,vip , Warehouse";
           // DBHelper.ExecuteNonQuery(sql);           
           //MessageBox.Show("清除成功");
        }

        private void 书本类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示WarehouseForm窗体
            TypeForm TypeForm = new TypeForm();
            AddTabPage("书本类型", TypeForm);
        }

        private void 仓库管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示WarehouseForm窗体
            WarehouseForm warehouseForm = new WarehouseForm();
            AddTabPage("仓库管理", warehouseForm);
        }

        private void btn_Type_Click(object sender, EventArgs e)
        {
            //显示TypeForm窗体
            TypeForm type = new TypeForm();
            AddTabPage("类型管理", type);
        }

        private void showbooknum_Tick(object sender, EventArgs e)
        {

            if (int.Parse(BooksBLL.GetBooksLikeName(BooksBLL.GetMinStockBooksName()).Rows[0][7].ToString()) < 6)
            {
                //MessageBox.Show(BooksBLL.GetMinStockBooksName() + " 库存不足6本！", "库存警告", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.kucunwarn.Text = "《"+BooksBLL.GetMinStockBooksName()+"》" + " 库存不足6本！";
            }
            else
            {
                this.kucunwarn.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.kucunwarn.Text = "";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
