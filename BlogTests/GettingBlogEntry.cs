using System.Net;
using System.Net.Http;
using Blog;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using NUnit.Framework;

namespace BlogTests
{
    public class GettingBlogEntry
    {
        private TestServer _server;
        private HttpClient _client;

        [SetUp]
        public void SetUp()
        {
            var builder = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>();

            _server = new TestServer(builder);
            _client = _server.CreateClient();
        }
        
        [Test]
        public void CorrectStatusCodeReturned()
        {
            Assert.That(_client.GetAsync("/").Result.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void GotSomeContent()
        {
            Assert.That(_client.GetAsync("/").Result.Content, Is.Not.Null);
        }
    }
}