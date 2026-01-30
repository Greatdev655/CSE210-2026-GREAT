using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _productList;
    private Customer _customer;

    // Constructor
    public Order(Customer customer, List<Product> productList)
    {
        _customer = customer;
        _productList = productList ?? new List<Product>();
    }

    // Optional: Add a product after creating the order
    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }

    // Calculate total price including shipping
    public double GetTotalPrice()
    {
        double totalCost = 0;

        foreach (Product product in _productList)
        {
            totalCost += product.CalculateTotalCost();
        }

        // Shipping: $5 for USA, $35 for others
        double shippingCost = _customer.LivesInUSA() ? 5 : 35;
        totalCost += shippingCost;

        return totalCost;
    }

    // Generate packing label (product names and IDs)
    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        foreach (Product product in _productList)
        {
            label.AppendLine($"Product Name: {product.GetName()}, Product ID: {product.GetProductId()}");
        }
        return label.ToString();
    }

    // Generate shipping label (customer name and address)
    public string GetShippingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine($"Customer Name: {_customer.GetName()}");
        label.AppendLine(_customer.GetAddress().ToString());
        return label.ToString();
    }

    // Optional: access product list
    public List<Product> GetProductList()
    {
        return _productList;
    }
}
