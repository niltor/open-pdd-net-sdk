using Console;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var helper = new PddApiDocHelper();
            
            await helper.Run();
            System.Console.WriteLine("finish");
            System.Console.ReadLine();

        }
    }
}