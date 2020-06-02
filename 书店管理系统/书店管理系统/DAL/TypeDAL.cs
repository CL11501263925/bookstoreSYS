using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;
using System.Data;
using System.Windows;
namespace DAL
{
    public class TypeDAL
    {
        /// <summary>
        /// 查询类型
        /// </summary>
        /// <returns></returns>
        public static DataTable selecttype()
        {
            string sql1 = "select * from type";
            return DBHelper.GetDataTable(sql1);
        }

        /// <summary>
        /// 根据类型名返回类型编号
        /// </summary>
        /// <param name="TypeName">类型名</param>
        /// <returns>TypeId</returns>
        public static int GetTypeIDByTypeName(string TypeName)
        {
            string sql = string.Format("select TypeID from type where typeName ='{0}'", TypeName);
            DataTable dt = DBHelper.GetDataTable(sql);
            if (dt.Rows.Count==0)
            {
                return 0;
            }
            return int.Parse(dt.Rows[0][0].ToString());
        }
        

        /// <summary>
        /// 添加类型
        /// </summary>
        /// <param name="TypeName"></param>
        /// <returns></returns>
        public static bool InsertType(string TypeName)
        {
            string sql = string.Format("insert Type values('{0}')", TypeName);
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 修改类型名根据类型编号
        /// </summary>
        /// <param name="TypeID"></param>
        /// <param name="TypeName"></param>
        /// <returns></returns>
        public static bool UpdateType(int TypeID, string TypeName)
        {
            string sql = string.Format("update Type set TypeName='{0}' where TypeID={1}", TypeName, TypeID);
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 删除类型
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool DeleteType(int id)
        {
            string sql = string.Format("delete from Type where Typeid={0}", id);
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 模糊查询类型名
        /// </summary>
        /// <param name="TypeName"></param>
        /// <returns></returns>
        public static DataTable GetDataTableLikeTypeName(string TypeName)
        {
            string sql = string.Format("select * from Type where TypeName like '%{0}%'", TypeName);
            return DBHelper.GetDataTable(sql);
        }
    }
}
