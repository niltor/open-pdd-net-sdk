using Console;

namespace Sample;

internal class Program
{
    private async static Task Main(string[] args)
    {
        var helper = new PddApiDocHelper();
        //await helper.Run();
        await helper.GeneratePddServiceClassAsync();

        System.Console.WriteLine("finish");
        System.Console.ReadLine();
    }
}
