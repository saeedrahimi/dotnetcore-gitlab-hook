using System;
using Newtonsoft.Json;

namespace DotnetCoreGitlabHook.Models
{
    public class Repository
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("description")]
        public string Description { get; set; }
        
        [JsonProperty("url")]
        public Uri Url { get; set; }
        
        [JsonProperty("homepage")]
        public Uri Homepage { get; set; }
    }
}
