using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class GetGoodsInformationResponseModel : PddResponseModel
    {
        /// <summary>
        /// 商品详情响应对象
        /// </summary>
        [JsonProperty("goods_info_get_response")]
        public GoodsInfoGetResponseResponseModel GoodsInfoGetResponse { get; set; }
        public partial class GoodsInfoGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 商品详情对象
            /// </summary>
            [JsonProperty("goods_info")]
            public GoodsInfoResponseModel GoodsInfo { get; set; }
            public partial class GoodsInfoResponseModel : PddResponseModel
            {
                /// <summary>
                /// 商品编码
                /// </summary>
                [JsonProperty("goods_id")]
                public long? GoodsId { get; set; }
                /// <summary>
                /// 商品序列编码
                /// </summary>
                [JsonProperty("goods_sn")]
                public string GoodsSn { get; set; }
                /// <summary>
                /// 商品类型，1-普通商品，2-进口商品，3-直供，4-直邮
                /// </summary>
                [JsonProperty("goods_type")]
                public int? GoodsType { get; set; }
                /// <summary>
                /// 商品一级类目
                /// </summary>
                [JsonProperty("goods_category")]
                public string GoodsCategory { get; set; }
                /// <summary>
                /// 叶子类目
                /// </summary>
                [JsonProperty("last_category")]
                public string LastCategory { get; set; }
                /// <summary>
                /// 是否七天无理由售后，0-不支持，1-支持
                /// </summary>
                [JsonProperty("is_refundable")]
                public int? IsRefundable { get; set; }
                /// <summary>
                /// 承诺发货时间
                /// </summary>
                [JsonProperty("shipment_limit_second")]
                public long? ShipmentLimitSecond { get; set; }
                /// <summary>
                /// 商品名称
                /// </summary>
                [JsonProperty("goods_name")]
                public string GoodsName { get; set; }
                /// <summary>
                /// 商品图片 url
                /// </summary>
                [JsonProperty("image_url")]
                public string ImageUrl { get; set; }
                /// <summary>
                /// 商品库存
                /// </summary>
                [JsonProperty("goods_quantity")]
                public int? GoodsQuantity { get; set; }
                /// <summary>
                /// 商品是否上架，0-下架，1-上架；
                /// </summary>
                [JsonProperty("is_onsale")]
                public int? IsOnsale { get; set; }
                /// <summary>
                /// 商品是否全新，0-全新商品，1-二手商品
                /// </summary>
                [JsonProperty("second_hand")]
                public int? SecondHand { get; set; }
                /// <summary>
                /// 成团人数
                /// </summary>
                [JsonProperty("group_required_customer_num")]
                public long? GroupRequiredCustomerNum { get; set; }
                /// <summary>
                /// sku列表对象
                /// </summary>
                [JsonProperty("sku_list")]
                public List<SkuListResponseModel> SkuList { get; set; }
                public partial class SkuListResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 商品规格名称
                    /// </summary>
                    [JsonProperty("spec")]
                    public string Spec { get; set; }
                    /// <summary>
                    /// 商品sku编码
                    /// </summary>
                    [JsonProperty("sku_id")]
                    public long? SkuId { get; set; }
                    /// <summary>
                    /// 商品sku库存
                    /// </summary>
                    [JsonProperty("sku_quantity")]
                    public long? SkuQuantity { get; set; }
                    /// <summary>
                    /// 商家外部编码（sku），同其他接口中的outer_id 、out_id、out_sku_sn、outer_sku_sn、out_sku_id、outer_sku_id 都为商家编码（sku维度）。
                    /// </summary>
                    [JsonProperty("outer_id")]
                    public string OuterId { get; set; }
                    /// <summary>
                    /// 商家外部编码（商品），同其他接口中的outer_goods_id 、out_goods_id、out_goods_sn、outer_goods_sn 都为商家编码（goods维度）。
                    /// </summary>
                    [JsonProperty("outer_goods_id")]
                    public string OuterGoodsId { get; set; }
                    /// <summary>
                    /// sku预览图
                    /// </summary>
                    [JsonProperty("sku_img")]
                    public string SkuImg { get; set; }
                    /// <summary>
                    /// 拼团价格（元）
                    /// </summary>
                    [JsonProperty("group_price")]
                    public string GroupPrice { get; set; }
                    /// <summary>
                    /// 单买价格（元）
                    /// </summary>
                    [JsonProperty("single_price")]
                    public string SinglePrice { get; set; }
                    /// <summary>
                    /// 商品sku是否上架，0-下架，1-上架
                    /// </summary>
                    [JsonProperty("is_sku_onsale")]
                    public int? IsSkuOnsale { get; set; }

                }

            }

        }

    }

}
