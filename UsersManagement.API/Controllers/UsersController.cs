using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersManagement.API.Fake;
using UsersManagement.API.Models;

namespace UsersManagement.API.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private List<User> _users = FakeData.GetUsers(50);

        [HttpGet]
        public List<User> Get()
        {
            return _users;
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            var oneUser = new User();
            if (_users != null)
            {
                oneUser = _users.FirstOrDefault(x => x.Id == id);

            }
            return oneUser;

        }
        [HttpPost]
        public User Post([FromBody] User user)
        {
            if (user == null)
            {

            }
            else
            {
                _users.Add(user);

            }
            return user;

        }
        [HttpPut]
        public User Put([FromBody] User user)
        {
            var editUser = _users.FirstOrDefault(x => x.Id == user.Id);
            editUser.UserName = user.UserName;
            editUser.Department = user.Department;
            editUser.EventDate = user.EventDate;
            return user;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var deleteUser = _users.FirstOrDefault(x=>x.Id==id);
            _users.Remove(deleteUser);

        }


    }
}
