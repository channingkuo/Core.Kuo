#region 类文件描述
/*******************************************************
Copyright @ Channing Kuo All rights reserved. 
创建人   : Channing Kuo
创建时间 : 2018/7/3
说明     : DataBase Connection
********************************************************/
#endregion

using Core.Kuo.Provider;
using MySql.Data.MySqlClient;

namespace Core.Kuo.Services
{
    public class Connection : IConnection
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        /// <value>The connection string.</value>
        protected static string ConnectionString { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:DataAccess.Connection"/> class.
        /// </summary>
        /// <param name="connectionString">Connection string.</param>
        public Connection(string connectionString)
        {
            ConnectionString = Cryption.Cryption.DesDecrypt(connectionString);
        }

        protected override MySqlConnection DoConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns>The connection.</returns>
        public static MySqlConnection GetConnectionString()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
