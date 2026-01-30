using System;
using System.Collections.Generic;


public class Product
{
    private string _name;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;


    public Product(string Name, string ProductID, double PricePerUnit, int Quantity)
    {
        _name = Name;
        _productId = ProductID;
        _pricePerUnit = PricePerUnit;
        _quantity = Quantity;
    }

    public double CalculateTotalCost()
    {
        return _pricePerUnit * _quantity;

    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public double GetPricePerUnit()
    {
        return _pricePerUnit;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}
