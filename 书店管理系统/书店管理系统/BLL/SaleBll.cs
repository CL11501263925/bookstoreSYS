using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
   public class SaleBll
    {
       /// <summary>
       /// 查询销售表
       /// </summary>
       /// <returns></returns>
       public static DataTable SelectSale()
       {
           return SaleDal.SelectSale();
       }
       /// <summary>
       /// 根据时间查询销售表
       /// </summary>
       /// <param name="begin"></param>
       /// <param name="end"></param>
       /// <returns></returns>
       public static DataTable SelectSaleByTime(int Salesmanid, string begin, string end)
       {
           return SaleDal.SelectSaleByTime(Salesmanid,begin, end);
       }
       /// <summary>
       /// 添加销售记录
       /// </summary>
       /// <param name="danhao"></param>
       /// <param name="time"></param>
       /// <param name="sum"></param>
       /// <param name="Salesmanid"></param>
       /// <returns></returns>
       public static bool InsertSale(string danhao, DateTime time, double sum, int Salesmanid)
       {
           return SaleDal.InsertSale(danhao,time,sum,Salesmanid);
       }
       /// <summary>
       /// 根据单号返回销售ID
       /// </summary>
       /// <param name="time"></param>
       /// <returns></returns>
       public static int GetSDIDByTime(string time)
       {
           return SaleDal.GetSDIDByTime(time);
       }
    }
}
