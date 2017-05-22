/*
 *创建人：琚建飞
 *创建时间：2016年10月5日15:17:26
 *说明：时间真的不多，登陆的业务逻辑类
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginManager
    {
        #region 用户登录是否成功
        /// <summary>
        /// 用户登录是否成功
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="pwd">用户密码</param>
        /// <returns></returns>
        public static bool Login(string name,string pwd)
        {
            bool flag = false;
            if ("jujianfei"==name && "1"==pwd)
            {
                flag = true;
            }
            return flag;
        }
        #endregion
    }   
}
