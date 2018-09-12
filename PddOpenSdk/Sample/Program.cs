using System;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var helper = new PddApiDocHelper();
            for (int i = 0; i < 22; i++)
            {
                await helper.GetDocListByCatAsync(i);

            }
            Console.WriteLine("finish");
            Console.ReadLine();
        }
    }
}
