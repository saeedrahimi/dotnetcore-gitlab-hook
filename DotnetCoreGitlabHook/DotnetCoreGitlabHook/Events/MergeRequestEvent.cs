using DotnetCoreGitlabHook.Models;
using Newtonsoft.Json;

namespace DotnetCoreGitlabHook.Events
{
    public class MergeRequestEvent : Event
    {
        [JsonProperty("object_attributes")]
        public MergeRequest MergeRequest { get; set; }
    }
}
