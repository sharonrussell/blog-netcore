using System.Net;
using BlogTests.Contexts;
using NUnit.Framework;

namespace BlogTests
{
    public class GettingBlogEntry: BlogContext
    {
        [Test]
        public void CorrectStatusCodeReturned()
        {
            Assert.That(Client.GetAsync("/").Result.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void GotSomeContent()
        {
            Assert.That(Client.GetAsync("/").Result.Content, Is.Not.Null);
        }
    }
}