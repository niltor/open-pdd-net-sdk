using Microsoft.Extensions.Options;

namespace NetCoreMvc
{
    public class PddService
    {
        private readonly IOptions<PddOptions> _options;
        public PddService(IOptions<PddOptions> options)
        {
            _options = options;

        }


        public void Test()
        {
            System.Console.WriteLine(_options.Value.ClientId);
            System.Console.WriteLine(_options.Value.ClientSecret);
        }
    }
}
