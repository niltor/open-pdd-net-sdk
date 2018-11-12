using System.Collections.Generic;

namespace Sample
{
    /// <summary>
    /// 拼多多接口列表模型
    /// </summary>
    public class PddDocListModel
    {
        public bool? Success { get; set; }
        public long? ErrorCode { get; set; }
        public object ErrorMsg { get; set; }
        public Result Result { get; set; }
    }

    public partial class Result
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public List<ApiDoc> DocList { get; set; }
    }

    public partial class ApiDoc
    {
        public string ScopeName { get; set; }
        public long? ScopeStatus { get; set; }
        public long? CatId { get; set; }
        public string CatName { get; set; }
        public string ApiName { get; set; }
        public string ApiDesc { get; set; }
        public long? NeedOauth { get; set; }
        public string UsageScenarios { get; set; }
        public string CodeExample { get; set; }
        public string RequestCodeExample { get; set; }
        public long? Id { get; set; }
        public long? Status { get; set; }
        public long? CreatedAt { get; set; }
        public long? UpdatedAt { get; set; }
        public long? CreatorId { get; set; }
        public string CreatorName { get; set; }
        public List<ParamList> RequestParamList { get; set; }
        public List<ParamList> ResponseParamList { get; set; }
        public List<object> ErrorParamList { get; set; }
        public List<LimiterList> LimiterList { get; set; }
        public List<object> ApiDocOperateRecordList { get; set; }
    }

    public partial class LimiterList
    {
        public long? TimeRange { get; set; }
        public long? Times { get; set; }
        public long? LimiterLevel { get; set; }
    }

    public partial class ParamList
    {
        public long? Id { get; set; }
        public string ParamName { get; set; }
        public string ParamType { get; set; }
        public int? IsMust { get; set; }
        public string ParamDesc { get; set; }
        public string Example { get; set; }
        public long? ParentId { get; set; }
        public long? ChildrenNum { get; set; }
        public string ParentParamName { get; set; }
        public long? Level { get; set; }
    }

}
