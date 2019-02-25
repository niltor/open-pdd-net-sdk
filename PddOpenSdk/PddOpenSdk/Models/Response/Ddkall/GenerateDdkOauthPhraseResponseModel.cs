using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Ddkall
{
    public partial class GenerateDdkOauthPhraseResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("ddk_phrase_generate_response")]
        public DdkPhraseGenerateResponseResponseModel DdkPhraseGenerateResponse { get; set; }
        public partial class DdkPhraseGenerateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 口令列表
            /// </summary>
            [JsonProperty("promotion_phrase_list")]
            public List<PromotionPhraseListResponseModel> PromotionPhraseList { get; set; }
            /// <summary>
            /// 总数
            /// </summary>
            [JsonProperty("total")]
            public int? Total { get; set; }
            public partial class PromotionPhraseListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 商品id
                /// </summary>
                [JsonProperty("goods_id")]
                public long? GoodsId { get; set; }
                /// <summary>
                /// 口令
                /// </summary>
                [JsonProperty("phrase")]
                public string Phrase { get; set; }

            }

        }

    }

}
