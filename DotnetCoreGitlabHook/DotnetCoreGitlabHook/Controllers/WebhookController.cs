using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using DotnetCoreGitlabHook.Events;
using Newtonsoft.Json;

namespace DotnetCoreGitlabHook.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebhookController : ControllerBase
    {
 

        private const string DefaultHeaderKey = "X-Gitlab-Event";
        private readonly ILogger<WebhookController> _logger;

        public WebhookController(ILogger<WebhookController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public string Post()
        {
            var request = this.HttpContext.Request;
            var json = new StreamReader(request.Body).ReadToEnd();
            var eventType = request.Headers[DefaultHeaderKey];
            return eventType;
            switch (eventType)
            {
                case "Note Hook":
                {
                    var e = Deserialize<NoteEvent>(json);
                
                    return json;
                }
                
                default: throw new NotSupportedException(
                    "The hook is not supported yet."
                );
            }
        }
        

        public bool Supports(HttpRequest request)
        {
            return request.Headers.ContainsKey(DefaultHeaderKey);
        }

        private static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
