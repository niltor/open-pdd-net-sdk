using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Refund
{
    public partial class GetRefundAddressListResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("refund_address_list_get_response")]
        public RefundAddressListGetResponseResponseModel RefundAddressListGetResponse { get; set; }
        public partial class RefundAddressListGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 退货地址列表
            /// </summary>
            [JsonProperty("refund_address_list")]
            public List<RefundAddressListResponseModel> RefundAddressList { get; set; }
            public partial class RefundAddressListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 退货地址所在城市ID
                /// </summary>
                [JsonProperty("city_id")]
                public int? CityId { get; set; }
                /// <summary>
                /// 退货地址所在城市名字
                /// </summary>
                [JsonProperty("city_name")]
                public string CityName { get; set; }
                /// <summary>
                /// 退货地址所在区ID
                /// </summary>
                [JsonProperty("district_id")]
                public int? DistrictId { get; set; }
                /// <summary>
                /// 退货地址所在区名字
                /// </summary>
                [JsonProperty("district_name")]
                public string DistrictName { get; set; }
                /// <summary>
                /// 退货地址ID
                /// </summary>
                [JsonProperty("id")]
                public long? Id { get; set; }
                /// <summary>
                /// 是否为默认退货地址
                /// </summary>
                [JsonProperty("is_default")]
                public string IsDefault { get; set; }
                /// <summary>
                /// 退货地址是否合法
                /// </summary>
                [JsonProperty("is_legal")]
                public bool? IsLegal { get; set; }
                /// <summary>
                /// 退货地址是否有效
                /// </summary>
                [JsonProperty("is_validated")]
                public bool? IsValidated { get; set; }
                /// <summary>
                /// 店铺ID
                /// </summary>
                [JsonProperty("mall_id")]
                public long? MallId { get; set; }
                /// <summary>
                /// 退货地址所在省份ID
                /// </summary>
                [JsonProperty("province_id")]
                public int? ProvinceId { get; set; }
                /// <summary>
                /// 退货地址所在省份名字
                /// </summary>
                [JsonProperty("province_name")]
                public string ProvinceName { get; set; }
                /// <summary>
                /// 退货地址
                /// </summary>
                [JsonProperty("refund_address")]
                public string RefundAddress { get; set; }
                /// <summary>
                /// refund_id
                /// </summary>
                [JsonProperty("refund_address_id")]
                public string RefundAddressId { get; set; }
                /// <summary>
                /// 退货收件人名字
                /// </summary>
                [JsonProperty("refund_name")]
                public string RefundName { get; set; }
                /// <summary>
                /// 退货收件人手机号
                /// </summary>
                [JsonProperty("refund_phone")]
                public string RefundPhone { get; set; }
                /// <summary>
                /// 退货收件人固定电话
                /// </summary>
                [JsonProperty("refund_tel")]
                public string RefundTel { get; set; }

            }

        }

    }

}
