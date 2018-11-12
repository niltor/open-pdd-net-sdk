using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class GetDdkGoodsBasicInfoRequestModel : PddRequestModel
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("goods_id_list")]
        public List<long> GoodsIdList { get; set; }

    }

}
