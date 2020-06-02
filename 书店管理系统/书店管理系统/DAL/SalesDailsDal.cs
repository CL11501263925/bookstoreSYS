using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using model;

namespace DAL
{
    public class SalesDailsDal
    {
        /// <summary>
        /// 根据销售记录查询详情
        /// </summary>
        /// <param name="SaleID"></param>
        /// <returns></returns>
        public static DataTable SelectDailsBySalesID(int SaleID)
        {
            string sql = "select * from SalesDetail a,Books b where a.BooksID=b.BooksID and SalesID=" + SaleID;
            return DBHelper.GetDataTable(sql);
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public static double SelectDail()
        {
            double sum = 0;
            string sql = "select * from SalesDetail a,Sales b,Books c where a.SalesID=b.SalesID and a.BooksID=c.BooksID";
            DataTable dt = DBHelper.GetDataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sum += double.Parse(dt.Rows[i]["Quantity"].ToString()) * double.Parse(dt.Rows[i]["AloneAmount"].ToString());
            }
            return sum;
        }
        /// <summary>
        /// 添加销售详情表
        /// </summary>
        /// <param name="sale"></param>
        /// <returns></returns>
        public static bool InsertSaleDail(SalesDetail sale)
        {
            string sql = string.Format("insert SalesDetail values({0},{1},{2},{3})", sale.SalesID, sale.BooksID, sale.Quantity,sale.AloneAmount);
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}
