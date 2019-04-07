using Console;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var helper = new PddApiDocHelper();
            //for (int i = 1; i < 23; i++)
            //{
            //    await helper.GetDocListByCatAsync(i);
            //}

            await helper.TestApi("pdd.ad.history.keyword.report.get");
            //await helper.Run();
            System.Console.WriteLine("finish");
            System.Console.ReadLine();

        }
    }
}