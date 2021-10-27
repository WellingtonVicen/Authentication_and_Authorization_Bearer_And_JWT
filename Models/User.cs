using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_AUTH.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Passowrd { get; set; }
        public string Role { get; set; }
    }
}
