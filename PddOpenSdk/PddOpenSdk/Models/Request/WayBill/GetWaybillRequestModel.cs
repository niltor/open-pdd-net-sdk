using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.WayBill
{
    public partial class GetWaybillRequestModel : PddRequestModel
    {
        /// <summary>
        /// 入参信息
        /// </summary>
        [JsonProperty("param_waybill_cloud_print_apply_new_request")]
        public ParamWaybillCloudPrintApplyNewRequestRequestModel ParamWaybillCloudPrintApplyNewRequest { get; set; }
        public partial class ParamWaybillCloudPrintApplyNewRequestRequestModel : PddRequestModel
        {
            /// <summary>
            /// 设定取号返回的云打印报文是否加密
            /// </summary>
            [JsonProperty("need_encrypt")]
            public bool? NeedEncrypt { get; set; }
            /// <summary>
            /// 发货人信息
            /// </summary>
            [JsonProperty("sender")]
            public SenderRequestModel Sender { get; set; }
            /// <summary>
            /// 请求面单信息，数量限制为10
            /// </summary>
            [JsonProperty("trade_order_info_dtos")]
            public List<TradeOrderInfoDtosRequestModel> TradeOrderInfoDtos { get; set; }
            /// <summary>
            /// 物流公司Code
            /// </summary>
            [JsonProperty("wp_code")]
            public string WpCode { get; set; }
            public partial class SenderRequestModel : PddRequestModel
            {
                /// <summary>
                /// 地址
                /// </summary>
                [JsonProperty("address")]
                public AddressRequestModel Address { get; set; }
                /// <summary>
                /// 手机号码
                /// </summary>
                [JsonProperty("mobile")]
                public string Mobile { get; set; }
                /// <summary>
                /// 姓名
                /// </summary>
                [JsonProperty("name")]
                public string Name { get; set; }
                /// <summary>
                /// 固定电话
                /// </summary>
                [JsonProperty("phone")]
                public string Phone { get; set; }
                public partial class AddressRequestModel : PddRequestModel
                {
                    /// <summary>
                    /// 城市，仅支持非空值
                    /// </summary>
                    [JsonProperty("city")]
                    public string City { get; set; }
                    /// <summary>
                    /// 详细地址，仅支持非空值
                    /// </summary>
                    [JsonProperty("detail")]
                    public string Detail { get; set; }
                    /// <summary>
                    /// 区，仅支持非空值
                    /// </summary>
                    [JsonProperty("district")]
                    public string District { get; set; }
                    /// <summary>
                    /// 省，仅支持非空值
                    /// </summary>
                    [JsonProperty("province")]
                    public string Province { get; set; }
                    /// <summary>
                    /// 街道
                    /// </summary>
                    [JsonProperty("town")]
                    public string Town { get; set; }
                    /// <summary>
                    /// 国家/地区
                    /// </summary>
                    [JsonProperty("country")]
                    public string Country { get; set; }

                }

            }
            public partial class TradeOrderInfoDtosRequestModel : PddRequestModel
            {
                /// <summary>
                /// 物流服务内容链接
                /// </summary>
                [JsonProperty("logistics_services")]
                public string LogisticsServices { get; set; }
                /// <summary>
                /// 请求id
                /// </summary>
                [JsonProperty("object_id")]
                public string ObjectId { get; set; }
                /// <summary>
                /// 订单信息
                /// </summary>
                [JsonProperty("order_info")]
                public OrderInfoRequestModel OrderInfo { get; set; }
                /// <summary>
                /// 包裹信息
                /// </summary>
                [JsonProperty("package_info")]
                public PackageInfoRequestModel PackageInfo { get; set; }
                /// <summary>
                /// 收件人信息
                /// </summary>
                [JsonProperty("recipient")]
                public RecipientRequestModel Recipient { get; set; }
                /// <summary>
                /// 标准模板模板URL
                /// </summary>
                [JsonProperty("template_url")]
                public string TemplateUrl { get; set; }
                /// <summary>
                /// 使用者ID
                /// </summary>
                [JsonProperty("user_id")]
                public long UserId { get; set; }
                public partial class OrderInfoRequestModel : PddRequestModel
                {
                    /// <summary>
                    /// 订单渠道平台编码 当当网-DD，小米有品-XMYP，寺库-SK，聚美优品-JM，蜜芽-MY，小红书-XHS，萌推-MT，唯品会-WPH，拍拍-PP，ebay-EBAY，亚马逊-AMAZON，苏宁-SN，国美-GM，1号店-YHD，凡客-VANCL，邮乐-YL，优购-YG，乐蜂-LF，聚尚-JS，拍鞋-PX，银泰-YT，抖音-DY
                    /// </summary>
                    [JsonProperty("order_channels_type")]
                    public string OrderChannelsType { get; set; }
                    /// <summary>
                    /// 订单号,数量限制100
                    /// </summary>
                    [JsonProperty("trade_order_list")]
                    public List<string> TradeOrderList { get; set; }

                }
                public partial class PackageInfoRequestModel : PddRequestModel
                {
                    /// <summary>
                    /// 快运货品描述
                    /// </summary>
                    [JsonProperty("goods_description")]
                    public string GoodsDescription { get; set; }
                    /// <summary>
                    /// 包裹id,拆合单使用
                    /// </summary>
                    [JsonProperty("id")]
                    public string Id { get; set; }
                    /// <summary>
                    /// 商品信息,数量限制为100
                    /// </summary>
                    [JsonProperty("items")]
                    public List<ItemsRequestModel> Items { get; set; }
                    /// <summary>
                    /// 快运包装方式描述
                    /// </summary>
                    [JsonProperty("packaging_description")]
                    public string PackagingDescription { get; set; }
                    /// <summary>
                    /// 子母件总包裹数
                    /// </summary>
                    [JsonProperty("total_packages_count")]
                    public int? TotalPackagesCount { get; set; }
                    /// <summary>
                    /// 体积, 单位 ml
                    /// </summary>
                    [JsonProperty("volume")]
                    public long? Volume { get; set; }
                    /// <summary>
                    /// 重量,单位 g
                    /// </summary>
                    [JsonProperty("weight")]
                    public long? Weight { get; set; }
                    public partial class ItemsRequestModel : PddRequestModel
                    {
                        /// <summary>
                        /// 数量
                        /// </summary>
                        [JsonProperty("count")]
                        public int Count { get; set; }
                        /// <summary>
                        /// 名称
                        /// </summary>
                        [JsonProperty("name")]
                        public string Name { get; set; }

                    }

                }
                public partial class RecipientRequestModel : PddRequestModel
                {
                    /// <summary>
                    /// 地址
                    /// </summary>
                    [JsonProperty("address")]
                    public AddressRequestModel Address { get; set; }
                    /// <summary>
                    /// 手机号码
                    /// </summary>
                    [JsonProperty("mobile")]
                    public string Mobile { get; set; }
                    /// <summary>
                    /// 姓名
                    /// </summary>
                    [JsonProperty("name")]
                    public string Name { get; set; }
                    /// <summary>
                    /// 固定电话
                    /// </summary>
                    [JsonProperty("phone")]
                    public string Phone { get; set; }
                    public partial class AddressRequestModel : PddRequestModel
                    {
                        /// <summary>
                        /// 城市，仅支持非空值
                        /// </summary>
                        [JsonProperty("city")]
                        public string City { get; set; }
                        /// <summary>
                        /// 详细地址，仅支持非空值
                        /// </summary>
                        [JsonProperty("detail")]
                        public string Detail { get; set; }
                        /// <summary>
                        /// 区，仅支持非空值
                        /// </summary>
                        [JsonProperty("district")]
                        public string District { get; set; }
                        /// <summary>
                        /// 省，仅支持非空值
                        /// </summary>
                        [JsonProperty("province")]
                        public string Province { get; set; }
                        /// <summary>
                        /// 街道
                        /// </summary>
                        [JsonProperty("town")]
                        public string Town { get; set; }
                        /// <summary>
                        /// 国家/地区
                        /// </summary>
                        [JsonProperty("country")]
                        public string Country { get; set; }

                    }

                }

            }

        }

    }

}
