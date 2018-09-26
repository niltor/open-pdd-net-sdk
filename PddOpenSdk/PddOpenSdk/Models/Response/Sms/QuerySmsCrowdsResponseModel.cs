using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Sms
{
    public class Crowd
    {

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("location_type")]
        public object LocationType { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("location")]
        public object Location { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("gender")]
        public object Gender { get; set; }

        /// <summary>
        /// Examples: 30
        /// </summary>
        [JsonProperty("purchase_days")]
        public int PurchaseDays { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("none_purchase_days")]
        public object NonePurchaseDays { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("goods_favor_days")]
        public object GoodsFavorDays { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("mall_favor_days")]
        public object MallFavorDays { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("min_order_count")]
        public object MinOrderCount { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("max_order_count")]
        public object MaxOrderCount { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("first_buy_start_time")]
        public object FirstBuyStartTime { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("first_buy_end_time")]
        public object FirstBuyEndTime { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("mall_visit_days")]
        public object MallVisitDays { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("mall_none_visit_days")]
        public object MallNoneVisitDays { get; set; }
    }

    public class Result
    {

        /// <summary>
        /// Examples: 6
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("scene")]
        public object Scene { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("mall_id")]
        public object MallId { get; set; }

        /// <summary>
        /// Examples: "新客户"
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("people_num")]
        public int PeopleNum { get; set; }

        /// <summary>
        /// Examples: {"location_type":null,"location":null,"gender":null,"purchase_days":30,"none_purchase_days":null,"goods_favor_days":null,"mall_favor_days":null,"min_order_count":null,"max_order_count":null,"first_buy_start_time":null,"first_buy_end_time":null,"mall_visit_days":null,"mall_none_visit_days":null}
        /// </summary>
        [JsonProperty("crowd")]
        public Crowd Crowd { get; set; }
    }

    public class SmsCrowsQueryResponse
    {

        /// <summary>
        /// Examples: 5
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// Examples: [{"id":6,"type":1,"scene":null,"mall_id":null,"name":"新客户","people_num":0,"crowd":{"location_type":null,"location":null,"gender":null,"purchase_days":30,"none_purchase_days":null,"goods_favor_days":null,"mall_favor_days":null,"min_order_count":null,"max_order_count":null,"first_buy_start_time":null,"first_buy_end_time":null,"mall_visit_days":null,"mall_none_visit_days":null}}]
        /// </summary>
        [JsonProperty("result")]
        public IList<Result> Result { get; set; }
    }

    public class QuerySmsCrowdsResponseModel
    {

        /// <summary>
        /// Examples: {"total":5,"result":[{"id":6,"type":1,"scene":null,"mall_id":null,"name":"新客户","people_num":0,"crowd":{"location_type":null,"location":null,"gender":null,"purchase_days":30,"none_purchase_days":null,"goods_favor_days":null,"mall_favor_days":null,"min_order_count":null,"max_order_count":null,"first_buy_start_time":null,"first_buy_end_time":null,"mall_visit_days":null,"mall_none_visit_days":null}}]}
        /// </summary>
        [JsonProperty("sms_crows_query_response")]
        public SmsCrowsQueryResponse SmsCrowsQueryResponse { get; set; }
    }


}
