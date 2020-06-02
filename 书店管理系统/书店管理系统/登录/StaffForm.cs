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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }
        //保存ID
        int id;
        bool flag;
        //判断折扣是否为小数
        float result;
        private void StaffForm_Load(object sender, EventArgs e)
        {
            cbo_work.SelectedIndex = 0;
            cbo_gander.SelectedIndex = 0;
            //不允许自动创建列
            this.dgv_renyuan.AutoGenerateColumns = false;
            //绑定数据源
            this.dgv_renyuan.DataSource = SalemanBll.GetSaleman();
            //初始最大化
            this.WindowState = FormWindowState.Maximized;
            //设置为可编辑状态
            dgv_renyuan.BeginEdit(false);
        }
        /// <summary>
        /// 模糊查询员工
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_chaxun_Click(object sender, EventArgs e)
        {
            this.dgv_renyuan.AutoGenerateColumns = false;
            this.dgv_renyuan.DataSource = SalemanBll.GetSalemanLikeName(this.txt_renyuan.Text);
        }
        /// <summary>
        /// 添加员工
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>       
        private void btn_zengjia_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (this.txt_basesalary.Text==""||this.txt_commissionRate.Text==""||this.txt_mobile.Text==""||this.txt_name.Text==""||this.txt_pwd.Text=="")
                {
                    MessageBox.Show("信息不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                if (TextBoxBll.Intextnull(this.txt_mobile.Text, 3))
                {
                    MessageBox.Show("请输入正确的电话号码", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (TextBoxBll.Intextnull(this.txt_commissionRate.Text,4))//验证提成是否为1~0之间的数字
                {
                    MessageBox.Show("提成必须是0~1的数字", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (TextBoxBll.Intextnull(this.txt_name.Text, 1))
                {
                    MessageBox.Show("姓名格式错误", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                     else if (SalemanBll.SelectSalemanByMobile(this.txt_mobile.Text))
                {
                    MessageBox.Show("电话号码已存在", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    Saleman saleman = new Saleman()
                    {
                        SalesmanName = this.txt_name.Text,
                        Mobile = this.txt_mobile.Text,
                        Pwd = this.txt_pwd.Text,
                        Gender = this.cbo_gander.Text,
                        BaseSalary = this.txt_basesalary.Text,
                        CommissionRate = this.txt_commissionRate.Text,
                        Work = this.cbo_work.Text
                    };
                    
                        if (SalemanBll.InsertSalesman(saleman))
                        {
                            MessageBox.Show("添加成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("添加失败", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        flag = true;
                    }
                   
                
       
            }
            catch (Exception )
            {
                MessageBox.Show("请正确填写信息", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
               
            }
            finally
            {
                this.dgv_renyuan.DataSource = SalemanBll.GetSaleman();
                this.txt_basesalary.Text = "";
                this.txt_commissionRate.Text = "";
                this.txt_mobile.Text = "";
                this.txt_name.Text = "";
                this.txt_pwd.Text = "";
            }

        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_xiugai_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                {
                    if (TextBoxBll.Intextnull(this.txt_mobile.Text, 3))
                    {
                        MessageBox.Show("请输入正确的电话号码", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (TextBoxBll.Intextnull(this.txt_commissionRate.Text, 4))//验证提成是否为1~0之间的数字
                    {
                        MessageBox.Show("提成必须是0~1的数字", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (TextBoxBll.Intextnull(this.txt_name.Text, 1))
                    {
                        MessageBox.Show("姓名格式错误", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        Saleman saleman = new Saleman()
                        {
                            SalesmanName = this.txt_name.Text,
                            Mobile = this.txt_mobile.Text,
                            Pwd = this.txt_pwd.Text,
                            Gender = this.cbo_gander.Text,
                            BaseSalary = this.txt_basesalary.Text,
                            CommissionRate = this.txt_commissionRate.Text,
                            Work = this.cbo_work.Text
                        };
                        if (SalemanBll.UpdateSaleman(saleman))
                        {
                            MessageBox.Show("修改成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("修改失败", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选择员工", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                this.dgv_renyuan.DataSource = SalemanBll.GetSaleman();
                this.txt_basesalary.Text = "";
                this.txt_commissionRate.Text = "";
                this.txt_mobile.Text = "";
                this.txt_name.Text = "";
                this.txt_pwd.Text = "";
            }

        }
        /// <summary>
        /// 删除员工
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_shanchu_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                {
                    if (SalemanBll.DeleteSaleman(id))
                    {
                        MessageBox.Show("删除成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("删除失败", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("请选择员工", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                this.dgv_renyuan.DataSource = SalemanBll.GetSaleman();
                this.txt_basesalary.Text = "";
                this.txt_commissionRate.Text = "";
                this.txt_mobile.Text = "";
                this.txt_name.Text = "";
                this.txt_pwd.Text = "";
            }
        }

        private void dgv_renyuan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //保存ID用于删除和修改
            try
            {
                this.txt_basesalary.Text = dgv_renyuan.Rows[e.RowIndex].Cells[5].Value.ToString();
                this.txt_commissionRate.Text = dgv_renyuan.Rows[e.RowIndex].Cells[6].Value.ToString();
                this.txt_mobile.Text = dgv_renyuan.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.txt_name.Text = dgv_renyuan.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txt_pwd.Text = dgv_renyuan.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.cbo_gander.Text = dgv_renyuan.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.cbo_work.Text = dgv_renyuan.Rows[e.RowIndex].Cells[7].Value.ToString();
                id = int.Parse(dgv_renyuan.Rows[e.RowIndex].Cells[0].Value.ToString());
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
            int ret = exportDataToExcel.ExportExcel("项目总表", dgv_renyuan, dialog);
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
