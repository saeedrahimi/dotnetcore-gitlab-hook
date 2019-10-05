using Newtonsoft.Json;

namespace DotnetCoreGitlabHook.Events
{
    public abstract class Event
    {
        [JsonProperty("object_kind")]
        public ObjectKind ObjectKind { get; set; }
    }
}
