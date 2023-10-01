using WhatWhere.Entity.Concrete;

public class CategoryViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Category> Categories { get; internal set; }
    public int TownId { get; set; }
    public int CityId { get; internal set; }
}
