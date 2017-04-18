using MongoDB.Bson.Serialization.Attributes;

namespace Roles.WebAPI.Models
{
    [BsonIgnoreExtraElements]
    public class Role
    {
        public string role_name { get; set; }
    }
}
