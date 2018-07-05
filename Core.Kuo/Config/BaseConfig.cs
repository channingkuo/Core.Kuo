
namespace Core.Kuo.Config
{
    public class BaseConfig
    {
        /// <summary>
        /// datdabase connection
        /// </summary>
        public string DefaultConnection { get; set; }
        /// <summary>
        /// 对称加密解密的密钥 
        /// </summary>
        public string CryptionKey { get; set; }
    }
}
