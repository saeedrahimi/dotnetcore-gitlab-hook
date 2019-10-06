using DotnetCoreGitlabHook.Models;
using Newtonsoft.Json;

namespace DotnetCoreGitlabHook.Events
{
    public class NoteEvent : UserAwareEvent
    {
        [JsonProperty("object_attributes")]
        public Note Note { get; set; }
        
        [JsonProperty("project")]
        public Project Project { get; set; }
        
        [JsonProperty("repository")]
        public Repository Repository { get; set; }
        
        [JsonProperty("merge_request")]
        public MergeRequest MergeRequest { get; set; }
    }
}
