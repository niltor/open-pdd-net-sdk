using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class QueryAdCreativeResponseModel : PddResponseModel {
        /// <summary>
        /// List<Object>
        /// </summary>
        [JsonProperty ("open_api_response")]
        public List<OpenApiResponseResponseModel> OpenApiResponse { get; set; }
        public partial class OpenApiResponseResponseModel : PddResponseModel {
            /// <summary>
            /// 千次展现成本
            /// </summary>
            [JsonProperty ("cpm")]
            public double? Cpm { get; set; }
            /// <summary>
            /// 广告投资回报率
            /// </summary>
            [JsonProperty ("roi")]
            public double? Roi { get; set; }
            /// <summary>
            /// 广告转化支付金额，单位厘
            /// </summary>
            [JsonProperty ("gmv")]
            public long? Gmv { get; set; }
            /// <summary>
            /// 广告转化支付订单数
            /// </summary>
            [JsonProperty ("order_num")]
            public long? OrderNum { get; set; }
            /// <summary>
            /// 点击单价，单位厘
            /// </summary>
            [JsonProperty ("cpc")]
            public double? Cpc { get; set; }
            /// <summary>
            /// 广告消耗,单位厘
            /// </summary>
            [JsonProperty ("spend")]
            public long? Spend { get; set; }
            /// <summary>
            /// 广告点击率
            /// </summary>
            [JsonProperty ("ctr")]
            public double? Ctr { get; set; }
            /// <summary>
            /// 广告点击数
            /// </summary>
            [JsonProperty ("click")]
            public int Click { get; set; }
            /// <summary>
            /// 广告曝光数
            /// </summary>
            [JsonProperty ("impression")]
            public int Impression { get; set; }
            /// <summary>
            /// 状态：1-推广中，2-手动暂停，3-已删除
            /// </summary>
            [JsonProperty ("status")]
            public int Status { get; set; }
            /// <summary>
            /// 销量
            /// </summary>
            [JsonProperty ("sold_quantity")]
            public long? SoldQuantity { get; set; }
            /// <summary>
            /// 最小团购价
            /// </summary>
            [JsonProperty ("min_group_price")]
            public long? MinGroupPrice { get; set; }
            /// <summary>
            /// 广告主操作状态：1-有效，2-暂停
            /// </summary>
            [JsonProperty ("operate_status")]
            public int OperateStatus { get; set; }
            /// <summary>
            /// 图高
            /// </summary>
            [JsonProperty ("image_height")]
            public int ImageHeight { get; set; }
            /// <summary>
            /// 图宽
            /// </summary>
            [JsonProperty ("image_width")]
            public int ImageWidth { get; set; }
            /// <summary>
            /// 图片地址
            /// </summary>
            [JsonProperty ("image_url")]
            public string ImageUrl { get; set; }
            /// <summary>
            /// 图片id
            /// </summary>
            [JsonProperty ("image_id")]
            public long? ImageId { get; set; }
            /// <summary>
            /// 标题
            /// </summary>
            [JsonProperty ("title")]
            public string Title { get; set; }
            /// <summary>
            /// 创意id
            /// </summary>
            [JsonProperty ("creative_id")]
            public long? CreativeId { get; set; }

        }

    }

}