namespace PddOpenSdk.Models.Response.WayBill;
public partial class SearchWaybillResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("pdd_waybill_search_response")]
    public PddWaybillSearchResponseResponse PddWaybillSearchResponse { get; set; }
    public partial class PddWaybillSearchResponseResponse : PddResponseModel
    {

        /// <summary>
        /// WP网点信息及对应的商家的发货信息
        /// </summary>
        [JsonPropertyName("waybill_apply_subscription_cols")]
        public List<WaybillApplySubscriptionColsResponse> WaybillApplySubscriptionCols { get; set; }
        public partial class WaybillApplySubscriptionColsResponse : PddResponseModel
        {

            /// <summary>
            /// wp网点信息及对应的商家的发货信息
            /// </summary>
            [JsonPropertyName("branch_account_cols")]
            public List<BranchAccountColsResponse> BranchAccountCols { get; set; }

            /// <summary>
            /// 快递公司ID
            /// </summary>
            [JsonPropertyName("wp_code")]
            public string WpCode { get; set; }

            /// <summary>
            /// 物流服务商业务类型
            /// </summary>
            [JsonPropertyName("wp_type")]
            public int? WpType { get; set; }
            public partial class BranchAccountColsResponse : PddResponseModel
            {

                /// <summary>
                /// 已用面单数量
                /// </summary>
                [JsonPropertyName("allocated_quantity")]
                public long? AllocatedQuantity { get; set; }

                /// <summary>
                /// 网点Code
                /// </summary>
                [JsonPropertyName("branch_code")]
                public string BranchCode { get; set; }

                /// <summary>
                /// 网点名称
                /// </summary>
                [JsonPropertyName("branch_name")]
                public string BranchName { get; set; }

                /// <summary>
                /// 取消的面单总数
                /// </summary>
                [JsonPropertyName("cancel_quantity")]
                public long? CancelQuantity { get; set; }

                /// <summary>
                /// 电子面单余额数量
                /// </summary>
                [JsonPropertyName("quantity")]
                public long? Quantity { get; set; }

                /// <summary>
                /// 已回收用面单数量
                /// </summary>
                [JsonPropertyName("recycled_quantity")]
                public long? RecycledQuantity { get; set; }

                /// <summary>
                /// 服务类型列表
                /// </summary>
                [JsonPropertyName("service_info_cols")]
                public List<ServiceInfoColsResponse> ServiceInfoCols { get; set; }

                /// <summary>
                /// 当前网点下的发货地址
                /// </summary>
                [JsonPropertyName("shipp_address_cols")]
                public List<ShippAddressColsResponse> ShippAddressCols { get; set; }

                /// <summary>
                /// 增值服务账号
                /// </summary>
                [JsonPropertyName("vas_account_cols")]
                public List<VasAccountColsResponse> VasAccountCols { get; set; }
                public partial class ServiceInfoColsResponse : PddResponseModel
                {

                    /// <summary>
                    /// 是否必须
                    /// </summary>
                    [JsonPropertyName("required")]
                    public bool? Required { get; set; }

                    /// <summary>
                    /// 服务属性类型列表
                    /// </summary>
                    [JsonPropertyName("service_attributes")]
                    public List<ServiceAttributesResponse> ServiceAttributes { get; set; }

                    /// <summary>
                    /// 服务code
                    /// </summary>
                    [JsonPropertyName("service_code")]
                    public string ServiceCode { get; set; }

                    /// <summary>
                    /// 服务描述
                    /// </summary>
                    [JsonPropertyName("service_desc")]
                    public string ServiceDesc { get; set; }

                    /// <summary>
                    /// 服务名称
                    /// </summary>
                    [JsonPropertyName("service_name")]
                    public string ServiceName { get; set; }
                    public partial class ServiceAttributesResponse : PddResponseModel
                    {

                        /// <summary>
                        /// 属性code
                        /// </summary>
                        [JsonPropertyName("attribute_code")]
                        public string AttributeCode { get; set; }

                        /// <summary>
                        /// 属性名称
                        /// </summary>
                        [JsonPropertyName("attribute_name")]
                        public string AttributeName { get; set; }

                        /// <summary>
                        /// 属性类型
                        /// </summary>
                        [JsonPropertyName("attribute_type")]
                        public string AttributeType { get; set; }

                        /// <summary>
                        /// 属性描述
                        /// </summary>
                        [JsonPropertyName("type_desc")]
                        public string TypeDesc { get; set; }

                    }

                }
                public partial class ShippAddressColsResponse : PddResponseModel
                {

                    /// <summary>
                    /// 市名称（二级地址）
                    /// </summary>
                    [JsonPropertyName("city")]
                    public string City { get; set; }

                    /// <summary>
                    /// 详细地址
                    /// </summary>
                    [JsonPropertyName("detail")]
                    public string Detail { get; set; }

                    /// <summary>
                    /// 区名称（三级地址）
                    /// </summary>
                    [JsonPropertyName("district")]
                    public string District { get; set; }

                    /// <summary>
                    /// 省名称（一级地址）
                    /// </summary>
                    [JsonPropertyName("province")]
                    public string Province { get; set; }

                    /// <summary>
                    /// 国家/地区
                    /// </summary>
                    [JsonPropertyName("country")]
                    public string Country { get; set; }

                }
                public partial class VasAccountColsResponse : PddResponseModel
                {

                    /// <summary>
                    /// 账户类型描述
                    /// </summary>
                    [JsonPropertyName("account_type_desc")]
                    public string AccountTypeDesc { get; set; }

                    /// <summary>
                    /// 电子面单余额数量
                    /// </summary>
                    [JsonPropertyName("quantity")]
                    public long? Quantity { get; set; }

                    /// <summary>
                    /// 已用面单数量
                    /// </summary>
                    [JsonPropertyName("allocated_quantity")]
                    public long? AllocatedQuantity { get; set; }

                    /// <summary>
                    /// 取消的面单总数
                    /// </summary>
                    [JsonPropertyName("cancel_quantity")]
                    public long? CancelQuantity { get; set; }

                    /// <summary>
                    /// 已回收用面单数量
                    /// </summary>
                    [JsonPropertyName("recycled_quantity")]
                    public long? RecycledQuantity { get; set; }

                }

            }

        }

    }

}

