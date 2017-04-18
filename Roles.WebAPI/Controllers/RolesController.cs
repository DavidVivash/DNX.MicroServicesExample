using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Roles.WebAPI.Models;

namespace Roles.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class RolesController : Controller
    {
        private static readonly MongoClient client;

        static RolesController()
        {
            client = new MongoClient("mongodb://localhost:27017");
        }

        [HttpGet("{user_id}")]
        public async Task<UserRoles> Get(int user_id)
        {
            var userRoles = await client.GetDatabase("UserRoles")
                .GetCollection<UserRoles>("userroles")
                .Find(Builders<UserRoles>.Filter.Eq("user_id", user_id))
                .FirstOrDefaultAsync();

            return userRoles;
        }
        
        [HttpPut]
        public async Task<UserRoles> Put([FromBody]UserRoles roles)
        {
            var result = await client.GetDatabase("UserRoles")
                .GetCollection<UserRoles>("userroles")
                .ReplaceOneAsync(Builders<UserRoles>.Filter.Eq("user_id", roles.user_id), roles, new UpdateOptions { IsUpsert = true });
    
            return roles;
        }
    }
}
