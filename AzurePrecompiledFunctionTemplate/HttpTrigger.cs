using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace AzurePrecompiledFunctionTemplate
{
    public class HttpTrigger
    {
        public static HttpResponseMessage SayHelloToJohnDoe(HttpRequestMessage req, TraceWriter log)
        {
            log.Info("SayHelloToJohnDoe HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent($"Hello John Doe");

            return response;
        }

        public static async Task<HttpResponseMessage> SayHelloTo(HttpRequestMessage req, TraceWriter log)
        {
            log.Info("SayHelloTo HTTP trigger function processed a request.");

            var content = await req.Content.ReadAsStringAsync();
            var personDefinition = new { Name = "" };
            var person = JsonConvert.DeserializeAnonymousType(content, personDefinition);

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent($"Hello { person.Name }");

            return response;
        }
    }
}
