using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using model;
using DAL;
using System.Data;

namespace BLL
{
   public class VipBll
    {
       /// <summary>
       /// 添加会员
       /// </summary>
       /// <param name="vip"></param>
       /// <returns></returns>
       public static bool InsertVip(Vip vip)
       {
           return VipDal.InsertVip(vip);
       }
        /// <summary>
        /// 根据电话号码查询会员
        /// </summary>
        /// <param name="Mobile"></param>
        /// <returns></returns>
       public static bool SelectVipBymobilebool(string Mobile)
       {
           return VipDal.SelectVipBymobilebool(Mobile);
       }
       /// <summary>
       /// 根据电话号码查询会员
       /// </summary>
       /// <param name="Mobile"></param>
       /// <returns></returns>
       public static DataTable SetVipByMobile(string Mobile)
       {
           return VipDal.SetVipByMobile(Mobile);
       }
       /// <summary>
       /// 添加积分
       /// </summary>
       /// <param name="phone"></param>
       /// <param name="jifen"></param>
       /// <returns></returns>
       public static bool UpdatejifenByPhone(string phone, int jifen)
       {
           return VipDal.UpdatejifenByPhone(phone, jifen);
       }
       /// <summary>
       /// 减去积分
       /// </summary>
       /// <param name="phone"></param>
       /// <param name="jifen"></param>
       /// <returns></returns>
       public static bool DecreasejifenByPhone(string phone, int jifen)
       {
           return VipDal.DecreasejifenByPhone(phone, jifen);
       }
       /// <summary>
       /// 清空积分
       /// </summary>
       /// <param name="phone"></param>
       /// <param name="jifen"></param>
       /// <returns></returns>
       public static bool ClearjifenByPhone(string phone)
       {
           return VipDal.ClearjifenByPhone(phone);
       }
        /// <summary>
        /// 查询会员表
        /// </summary>
        /// <returns></returns>
       public static List<Vip> GetBooks()
       {
           return VipDal.GetBooks();
       }
        /// <summary>
       /// 模糊查询或者电话或者姓名
       /// </summary>
       /// <param name="name"></param>
       /// <param name="phone"></param>
       /// <returns></returns>
       public static DataTable SelectVIPLikeNameOrPhone(string name, string phone)
       {
           return VipDal.SelectVIPLikeNameOrPhone(name, phone);
       }
       /// <summary>
       /// 删除会员
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
       public static bool DeleteVip(int id)
       {
           return VipDal.DeleteVip(id);
       }
        /// <summary>
       /// 修改会员信息
       /// </summary>
       /// <param name="vip"></param>
       /// <returns></returns>
       public static bool UpdateVip(Vip vip)
       {
           return VipDal.UpdateVip(vip);
       }
    }
}
