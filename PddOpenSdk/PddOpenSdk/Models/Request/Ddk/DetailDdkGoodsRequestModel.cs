using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class DetailDdkGoodsRequestModel : PddRequestModel
    {
        /// <summary>
        /// 商品ID，仅支持单个查询。例如：[123456]
        /// </summary>
        [JsonProperty("goods_id_list")]
        public List<long> GoodsIdList { get; set; }
        public partial class GoodsIdListRequestModel : PddRequestModel
        {

        }

    }

}
