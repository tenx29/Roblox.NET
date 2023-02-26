using System;
using Newtonsoft.Json;

namespace Roblox.AccountInformation.Models
{
    public class Badge
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("description")]
        public string Description { get; set; }
        
        [JsonProperty("imageUrl")]
        public Uri ImageUrl { get; set; }
    }
}