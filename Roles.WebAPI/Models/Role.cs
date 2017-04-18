using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Roles.WebAPI.Models
{
    [BsonIgnoreExtraElements]
    public class Role
    {
        [BsonElement("role_name")]
        [JsonProperty("role_name")]
        public string RoleName { get; set; }
    }
}
