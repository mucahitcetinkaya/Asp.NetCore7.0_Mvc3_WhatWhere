using WhatWhere.Entity.Concrete;

public class CategoryViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Category> Categories { get; set; }
}
