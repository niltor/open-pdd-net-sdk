using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public class Result
    {

        /// <summary>
        /// Examples: 1533571200000
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }

        /// <summary>
        /// Examples: 236638
        /// </summary>
        [JsonProperty("mall_id")]
        public int MallId { get; set; }

        /// <summary>
        /// Examples: 6
        /// </summary>
        [JsonProperty("plan_id")]
        public int PlanId { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("plan_name")]
        public object PlanName { get; set; }

        /// <summary>
        /// Examples: 5
        /// </summary>
        [JsonProperty("unit_id")]
        public int UnitId { get; set; }

        /// <summary>
        /// Examples: "测试banner单元"
        /// </summary>
        [JsonProperty("unit_name")]
        public string UnitName { get; set; }

        /// <summary>
        /// Examples: 50127
        /// </summary>
        [JsonProperty("creative_id")]
        public int CreativeId { get; set; }

        /// <summary>
        /// Examples: "3_2"
        /// </summary>
        [JsonProperty("scene_info")]
        public string SceneInfo { get; set; }

        /// <summary>
        /// Examples: 2
        /// </summary>
        [JsonProperty("idx")]
        public int Idx { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("impr_num")]
        public object ImprNum { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("click_num")]
        public object ClickNum { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("spend")]
        public object Spend { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("pay_order_num")]
        public object PayOrderNum { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("pay_gmv")]
        public object PayGmv { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("plan_cpt_spend")]
        public int PlanCptSpend { get; set; }

        /// <summary>
        /// Examples: "http://mobile.yangkeduo.com/goods.html?goods_id=213213"
        /// </summary>
        [JsonProperty("page_url")]
        public string PageUrl { get; set; }

        /// <summary>
        /// Examples: "http://pddtestimg.yangkeduo.com/test/2018-03-22/392f4d6f63ac261aeb0f30ea64a04d3e.jpeg"
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
    }

    public class AdCreativeReportGetResponse
    {

        /// <summary>
        /// Examples: 13
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// Examples: [{"date":1533571200000,"mall_id":236638,"plan_id":6,"plan_name":null,"unit_id":5,"unit_name":"测试banner单元","creative_id":50127,"scene_info":"3_2","idx":2,"impr_num":null,"click_num":null,"spend":null,"pay_order_num":null,"pay_gmv":null,"plan_cpt_spend":0,"page_url":"http://mobile.yangkeduo.com/goods.html?goods_id=213213","image_url":"http://pddtestimg.yangkeduo.com/test/2018-03-22/392f4d6f63ac261aeb0f30ea64a04d3e.jpeg"}]
        /// </summary>
        [JsonProperty("result")]
        public IList<Result> Result { get; set; }
    }

    public class GetAdCreativeReportResponseModel
    {

        /// <summary>
        /// Examples: {"total":13,"result":[{"date":1533571200000,"mall_id":236638,"plan_id":6,"plan_name":null,"unit_id":5,"unit_name":"测试banner单元","creative_id":50127,"scene_info":"3_2","idx":2,"impr_num":null,"click_num":null,"spend":null,"pay_order_num":null,"pay_gmv":null,"plan_cpt_spend":0,"page_url":"http://mobile.yangkeduo.com/goods.html?goods_id=213213","image_url":"http://pddtestimg.yangkeduo.com/test/2018-03-22/392f4d6f63ac261aeb0f30ea64a04d3e.jpeg"}]}
        /// </summary>
        [JsonProperty("ad_creative_report_get_response")]
        public AdCreativeReportGetResponse AdCreativeReportGetResponse { get; set; }
    }


}
