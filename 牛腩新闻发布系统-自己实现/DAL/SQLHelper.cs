/*
 *制作人：琚建飞
 *创建时间：2016年9月26日15:36:18
 *说明：数据库的助手类
 *版权所有：提高班
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class SQLHelper
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        private SqlDataReader sdr = null;
        public SQLHelper() //构造函数
        {
            string connStr =ConfigurationManager.ConnectionStrings["connStr"].ConnectionString; //读取配置文件内容
            conn = new SqlConnection(connStr);
        }

        private SqlConnection GetConn()
        {
            if (conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }
        /// <summary>
        /// 该方法执行执行不带参数的增删改SQL语句或存储过程
        /// </summary>
        /// <param name="cmdText">增删改SQL语句或存储过程</param>
        /// <param name="ct">命令类型</param>
        /// <returns></returns>
        public  int ExecuteNonQuery(string cmdText,CommandType ct)
        {
            //string connStr = @"server=DESKTOP-MQNAEUK;database=newssystem;uid=sa;pwd=jujianfei";
            //SqlConnection conn = new SqlConnection(connStr);
            //conn.Open();
            int res;
            try
            {
                cmd = new SqlCommand(cmdText,GetConn());
                cmd.CommandType = ct;
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State==ConnectionState.Open)
                {
                    conn.Close();
                }             
            }
            return res;
            //SqlCommand cmd = new SqlCommand(sql,GetConn());
            //int res=cmd.ExecuteNonQuery();
            //conn.Close();
            //return res;
        }

        /// <summary>
        /// 执行带参数的SQL增删改语句或存储过程
        /// </summary>
        /// <param name="cmdText">SQL增删改语句或存储过程</param>
        /// <param name="paras"></param>
        /// <param name="ct">命令类型</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string cmdText,SqlParameter[] paras,CommandType ct)
        {
            int res;
            using(cmd = new SqlCommand(cmdText,GetConn()))
            {
                cmd.CommandType = ct;
                cmd.Parameters.AddRange(paras);
                res=cmd.ExecuteNonQuery();
            }
            return res;
        }

        /// <summary>
        /// 该方法执行传入的SQL查询语句或存储过程
        /// </summary>
        /// <param name="sql">SQL查询语句或存储过程</param>
        ///  <param name="ct">命令类型</param>
        /// <returns></returns>
        public DataTable ExecuteQuery(string cmdText,CommandType ct)
        {
            DataTable dt = new DataTable();
            //string connStr = @"server=DESKTOP-MQNAEUK;database=newssystem;uid=sa;pwd=jujianfei";
            //SqlConnection conn = new SqlConnection(connStr);
            //conn.Open();
            cmd = new SqlCommand(cmdText, GetConn());
            cmd.CommandType = ct;
            using (sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                dt.Load(sdr);                
            }
            //sdr.Close();
            //conn.Close();
            return dt;
        }

       /// <summary>
        /// 执行带参数的SQL查询语句或存储过程
       /// </summary>
        /// <param name="cmdText">SQL查询语句或存储过程</param>
       /// <param name="paras">参数集合</param>
       /// <param name="ct">命令类型</param>
       /// <returns></returns>
        public DataTable ExecuteQuery(string cmdText, SqlParameter[] paras,CommandType ct)
        {
            DataTable dt = new DataTable();
            cmd = new SqlCommand(cmdText, GetConn());
            cmd.CommandType = ct;
            cmd.Parameters.AddRange(paras);
            using (sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                dt.Load(sdr);
            }
            return dt;
        }

        //public DataTable test(string procName)
        //{
        //    DataTable dt = new DataTable();
        //    cmd = new SqlCommand(procName, GetConn());
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    using (sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
        //    {
        //        dt.Load(sdr);
        //    }
        //    return dt;
        //}
    }
}
