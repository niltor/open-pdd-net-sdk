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

            Console.ReadLine();
        }
    }
}
