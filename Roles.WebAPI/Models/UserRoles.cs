using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Roles.WebAPI.Models
{
    [BsonIgnoreExtraElements]
    public class UserRoles
    {
        [BsonElement("user_id")]
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [BsonElement("roles")]
        [JsonProperty("roles")]
        public IEnumerable<Role> Roles { get; set; }
    }
}
