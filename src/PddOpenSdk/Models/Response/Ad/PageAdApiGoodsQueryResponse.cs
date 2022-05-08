namespace PddOpenSdk.Models.Response.Ad;
public partial class PageAdApiGoodsQueryResponse : PddResponseModel
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
        public ResultResponseModel Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponseModel : PddResponseModel
        {

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("result")]
            public List<ResultResponse> Result { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("total")]
            public long? Total { get; set; }
            public partial class ResultResponse : PddResponseModel
            {

                /// <summary>
                /// 商品类目Id
                /// </summary>
                [JsonPropertyName("catId")]
                public long? CatId { get; set; }

                /// <summary>
                /// 商品类目名称
                /// </summary>
                [JsonPropertyName("catName")]
                public string CatName { get; set; }

                /// <summary>
                /// 商品Id
                /// </summary>
                [JsonPropertyName("goodsId")]
                public long? GoodsId { get; set; }

                /// <summary>
                /// 商品名称
                /// </summary>
                [JsonPropertyName("goodsName")]
                public string GoodsName { get; set; }

                /// <summary>
                /// 商品最小团购价
                /// </summary>
                [JsonPropertyName("minGroupPrice")]
                public long? MinGroupPrice { get; set; }

                /// <summary>
                /// 商品库存
                /// </summary>
                [JsonPropertyName("quantity")]
                public long? Quantity { get; set; }

                /// <summary>
                /// 商品销量
                /// </summary>
                [JsonPropertyName("soldQuantity")]
                public long? SoldQuantity { get; set; }

                /// <summary>
                /// 商品图片链接
                /// </summary>
                [JsonPropertyName("thumbUrl")]
                public string ThumbUrl { get; set; }

            }

        }

    }

}

