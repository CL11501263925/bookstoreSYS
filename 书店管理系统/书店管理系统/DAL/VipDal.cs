using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public class VipDal
    {
        /// <summary>
        /// 查询会员表
        /// </summary>
        /// <returns></returns>
        public static List<Vip> GetBooks()
        {
            string sql = "select * from Vip ";
            DataTable dt = DBHelper.GetDataTable(sql);
            List<Vip> list = new List<Vip>();
           
            foreach (DataRow rows in dt.Rows)
            {
                Vip vip = new Vip();
                vip.jifen = int.Parse(rows["jifen"].ToString());
                vip.Gender = rows["Gender"].ToString();
                vip.Mobile = rows["Mobile"].ToString();
                vip.VipID = int.Parse(rows["VipID"].ToString());
                vip.VipName = rows["VipName"].ToString();
                list.Add(vip);
            }
            return list;
        }
       /// <summary>
       /// 根据电话号码查询会员 返回表格
       /// </summary>
       /// <param name="Mobile"></param>
       /// <returns></returns>
        public static DataTable SetVipByMobile(string Mobile)
        {
            string sql = string.Format("select * from VIP where Mobile='{0}'", Mobile);
            return DBHelper.GetDataTable(sql);
        }
        /// <summary>
        /// 根据电话号码查询会员 判断是否
        /// </summary>
        /// <param name="Mobile"></param>
        /// <returns></returns>
        public static bool SelectVipBymobilebool(string Mobile)
        {
            string sql =string.Format("select * from VIP where Mobile='{0}'",Mobile);
            return DBHelper.GetDataTable(sql).Rows.Count>0;
        }

       /// <summary>
       /// 添加会员
       /// </summary>
       /// <param name="vip"></param>
       /// <returns></returns>
        public static bool InsertVip(Vip vip)
        {
            string sql = string.Format("insert Vip values ('{0}','{1}','{2}',{3})", vip.VipName, vip.Mobile, vip.Gender, vip.jifen);
            return DBHelper.ExecuteNonQuery(sql);
        }
       /// <summary>
       /// 添加积分
       /// </summary>
       /// <param name="phone"></param>
       /// <param name="jifen"></param>
       /// <returns></returns>
        public static bool UpdatejifenByPhone(string phone,int jifen)
        {
            string sql = "update Vip set jifen+='" + jifen + "' where Mobile='"+phone+"'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 清空积分
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="jifen"></param>
        /// <returns></returns>
        public static bool ClearjifenByPhone(string phone)
        {
            string sql = "update Vip set jifen*='" + 0 + "' where Mobile='" + phone + "'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 减去积分
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="jifen"></param>
        /// <returns></returns>
        public static bool DecreasejifenByPhone(string phone, int jifen)
        {
            string sql = "update Vip set jifen-='" + jifen + "' where Mobile='"+phone+"'";
            return DBHelper.ExecuteNonQuery(sql);
        }
       /// <summary>
       /// 模糊查询或者电话或者姓名
       /// </summary>
       /// <param name="name"></param>
       /// <param name="phone"></param>
       /// <returns></returns>
        public static DataTable SelectVIPLikeNameOrPhone(string name,string phone)
        {
            string sql = string.Format("select * from Vip where VipName like '%{0}%' or Mobile like '%{1}%'",name, phone);
            return DBHelper.GetDataTable(sql);
        }
       /// <summary>
       /// 删除会员
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
        public static bool DeleteVip(int id)
        {
            string sql = string.Format("delete from vip where vipID={0}", id);
            return DBHelper.ExecuteNonQuery(sql);
        }
       /// <summary>
       /// 修改会员信息
       /// </summary>
       /// <param name="vip"></param>
       /// <returns></returns>
        public static bool UpdateVip(Vip vip)
        {
            string sql = string.Format("update vip set VipName='{0}' , Mobile={1} , Gender='{2}' , jifen={3} where VipID={4} "
                ,vip.VipName,vip.Mobile,vip.Gender,vip.jifen,vip.VipID);
            return DBHelper.ExecuteNonQuery(sql);
        }
       /// <summary>
       /// 根据电话号码查询会员
       /// </summary>
       /// <param name="Phone"></param>
       /// <returns></returns>
        public static DataTable SelectVIPbyName(string Phone)
        {
            string sql = "select * from Vip where Mobile='"+Phone+"'";
            return DBHelper.GetDataTable(sql);
        }
    }
}
