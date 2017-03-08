using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace AzurePrecompiledFunctionTemplate
{
    public class HttpTrigger
    {
        public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            var content = await req.Content.ReadAsStringAsync();
            var personDefinition = new { Name = "" };
            var person = JsonConvert.DeserializeAnonymousType(content, personDefinition);

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent($"Hello { person.Name } wie ghet eesdij");

            return response;
        }
    }
}
