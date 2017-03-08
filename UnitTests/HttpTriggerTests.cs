
using AzurePrecompiledFunctionTemplate;
using System.Net.Http;

namespace UnitTests
{
    public class HttpTriggerTests
    {
        public void Run_WithValidRequest_ReturnsHttpResponseCodeOK()
        {
            //arrange
            var httpRequestMessage = CreateValidHttpRequestMessage();

            //act
            //var repsonseCode = await HttpTrigger.Run(httpRequestMessage, null);
        }

        private HttpRequestMessage CreateValidHttpRequestMessage()
        {
            var httpRequestMessage = new HttpRequestMessage();

            return httpRequestMessage;
        }
    }
}
