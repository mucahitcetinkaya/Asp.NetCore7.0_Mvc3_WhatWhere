using WhatWhere.Entity.Concrete;

namespace WhatWhere.Mvc.Areas.Admin.Models
{
    public class UserUpdateViewModel
    {
        public User User { get; set; }
        public List<Role> Roles { get; set; }
        public IList<string> SelectedRoles { get; set; }
    }
}
