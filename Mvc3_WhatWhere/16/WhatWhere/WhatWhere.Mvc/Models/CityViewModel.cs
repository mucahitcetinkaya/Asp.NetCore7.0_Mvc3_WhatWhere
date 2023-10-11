using WhatWhere.Entity.Concrete;

public class CityViewModel
{
    public int Id { get; set; }
    public string Sehir { get; set; }
    public List<City> Cities { get; internal set; }
}
