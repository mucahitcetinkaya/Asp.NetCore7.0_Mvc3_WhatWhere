using Microsoft.AspNetCore.Identity;

namespace WhatWhere.Entity.Concrete
{
    public class User : IdentityUser
    {
        public User()
        {
            Name = FirstName + " " + LastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}