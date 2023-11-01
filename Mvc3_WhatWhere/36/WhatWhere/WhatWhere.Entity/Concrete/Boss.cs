namespace WhatWhere.Entity.Concrete
{
    public class Boss
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Gender { get; set; }
        public DateTime? BirthOfYear { get; set; }

        public string? PhoneNumber { get; set; }
        public string? MailAdress { get; set; }
        public string? Url { get; set; }

        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? Address { get; set; }
        public bool IsHome { get; set; } = true;
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;


        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;


        public List<Shop>? Shops { get; set; }

    }
}
