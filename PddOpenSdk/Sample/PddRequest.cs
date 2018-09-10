using System.ComponentModel.DataAnnotations;

namespace Sample
{
    /// <summary>
    /// 拼多多请求
    /// </summary>
    public class PddRequest
    {
        /// <summary>
        /// 请求接口
        /// </summary>
        readonly string Daemon = "http://gw-api.pinduoduo.com/api/router";
        readonly string ClientId = "";

        public PddRequest()
        {

        }

        /// <summary>
        /// 获取AccessToken
        /// </summary>
        /// <returns></returns>
        protected string GetAccessToken()
        {
            return default;
        }

        protected object Post(string name)
        {

            return default;
        }
    }

    /// <summary>
    /// 公共请求参数
    /// </summary>
    public class CommonReqeustParams
    {
        /// <summary>
        /// API接口名称
        /// </summary>
        [Required]
        public string Type { get; set; }
        /// <summary>
        /// POP分配给应用的client_id
        /// </summary>
        [Required]
        public string Client_Id { get; set; }
        /// <summary>
        /// 通过code获取的access_token(无需授权的接口，该字段不参与sign签名运算)
        /// </summary>
        public string Access_Token { get; set; }
        /// <summary>
        /// UNIX时间戳
        /// </summary>
        [Required]
        public string TimeStamp { get; set; }
        /// <summary>
        /// 响应格式，即返回数据的格式，JSON或者XML（二选一），默认JSON，注意是大写
        /// </summary>
        public string Data_Type { get; set; } = "JSON";
        /// <summary>
        /// API协议版本号，默认为V1，可不填
        /// </summary>
        public string Version { get; set; } = "V1";
        /// <summary>
        /// API输入参数签名结果，签名算法参考开放平台接入指南第三部分底部
        /// </summary>
        [Required]
        public string Sign { get; set; }

    }
}
