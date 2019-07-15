using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Waybill
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
                    /// 当前网点下的发货地址
                    /// </summary>
                    [JsonProperty("shipp_address_cols")]
                    public List<ShippAddressColsResponseModel> ShippAddressCols { get; set; }
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

                    }

                }

            }

        }

    }

}
