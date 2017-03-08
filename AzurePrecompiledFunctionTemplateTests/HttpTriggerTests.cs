using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.Azure.WebJobs.Host;
using AzurePrecompiledFunctionTemplateTests;
using Newtonsoft.Json;

namespace AzurePrecompiledFunctionTemplate.Tests
{
    [TestClass()]
    public class HttpTriggerTests: TestBase
    {


        [TestMethod()]
        public async Task Run_WithJohnDoeJson_ReturnsHelloJohnDoe()
        {
            //arrange
            var person = new { Name = "John Doe" };

            var request = CreateHttpRequestWith(person);
            var traceWriter = GetTestTraceWriter();

            //act
            var response = await HttpTrigger.Run(request, traceWriter);
            var returnMessage = await response.Content.ReadAsStringAsync();

            //assert
            Assert.AreEqual("Hello John Doe", returnMessage);
        }
    }
}