using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Sms
{
    public class Target
    {

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("min_pay_amount")]
        public object MinPayAmount { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("max_pay_amount")]
        public object MaxPayAmount { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("pay_amount_limit")]
        public object PayAmountLimit { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("sex")]
        public object Sex { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("region")]
        public object Region { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("region_type")]
        public object RegionType { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("order_start_time")]
        public object OrderStartTime { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("order_end_time")]
        public object OrderEndTime { get; set; }

        /// <summary>
        /// Examples: 5
        /// </summary>
        [JsonProperty("order_time_type")]
        public int OrderTimeType { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("people_num")]
        public int PeopleNum { get; set; }
    }

    public class Crowd2
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
        /// Examples: null
        /// </summary>
        [JsonProperty("purchase_days")]
        public object PurchaseDays { get; set; }

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
        /// Examples: 0
        /// </summary>
        [JsonProperty("min_order_count")]
        public int MinOrderCount { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("max_order_count")]
        public int MaxOrderCount { get; set; }

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
        /// Examples: 7
        /// </summary>
        [JsonProperty("mall_visit_days")]
        public int MallVisitDays { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("mall_none_visit_days")]
        public object MallNoneVisitDays { get; set; }
    }

    public class Crowd
    {

        /// <summary>
        /// Examples: "感兴趣的用户"
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("people_num")]
        public object PeopleNum { get; set; }

        /// <summary>
        /// Examples: {"location_type":null,"location":null,"gender":null,"purchase_days":null,"none_purchase_days":null,"goods_favor_days":null,"mall_favor_days":null,"min_order_count":0,"max_order_count":0,"first_buy_start_time":null,"first_buy_end_time":null,"mall_visit_days":7,"mall_none_visit_days":null}
        /// </summary>
        [JsonProperty("crowd")]
        public Crowd2 Crowd { get; set; }
    }

    public class SmsSellSettingDetailQueryResponse
    {

        /// <summary>
        /// Examples: 311609
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Examples: 26218
        /// </summary>
        [JsonProperty("mall_id")]
        public int MallId { get; set; }

        /// <summary>
        /// Examples: 4
        /// </summary>
        [JsonProperty("scene")]
        public int Scene { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("trigger_condition")]
        public object TriggerCondition { get; set; }

        /// <summary>
        /// Examples: {"min_pay_amount":null,"max_pay_amount":null,"pay_amount_limit":null,"sex":null,"region":null,"region_type":null,"order_start_time":null,"order_end_time":null,"order_time_type":5,"people_num":0}
        /// </summary>
        [JsonProperty("target")]
        public Target Target { get; set; }

        /// <summary>
        /// Examples: 60
        /// </summary>
        [JsonProperty("template_id")]
        public int TemplateId { get; set; }

        /// <summary>
        /// Examples: "恰嵩的周边店1：{店铺短链接}asd{优惠券到期时间}asd {优惠券面额}asd {商品短链接}"
        /// </summary>
        [JsonProperty("template_content")]
        public string TemplateContent { get; set; }

        /// <summary>
        /// Examples: "2018-08-15 14:00:00"
        /// </summary>
        [JsonProperty("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("open")]
        public int Open { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("send_num")]
        public int SendNum { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("crowd_id")]
        public int CrowdId { get; set; }

        /// <summary>
        /// Examples: {"name":"感兴趣的用户","people_num":null,"crowd":{"location_type":null,"location":null,"gender":null,"purchase_days":null,"none_purchase_days":null,"goods_favor_days":null,"mall_favor_days":null,"min_order_count":0,"max_order_count":0,"first_buy_start_time":null,"first_buy_end_time":null,"mall_visit_days":7,"mall_none_visit_days":null}}
        /// </summary>
        [JsonProperty("crowd")]
        public Crowd Crowd { get; set; }
    }

    public class QuerySmsSellSettingDetailResponseModel
    {

        /// <summary>
        /// Examples: {"id":311609,"mall_id":26218,"scene":4,"trigger_condition":null,"target":{"min_pay_amount":null,"max_pay_amount":null,"pay_amount_limit":null,"sex":null,"region":null,"region_type":null,"order_start_time":null,"order_end_time":null,"order_time_type":5,"people_num":0},"template_id":60,"template_content":"恰嵩的周边店1：{店铺短链接}asd{优惠券到期时间}asd {优惠券面额}asd {商品短链接}","send_time":"2018-08-15 14:00:00","open":1,"send_num":0,"crowd_id":1,"crowd":{"name":"感兴趣的用户","people_num":null,"crowd":{"location_type":null,"location":null,"gender":null,"purchase_days":null,"none_purchase_days":null,"goods_favor_days":null,"mall_favor_days":null,"min_order_count":0,"max_order_count":0,"first_buy_start_time":null,"first_buy_end_time":null,"mall_visit_days":7,"mall_none_visit_days":null}}}
        /// </summary>
        [JsonProperty("sms_sell_setting_detail_query_response")]
        public SmsSellSettingDetailQueryResponse SmsSellSettingDetailQueryResponse { get; set; }
    }


}
