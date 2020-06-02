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
    public class BooksDAL
    {
        /// <summary>
        /// 根据条形码查询书本
        /// </summary>
        /// <param name="BarCode"></param>
        /// <returns></returns>
        public static DataTable selectbookstypeBarCode(string BarCode)
        {
            string sql = string.Format("select * from books a,type b where a.typeid=b.typeid  and BarCode='{0}'", BarCode);
            return DBHelper.GetDataTable(sql);
        }
        /// <summary>
        /// 查询书本表
        /// </summary>
        /// <returns></returns>
        public static List<Books> GetBooks()
        {
            string sql = "select * from Books";
            DataTable dt = DBHelper.GetDataTable(sql);
            List<Books> list = new List<Books>();
            Books books = new Books();
            foreach (DataRow rows in dt.Rows)
            {
                books.BooksID = int.Parse(rows["BooksID"].ToString());
                books.BooksName = rows["BooksName"].ToString();
                books.SalePrice = decimal.Parse(rows["SalePrice"].ToString());
                books.StorePrice = decimal.Parse(rows["StorePrice"].ToString());
                books.StockDate = DateTime.Parse(rows["StockDate"].ToString());
                books.StockNum = int.Parse(rows["StockNum"].ToString());
                books.TypeID = int.Parse(rows["TypeID"].ToString());
                list.Add(books);
            }
            return list;

        }
        /// <summary>
        /// 查询书本表显示类型
        /// </summary>
        /// <returns></returns>
        public static DataTable GetBooksandType()
        {
            string sql = "select * from [dbo].[Books] a,type b  where a.typeID=b.typeID ";
            return DBHelper.GetDataTable(sql);
        }
        /// <summary>
        /// 查询书本以及类型根据条形码
        /// </summary>
        /// <param name="BarCode"></param>
        /// <returns></returns>
        public static DataTable SelectBooksTypeByBarCode(string BarCode)
        {
            string sql = string.Format("select * from [dbo].[Books] a,type b  where a.typeID=b.typeID and BarCode='{0}'", BarCode);
            return DBHelper.GetDataTable(sql);
        }
        /// <summary>
        /// 添加书本
        /// </summary>
        /// <param name="gs"></param>
        /// <returns></returns>
        public static bool InsertBooks(Books gs)
        {
            string sql = string.Format("insert Books values ('{0}',{1},'{2}',{3},{4},{5},{6},'{7}')", gs.BooksName, gs.TypeID, gs.BarCode, gs.StorePrice, gs.SalePrice, gs.Discount, gs.StockNum, gs.StockDate);
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 根据书本名模糊查询
        /// </summary>
        /// <param name="BooksName"></param>
        /// <returns></returns>
        public static DataTable GetBooksLikeName(string BooksName)
        {
            string sql = string.Format("select * from Books a, type b  where a.typeID=b.typeID and BooksName like '%{0}%'", BooksName);
            return DBHelper.GetDataTable(sql);
        }
        /// <summary>
        /// 修改书本信息
        /// </summary>
        /// <param name="gs"></param>
        /// <returns></returns>
        public static bool UpdateBooks(Books gs)
        {
            string sql = string.Format("update books set booksname='{0}',typeid={1},BarCode='{2}',StorePrice={3}, SalePrice={4},Discount={5},StockNum={6},StockDate='{7}' where booksid={8}"
            ,gs.BooksName, gs.TypeID, gs.BarCode,gs.StorePrice,gs.SalePrice, gs.Discount, gs.StockNum, gs.StockDate, gs.BooksID);
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 删除书本
        /// </summary>
        /// <param name="BooksID"></param>
        /// <returns></returns>
        public static bool DeleteBooks(int BooksID)
        {
            string sql = string.Format("delete from books where Booksid={0}", BooksID);
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 检索条形码是否存在
        /// </summary>
        /// <param name="BarCode"></param>
        /// <returns></returns>
        public static bool GetBooksByBarCode(string BarCode)
        {
            string sql = string.Format("select * from books a,type b where a.typeid=b.typeid  and BarCode='{0}'", BarCode);
            return int.Parse(DBHelper.GetDataTable(sql).Rows.Count.ToString())>0;

        }

        /// <summary>
        /// 进货
        /// </summary>
        /// <returns></returns>
        public static bool InsertbooksByBarCod(int newGoods,int oldGoods, string BarCode)
        {
            string sql = string.Format("UPDATE Books set stockNum='{0}' where barcode='{1}'", newGoods + oldGoods, BarCode);
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 根据书本名称查询库存数
        /// </summary>
        /// <param name="goodsName"></param>
        /// <returns></returns>
        public static int GetStockNumByBooksName(string goodsName)
        {
            string sql = string.Format("select stockNum from books where goodsname='{0}'", goodsName);
            return int.Parse(DBHelper.GetDataTable(sql).Rows[0][0].ToString());
        }
        /// <summary>
        /// 根据编号查询书本返回非断开式查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static SqlDataReader GetBooksReturnDataReaderByID(int id)
        {
            string sql1 = string.Format("select * from books where goodsid={0}", id);
            return DBHelper.GetDataReader(sql1);
        }
        /// <summary>
        /// 销售书本减少库存数
        /// </summary>
        /// <param name="BooksName"></param>
        /// <param name="GoodsNum"></param>
        /// <returns></returns>
        public static bool UpdateBooksStockNum(string BooksName,int GoodsNum)
        {
            string sql= string.Format("update books set stocknum-={0} where BooksName='{1}'", GoodsNum, BooksName);
            return DBHelper.ExecuteNonQuery(sql);
         }
        /// <summary>
        /// 根据书本姓名返回书本编号
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static int GetBooksIDbyBooksName(string name)
        {
            string sql = "select BooksID from Books where BooksName='" + name + "'";
            return int.Parse(DBHelper.GetDataTable(sql).Rows[0][0].ToString());
        }

        public static string GetMinStockBooksName()
        {
            string sql = "select * from Books where StockNum=(select min(StockNum) from Books)";
            return DBHelper.GetDataTable(sql).Rows[0][1].ToString();
        }
    }
}

