using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.WayBill
{
    public partial class SearchWaybillResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("pdd_waybill_search_response")]
        public PddWaybillSearchResponseResponseModel PddWaybillSearchResponse { get; set; }
        public partial class PddWaybillSearchResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// WP网点信息及对应的商家的发货信息
            /// </summary>
            [JsonProperty("waybill_apply_subscription_cols")]
            public List<WaybillApplySubscriptionColsResponseModel> WaybillApplySubscriptionCols { get; set; }
            public partial class WaybillApplySubscriptionColsResponseModel : PddResponseModel
            {
                /// <summary>
                /// wp网点信息及对应的商家的发货信息
                /// </summary>
                [JsonProperty("branch_account_cols")]
                public List<BranchAccountColsResponseModel> BranchAccountCols { get; set; }
                /// <summary>
                /// 快递公司ID
                /// </summary>
                [JsonProperty("wp_code")]
                public string WpCode { get; set; }
                /// <summary>
                /// 物流服务商业务类型
                /// </summary>
                [JsonProperty("wp_type")]
                public int? WpType { get; set; }
                public partial class BranchAccountColsResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 已用面单数量
                    /// </summary>
                    [JsonProperty("allocated_quantity")]
                    public long? AllocatedQuantity { get; set; }
                    /// <summary>
                    /// 网点Code
                    /// </summary>
                    [JsonProperty("branch_code")]
                    public string BranchCode { get; set; }
                    /// <summary>
                    /// 网点名称
                    /// </summary>
                    [JsonProperty("branch_name")]
                    public string BranchName { get; set; }
                    /// <summary>
                    /// 取消的面单总数
                    /// </summary>
                    [JsonProperty("cancel_quantity")]
                    public long? CancelQuantity { get; set; }
                    /// <summary>
                    /// 电子面单余额数量
                    /// </summary>
                    [JsonProperty("quantity")]
                    public long? Quantity { get; set; }
                    /// <summary>
                    /// 已回收用面单数量
                    /// </summary>
                    [JsonProperty("recycled_quantity")]
                    public long? RecycledQuantity { get; set; }
                    /// <summary>
                    /// 服务类型列表
                    /// </summary>
                    [JsonProperty("service_info_cols")]
                    public List<ServiceInfoColsResponseModel> ServiceInfoCols { get; set; }
                    /// <summary>
                    /// 当前网点下的发货地址
                    /// </summary>
                    [JsonProperty("shipp_address_cols")]
                    public List<ShippAddressColsResponseModel> ShippAddressCols { get; set; }
                    /// <summary>
                    /// 增值服务账号
                    /// </summary>
                    [JsonProperty("vas_account_cols")]
                    public List<VasAccountColsResponseModel> VasAccountCols { get; set; }
                    public partial class ServiceInfoColsResponseModel : PddResponseModel
                    {
                        /// <summary>
                        /// 是否必须
                        /// </summary>
                        [JsonProperty("required")]
                        public bool? Required { get; set; }
                        /// <summary>
                        /// 服务属性类型列表
                        /// </summary>
                        [JsonProperty("service_attributes")]
                        public List<ServiceAttributesResponseModel> ServiceAttributes { get; set; }
                        /// <summary>
                        /// 服务code
                        /// </summary>
                        [JsonProperty("service_code")]
                        public string ServiceCode { get; set; }
                        /// <summary>
                        /// 服务描述
                        /// </summary>
                        [JsonProperty("service_desc")]
                        public string ServiceDesc { get; set; }
                        /// <summary>
                        /// 服务名称
                        /// </summary>
                        [JsonProperty("service_name")]
                        public string ServiceName { get; set; }
                        public partial class ServiceAttributesResponseModel : PddResponseModel
                        {
                            /// <summary>
                            /// 属性code
                            /// </summary>
                            [JsonProperty("attribute_code")]
                            public string AttributeCode { get; set; }
                            /// <summary>
                            /// 属性名称
                            /// </summary>
                            [JsonProperty("attribute_name")]
                            public string AttributeName { get; set; }
                            /// <summary>
                            /// 属性类型
                            /// </summary>
                            [JsonProperty("attribute_type")]
                            public string AttributeType { get; set; }
                            /// <summary>
                            /// 属性描述
                            /// </summary>
                            [JsonProperty("type_desc")]
                            public string TypeDesc { get; set; }

                        }

                    }
                    public partial class ShippAddressColsResponseModel : PddResponseModel
                    {
                        /// <summary>
                        /// 市名称（二级地址）
                        /// </summary>
                        [JsonProperty("city")]
                        public string City { get; set; }
                        /// <summary>
                        /// 详细地址
                        /// </summary>
                        [JsonProperty("detail")]
                        public string Detail { get; set; }
                        /// <summary>
                        /// 区名称（三级地址）
                        /// </summary>
                        [JsonProperty("district")]
                        public string District { get; set; }
                        /// <summary>
                        /// 省名称（一级地址）
                        /// </summary>
                        [JsonProperty("province")]
                        public string Province { get; set; }
                        /// <summary>
                        /// 国家/地区
                        /// </summary>
                        [JsonProperty("country")]
                        public string Country { get; set; }

                    }
                    public partial class VasAccountColsResponseModel : PddResponseModel
                    {
                        /// <summary>
                        /// 账户类型描述
                        /// </summary>
                        [JsonProperty("account_type_desc")]
                        public string AccountTypeDesc { get; set; }
                        /// <summary>
                        /// 电子面单余额数量
                        /// </summary>
                        [JsonProperty("quantity")]
                        public long? Quantity { get; set; }
                        /// <summary>
                        /// 已用面单数量
                        /// </summary>
                        [JsonProperty("allocated_quantity")]
                        public long? AllocatedQuantity { get; set; }
                        /// <summary>
                        /// 取消的面单总数
                        /// </summary>
                        [JsonProperty("cancel_quantity")]
                        public long? CancelQuantity { get; set; }
                        /// <summary>
                        /// 已回收用面单数量
                        /// </summary>
                        [JsonProperty("recycled_quantity")]
                        public long? RecycledQuantity { get; set; }

                    }

                }

            }

        }

    }

}
