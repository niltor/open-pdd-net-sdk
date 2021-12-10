namespace PddOpenSdk.Models.Request.WayBill;
public partial class GetWaybill
{

    /// <summary>
    /// 入参信息
    /// </summary>
    [JsonPropertyName("param_waybill_cloud_print_apply_new_request")]
    public ParamWaybillCloudPrintApplyNewRequestModel ParamWaybillCloudPrintApplyNewRequest { get; set; }
    public partial class ParamWaybillCloudPrintApplyNewRequestModel
    {

        /// <summary>
        /// 设定取号返回的云打印报文是否加密
        /// </summary>
        [JsonPropertyName("need_encrypt")]
        public bool? NeedEncrypt { get; set; }

        /// <summary>
        /// 发货人信息
        /// </summary>
        [JsonPropertyName("sender")]
        public SenderModel Sender { get; set; }

        /// <summary>
        /// 请求面单信息，数量限制为10
        /// </summary>
        [JsonPropertyName("trade_order_info_dtos")]
        public List<TradeOrderInfoDtosModel> TradeOrderInfoDtos { get; set; }

        /// <summary>
        /// 物流公司Code
        /// </summary>
        [JsonPropertyName("wp_code")]
        public string WpCode { get; set; }
        public partial class SenderModel
        {

            /// <summary>
            /// 地址
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
                /// 城市，仅支持非空值
                /// </summary>
                [JsonPropertyName("city")]
                public string City { get; set; }

                /// <summary>
                /// 国家/地区
                /// </summary>
                [JsonPropertyName("country")]
                public string Country { get; set; }

                /// <summary>
                /// 详细地址，仅支持非空值
                /// </summary>
                [JsonPropertyName("detail")]
                public string Detail { get; set; }

                /// <summary>
                /// 区，仅支持非空值
                /// </summary>
                [JsonPropertyName("district")]
                public string District { get; set; }

                /// <summary>
                /// 省，仅支持非空值
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
            /// 收件人信息
            /// </summary>
            [JsonPropertyName("recipient")]
            public RecipientModel Recipient { get; set; }

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
                /// 订单渠道平台编码 拼多多-PDD，淘宝-TB，天猫-TM，京东-JD，阿里巴巴-ALBB，有赞-YZ，微店-WD，蘑菇街-MGJ，云集-YJ，贝贝网-BB，转转-ZZ，快手小店-KS，当当网-DD，小米有品-XMYP，寺库-SK，聚美优品-JM，蜜芽-MY，小红书-XHS，萌推-MT，唯品会-WPH，拍拍-PP，ebay-EBAY，亚马逊-AMAZON，苏宁-SN，国美-GM，1号店-YHD，凡客-VANCL，邮乐-YL，优购-YG，乐蜂-LF，聚尚-JS，拍鞋-PX，银泰-YT，抖音-DY，其他-OTHERS
                /// </summary>
                [JsonPropertyName("order_channels_type")]
                public string OrderChannelsType { get; set; }

                /// <summary>
                /// 订单号,数量限制100
                /// </summary>
                [JsonPropertyName("trade_order_list")]
                public List<string> TradeOrderList { get; set; }

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
                public int? TotalPackagesCount { get; set; }

                /// <summary>
                /// 体积, 单位 ml
                /// </summary>
                [JsonPropertyName("volume")]
                public long? Volume { get; set; }

                /// <summary>
                /// 重量,单位 g
                /// </summary>
                [JsonPropertyName("weight")]
                public long? Weight { get; set; }
                public partial class ItemsModel
                {

                    /// <summary>
                    /// 数量
                    /// </summary>
                    [JsonPropertyName("count")]
                    public int Count { get; set; }

                    /// <summary>
                    /// 名称
                    /// </summary>
                    [JsonPropertyName("name")]
                    public string Name { get; set; }

                }

            }
            public partial class RecipientModel
            {

                /// <summary>
                /// 地址
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
                    /// 城市，仅支持非空值
                    /// </summary>
                    [JsonPropertyName("city")]
                    public string City { get; set; }

                    /// <summary>
                    /// 国家/地区
                    /// </summary>
                    [JsonPropertyName("country")]
                    public string Country { get; set; }

                    /// <summary>
                    /// 详细地址，仅支持非空值
                    /// </summary>
                    [JsonPropertyName("detail")]
                    public string Detail { get; set; }

                    /// <summary>
                    /// 区，仅支持非空值
                    /// </summary>
                    [JsonPropertyName("district")]
                    public string District { get; set; }

                    /// <summary>
                    /// 省，仅支持非空值
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

        }

    }

}

