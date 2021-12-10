namespace PddOpenSdk.Models.Response.Ddk;
public partial class GenDdkResourceUrlResponse : PddResponseModel
{

    /// <summary>
    /// resource_url_response
    /// </summary>
    [JsonPropertyName("resource_url_response")]
    public ResourceUrlResponseResponse ResourceUrlResponse { get; set; }
    public partial class ResourceUrlResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 多人团链接
        /// </summary>
        [JsonPropertyName("multi_url_list")]
        public MultiUrlListResponse MultiUrlList { get; set; }

        /// <summary>
        /// sign
        /// </summary>
        [JsonPropertyName("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 单人团链接
        /// </summary>
        [JsonPropertyName("single_url_list")]
        public SingleUrlListResponse SingleUrlList { get; set; }

        /// <summary>
        /// 拼多多福利券微信小程序信息
        /// </summary>
        [JsonPropertyName("we_app_info")]
        public WeAppInfoResponse WeAppInfo { get; set; }
        public partial class MultiUrlListResponse : PddResponseModel
        {

            /// <summary>
            /// 对应出参url的短链接，与url功能一致。
            /// </summary>
            [JsonPropertyName("short_url")]
            public string ShortUrl { get; set; }

            /// <summary>
            /// 频道推广长链接，唤起H5页面
            /// </summary>
            [JsonPropertyName("url")]
            public string Url { get; set; }

        }
        public partial class SingleUrlListResponse : PddResponseModel
        {

            /// <summary>
            /// 对应出参url的短链接，与url功能一致。
            /// </summary>
            [JsonPropertyName("short_url")]
            public string ShortUrl { get; set; }

            /// <summary>
            /// 频道推广长链接，唤起H5页面
            /// </summary>
            [JsonPropertyName("url")]
            public string Url { get; set; }

        }
        public partial class WeAppInfoResponse : PddResponseModel
        {

            /// <summary>
            /// 小程序id
            /// </summary>
            [JsonPropertyName("app_id")]
            public string AppId { get; set; }

            /// <summary>
            /// Banner图
            /// </summary>
            [JsonPropertyName("banner_url")]
            public string BannerUrl { get; set; }

            /// <summary>
            /// 描述
            /// </summary>
            [JsonPropertyName("desc")]
            public string Desc { get; set; }

            /// <summary>
            /// 小程序path值
            /// </summary>
            [JsonPropertyName("page_path")]
            public string PagePath { get; set; }

            /// <summary>
            /// 来源名
            /// </summary>
            [JsonPropertyName("source_display_name")]
            public string SourceDisplayName { get; set; }

            /// <summary>
            /// 小程序标题
            /// </summary>
            [JsonPropertyName("title")]
            public string Title { get; set; }

            /// <summary>
            /// 用户名
            /// </summary>
            [JsonPropertyName("user_name")]
            public string UserName { get; set; }

            /// <summary>
            /// 小程序icon
            /// </summary>
            [JsonPropertyName("we_app_icon_url")]
            public string WeAppIconUrl { get; set; }

        }

    }

}

