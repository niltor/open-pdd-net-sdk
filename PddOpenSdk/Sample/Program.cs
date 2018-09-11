using System;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var helper = new PddApiDocHelper();
   
                await helper.GetDocListByCatAsync(5);

          

            Console.WriteLine("finish");
            Console.ReadLine();
        }
    }
}
