using WhatWhere.Entity.Concrete;
using WhatWhere.Mvc.Models;

public class CityViewModel : BaseViewModel
{
    public string Sehir { get; set; }
    public List<City> Cities { get; internal set; }
}
