#region 类文件描述
/*******************************************************
Copyright @ Channing Kuo All rights reserved. 
创建人   : Channing Kuo
创建时间 : 2018/7/4
说明     : Connection抽象类
********************************************************/
#endregion

using MySql.Data.MySqlClient;

namespace Core.Kuo.Provider
{
    abstract public class IConnection
    {
        abstract protected MySqlConnection DoConnection();
    }
}
