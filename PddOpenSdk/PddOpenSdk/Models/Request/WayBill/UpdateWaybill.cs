namespace PddOpenSdk.Models.Request.WayBill;
public partial class UpdateWaybill
{

    /// <summary>
    /// param_waybill_cloud_print_update_request
    /// </summary>
    [JsonPropertyName("param_waybill_cloud_print_update_request")]
    public ParamWaybillCloudPrintUpdateRequestModel ParamWaybillCloudPrintUpdateRequest { get; set; }
    public partial class ParamWaybillCloudPrintUpdateRequestModel
    {

        /// <summary>
        /// 请求表示id
        /// </summary>
        [JsonPropertyName("object_id")]
        public string ObjectId { get; set; }

        /// <summary>
        /// 包裹信息
        /// </summary>
        [JsonPropertyName("package_info")]
        public PackageInfoModel PackageInfo { get; set; }

        /// <summary>
        /// 收件信息
        /// </summary>
        [JsonPropertyName("recipient")]
        public RecipientModel Recipient { get; set; }

        /// <summary>
        /// 发件信息
        /// </summary>
        [JsonPropertyName("sender")]
        public SenderModel Sender { get; set; }

        /// <summary>
        /// 模板URL
        /// </summary>
        [JsonPropertyName("template_url")]
        public string TemplateUrl { get; set; }

        /// <summary>
        /// 面单号
        /// </summary>
        [JsonPropertyName("waybill_code")]
        public string WaybillCode { get; set; }

        /// <summary>
        /// 物流公司CODE
        /// </summary>
        [JsonPropertyName("wp_code")]
        public string WpCode { get; set; }
        public partial class PackageInfoModel
        {

            /// <summary>
            /// 商品
            /// </summary>
            [JsonPropertyName("items")]
            public List<ItemsModel> Items { get; set; }

            /// <summary>
            /// 体积
            /// </summary>
            [JsonPropertyName("volume")]
            public int? Volume { get; set; }

            /// <summary>
            /// 重量
            /// </summary>
            [JsonPropertyName("weight")]
            public int? Weight { get; set; }
            public partial class ItemsModel
            {

                /// <summary>
                /// 数量
                /// </summary>
                [JsonPropertyName("count")]
                public int? Count { get; set; }

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
                /// 城市
                /// </summary>
                [JsonPropertyName("city")]
                public string City { get; set; }

                /// <summary>
                /// 地区/国家
                /// </summary>
                [JsonPropertyName("country")]
                public string Country { get; set; }

                /// <summary>
                /// 详细地址
                /// </summary>
                [JsonPropertyName("detail")]
                public string Detail { get; set; }

                /// <summary>
                /// 区地址
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
        public partial class SenderModel
        {

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

        }

    }

}

