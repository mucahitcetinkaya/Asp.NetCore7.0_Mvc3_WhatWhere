namespace WhatWhere.Mvc.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string MailAdress { get; set; }
    }
}
