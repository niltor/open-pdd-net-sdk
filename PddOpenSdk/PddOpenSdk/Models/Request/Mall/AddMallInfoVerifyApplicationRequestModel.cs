using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Request;
namespace PddOpenSdk.Models.Request.Mall
{
    public partial class AddMallInfoVerifyApplicationRequestModel : PddRequestModel
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("goods_id")]
        public long GoodsId { get; set; }
        /// <summary>
        /// 第三方软件账号id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        /// <summary>
        /// 店主名称
        /// </summary>
        [JsonProperty("ww_name")]
        public string WwName { get; set; }

    }

}
