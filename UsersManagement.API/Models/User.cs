using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsersManagement.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Department { get; set; }
        public string ProfileUrl { get; set; }
        public DateTime EventDate { get; set; }

    }
}
