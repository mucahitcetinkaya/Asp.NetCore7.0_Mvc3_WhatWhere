using Microsoft.AspNetCore.Identity;

namespace WhatWhere.Entity.Concrete
{
    public class Role : IdentityRole
    {
        public string Description { get; set; }
    }
}
