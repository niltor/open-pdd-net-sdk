using System;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var helper = new PddApiDocHelper();
            for (int i = 0; i < 21; i++)
            {
                await helper.GetDocListByCatAsync(i);

            }

            Console.ReadLine();
        }
    }
}
