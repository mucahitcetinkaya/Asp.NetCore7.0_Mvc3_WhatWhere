namespace WhatWhere.Entity.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string MailAdress { get; set; }
        public string Url { get; set; }

    }
}