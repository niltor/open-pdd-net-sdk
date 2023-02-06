namespace PddOpenSdk.Models.Response.Ad;
public partial class CreateAdApiUnitTrResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("errorMsg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 商品id
            /// </summary>
            [JsonPropertyName("goodsId")]
            public long? GoodsId { get; set; }

            /// <summary>
            /// 全站推广互斥广告列表
            /// </summary>
            [JsonPropertyName("mutexUnitList")]
            public List<MutexUnitListResponse> MutexUnitList { get; set; }
            public partial class MutexUnitListResponse : PddResponseModel
            {

                /// <summary>
                /// 广告id
                /// </summary>
                [JsonPropertyName("adId")]
                public long? AdId { get; set; }

                /// <summary>
                /// 广告名称
                /// </summary>
                [JsonPropertyName("adName")]
                public string AdName { get; set; }

                /// <summary>
                /// 广告场景
                /// </summary>
                [JsonPropertyName("scenesType")]
                public int? ScenesType { get; set; }

            }

        }

    }

}

