namespace PddOpenSdk.Models.Response.Refund;
public partial class GetRefundAddressListResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("refund_address_list_get_response")]
    public RefundAddressListGetResponseResponse RefundAddressListGetResponse { get; set; }
    public partial class RefundAddressListGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 退货地址列表
        /// </summary>
        [JsonPropertyName("refund_address_list")]
        public List<RefundAddressListResponse> RefundAddressList { get; set; }
        public partial class RefundAddressListResponse : PddResponseModel
        {

            /// <summary>
            /// 退货地址所在城市ID
            /// </summary>
            [JsonPropertyName("city_id")]
            public int? CityId { get; set; }

            /// <summary>
            /// 退货地址所在城市名字
            /// </summary>
            [JsonPropertyName("city_name")]
            public string CityName { get; set; }

            /// <summary>
            /// 退货地址所在区ID
            /// </summary>
            [JsonPropertyName("district_id")]
            public int? DistrictId { get; set; }

            /// <summary>
            /// 退货地址所在区名字
            /// </summary>
            [JsonPropertyName("district_name")]
            public string DistrictName { get; set; }

            /// <summary>
            /// 退货地址ID
            /// </summary>
            [JsonPropertyName("id")]
            public long? Id { get; set; }

            /// <summary>
            /// 是否为默认退货地址
            /// </summary>
            [JsonPropertyName("is_default")]
            public string IsDefault { get; set; }

            /// <summary>
            /// 退货地址是否合法
            /// </summary>
            [JsonPropertyName("is_legal")]
            public bool? IsLegal { get; set; }

            /// <summary>
            /// 退货地址是否有效
            /// </summary>
            [JsonPropertyName("is_validated")]
            public bool? IsValidated { get; set; }

            /// <summary>
            /// 店铺ID
            /// </summary>
            [JsonPropertyName("mall_id")]
            public long? MallId { get; set; }

            /// <summary>
            /// 退货地址所在省份ID
            /// </summary>
            [JsonPropertyName("province_id")]
            public int? ProvinceId { get; set; }

            /// <summary>
            /// 退货地址所在省份名字
            /// </summary>
            [JsonPropertyName("province_name")]
            public string ProvinceName { get; set; }

            /// <summary>
            /// 退货地址
            /// </summary>
            [JsonPropertyName("refund_address")]
            public string RefundAddress { get; set; }

            /// <summary>
            /// refund_id
            /// </summary>
            [JsonPropertyName("refund_address_id")]
            public string RefundAddressId { get; set; }

            /// <summary>
            /// 退货收件人名字
            /// </summary>
            [JsonPropertyName("refund_name")]
            public string RefundName { get; set; }

            /// <summary>
            /// 退货收件人手机号
            /// </summary>
            [JsonPropertyName("refund_phone")]
            public string RefundPhone { get; set; }

            /// <summary>
            /// 退货收件人固定电话
            /// </summary>
            [JsonPropertyName("refund_tel")]
            public string RefundTel { get; set; }

        }

    }

}

