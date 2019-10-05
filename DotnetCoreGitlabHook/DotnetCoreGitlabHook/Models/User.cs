using System;
using Newtonsoft.Json;

namespace DotnetCoreGitlabHook.Models
{
    public class User
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("username")]
        public string Username { get; set; }
        
        [JsonProperty("avatar_url")]
        public Uri AvatarUrl { get; set; }
    }
}
