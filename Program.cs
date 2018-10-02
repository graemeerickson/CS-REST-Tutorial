using System;
using System.Threading.Tasks;

namespace WebAPIClient
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            ProcessRepositories().Wait();
        }

        private static async Task ProcessRepositories()
        {

        }
    }
}
