using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DotnetCoreGitlabHook.Events;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace DotnetCoreGitlabHook.Controllers {
    [ApiController]
    [Route ("[controller]")]
    public class WebhookController : ControllerBase {

        private const string DefaultHeaderKey = "X-Gitlab-Event";
        private readonly ILogger<WebhookController> _logger;

        public WebhookController (ILogger<WebhookController> logger) {
            _logger = logger;
        }

        [HttpPost]
        public async Task<string> Post () {
            var request = this.HttpContext.Request;
            var json = await new StreamReader(request.Body).ReadToEndAsync();
            var eventType = request.Headers[DefaultHeaderKey];
            Console.WriteLine(eventType);
            Console.WriteLine(json);
            switch (eventType) {
                case "Note Hook":
                    {
                        var e = Deserialize<NoteEvent> (json);

                        return json;
                    }

                default:
                    throw new NotSupportedException (
                        "The hook is not supported yet."
                    );
            }
        }

        public bool Supports (HttpRequest request) {
            return request.Headers.ContainsKey (DefaultHeaderKey);
        }

        private static T Deserialize<T> (string json) {
            return JsonConvert.DeserializeObject<T> (json);
        }
    }
}