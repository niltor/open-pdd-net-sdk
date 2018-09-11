using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var helper = new PddApiDocHelper();
            //await helper.GetDocListByCatAsync(1);

            var commonParams = new CommonReqeustParams
            {
                Access_Token = "accesstoken",
                Client_Id = "clientid",
                Data_Type = "datatype",
                Sign = "sign",
                TimeStamp = "timestamp",
                Type = "type",
                Version = "version"
            };
            var dic = Function.ToDictionary<string>(commonParams, OrderType.ASC);


            string jsonString = @"{""error_response"": { ""error_code"": 20006, ""error_msg"": ""请求参数 type 有误"" }}";

            var jObject = JObject.Parse(jsonString);
            if (jObject.TryGetValue("error_response", out var errorResponse))
            {
                // TODO:记录异常
                System.Console.WriteLine(errorResponse["error_code"].ToString());
            }

            Console.WriteLine(JsonConvert.SerializeObject(dic));
            Console.ReadLine();
        }
    }
}
