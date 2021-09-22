using Console;
using System.Threading.Tasks;

namespace Sample
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var helper = new PddApiDocHelper();
            await helper.Run().ConfigureAwait(false);

            System.Console.WriteLine("finish");
            System.Console.ReadLine();
        }
    }
}