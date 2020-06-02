using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using model;
using DAL;
namespace BLL
{
  public  class TypeBLL
    {
      /// <summary>
      /// 查询类型
      /// </summary>
      /// <returns></returns>
      public static DataTable selecttype()
      {
          return TypeDAL.selecttype();
      }
       /// <summary>
     /// 根据类型名返回类型编号
     /// </summary>
     /// <param name="TypeName">类型名</param>
     /// <returns>TypeId</returns>
      public static int GetTypeIDByTypeName(string TypeName)
      {
          return TypeDAL.GetTypeIDByTypeName(TypeName);
      }
     
      /// <summary>
     /// 添加类型
     /// </summary>
     /// <param name="TypeName"></param>
     /// <returns></returns>
      public static bool InsertType(string TypeName)
      {
          return TypeDAL.InsertType(TypeName);
      }
      /// <summary>
     /// 修改类型名根据类型编号
     /// </summary>
     /// <param name="TypeID"></param>
     /// <param name="TypeName"></param>
     /// <returns></returns>
      public static bool UpdateType(int TypeID, string TypeName)
      {
          return TypeDAL.UpdateType(TypeID, TypeName);
      }
      /// <summary>
        /// 删除类型
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
      public static bool DeleteType(int id)
      {
          return TypeDAL.DeleteType(id);
      }
        /// <summary>
        /// 模糊查询类型名
        /// </summary>
        /// <param name="TypeName"></param>
        /// <returns></returns>
      public static DataTable GetDataTableLikeTypeName(string TypeName)
      {
          return TypeDAL.GetDataTableLikeTypeName(TypeName);
      }
    }
}
