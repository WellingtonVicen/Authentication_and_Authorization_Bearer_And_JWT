using API_AUTH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_AUTH.Repositories
{
    public class UserRepository
    {
        public static User GetUser(string username, string password)
        {
            var users = new List<User> 
            {
                new User { Id = 1, UserName = "Wellington", Passowrd = "Vicencio", Role = "Developer"},
                new User { Id = 2, UserName = "Fernando", Passowrd = "Gomes", Role = "Developer"},
                new User { Id = 3, UserName = "Leo", Passowrd = "Januario", Role = "QA"},
                new User { Id = 4, UserName = "Flavio", Passowrd = "Alvarenga", Role = "Developer"},
                new User { Id = 5, UserName = "Dayvid", Passowrd = "Ribeiro", Role = "Tech-Lead"},
            };

            return users.FirstOrDefault(x => x.UserName == username && x.Passowrd == password);
        }
    }
}
