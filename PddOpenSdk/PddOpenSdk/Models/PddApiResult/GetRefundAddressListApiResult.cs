namespace App.Models.PddApiResult
{
    
public class RefundAddressList
{
    public int id { get; set; }
    public string refund_address { get; set; }
    public string refund_name { get; set; }
    public string refund_phone { get; set; }
    public int mall_id { get; set; }
    public string is_default { get; set; }
    public string refund_tel { get; set; }
    public int province_id { get; set; }
    public string province_name { get; set; }
    public int city_id { get; set; }
    public string city_name { get; set; }
    public int district_id { get; set; }
    public string district_name { get; set; }
    public bool is_legal { get; set; }
    public bool is_validated { get; set; }
}


public class RefundAddressListGetResponse
{
    public List<RefundAddressList> refund_address_list { get; set; }
}


public class GetRefundAddressListApiResult
{
    public RefundAddressListGetResponse refund_address_list_get_response { get; set; }
}

}
