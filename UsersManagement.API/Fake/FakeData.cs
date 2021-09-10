using Bogus;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersManagement.API.Models;

namespace UsersManagement.API.Fake
{
    public static class FakeData
    {
        private static List<User> _users;
        [HttpGet]
        public static List<User> GetUsers(int number)
        {
            if (_users != null) return _users;
            _users = new Faker<User>().RuleFor(u => u.Id, f => f.IndexFaker + 1)
                .RuleFor(u => u.UserName, f => f.Name.FullName())
                .RuleFor(u => u.Department, f =>f.Commerce.Department())
                .RuleFor(u => u.ProfileUrl, f => f.Internet.Avatar())
                .RuleFor(u => u.EventDate, f => f.Date.Future())
                .Generate(number);

            return _users;
        }
    }
}
