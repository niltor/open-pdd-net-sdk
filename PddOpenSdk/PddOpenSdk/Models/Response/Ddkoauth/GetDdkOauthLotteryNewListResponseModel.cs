using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddkoauth
{
    public class List
    {

        /// <summary>
        /// Examples: "210035_565"
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// Examples: "180904-257663033933549"
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("goods_thumb_url")]
        public object GoodsThumbUrl { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("goods_id")]
        public object GoodsId { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("goods_name")]
        public object GoodsName { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("pay_time")]
        public object PayTime { get; set; }

        /// <summary>
        /// Examples: 1536066890
        /// </summary>
        [JsonProperty("updated_at")]
        public int UpdatedAt { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("verify_time")]
        public object VerifyTime { get; set; }

        /// <summary>
        /// Examples: 3
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Examples: "333"
        /// </summary>
        [JsonProperty("custom_parameters")]
        public string CustomParameters { get; set; }
    }

    public class LotteryNewShowBillResponse
    {

        /// <summary>
        /// Examples: [{"pid":"210035_565","order_sn":"180904-257663033933549","goods_thumb_url":null,"goods_id":null,"goods_name":null,"pay_time":null,"updated_at":1536066890,"verify_time":null,"status":3,"custom_parameters":"333"}]
        /// </summary>
        [JsonProperty("list")]
        public IList<List> List { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("page_num")]
        public int PageNum { get; set; }

        /// <summary>
        /// Examples: 10
        /// </summary>
        [JsonProperty("page_size")]
        public int PageSize { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class GetDdkOauthLotteryNewListResponseModel
    {

        /// <summary>
        /// Examples: {"list":[{"pid":"210035_565","order_sn":"180904-257663033933549","goods_thumb_url":null,"goods_id":null,"goods_name":null,"pay_time":null,"updated_at":1536066890,"verify_time":null,"status":3,"custom_parameters":"333"}],"page_num":1,"page_size":10,"total_count":1}
        /// </summary>
        [JsonProperty("lottery_new_show_bill_response")]
        public LotteryNewShowBillResponse LotteryNewShowBillResponse { get; set; }
    }


}
