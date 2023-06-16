namespace PddOpenSdk.Models.Response.Goods;
public partial class CodeSelectGoodsLabelResponse : PddResponseModel
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
        [JsonPropertyName("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("error_msg")]
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
            /// 跨境货品skcId
            /// </summary>
            [JsonPropertyName("bg_prod_skc_id")]
            public long? BgProdSkcId { get; set; }

            /// <summary>
            /// 跨境货品skuId
            /// </summary>
            [JsonPropertyName("bg_prod_sku_id")]
            public long? BgProdSkuId { get; set; }

            /// <summary>
            /// 服饰类商品主属性，非服饰类商品为空
            /// </summary>
            [JsonPropertyName("clothes_spec")]
            public string ClothesSpec { get; set; }

            /// <summary>
            /// 是否服饰类商品
            /// </summary>
            [JsonPropertyName("is_clothes")]
            public bool? IsClothes { get; set; }

            /// <summary>
            /// 标签条码
            /// </summary>
            [JsonPropertyName("label_code")]
            public long? LabelCode { get; set; }

            /// <summary>
            /// 产地
            /// </summary>
            [JsonPropertyName("made_in")]
            public string MadeIn { get; set; }

            /// <summary>
            /// 销售属性
            /// </summary>
            [JsonPropertyName("spec")]
            public string Spec { get; set; }

        }

    }

}

