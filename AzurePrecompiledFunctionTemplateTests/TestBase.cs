using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AzurePrecompiledFunctionTemplateTests
{
    public class TestBase
    {
        protected TraceWriter GetTestTraceWriter()
        {
            return new TestTraceWriter(System.Diagnostics.TraceLevel.Info);
        }

        protected HttpRequestMessage CreateHttpRequestWith(object jsonObject)
        {
            string jsonContent = JsonConvert.SerializeObject(jsonObject);

            var request = new HttpRequestMessage()
            {
                Content = new StringContent(jsonContent, Encoding.UTF8, "application/json")
            };

            return request;
        }
        
    }
}
