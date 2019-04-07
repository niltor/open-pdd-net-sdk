using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class GetGoodsLogisticsTemplateRequestModel : PddRequestModel {
        /// <summary>
        /// 默认返回运费模板的页数为1，最高为100页，注意：page与page_size必须传一个
        /// </summary>
        [JsonProperty ("page")]
        public int Page { get; set; }
        /// <summary>
        /// 默认返回20条模板数据，最多100条数据
        /// </summary>
        [JsonProperty ("page_size")]
        public int PageSize { get; set; }

    }

}