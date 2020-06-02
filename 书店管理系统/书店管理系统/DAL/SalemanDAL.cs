using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using model;

namespace DAL
{
  public  class SalemanDAL
    {
      /// <summary>
      /// 登录 
      /// </summary>
      /// <param name="userName">用户名</param>
      /// <param name="password">密码</param>
      /// <param name="work">职务</param>
      /// <returns></returns>
      public static bool Login(string userName,string password,string work)
      {
          string sql = string.Format("select * from Saleman where SalesmanName='{0}'and Pwd='{1}' and Work='{2}'",userName,password,work);
          return int.Parse(DBHelper.GetDataTable(sql).Rows.Count.ToString()) > 0;
      }
      /// <summary>
      /// 查询员工表
      /// </summary>
      /// <returns></returns>
      public static DataTable GetSaleman()
      {
          string sql = "select * from Saleman";
          return DBHelper.GetDataTable(sql);
      }
      /// <summary>
      /// 存储过程 登录
      /// </summary>
      /// <param name="phone">电话号码</param>
      /// <param name="pwd">密码</param>
      /// <returns>0-账号不存在 1-密码错误 2-登录成功</returns>
      public static int LoginUserInfo(string phone,string pwd,string work)
      {
          SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@phone",phone),
                new SqlParameter("@password",pwd),
                new SqlParameter("@num",SqlDbType.Int),
                new SqlParameter("@work",work)
          };
          paras[2].Direction = ParameterDirection.Output;
          DBHelper.GetDataTableByProcedure("LoginSales", paras);
          return (int)paras[2].Value;
      }
      /// <summary>
      /// 查询销售员是否存在
      /// </summary>
      /// <param name="phone">电话号码</param>
      /// <returns></returns>
      public static bool SelectSalemanByMobile(string phone)
      {
          string sql = "select * from Saleman where Mobile="+phone;
          return int.Parse(DBHelper.GetDataTable(sql).Rows.Count.ToString()) > 0;
      }
      /// <summary>
      /// 修改销售员的信息
      /// </summary>
      /// <param name="Salesman"></param>
      /// <returns></returns>
      public static bool UpdateSaleman(Saleman Salesman)
      {         
          string sql = string.Format("update Saleman set SalesmanName='{0}' , Pwd='{1}' ,Gender='{2}',BaseSalary={3},CommissionRate={4},work='{5}' where Mobile='{6}' ",
              Salesman.SalesmanName, Salesman.Pwd, Salesman.Gender, Salesman.BaseSalary, Salesman.CommissionRate, Salesman.Work, Salesman.Mobile);
          return DBHelper.ExecuteNonQuery(sql);
      }
      /// <summary>
      /// 添加员工
      /// </summary>
      /// <param name="Salesman"></param>
      /// <returns></returns>
      public static bool InsertSalesman(Saleman Salesman)
      {
          string sql1 = string.Format("insert Saleman values ('{0}','{1}','{2}','{3}',{4},{5},'{6}')"
              , Salesman.SalesmanName, Salesman.Mobile, Salesman.Pwd, Salesman.Gender, Salesman.BaseSalary, Salesman.CommissionRate, Salesman.Work);
         return DBHelper.ExecuteNonQuery(sql1);
      }
     /// <summary>
      /// 查询员工根据姓名模糊查询
     /// </summary>
     /// <param name="Name"></param>
     /// <returns></returns>
      public static DataTable GetSalemanLikeName(string Name)
      {
          string sql = string.Format("select * from [dbo].[Saleman] where [SalesmanName] like '%{0}%'", Name);
          return DBHelper.GetDataTable(sql);
      }
      /// <summary>
      /// 根据电话号码返回 员工姓名
      /// </summary>
      /// <param name="phone"></param>
      /// <returns></returns>
      public static string GetSalemanNameByPhone(string phone)
      {
          string sql = "select SalesmanName from saleman where Mobile='" + phone + "'";
         return DBHelper.GetDataTable(sql).Rows[0][0].ToString();

      }
      /// <summary>
      /// 删除员工
      /// </summary>
      /// <param name="id"></param>
      /// <returns></returns>
      public static bool DeleteSaleman(int id)
      {
          string sql = "delete from Saleman where SalesmanID="+id;
          return DBHelper.ExecuteNonQuery(sql);
      }

      /// <summary>
      /// 查询员工根据姓名返回编号
      /// </summary>
      /// <param name="name"></param>
      /// <returns></returns>
      public static int SelectSalemanByName(string name)
       {
           string sql = "select * from Saleman where SalesmanName='"+name+"'";
           if (DBHelper.GetDataTable(sql).Rows.Count.ToString()=="0")
           {
               return 0;
           }
           else
           {
               return int.Parse(DBHelper.GetDataTable(sql).Rows[0][0].ToString());
           }
           
       }
    }
}
