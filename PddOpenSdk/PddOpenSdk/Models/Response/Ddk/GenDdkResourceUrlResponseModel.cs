using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public partial class GenDdkResourceUrlResponseModel : PddResponseModel
    {
        /// <summary>
        /// resource_url_response
        /// </summary>
        [JsonProperty("resource_url_response")]
        public ResourceUrlResponseResponseModel ResourceUrlResponse { get; set; }
        public partial class ResourceUrlResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 多人团链接
            /// </summary>
            [JsonProperty("multi_url_list")]
            public MultiUrlListResponseModel MultiUrlList { get; set; }
            /// <summary>
            /// sign
            /// </summary>
            [JsonProperty("sign")]
            public string Sign { get; set; }
            /// <summary>
            /// 单人团链接
            /// </summary>
            [JsonProperty("single_url_list")]
            public SingleUrlListResponseModel SingleUrlList { get; set; }
            /// <summary>
            /// 拼多多福利券微信小程序信息
            /// </summary>
            [JsonProperty("we_app_info")]
            public WeAppInfoResponseModel WeAppInfo { get; set; }
            public partial class MultiUrlListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 对应出参url的短链接，与url功能一致。
                /// </summary>
                [JsonProperty("short_url")]
                public string ShortUrl { get; set; }
                /// <summary>
                /// 频道推广长链接，唤起H5页面
                /// </summary>
                [JsonProperty("url")]
                public string Url { get; set; }

            }
            public partial class SingleUrlListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 对应出参url的短链接，与url功能一致。
                /// </summary>
                [JsonProperty("short_url")]
                public string ShortUrl { get; set; }
                /// <summary>
                /// 频道推广长链接，唤起H5页面
                /// </summary>
                [JsonProperty("url")]
                public string Url { get; set; }

            }
            public partial class WeAppInfoResponseModel : PddResponseModel
            {
                /// <summary>
                /// 小程序id
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
                /// 小程序icon
                /// </summary>
                [JsonProperty("we_app_icon_url")]
                public string WeAppIconUrl { get; set; }

            }

        }

    }

}
