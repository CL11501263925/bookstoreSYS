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
    public partial class VIPForm : Form
    {
        public VIPForm()
        {
            InitializeComponent();
        }
        int id;

        private void VIP1Form_Load(object sender, EventArgs e)
        {
            //遍历出VIP    

            this.dgv_VIP.AutoGenerateColumns = false;
            this.dgv_VIP.DataSource = VipBll.GetBooks();

            this.cbo_gander.SelectedIndex = 0;
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_zengjia_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_phone.Text == "" || this.txt_name.Text == "" || this.txt_zhekou.Text == "")
                {
                    MessageBox.Show("信息不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (TextBoxBll.Intextnull(this.txt_name.Text, 1))
                {
                    MessageBox.Show("姓名过长", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (TextBoxBll.Intextnull(this.txt_phone.Text, 3))
                {
                    MessageBox.Show("请输入正确的电话号码", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                else if (TextBoxBll.Intextnull(this.txt_zhekou.Text, 2))//验证折扣是否为1~0之间的数字
                {
                    MessageBox.Show("积分必须是正整数", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    Vip vip = new Vip()
                    {
                        Mobile = this.txt_phone.Text,
                        jifen = 0,
                        VipName = this.txt_name.Text,
                        Gender = this.cbo_gander.Text
                    };
                    VipBll.InsertVip(vip);
                    MessageBox.Show("添加成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                this.dgv_VIP.DataSource = VipBll.GetBooks();
                this.txt_name.Text = "";
                this.txt_phone.Text = "";
                this.txt_zhekou.Text = "";
                this.cbo_gander.SelectedIndex = 0;
            }

        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_chaxun_Click(object sender, EventArgs e)
        {

            this.dgv_VIP.DataSource = VipBll.SelectVIPLikeNameOrPhone(this.txt_chaxun.Text, this.txt_chaxun.Text);

        }

        private void dgv_VIP_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                this.txt_name.Text = dgv_VIP.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txt_phone.Text = dgv_VIP.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.txt_zhekou.Text = dgv_VIP.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.cbo_gander.Text = dgv_VIP.Rows[e.RowIndex].Cells[3].Value.ToString();
                id = int.Parse(dgv_VIP.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("请点击正确的位置", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

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
                if (this.txt_phone.Text == "" || this.txt_name.Text == "" || this.txt_zhekou.Text == "")
                {
                    MessageBox.Show("信息不能为空", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                //else if (TextBoxBll.Intextnull(this.txt_name.Text, 1))
                //{
                //    MessageBox.Show("姓名过长", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //}
                else if (TextBoxBll.Intextnull(this.txt_phone.Text, 3))
                {
                    MessageBox.Show("请输入正确的电话号码", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (TextBoxBll.Intextnull(this.txt_zhekou.Text, 2))//验证折扣是否为1~0之间的数字
                {
                    MessageBox.Show("积分必须是正整数", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    //string sql = string.Format("update vip set VipName='{0}',Mobile='{1}',Gender='{2}',Discount={3} where vipID={4}) ", txt_name.Text, txt_phone.Text, this.cbo_gander.Text, this.txt_zhekou.Text, id);
                    Vip vip = new Vip()
                    {
                        VipID=id,
                        Mobile = this.txt_phone.Text,
                        jifen = 0,
                        VipName = this.txt_name.Text,
                        Gender = this.cbo_gander.Text
                    };
                    if (VipBll.UpdateVip(vip))
	                 {		
                    this.dgv_VIP.DataSource = VipBll.GetBooks();
                    MessageBox.Show("修改成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                this.dgv_VIP.DataSource = VipBll.GetBooks();

                this.txt_name.Text = "";
                this.txt_phone.Text = "";
                this.txt_zhekou.Text = "";
                this.cbo_gander.SelectedIndex = 0;
            }

        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_shanchu_Click(object sender, EventArgs e)
        {
            try
            {

                if (VipBll.DeleteVip(id))
                {
                    MessageBox.Show("删除成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {

                this.dgv_VIP.DataSource = VipBll.GetBooks();
                this.txt_name.Text = "";
                this.txt_phone.Text = "";
                this.txt_zhekou.Text = "";
                this.cbo_gander.SelectedIndex = 0;
            }
        }

        private void exportButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            ExportDGVToExcel exportDataToExcel = new ExportDGVToExcel();
            int ret = exportDataToExcel.ExportExcel("项目总表", dgv_VIP, dialog);
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
