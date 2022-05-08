namespace PddOpenSdk.Models.Response.Order;
public partial class GetOrderVirtualInformationResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("order_virtual_information_response")]
    public OrderVirtualInformationResponseResponse OrderVirtualInformationResponse { get; set; }
    public partial class OrderVirtualInformationResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 联系人手机号
        /// </summary>
        [JsonPropertyName("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 身份证名
        /// </summary>
        [JsonPropertyName("id_card_name")]
        public string IdCardName { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [JsonPropertyName("id_card_num")]
        public string IdCardNum { get; set; }

        /// <summary>
        /// 选号卡号
        /// </summary>
        [JsonPropertyName("phone_number_chosen_by_user")]
        public string PhoneNumberChosenByUser { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

    }

}

