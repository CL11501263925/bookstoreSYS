using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DBHelper
    {
        public static string con = "Data Source=(local);Initial Catalog=项目-书店管理系统;Integrated Security=True";
        //数据库连接对象
        public static SqlConnection conn = null;
        //初始化数据库连接
        public static void InitConnection()
        {
            //如果连接对象不存在，则创建连接
            if (conn==null)
            {
                conn = new SqlConnection(con);
            }
            //如果连接对象关闭，则打开连接
            if (conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
            //如果连接中断，则重启连接
            if (conn.State==ConnectionState.Broken)
            {
                conn.Close();
                conn.Open();
            }           
        }
        //查询，获取DataReader
        public static SqlDataReader GetDataReader(string sqlstr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlstr,conn);
            //CommandBehavior.CloseConnecetion 命令行为：当DataReader对象关闭时自动关闭占用的连接对象
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        //查询，获取DataTable
        public static DataTable GetDataTable(string sqlStr)
        {
            InitConnection();
            DataTable table = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sqlStr,conn);            
            dap.Fill(table);
            conn.Close();
            if (table == null)
                return null;
            return table;
        }

        //增删改
        public static bool ExecuteNonQuery(string sqlstr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlstr,conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }
        //执行集合函数
        public static object ExecuteScalar(string sqlstr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlstr,conn);
            object result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        /// <summary>
        /// 查询存储过程
        /// </summary>
        /// <param name="bookName">存储工程名</param>
        /// <param name="paras">输入参数</param>
        /// <returns></returns>
        public static DataTable GetDataTableByProcedure(string bookName, SqlParameter[] paras)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(bookName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < paras.Length; i++)
            {
                cmd.Parameters.Add(paras[i]);
            }
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dt);
            conn.Close();
            return dt;
        }

        /// <summary>
        /// 增删改存储过程
        /// </summary>
        /// <param name="bookName">存储过程名字</param>
        /// <param name="paras">参数</param>
        /// <returns></returns>
        public static bool ExecuteByProcedure(string bookName, SqlParameter[] paras)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(bookName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < paras.Length; i++)
            {
                cmd.Parameters.Add(paras[i]);
            }
            return cmd.ExecuteNonQuery() > 0;
        }
}
}