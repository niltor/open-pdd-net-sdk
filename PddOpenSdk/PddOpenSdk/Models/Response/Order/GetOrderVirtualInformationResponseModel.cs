using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Order
{
    public partial class GetOrderVirtualInformationResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("order_virtual_information_response")]
        public OrderVirtualInformationResponseResponseModel OrderVirtualInformationResponse { get; set; }
        public partial class OrderVirtualInformationResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 联系人手机号
            /// </summary>
            [JsonProperty("contact_phone")]
            public string ContactPhone { get; set; }
            /// <summary>
            /// 身份证名
            /// </summary>
            [JsonProperty("id_card_name")]
            public string IdCardName { get; set; }
            /// <summary>
            /// 身份证号
            /// </summary>
            [JsonProperty("id_card_num")]
            public string IdCardNum { get; set; }
            /// <summary>
            /// 选号卡号
            /// </summary>
            [JsonProperty("phone_number_chosen_by_user")]
            public string PhoneNumberChosenByUser { get; set; }
            /// <summary>
            /// 订单号
            /// </summary>
            [JsonProperty("order_sn")]
            public string OrderSn { get; set; }

        }

    }

}
