using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
using model;

namespace 书店管理系统
{
    public partial class TypeForm : Form
    {
        public TypeForm()
        {
            InitializeComponent();
        }

        private void TypeForm_Load(object sender, EventArgs e)
        {
            //绑定数据
            this.dgv_xiangqing.AutoGenerateColumns = false;
            this.dgv_xiangqing.DataSource = TypeBLL.selecttype() ;                         
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                TypeBLL.InsertType(this.txt_typename.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {              
            this.dgv_xiangqing.AutoGenerateColumns = false;
            this.dgv_xiangqing.DataSource = TypeBLL.selecttype();
            this.txt_typename.Text = "";
            }
           
            
        }
        int id;
        private void dgv_xiangqing_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
            id = int.Parse(this.dgv_xiangqing.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.txt_typename.Text = this.dgv_xiangqing.Rows[e.RowIndex].Cells[1].Value.ToString();           
            }
            catch (Exception )
            {
                MessageBox.Show(" 请点击正确的位置", "温馨提示");
            }
           
           
        }
        //修改
        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TypeBLL.UpdateType(id, this.txt_typename.Text))
                {
                    MessageBox.Show("修改成功", "温馨提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //初始化
                id = 0;
                this.txt_typename.Text = "";
                this.dgv_xiangqing.DataSource = TypeBLL.selecttype();
            }
        }

        //删除
        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (TypeBLL.DeleteType(id))
                {
                    MessageBox.Show("删除成功", "温馨提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //初始化
                id = 0;
                this.txt_typename.Text = "";
                this.dgv_xiangqing.DataSource = TypeBLL.selecttype();
            }
        }

        private void btn_chaxun_Click(object sender, EventArgs e)
        {
            try
            {
               this.dgv_xiangqing.DataSource=TypeBLL.GetDataTableLikeTypeName(this.txt_chaxun.Text);
            }
            finally {
                //初始化
                id = 0;
                this.txt_typename.Text = "";
               
            }
           
        }

        private void exportButton1_Click(object sender, EventArgs e)
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
