namespace PddOpenSdk.Models.Response.WayBill;
public partial class GetCloudprintStdtemplatesResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("pdd_cloudprint_stdtemplates_get_response")]
    public PddCloudprintStdtemplatesGetResponseResponse PddCloudprintStdtemplatesGetResponse { get; set; }
    public partial class PddCloudprintStdtemplatesGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 结果集
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 所有wp的标准模板
            /// </summary>
            [JsonPropertyName("datas")]
            public List<DatasResponse> Datas { get; set; }
            public partial class DatasResponse : PddResponseModel
            {

                /// <summary>
                /// 该wp的所有标准模板
                /// </summary>
                [JsonPropertyName("standard_templates")]
                public List<StandardTemplatesResponse> StandardTemplates { get; set; }

                /// <summary>
                /// wp编码
                /// </summary>
                [JsonPropertyName("wp_code")]
                public string WpCode { get; set; }
                public partial class StandardTemplatesResponse : PddResponseModel
                {

                    /// <summary>
                    /// 模板id
                    /// </summary>
                    [JsonPropertyName("standard_template_id")]
                    public long? StandardTemplateId { get; set; }

                    /// <summary>
                    /// 模板名称
                    /// </summary>
                    [JsonPropertyName("standard_template_name")]
                    public string StandardTemplateName { get; set; }

                    /// <summary>
                    /// 模板url
                    /// </summary>
                    [JsonPropertyName("standard_template_url")]
                    public string StandardTemplateUrl { get; set; }

                    /// <summary>
                    /// 模版类型
                    /// </summary>
                    [JsonPropertyName("standard_waybill_type")]
                    public int? StandardWaybillType { get; set; }

                }

            }

        }

    }

}

