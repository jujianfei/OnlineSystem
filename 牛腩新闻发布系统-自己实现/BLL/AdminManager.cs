/*
 * ==================
 * 创建人：琚建飞
 * 创建时间：2017/5/23 15:31:05
 * 说明：
 * ==================
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class AdminManager
    {
        public static bool Login(string name, string pwd)
        {
            DAL.AdmainDAO ad = new DAL.AdmainDAO();
            return ad.JudgeAdmin(name,pwd);
        }
    }
}
