using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Refund
{
    public class RefundAddressList
    {

        /// <summary>
        /// Examples: 779860
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Examples: "金虹桥国际中心"
        /// </summary>
        [JsonProperty("refund_address")]
        public string RefundAddress { get; set; }

        /// <summary>
        /// Examples: "王先生"
        /// </summary>
        [JsonProperty("refund_name")]
        public string RefundName { get; set; }

        /// <summary>
        /// Examples: "15290330705"
        /// </summary>
        [JsonProperty("refund_phone")]
        public string RefundPhone { get; set; }

        /// <summary>
        /// Examples: 410104
        /// </summary>
        [JsonProperty("mall_id")]
        public int MallId { get; set; }

        /// <summary>
        /// Examples: "Y"
        /// </summary>
        [JsonProperty("is_default")]
        public string IsDefault { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("refund_tel")]
        public string RefundTel { get; set; }

        /// <summary>
        /// Examples: 25
        /// </summary>
        [JsonProperty("province_id")]
        public int ProvinceId { get; set; }

        /// <summary>
        /// Examples: "上海"
        /// </summary>
        [JsonProperty("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// Examples: 321
        /// </summary>
        [JsonProperty("city_id")]
        public int CityId { get; set; }

        /// <summary>
        /// Examples: "上海"
        /// </summary>
        [JsonProperty("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// Examples: 2703
        /// </summary>
        [JsonProperty("district_id")]
        public int DistrictId { get; set; }

        /// <summary>
        /// Examples: "长宁区"
        /// </summary>
        [JsonProperty("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("is_legal")]
        public bool IsLegal { get; set; }

        /// <summary>
        /// Examples: false
        /// </summary>
        [JsonProperty("is_validated")]
        public bool IsValidated { get; set; }
    }

    public class RefundAddressListGetResponse
    {

        /// <summary>
        /// Examples: [{"id":779860,"refund_address":"金虹桥国际中心","refund_name":"王先生","refund_phone":"15290330705","mall_id":410104,"is_default":"Y","refund_tel":"","province_id":25,"province_name":"上海","city_id":321,"city_name":"上海","district_id":2703,"district_name":"长宁区","is_legal":true,"is_validated":false}]
        /// </summary>
        [JsonProperty("refund_address_list")]
        public IList<RefundAddressList> RefundAddressList { get; set; }
    }

    public class GetRefundAddressListResponseModel
    {

        /// <summary>
        /// Examples: {"refund_address_list":[{"id":779860,"refund_address":"金虹桥国际中心","refund_name":"王先生","refund_phone":"15290330705","mall_id":410104,"is_default":"Y","refund_tel":"","province_id":25,"province_name":"上海","city_id":321,"city_name":"上海","district_id":2703,"district_name":"长宁区","is_legal":true,"is_validated":false}]}
        /// </summary>
        [JsonProperty("refund_address_list_get_response")]
        public RefundAddressListGetResponse RefundAddressListGetResponse { get; set; }
    }


}
