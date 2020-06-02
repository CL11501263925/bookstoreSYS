using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;
using DAL;
using System.Data;

namespace BLL
{
   public class SalemanBll
    {
      /// <summary>
      /// 管理员登录
      /// </summary>
      /// <param name="userName">用户名</param>
      /// <param name="password">密码</param>
      /// <returns></returns>
       public static bool Login(string userName, string password,string work)
       {
           return SalemanDAL.Login(userName,password,work);
       }
       /// <summary>
      /// 查询销售员是否存在
      /// </summary>
      /// <param name="phone">电话号码</param>
      /// <returns></returns>
       public static bool SelectSalemanByMobile(string phone)
       {
           return SalemanDAL.SelectSalemanByMobile(phone);
       }
       /// <summary>
      /// 修改销售员的信息
      /// </summary>
      /// <param name="Salesman"></param>
      /// <returns></returns>
       public static bool UpdateSaleman(Saleman Salesman)
       {
           return SalemanDAL.UpdateSaleman(Salesman);
       }

        /// <summary>
      /// 添加员工
      /// </summary>
      /// <param name="Salesman"></param>
      /// <returns></returns>
       public static bool InsertSalesman(Saleman Salesman)
       {
           return SalemanDAL.InsertSalesman(Salesman);
       }
       /// <summary>
      /// 存储过程 登录
      /// </summary>
      /// <param name="phone"></param>
      /// <param name="pwd"></param>
      /// <returns>1-账号不存在 2-密码错误 0-登录成功</returns>
       public static int LoginUserInfo(string phone, string pwd, string work)
       {
           return SalemanDAL.LoginUserInfo(phone, pwd,work);
       }
       /// <summary>
      /// 根据电话号码返回 员工姓名
      /// </summary>
      /// <param name="phone"></param>
      /// <returns></returns>
       public static string GetSalemanNameByPhone(string phone)
       {
           return SalemanDAL.GetSalemanNameByPhone(phone);
       }
       /// <summary>
      /// 查询员工表
      /// </summary>
      /// <returns></returns>
       public static DataTable GetSaleman()
       {
           return SalemanDAL.GetSaleman();
       }
        /// <summary>
      /// 查询员工根据姓名模糊查询
     /// </summary>
     /// <param name="Name"></param>
     /// <returns></returns>
       public static DataTable GetSalemanLikeName(string Name)
       {
           return SalemanDAL.GetSalemanLikeName(Name);
       }
        /// <summary>
      /// 删除员工
      /// </summary>
      /// <param name="id"></param>
      /// <returns></returns>
       public static bool DeleteSaleman(int id)
       {
           return SalemanDAL.DeleteSaleman(id);
       }
       /// <summary>
      /// 查询员工根据姓名返回编号
      /// </summary>
      /// <param name="name"></param>
      /// <returns></returns>
       public static int SelectSalemanByName(string name)
       {
           return SalemanDAL.SelectSalemanByName(name);
       }
    }
}
