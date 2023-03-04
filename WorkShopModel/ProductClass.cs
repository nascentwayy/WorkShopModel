﻿public class Product
{
    public string Name;
    public double Price;

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public string Print()
    {
        return $"{Name} {Price}р";
    }
}