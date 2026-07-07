using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace WebNovelGenerator
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var test = new PlaywrightTest();

            await test.GetScreenshot();
        }
    }
}
