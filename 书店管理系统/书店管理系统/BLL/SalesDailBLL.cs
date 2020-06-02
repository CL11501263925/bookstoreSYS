using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using model;

namespace BLL
{
   public class SalesDailBLL
    {
        /// <summary>
        /// 根据销售记录查询详情
        /// </summary>
        /// <param name="SaleID"></param>
        /// <returns></returns>
       public static DataTable SelectDailsBySalesID(int SaleID)
       {
           return SalesDailsDal.SelectDailsBySalesID(SaleID);
       }
         /// <summary>
        ///统计营业额
        /// </summary>
        /// <returns></returns>
       public static double SelectDail()
       {
           return SalesDailsDal.SelectDail();
       }
       /// <summary>
       /// 添加销售详情表
       /// </summary>
       /// <param name="sale"></param>
       /// <returns></returns>
       public static bool InsertSaleDail(SalesDetail sale)
       {           
           return SalesDailsDal.InsertSaleDail(sale);
       }
    }
}
