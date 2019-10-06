using System;
using Newtonsoft.Json;

namespace DotnetCoreGitlabHook.Models
{
    public class Note
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        
        [JsonProperty("author_id")]
        public long AuthorId { get; set; }
        
        [JsonProperty("commit_id")]
        public string CommitId { get; set; }
        
        [JsonProperty("discussion_id")]
        public string DiscussionId { get; set; }
        
        [JsonProperty("note")]
        public string Content { get; set; }
        
        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}
