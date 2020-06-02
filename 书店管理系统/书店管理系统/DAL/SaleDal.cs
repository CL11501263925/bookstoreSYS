using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
   public class SaleDal
    {

       /// <summary>
       /// 查询销售表
       /// </summary>
       /// <returns></returns>
       public static DataTable SelectSale()
       {
           string sql = "select a.SalesID,a.ReceiptsCode,a.SalesDate,a.Amount,b.SalesmanName from Sales a,Saleman b where a.Salesmanid=b.salesmanid";
           return DBHelper.GetDataTable(sql);              
       }
       /// <summary>
       /// 根据时间查询销售表
       /// </summary>
       /// <param name="begin"></param>
       /// <param name="end"></param>
       /// <returns></returns>
       public static DataTable SelectSaleByTime(int Salesmanid,string begin,string end)
       {
           string sql = string.Format("select * from Sales,Saleman where Sales.SalesmanID=Saleman.SalesmanID and Sales.salesmanid = {0} and SalesDate between '{1}' and '{2}' ", Salesmanid, begin, end);
           return DBHelper.GetDataTable(sql);
       }
       /// <summary>
       /// 添加销售记录
       /// </summary>
       /// <param name="danhao"></param>
       /// <param name="time"></param>
       /// <param name="sum"></param>
       /// <param name="Salesmanid"></param>
       /// <returns></returns>
       public static bool InsertSale(string danhao,DateTime time,double sum,int Salesmanid)
       {
          string str = string.Format("insert Sales values ('{0}','{1}',{2},{3})", danhao, time, sum, Salesmanid);
          return DBHelper.ExecuteNonQuery(str);
       }
       /// <summary>
       /// 根据单号返回销售ID
       /// </summary>
       /// <param name="time"></param>
       /// <returns></returns>
       public static int GetSDIDByTime(string time)
       {
           string sql = string.Format("select SalesID from Sales where ReceiptsCode='{0}'",time);
           return int.Parse(DBHelper.GetDataTable(sql).Rows[0][0].ToString());
       }
    }
}
