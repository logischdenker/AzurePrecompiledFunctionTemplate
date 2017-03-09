using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using AzurePrecompiledFunctionTemplateTests;

namespace AzurePrecompiledFunctionTemplate.Tests
{
    [TestClass()]
    public class HttpTriggerTests: TestBase
    {
        [TestMethod()]
        public async Task SayHelloToJohnDoe_ReturnsHelloToJohnDoe()
        {
            //arrange
            var person = new { Name = "John Doe" };

            var request = CreateHttpRequestWith(person);
            var traceWriter = GetTestTraceWriter();

            //act
            var response = HttpTrigger.SayHelloToJohnDoe(request, traceWriter);
            var returnMessage = await response.Content.ReadAsStringAsync();

            //assert
            Assert.AreEqual("Hello John Doe", returnMessage);
        }

        [TestMethod()]
        public async Task SayHelloTo_World_ReturnsHelloWorld()
        {
            //arrange
            var payload = new { Name = "World" };
            var request = CreateHttpRequestWith(payload);
            var traceWriter = GetTestTraceWriter();

            //act
            var response = await HttpTrigger.SayHelloTo(request, traceWriter);
            var returnMessage = await response.Content.ReadAsStringAsync();

            //assert
            Assert.AreEqual("Hello World", returnMessage);
        }
    }
}