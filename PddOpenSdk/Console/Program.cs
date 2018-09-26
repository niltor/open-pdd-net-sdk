using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var helper = new PddApiDocHelper();
            for (int i = 1; i < 23; i++)
            {
                await helper.GetDocListByCatAsync(i);
            }
            Console.WriteLine("finish");
            Console.ReadLine();
        }
    }
}