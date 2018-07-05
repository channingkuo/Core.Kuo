#region 类文件描述
/*******************************************************
Copyright @ Channing Kuo All rights reserved. 
创建人   : Channing Kuo
创建时间 : 2018/7/4
说明     : PersisitBroker Functions
********************************************************/
#endregion

using System.Collections.Generic;
using System.Data;
using Core.Kuo.Provider;
using MySql.Data.MySqlClient;

namespace Core.Kuo.Services
{
    public class PersisitBroker : IPersisitBroker
    {
        public PersisitBroker() { }

        /// <summary>
        /// T-SQL查询
        /// </summary>
        /// <returns>The query.</returns>
        /// <param name="sql">T-SQL语句</param>
        override public DataTable Query(string sql)
        {
            return this.BaseMySqlData(sql);
        }

        /// <summary>
        /// 带参数查询
        /// </summary>
        /// <returns>The query.</returns>
        /// <param name="sql">T-SQL语句</param>
        /// <param name="parameters">查询参数</param>
        override public DataTable Query(string sql, Dictionary<string, object> parameters)
        {
            return this.BaseMySqlData(sql, parameters);
        }

        /// <summary>
        /// 带参数分页查询
        /// </summary>
        /// <returns>The query.</returns>
        /// <param name="sql">T-SQL语句</param>
        /// <param name="parameters">查询参数</param>
        /// <param name="pageIndex">分页-当前页</param>
        /// <param name="pageSize">分页-每页数量</param>
        /// <param name="orderBy">排序</param>
        /// <param name="count">数据总计</param>
        override public DataTable Query(string sql, Dictionary<string, object> parameters, int pageIndex, int pageSize, string orderBy, out int count)
        {
            return this.BaseMySqlData(sql, parameters, pageIndex, pageSize, orderBy, out count);
        }

        private DataTable BaseMySqlData(string sql)
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection connection = Connection.GetConnectionString())
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
            return dataTable;
        }

        private DataTable BaseMySqlData(string sql, Dictionary<string, object> parameters)
        {
            return null;
        }

        private DataTable BaseMySqlData(string sql, Dictionary<string, object> parameters, int pageIndex, int pageSize, string orderBy, out int count)
        {
            count = 0;
            return null;
        }
    }
}
