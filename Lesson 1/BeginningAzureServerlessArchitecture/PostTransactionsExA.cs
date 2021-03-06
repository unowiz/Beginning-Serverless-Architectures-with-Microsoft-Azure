using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace BeginningAzureServerlessArchitecture
{
    public static class PostTransactions
    {
        [FunctionName("PostTransactions")]
        public static HttpResponseMessage Run([HttpTrigger(
            AuthorizationLevel.Anonymous, 
            "get", 
            "post", 
            Route = "PostTransactions/name/{name}")] HttpRequestMessage req, string name, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            // Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK, "Hello " + name);
        }
    }
}
