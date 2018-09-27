using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public class DdkAppNewBillList
    {
        /// <summary>
        /// Examples: "60013_2039"
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// Examples: "180515-392972355200461"
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }

        /// <summary>
        /// Examples: "http://pddtestimg.yangkeduo.com/test/2017-09-19/ef972ed0e60279164d8fbea31515e238.jpeg"
        /// </summary>
        [JsonProperty("goods_thumb_url")]
        public string GoodsThumbUrl { get; set; }

        /// <summary>
        /// Examples: 10073718
        /// </summary>
        [JsonProperty("goods_id")]
        public int GoodsId { get; set; }

        /// <summary>
        /// Examples: "商品锁定19"
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// Examples: 1000
        /// </summary>
        [JsonProperty("money")]
        public int Money { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("pay_time")]
        public object PayTime { get; set; }

        /// <summary>
        /// Examples: 1526969107
        /// </summary>
        [JsonProperty("updated_at")]
        public int UpdatedAt { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("verify_time")]
        public object VerifyTime { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Examples: "abcd"
        /// </summary>
        [JsonProperty("custom_parameters")]
        public string CustomParameters { get; set; }
    }

    public class AppNewBillListResponse
    {

        /// <summary>
        /// Examples: [{"pid":"60013_2039","order_sn":"180515-392972355200461","goods_thumb_url":"http://pddtestimg.yangkeduo.com/test/2017-09-19/ef972ed0e60279164d8fbea31515e238.jpeg","goods_id":10073718,"goods_name":"商品锁定19","money":1000,"pay_time":null,"updated_at":1526969107,"verify_time":null,"status":1,"custom_parameters":"abcd"}]
        /// </summary>
        [JsonProperty("list")]
        public IList<DdkAppNewBillList> List { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class GetDdkAppNewBillListResponseModel
    {

        /// <summary>
        /// Examples: {"list":[{"pid":"60013_2039","order_sn":"180515-392972355200461","goods_thumb_url":"http://pddtestimg.yangkeduo.com/test/2017-09-19/ef972ed0e60279164d8fbea31515e238.jpeg","goods_id":10073718,"goods_name":"商品锁定19","money":1000,"pay_time":null,"updated_at":1526969107,"verify_time":null,"status":1,"custom_parameters":"abcd"}],"total_count":1}
        /// </summary>
        [JsonProperty("app_new_bill_list_response")]
        public AppNewBillListResponse AppNewBillListResponse { get; set; }
    }


}
