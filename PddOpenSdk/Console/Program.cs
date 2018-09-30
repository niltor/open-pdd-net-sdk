using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PddOpenSdk.Services;

namespace Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //var helper = new PddApiDocHelper();
            //for (int i = 21; i < 22; i++)
            //{
            //    await helper.GetDocListByCatAsync(i);
            //}

            string json = File.ReadAllText("data.json");

            var dic = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
            var api = new PddCommonApi();
            var sign=api.BuildSign(dic);
            Console.WriteLine(sign);



            Console.WriteLine("finish");

            Console.ReadLine();

        }
    }
}