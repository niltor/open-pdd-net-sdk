using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class CreateGoodsCpsUnitResponseModel : PddResponseModel
    {
        /// <summary>
        /// 失败原因列表对象，创建成功则此参数为空
        /// </summary>
        [JsonProperty("failed_vos")]
        public FailedVosResponseModel FailedVos { get; set; }

        public partial class FailedVosResponseModel : PddResponseModel
        {
            /// <summary>
            /// 创建失败的商品id
            /// </summary>
            [JsonProperty("goods_id")]
            public string GoodsId { get; set; }
            /// <summary>
            /// 创建失败原因
            /// </summary>
            [JsonProperty("reason")]
            public string Reason { get; set; }

        }

    }
}
