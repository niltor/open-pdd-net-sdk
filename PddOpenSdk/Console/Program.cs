using Console;

namespace Sample
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var helper = new PddApiDocHelper();
            await helper.Run();
            await helper.GeneratePddServiceClassAsync();

            Task.WaitAll();
            System.Console.WriteLine("finish");
            System.Console.ReadLine();
        }
    }
}