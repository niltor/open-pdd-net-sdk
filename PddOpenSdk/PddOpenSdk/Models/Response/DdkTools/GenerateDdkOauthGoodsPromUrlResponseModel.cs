using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.DdkTools
{
    public partial class GenerateDdkOauthGoodsPromUrlResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("goods_promotion_url_generate_response")]
        public GoodsPromotionUrlGenerateResponseResponseModel GoodsPromotionUrlGenerateResponse { get; set; }
        public partial class GoodsPromotionUrlGenerateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 多多进宝推广链接对象列表
            /// </summary>
            [JsonProperty("goods_promotion_url_list")]
            public List<GoodsPromotionUrlListResponseModel> GoodsPromotionUrlList { get; set; }
            public partial class GoodsPromotionUrlListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 唤醒拼多多app的推广短链接
                /// </summary>
                [JsonProperty("mobile_short_url")]
                public string MobileShortUrl { get; set; }
                /// <summary>
                /// 唤醒拼多多app的推广长链接
                /// </summary>
                [JsonProperty("mobile_url")]
                public string MobileUrl { get; set; }
                /// <summary>
                /// qq小程序信息
                /// </summary>
                [JsonProperty("qq_app_info")]
                public QqAppInfoResponseModel QqAppInfo { get; set; }
                /// <summary>
                /// schema的链接
                /// </summary>
                [JsonProperty("schema_url")]
                public string SchemaUrl { get; set; }
                /// <summary>
                /// 推广短链接
                /// </summary>
                [JsonProperty("short_url")]
                public string ShortUrl { get; set; }
                /// <summary>
                /// 推广长链接
                /// </summary>
                [JsonProperty("url")]
                public string Url { get; set; }
                /// <summary>
                /// 微博推广短链接
                /// </summary>
                [JsonProperty("weibo_app_web_view_short_url")]
                public string WeiboAppWebViewShortUrl { get; set; }
                /// <summary>
                /// 微博推广链接
                /// </summary>
                [JsonProperty("weibo_app_web_view_url")]
                public string WeiboAppWebViewUrl { get; set; }
                /// <summary>
                /// 小程序信息
                /// </summary>
                [JsonProperty("we_app_info")]
                public WeAppInfoResponseModel WeAppInfo { get; set; }
                /// <summary>
                /// 唤起微信app推广短链接
                /// </summary>
                [JsonProperty("we_app_web_view_short_url")]
                public string WeAppWebViewShortUrl { get; set; }
                /// <summary>
                /// 唤起微信app推广链接
                /// </summary>
                [JsonProperty("we_app_web_view_url")]
                public string WeAppWebViewUrl { get; set; }
                public partial class QqAppInfoResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 拼多多小程序id
                    /// </summary>
                    [JsonProperty("app_id")]
                    public string AppId { get; set; }
                    /// <summary>
                    /// Banner图
                    /// </summary>
                    [JsonProperty("banner_url")]
                    public string BannerUrl { get; set; }
                    /// <summary>
                    /// 描述
                    /// </summary>
                    [JsonProperty("desc")]
                    public string Desc { get; set; }
                    /// <summary>
                    /// 小程序path值
                    /// </summary>
                    [JsonProperty("page_path")]
                    public string PagePath { get; set; }
                    /// <summary>
                    /// 小程序icon
                    /// </summary>
                    [JsonProperty("qq_app_icon_url")]
                    public string QqAppIconUrl { get; set; }
                    /// <summary>
                    /// 来源名
                    /// </summary>
                    [JsonProperty("source_display_name")]
                    public string SourceDisplayName { get; set; }
                    /// <summary>
                    /// 小程序标题
                    /// </summary>
                    [JsonProperty("title")]
                    public string Title { get; set; }
                    /// <summary>
                    /// 用户名
                    /// </summary>
                    [JsonProperty("user_name")]
                    public string UserName { get; set; }

                }
                public partial class WeAppInfoResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 拼多多小程序id
                    /// </summary>
                    [JsonProperty("app_id")]
                    public string AppId { get; set; }
                    /// <summary>
                    /// Banner图
                    /// </summary>
                    [JsonProperty("banner_url")]
                    public string BannerUrl { get; set; }
                    /// <summary>
                    /// 描述
                    /// </summary>
                    [JsonProperty("desc")]
                    public string Desc { get; set; }
                    /// <summary>
                    /// 小程序path值
                    /// </summary>
                    [JsonProperty("page_path")]
                    public string PagePath { get; set; }
                    /// <summary>
                    /// 来源名
                    /// </summary>
                    [JsonProperty("source_display_name")]
                    public string SourceDisplayName { get; set; }
                    /// <summary>
                    /// 小程序标题
                    /// </summary>
                    [JsonProperty("title")]
                    public string Title { get; set; }
                    /// <summary>
                    /// 用户名
                    /// </summary>
                    [JsonProperty("user_name")]
                    public string UserName { get; set; }
                    /// <summary>
                    /// 小程序图片
                    /// </summary>
                    [JsonProperty("we_app_icon_url")]
                    public string WeAppIconUrl { get; set; }

                }

            }

        }

    }

}
