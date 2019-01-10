namespace Console
{
    public class ResponseError
    {



        //public string GetErrorInfo(int errorCode)
        //{

        //}
    }

    //"errorCode": "10000",
    //           "errorMsg": "参数错误，可能错误原因：order_status仅支持1：待发货状态",
    //           "solution": "参数值有误，按照文档要求填写请求参数",
    //           "outerErrorCode": ""
    public enum ErrorCode
    {
        /// <summary>
        ///
        /// </summary>
        E1000,


    }

    /// <summary>
    /// 批多多异常类
    /// </summary>
    public class PddException
    {
        public int ErrorCode { get; set; }
        public string ErrorMsg { get; set; }
        public string Solution { get; set; }
    }
}
