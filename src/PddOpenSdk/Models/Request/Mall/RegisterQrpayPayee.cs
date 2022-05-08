namespace PddOpenSdk.Models.Request.Mall;
public partial class RegisterQrpayPayee
{

    /// <summary>
    /// 参数列表
    /// </summary>
    [JsonPropertyName("payee_list")]
    public List<PayeeListModel> PayeeList { get; set; }
    public partial class PayeeListModel
    {

        /// <summary>
        /// 参数名，用于注册到名单，并生成对应URL
        /// </summary>
        [JsonPropertyName("payee")]
        public string Payee { get; set; }

    }

}

