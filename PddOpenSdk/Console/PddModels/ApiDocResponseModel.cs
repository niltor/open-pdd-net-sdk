namespace Console.PddModels
{
    public class ApiDocResponseModel
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("errorCode")]
        public long ErrorCode { get; set; }

        [JsonPropertyName("errorMsg")]
        public object ErrorMsg { get; set; }

        [JsonPropertyName("result")]
        public ApiDocDetail Result { get; set; }
    }

    public class ApiDocDetail
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("catId")]
        public long CatId { get; set; }

        [JsonPropertyName("apiName")]
        public string ApiName { get; set; }

        [JsonPropertyName("scopeName")]
        public string ScopeName { get; set; }

        [JsonPropertyName("usageScenarios")]
        public string UsageScenarios { get; set; }

        [JsonPropertyName("needOauth")]
        public long NeedOauth { get; set; }

        [JsonPropertyName("responseCodeExample")]
        public string ResponseCodeExample { get; set; }

        [JsonPropertyName("requestParamList")]
        public List<ParamList> RequestParamList { get; set; }

        [JsonPropertyName("responseParamList")]
        public List<ParamList> ResponseParamList { get; set; }

        [JsonPropertyName("errorParamList")]
        public List<ErrorParamList> ErrorParamList { get; set; }

        [JsonPropertyName("limiters")]
        public List<Limiter> Limiters { get; set; }

        [JsonPropertyName("permissionsPkgs")]
        public List<PermissionsPkg> PermissionsPkgs { get; set; }

        [JsonPropertyName("sdkDemos")]
        public List<SdkDemo> SdkDemos { get; set; }
    }

    public partial class ErrorParamList
    {
        [JsonPropertyName("errorCode")]
        public string ErrorCode { get; set; }

        [JsonPropertyName("errorMsg")]
        public string ErrorMsg { get; set; }

        [JsonPropertyName("solution")]
        public string Solution { get; set; }

        [JsonPropertyName("outerErrorCode")]
        public string OuterErrorCode { get; set; }
    }

    public partial class Limiter
    {
        [JsonPropertyName("limiterLevel")]
        public long LimiterLevel { get; set; }

        [JsonPropertyName("timeRange")]
        public long TimeRange { get; set; }

        [JsonPropertyName("times")]
        public long Times { get; set; }
    }

    public partial class PermissionsPkg
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("appTypeList")]
        public List<AppTypeList> AppTypeList { get; set; }
    }

    public partial class AppTypeList
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public partial class ParamList
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("parentId")]
        public long ParentId { get; set; }

        [JsonPropertyName("childrenNum")]
        public long ChildrenNum { get; set; }

        [JsonPropertyName("paramName")]
        public string ParamName { get; set; }

        [JsonPropertyName("paramType")]
        public string ParamType { get; set; }

        [JsonPropertyName("isMust")]
        public long? IsMust { get; set; } = 0;

        [JsonPropertyName("defaultValue")]
        public string DefaultValue { get; set; }

        [JsonPropertyName("example")]
        public string Example { get; set; }

        [JsonPropertyName("paramDesc")]
        public string ParamDesc { get; set; }

        [JsonPropertyName("sourcePath")]
        public object SourcePath { get; set; }
    }

    public partial class SdkDemo
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public enum ParamType { Double, Integer, Long, Object, ObjectArray, StringArray, Boolean, String, IntegerArray, LongArray, Map, MapArray, File };


}
