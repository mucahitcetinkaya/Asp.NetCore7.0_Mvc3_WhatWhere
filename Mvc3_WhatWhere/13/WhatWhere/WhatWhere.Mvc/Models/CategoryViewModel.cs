using WhatWhere.Entity.Concrete;
using WhatWhere.Mvc.Models;

public class CategoryViewModel : BaseViewModel
{
    public string Name { get; set; }
    public List<Category> Categories { get; internal set; }
    public int TownId { get; set; }
    public int CityId { get; internal set; }
}
