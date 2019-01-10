using System.Collections.Generic;
using Newtonsoft.Json;
using PddOpenSdk.Models.Response;
namespace PddOpenSdk.Models.Response.Express
{
    public partial class ListStockWareResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("open_api_response")]
        public OpenApiResponseResponseModel OpenApiResponse { get; set; }
        public partial class OpenApiResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 总数
            /// </summary>
            [JsonProperty("total")]
            public int? Total { get; set; }
            /// <summary>
            /// 货品详情
            /// </summary>
            [JsonProperty("ware_details")]
            public List<WareDetailsResponseModel> WareDetails { get; set; }
            public partial class WareDetailsResponseModel : PddResponseModel
            {
                /// <summary>
                /// 货品id
                /// </summary>
                [JsonProperty("id")]
                public long? Id { get; set; }
                /// <summary>
                /// 货品类型.0:单独货品 1:组合货品
                /// </summary>
                [JsonProperty("type")]
                public int? Type { get; set; }
                /// <summary>
                /// 组合货品中子货品的关联关系
                /// </summary>
                [JsonProperty("ware_infos")]
                public List<WareInfosResponseModel> WareInfos { get; set; }
                /// <summary>
                /// 货品sku信息
                /// </summary>
                [JsonProperty("ware_skus")]
                public List<WareSkusResponseModel> WareSkus { get; set; }
                /// <summary>
                /// 货品编码
                /// </summary>
                [JsonProperty("ware_sn")]
                public string WareSn { get; set; }
                /// <summary>
                /// 货品名称
                /// </summary>
                [JsonProperty("ware_name")]
                public string WareName { get; set; }
                /// <summary>
                /// 备注
                /// </summary>
                [JsonProperty("note")]
                public string Note { get; set; }
                /// <summary>
                /// 高低值服务，0低，1高
                /// </summary>
                [JsonProperty("service_quality")]
                public int? ServiceQuality { get; set; }
                /// <summary>
                /// 体积：立方厘米，精确到一位小数
                /// </summary>
                [JsonProperty("volume")]
                public int? Volume { get; set; }
                /// <summary>
                /// 长：厘米，精确到一位小数
                /// </summary>
                [JsonProperty("length")]
                public int? Length { get; set; }
                /// <summary>
                /// 宽：厘米，精确到一位小数
                /// </summary>
                [JsonProperty("width")]
                public int? Width { get; set; }
                /// <summary>
                /// 高：厘米，精确到一位小数
                /// </summary>
                [JsonProperty("height")]
                public int? Height { get; set; }
                /// <summary>
                /// 重量：kg，精确到两位小数
                /// </summary>
                [JsonProperty("weight")]
                public int? Weight { get; set; }
                /// <summary>
                /// 毛重：kg，精确到两位小数
                /// </summary>
                [JsonProperty("gross_weight")]
                public int? GrossWeight { get; set; }
                /// <summary>
                /// 净重：kg，精确到两位小数
                /// </summary>
                [JsonProperty("net_weight")]
                public int? NetWeight { get; set; }
                /// <summary>
                /// 皮重：kg，精确到两位小数
                /// </summary>
                [JsonProperty("tare_weight")]
                public int? TareWeight { get; set; }
                /// <summary>
                /// 单价：元，精确到一位小数
                /// </summary>
                [JsonProperty("price")]
                public int? Price { get; set; }
                /// <summary>
                /// 颜色
                /// </summary>
                [JsonProperty("color")]
                public string Color { get; set; }
                /// <summary>
                /// 包材
                /// </summary>
                [JsonProperty("packing")]
                public string Packing { get; set; }
                /// <summary>
                /// 库存
                /// </summary>
                [JsonProperty("quantity")]
                public long? Quantity { get; set; }
                /// <summary>
                /// 创建时间（毫秒）
                /// </summary>
                [JsonProperty("created_at")]
                public long? CreatedAt { get; set; }
                /// <summary>
                /// 更新时间（毫秒）
                /// </summary>
                [JsonProperty("updated_at")]
                public long? UpdatedAt { get; set; }
                public partial class WareInfosResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 子货品编码
                    /// </summary>
                    [JsonProperty("ware_sn")]
                    public string WareSn { get; set; }
                    /// <summary>
                    /// 子货品名称
                    /// </summary>
                    [JsonProperty("ware_name")]
                    public string WareName { get; set; }
                    /// <summary>
                    /// 子货品数量
                    /// </summary>
                    [JsonProperty("ware_quantity")]
                    public long? WareQuantity { get; set; }
                    /// <summary>
                    /// 子货品id
                    /// </summary>
                    [JsonProperty("ware_id")]
                    public long? WareId { get; set; }

                }
                public partial class WareSkusResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 商品id
                    /// </summary>
                    [JsonProperty("goods_id")]
                    public long? GoodsId { get; set; }
                    /// <summary>
                    /// skuid
                    /// </summary>
                    [JsonProperty("sku_id")]
                    public long? SkuId { get; set; }
                    /// <summary>
                    /// 货品id
                    /// </summary>
                    [JsonProperty("ware_id")]
                    public long? WareId { get; set; }
                    /// <summary>
                    /// 是否已绑定货品true/false
                    /// </summary>
                    [JsonProperty("exist_ware")]
                    public bool? ExistWare { get; set; }
                    /// <summary>
                    /// 上下架状态，true为上架
                    /// </summary>
                    [JsonProperty("is_onsale")]
                    public bool? IsOnsale { get; set; }
                    /// <summary>
                    /// 规格信息
                    /// </summary>
                    [JsonProperty("specs")]
                    public List<SpecsResponseModel> Specs { get; set; }
                    public partial class SpecsResponseModel : PddResponseModel
                    {
                        /// <summary>
                        /// 规格名称
                        /// </summary>
                        [JsonProperty("spec_key")]
                        public string SpecKey { get; set; }
                        /// <summary>
                        /// 规格值
                        /// </summary>
                        [JsonProperty("spec_value")]
                        public string SpecValue { get; set; }
                        /// <summary>
                        /// 规格id
                        /// </summary>
                        [JsonProperty("spec_id")]
                        public long? SpecId { get; set; }

                    }

                }

            }

        }

    }

}
