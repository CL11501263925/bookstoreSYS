using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;
using DAL;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
    public class BooksBLL
    {
        /// <summary>
        /// 查询书本表
        /// </summary>
        /// <returns></returns>
        public static List<Books> GetBooks()
        {
            return BooksDAL.GetBooks();
        }
         /// <summary>
        /// 查询书本表显示类型
        /// </summary>
        /// <returns></returns>
        public static DataTable GetBooksandType()
        {
            return BooksDAL.GetBooksandType();
        }
        /// <summary>
        /// 查询书本以及类型根据条形码
        /// </summary>
        /// <param name="BarCode"></param>
        /// <returns></returns>
        public static DataTable SelectBooksTypeByBarCode(string BarCode)
        {
            return BooksDAL.selectbookstypeBarCode(BarCode);
        }
        /// <summary>
        /// 添加书本
        /// </summary>
        /// <param name="gs"></param>
        /// <returns></returns>
        public static bool InsertBooks(Books gs)
        {            
            return BooksDAL.InsertBooks(gs);
        }
        /// <summary>
        /// 根据书本名模糊查询
        /// </summary>
        /// <param name="BooksName"></param>
        /// <returns></returns>
        public static DataTable GetBooksLikeName(string BooksName)
        {
            return BooksDAL.GetBooksLikeName(BooksName);
        }
        /// <summary>
        /// 修改书本信息
        /// </summary>
        /// <param name="gs"></param>
        /// <returns></returns>
        public static bool UpdateBooks(Books gs)
        {
            return BooksDAL.UpdateBooks(gs);
        }
         /// <summary>
        /// 删除书本
        /// </summary>
        /// <param name="BooksID">书本编号</param>
        /// <returns></returns>
        public static bool DeleteBooks(int BooksID)
        {
            return BooksDAL.DeleteBooks(BooksID);
        }
         /// <summary>
        /// 进货
        /// </summary>
        /// <returns></returns>
        public static bool InsertbooksByBarCod(int newGoods, int oldGoods, string BarCode)
        {
           return BooksDAL.InsertbooksByBarCod(newGoods,oldGoods,BarCode);
        }
         /// <summary>
        /// 根据书本名称查询库存数
        /// </summary>
        /// <param name="goodsName"></param>
        /// <returns></returns>
        public static int GetStockNumByBooksName(string goodsName)
        {
            return BooksDAL.GetStockNumByBooksName(goodsName);
        }
        /// <summary>
        /// 根据编号查询书本返回非断开式查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static SqlDataReader GetBooksReturnDataReaderByID(int id)
        {
            return BooksDAL.GetBooksReturnDataReaderByID(id);
        }
         /// <summary>
        /// 销售书本减少库存数
        /// </summary>
        /// <param name="BooksName"></param>
        /// <param name="GoodsNum"></param>
        /// <returns></returns>
        public static bool UpdateBooksStockNum(string BooksName, int GoodsNum)
        {
            return BooksDAL.UpdateBooksStockNum(BooksName,GoodsNum);
        }
        /// <summary>
        /// 根据书本姓名返回书本编号
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static int GetBooksIDbyBooksName(string name)
        {
            return BooksDAL.GetBooksIDbyBooksName(name);
        }
        public static string GetMinStockBooksName()
        {
            return BooksDAL.GetMinStockBooksName();
        }
    }
}
