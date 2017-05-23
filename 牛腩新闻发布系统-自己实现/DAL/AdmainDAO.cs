/*
 * ==================
 * 创建人：琚建飞
 * 创建时间：2017/5/23 15:19:17
 * 说明：
 * ==================
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class AdmainDAO
    {
        public bool JudgeAdmin(string uid,string pwd)
        {
            DataTable dt = new DataTable();
            string sql = "select adName,adPwd from Admin where adName=@name and adPwd=@pwd";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@name",uid),
                new SqlParameter("@pwd",pwd)
            };
            dt = new SQLHelper().ExecuteQuery(sql, paras, CommandType.Text);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
