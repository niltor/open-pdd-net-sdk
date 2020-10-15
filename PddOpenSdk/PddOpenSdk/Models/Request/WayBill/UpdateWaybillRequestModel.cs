using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.WayBill
{
    public partial class UpdateWaybillRequestModel : PddRequestModel
    {
        /// <summary>
        /// param_waybill_cloud_print_update_request
        /// </summary>
        [JsonProperty("param_waybill_cloud_print_update_request")]
        public ParamWaybillCloudPrintUpdateRequestRequestModel ParamWaybillCloudPrintUpdateRequest { get; set; }
        public partial class ParamWaybillCloudPrintUpdateRequestRequestModel : PddRequestModel
        {
            /// <summary>
            /// 请求表示id
            /// </summary>
            [JsonProperty("object_id")]
            public string ObjectId { get; set; }
            /// <summary>
            /// 包裹信息
            /// </summary>
            [JsonProperty("package_info")]
            public PackageInfoRequestModel PackageInfo { get; set; }
            /// <summary>
            /// 收件信息
            /// </summary>
            [JsonProperty("recipient")]
            public RecipientRequestModel Recipient { get; set; }
            /// <summary>
            /// 发件信息
            /// </summary>
            [JsonProperty("sender")]
            public SenderRequestModel Sender { get; set; }
            /// <summary>
            /// 模板URL
            /// </summary>
            [JsonProperty("template_url")]
            public string TemplateUrl { get; set; }
            /// <summary>
            /// 面单号
            /// </summary>
            [JsonProperty("waybill_code")]
            public string WaybillCode { get; set; }
            /// <summary>
            /// 物流公司CODE
            /// </summary>
            [JsonProperty("wp_code")]
            public string WpCode { get; set; }
            public partial class PackageInfoRequestModel : PddRequestModel
            {
                /// <summary>
                /// 商品
                /// </summary>
                [JsonProperty("items")]
                public List<ItemsRequestModel> Items { get; set; }
                /// <summary>
                /// 体积
                /// </summary>
                [JsonProperty("volume")]
                public long? Volume { get; set; }
                /// <summary>
                /// 重量
                /// </summary>
                [JsonProperty("weight")]
                public long? Weight { get; set; }
                public partial class ItemsRequestModel : PddRequestModel
                {
                    /// <summary>
                    /// 数量
                    /// </summary>
                    [JsonProperty("count")]
                    public int? Count { get; set; }
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
                    /// 城市
                    /// </summary>
                    [JsonProperty("city")]
                    public string City { get; set; }
                    /// <summary>
                    /// 详细地址
                    /// </summary>
                    [JsonProperty("detail")]
                    public string Detail { get; set; }
                    /// <summary>
                    /// 区地址
                    /// </summary>
                    [JsonProperty("district")]
                    public string District { get; set; }
                    /// <summary>
                    /// 省
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
            public partial class SenderRequestModel : PddRequestModel
            {
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

            }

        }

    }

}
