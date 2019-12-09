using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 大作业
{
    class Login_stra : Login_Con, login_way
    {
        public string Login(int i,string num)
        {
            DataSet ds = new DataSet();
            if (i==0)//VIP用户登陆系统
            {
                ds = con()._Select("sys_pwd","system","sys_num", num);
            }
            if (i == 1)//员工登陆系统
            {
                ds = con()._Select("sta_pwd", "staff", "sta_num", num);
            }
            if (ds.Tables[0].Rows.Count == 0)
                return " ";
            else        
             return ds.Tables[0].Rows[0][0].ToString().Trim();
        }
    }
    //登录接口便于扩展
    interface login_way
    {
        string Login(int i, string id);
    }
    // 通过数据库工厂获取数据库操作类
    abstract class Login_Con
    {
        public SOperate con()
        {
            SFact s = new SFact();
            SOperate select = s.Select();
            return select;
        }
    }
}
