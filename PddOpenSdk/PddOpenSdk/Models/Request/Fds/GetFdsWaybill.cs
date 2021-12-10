namespace PddOpenSdk.Models.Request.Fds;
public partial class GetFdsWaybill
{

    /// <summary>
    /// 入参信息
    /// </summary>
    [JsonPropertyName("param_fds_waybill_get_request")]
    public ParamFdsWaybillGetRequestModel ParamFdsWaybillGetRequest { get; set; }
    public partial class ParamFdsWaybillGetRequestModel
    {

        /// <summary>
        /// 发货人信息
        /// </summary>
        [JsonPropertyName("sender")]
        public SenderModel Sender { get; set; }

        /// <summary>
        /// 取号列表
        /// </summary>
        [JsonPropertyName("trade_order_info_dtos")]
        public List<TradeOrderInfoDtosModel> TradeOrderInfoDtos { get; set; }

        /// <summary>
        /// 物流公司 Code ，枚举： YTO- 圆通，ZTO-中通，YUNDA-韵达，STO-申通
        /// </summary>
        [JsonPropertyName("wp_code")]
        public string WpCode { get; set; }
        public partial class SenderModel
        {

            /// <summary>
            /// 发货地址，需要入参与 search 接口中的发货人地址信息一致
            /// </summary>
            [JsonPropertyName("address")]
            public AddressModel Address { get; set; }

            /// <summary>
            /// 手机号码
            /// </summary>
            [JsonPropertyName("mobile")]
            public string Mobile { get; set; }

            /// <summary>
            /// 姓名
            /// </summary>
            [JsonPropertyName("name")]
            public string Name { get; set; }

            /// <summary>
            /// 固定电话
            /// </summary>
            [JsonPropertyName("phone")]
            public string Phone { get; set; }
            public partial class AddressModel
            {

                /// <summary>
                /// 市
                /// </summary>
                [JsonPropertyName("city")]
                public string City { get; set; }

                /// <summary>
                /// 国家/地区
                /// </summary>
                [JsonPropertyName("country")]
                public string Country { get; set; }

                /// <summary>
                /// 详细地址
                /// </summary>
                [JsonPropertyName("detail")]
                public string Detail { get; set; }

                /// <summary>
                /// 区
                /// </summary>
                [JsonPropertyName("district")]
                public string District { get; set; }

                /// <summary>
                /// 省
                /// </summary>
                [JsonPropertyName("province")]
                public string Province { get; set; }

                /// <summary>
                /// 街道
                /// </summary>
                [JsonPropertyName("town")]
                public string Town { get; set; }

            }

        }
        public partial class TradeOrderInfoDtosModel
        {

            /// <summary>
            /// 物流服务内容链接
            /// </summary>
            [JsonPropertyName("logistics_services")]
            public string LogisticsServices { get; set; }

            /// <summary>
            /// 请求id
            /// </summary>
            [JsonPropertyName("object_id")]
            public string ObjectId { get; set; }

            /// <summary>
            /// 订单信息
            /// </summary>
            [JsonPropertyName("order_info")]
            public OrderInfoModel OrderInfo { get; set; }

            /// <summary>
            /// 包裹信息
            /// </summary>
            [JsonPropertyName("package_info")]
            public PackageInfoModel PackageInfo { get; set; }

            /// <summary>
            /// 标准模板模板URL
            /// </summary>
            [JsonPropertyName("template_url")]
            public string TemplateUrl { get; set; }

            /// <summary>
            /// 使用者ID
            /// </summary>
            [JsonPropertyName("user_id")]
            public long UserId { get; set; }
            public partial class OrderInfoModel
            {

                /// <summary>
                /// 订单渠道平台编码
                /// </summary>
                [JsonPropertyName("order_channels_type")]
                public string OrderChannelsType { get; set; }

                /// <summary>
                /// 订单列表，限制100个
                /// </summary>
                [JsonPropertyName("trade_order_list")]
                public List<TradeOrderListModel> TradeOrderList { get; set; }
                public partial class TradeOrderListModel
                {

                    /// <summary>
                    /// 代打店铺id
                    /// </summary>
                    [JsonPropertyName("mall_mask_id")]
                    public string MallMaskId { get; set; }

                    /// <summary>
                    /// 代打订单号
                    /// </summary>
                    [JsonPropertyName("order_mask_sn")]
                    public string OrderMaskSn { get; set; }

                }

            }
            public partial class PackageInfoModel
            {

                /// <summary>
                /// 快运货品描述
                /// </summary>
                [JsonPropertyName("goods_description")]
                public string GoodsDescription { get; set; }

                /// <summary>
                /// 包裹id,拆合单使用
                /// </summary>
                [JsonPropertyName("id")]
                public string Id { get; set; }

                /// <summary>
                /// 商品信息,数量限制为100
                /// </summary>
                [JsonPropertyName("items")]
                public List<ItemsModel> Items { get; set; }

                /// <summary>
                /// 快运包装方式描述
                /// </summary>
                [JsonPropertyName("packaging_description")]
                public string PackagingDescription { get; set; }

                /// <summary>
                /// 子母件总包裹数
                /// </summary>
                [JsonPropertyName("total_packages_count")]
                public string TotalPackagesCount { get; set; }

                /// <summary>
                /// 体积, 单位 ml
                /// </summary>
                [JsonPropertyName("volume")]
                public int? Volume { get; set; }

                /// <summary>
                /// 重量,单位 g
                /// </summary>
                [JsonPropertyName("weight")]
                public int? Weight { get; set; }
                public partial class ItemsModel
                {

                    /// <summary>
                    /// 数量
                    /// </summary>
                    [JsonPropertyName("count")]
                    public int Count { get; set; }

                    /// <summary>
                    /// 商品名称
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string Name { get; set; }

                }

            }

        }

    }

}

