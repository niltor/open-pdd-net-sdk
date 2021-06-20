using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Order
{
    public partial class LogisticsOrderUploadExtraRequestModel : PddRequestModel
    {
        /// <summary>
        /// 订单多包裹发货时使用的其他发货快递信息
        /// </summary>
        [JsonProperty("extra_track_list")]
        public List<ExtraTrackListRequestModel> ExtraTrackList { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }
        public partial class ExtraTrackListRequestModel : PddRequestModel
        {
            /// <summary>
            /// 快递公司id
            /// </summary>
            [JsonProperty("shipping_id")]
            public int ShippingId { get; set; }
            /// <summary>
            /// 快递单号
            /// </summary>
            [JsonProperty("tracking_number")]
            public string TrackingNumber { get; set; }

        }

    }

}
