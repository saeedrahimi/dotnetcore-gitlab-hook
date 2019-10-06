using DotnetCoreGitlabHook.Models;
using Newtonsoft.Json;

namespace DotnetCoreGitlabHook.Events
{
    public abstract class UserAwareEvent : Event
    {
        [JsonProperty("user")]
        public User User { get; set; }
    }
}
