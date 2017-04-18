using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Roles.WebAPI.Models
{
    [BsonIgnoreExtraElements]
    public class UserRoles
    {
        public int user_id { get; set; }

        public IEnumerable<Role> roles { get; set; }
    }
}
