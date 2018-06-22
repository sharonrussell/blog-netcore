using System.Net.Http;
using Blog;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace BlogTests.Contexts
{
    public class BlogContext
    {
        protected readonly HttpClient Client;

        protected BlogContext()
        {
            var builder = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>();

            var server = new TestServer(builder);
            Client = server.CreateClient();
        }
    }
}