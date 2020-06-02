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

namespace 书店管理系统
{
    public partial class SaledetailsForm : Form
    {
        public SaledetailsForm()
        {
            InitializeComponent();
        }
        
        private void SaledetailsForm_Load(object sender, EventArgs e)
        {
            
            //显示出销售表信息           
                      
            this.dgv_xiangqing.AutoGenerateColumns = false;     
            DataTable dt=SaleBll.SelectSale();
            this.dgv_xiangqing.DataSource = dt;
            //初始最大化
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //设置为可编辑状态
            //dgv_xiangqing.BeginEdit(false);
            //统计总营业额
                  
            this.lbl_yinyee.Text = SalesDailBLL.SelectDail().ToString();
            

        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            //退出
            Application.Exit();
        }
        //刷新
        private void skinButton2_Click(object sender, EventArgs e)
        {
            //显示出销售表信息           
            DataTable dt = SaleBll.SelectSale();            
            this.dgv_xiangqing.DataSource = dt;           
        }
        /// <summary>
        /// 根据时间和姓名查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton1_Click(object sender, EventArgs e)
        {
         int salemanid = SalemanBll.SelectSalemanByName(this.txt_chaxun.Text);
         if (salemanid==0)
         {

             MessageBox.Show("您查找的员工销售记录不存在", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
             this.dgv_xiangqing.DataSource = SaleBll.SelectSale();
         }
         else
         {
             this.dgv_xiangqing.DataSource = SaleBll.SelectSaleByTime(salemanid, this.dateTimePicker1.Text, this.dateTimePicker2.Text);         
         }
         
        }
        int id;//销售编号
        string mb;//详情
        double summoney;//总金额
        private void dgv_xiangqing_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {           
            id = int.Parse(this.dgv_xiangqing.Rows[e.RowIndex].Cells[0].Value.ToString());
            DataTable dt = SalesDailBLL.SelectDailsBySalesID(id);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                mb += " 书本名：" + dt.Rows[i]["BooksName"].ToString() + "\t 数量：" + dt.Rows[i]["Quantity"].ToString() + "\t 单价：" + dt.Rows[i]["AloneAmount"].ToString() + "\r";
                summoney += (double.Parse(dt.Rows[i]["Quantity"].ToString()) * double.Parse(dt.Rows[i]["AloneAmount"].ToString()));
            }
             mb+= "总金额："+summoney;
             MessageBox.Show(mb, "销售详情", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mb = "";//初始化
            summoney = 0;
            
        }

        private void exportbtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            ExportDGVToExcel exportDataToExcel = new ExportDGVToExcel();
            int ret = exportDataToExcel.ExportExcel("项目总表", dgv_xiangqing, dialog);
            if (ret == 0)
            {
                MessageBox.Show("导出项目总表成功");
            }
            else if (ret != 100)
            {
                MessageBox.Show("导出项目总表失败");
            }
        }

       
    }
}
