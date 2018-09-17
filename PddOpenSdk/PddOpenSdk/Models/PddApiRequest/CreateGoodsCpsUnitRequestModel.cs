using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class CreateGoodsCpsUnitRequestModel : PddRequestModel
    {
        /// <summary>
        /// 批量设置商品字符串，按照此格式来填写，具体参数见下。注意：创建优惠券时，必须优惠券几个参数都填，否则商品能创建成功,但是默认没有优惠券：[{"goods_id":10000,"rate":2,"coupon_id":123456,"coupon_start_time":1572345,"coupon_end_time":1576482,"discount":300,"init_quantity":600,"remain_quantity":560},{...}........]
        /// </summary>
        [JsonProperty("units")]
        public object Units { get; set; }

        public partial class UnitsRequestModel : PddRequestModel
        {

        }

    }
}
