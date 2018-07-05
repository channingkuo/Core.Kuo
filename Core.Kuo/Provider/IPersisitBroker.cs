#region 类文件描述
/*******************************************************
Copyright @ Channing Kuo All rights reserved. 
创建人   : Channing Kuo
创建时间 : 2018/7/4
说明     : PersisitBroker抽象类
********************************************************/
#endregion

using System.Collections.Generic;
using System.Data;

namespace Core.Kuo.Provider
{
    abstract public class IPersisitBroker
    {
        abstract public DataTable Query(string sql);
        abstract public DataTable Query(string sql, Dictionary<string, object> parameters);
        abstract public DataTable Query(string sql, Dictionary<string, object> parameters, int pageIndex, int pageSize, string orderBy, out int count);
    }
}
