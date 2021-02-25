using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class ListAdApiUnitCreativeQueryResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("response")]
        public ResponseResponseModel Response { get; set; }
        public partial class ResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("errorCode")]
            public int? ErrorCode { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("errorMsg")]
            public string ErrorMsg { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("result")]
            public List<ResultResponseModel> Result { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("success")]
            public bool? Success { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// 每笔成交金额(average pay amount)，单位厘
                /// </summary>
                [JsonProperty("avgPayAmount")]
                public double? AvgPayAmount { get; set; }
                /// <summary>
                /// 广告点击量
                /// </summary>
                [JsonProperty("click")]
                public long? Click { get; set; }
                /// <summary>
                /// 平均点击花费，单位厘
                /// </summary>
                [JsonProperty("cpc")]
                public double? Cpc { get; set; }
                /// <summary>
                /// 千次展现成本
                /// </summary>
                [JsonProperty("cpm")]
                public double? Cpm { get; set; }
                /// <summary>
                /// 创意类型。2表示静态创意创意，3表示智能创意。
                /// </summary>
                [JsonProperty("creativeType")]
                public int? CreativeType { get; set; }
                /// <summary>
                /// 广告点击率
                /// </summary>
                [JsonProperty("ctr")]
                public double? Ctr { get; set; }
                /// <summary>
                /// 点击转化率
                /// </summary>
                [JsonProperty("cvr")]
                public double? Cvr { get; set; }
                /// <summary>
                /// 启用状态。1表示启用，2表示暂停。
                /// </summary>
                [JsonProperty("dataOperateStatus")]
                public int? DataOperateStatus { get; set; }
                /// <summary>
                /// 广告转化支付金额，单位厘
                /// </summary>
                [JsonProperty("gmv")]
                public long? Gmv { get; set; }
                /// <summary>
                /// 商品收藏数
                /// </summary>
                [JsonProperty("goodsFavNum")]
                public long? GoodsFavNum { get; set; }
                /// <summary>
                /// 创意图片高
                /// </summary>
                [JsonProperty("imageHeight")]
                public int? ImageHeight { get; set; }
                /// <summary>
                /// 创意图片链接
                /// </summary>
                [JsonProperty("imageUrl")]
                public string ImageUrl { get; set; }
                /// <summary>
                /// 创意图片宽
                /// </summary>
                [JsonProperty("imageWidth")]
                public int? ImageWidth { get; set; }
                /// <summary>
                /// 广告曝光量
                /// </summary>
                [JsonProperty("impression")]
                public long? Impression { get; set; }
                /// <summary>
                /// 店铺收藏数
                /// </summary>
                [JsonProperty("mallFavNum")]
                public long? MallFavNum { get; set; }
                /// <summary>
                /// 广告转化支付订单量
                /// </summary>
                [JsonProperty("orderNum")]
                public long? OrderNum { get; set; }
                /// <summary>
                /// 广告投入产出比
                /// </summary>
                [JsonProperty("roi")]
                public double? Roi { get; set; }
                /// <summary>
                /// 广告消耗，单位厘
                /// </summary>
                [JsonProperty("spend")]
                public long? Spend { get; set; }
                /// <summary>
                /// 创意单元状态。1表示推广中，2表示手动暂停，3表示已删除，4表示待发布，5表示已驳回。
                /// </summary>
                [JsonProperty("status")]
                public int? Status { get; set; }
                /// <summary>
                /// 状态描述，当状态是驳回时显示驳回原因
                /// </summary>
                [JsonProperty("statusDesc")]
                public string StatusDesc { get; set; }
                /// <summary>
                /// 创意标题
                /// </summary>
                [JsonProperty("title")]
                public string Title { get; set; }
                /// <summary>
                /// 转化成本
                /// </summary>
                [JsonProperty("transactionCost")]
                public double? TransactionCost { get; set; }
                /// <summary>
                /// 创意单元Id
                /// </summary>
                [JsonProperty("unitCreativeId")]
                public long? UnitCreativeId { get; set; }

            }

        }

    }

}
