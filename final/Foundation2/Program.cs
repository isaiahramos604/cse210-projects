using System;
using System.Collections.Generic;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string country, string state, string city, string streetAddress)
    {
        _country = country;
        _state = state;
        _city = city;
        _streetAddress = streetAddress;
    }

    public bool IsInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public override string ToString()
    {
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }
}

class Product
{
    private string _name;
    private int _productID;
    private decimal _price;
    private int _quantity;

    public Product(string name, int productID, decimal price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public decimal GetTotalPrice()
    {
        return _price * _quantity;
    }

    public string GetNameOfProduct()
    {
        return _name;
    }

    public int GetProductID()
    {
        return _productID;
    }

    public decimal GetProductPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public override string ToString()
    {
        return $"Name: {_name}, ID: {_productID}";
    }
}

class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public Address GetCountry()
    {
        return _address;
    }

    public override string ToString()
    {
        return $"{_customerName}, {_address}";
    }
}

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.GetTotalPrice();
        }

        if (_customer.GetCountry().IsInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";

        foreach (Product product in _products)
        {
            packingLabel += $"{product.ToString()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.ToString()}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Shopping App!");

        Console.WriteLine("Please enter your name:");
        string customerName = Console.ReadLine();

        Console.WriteLine("Please enter your street address:");
        string streetAddress = Console.ReadLine();

        Console.WriteLine("Please enter your city:");
        string city = Console.ReadLine();

        Console.WriteLine("Please enter your state/province:");
        string state = Console.ReadLine();

        Console.WriteLine("Please enter your country:");
        string country = Console.ReadLine();

        Address customerAddress = new Address(country, state, city, streetAddress);
        Customer customer = new Customer(customerName, customerAddress);
        Order order = new Order(customer);
        List<Product> availableProducts = new List<Product>();

        
        availableProducts.Add(new Product("Bananas", 1, 10.0m, 100));
        availableProducts.Add(new Product("Oranges", 2, 20.0m, 50));
        availableProducts.Add(new Product("Apples", 3, 15.0m, 75));

        bool shopping = true;

        while (shopping)
        {
            Console.WriteLine("\nAvailable Products:");
            Console.WriteLine("-------------------");
            foreach (Product product in availableProducts)
            {
                Console.WriteLine($"{product.GetProductID()}. {product.GetNameOfProduct()} - Price: {product.GetProductPrice():C}");
            }

            Console.WriteLine("\nEnter the ID of the product you want to add to the basket (0 to checkout):");
            if (int.TryParse(Console.ReadLine(), out int selectedProductId))
            {
                if (selectedProductId == 0)
                {
                    shopping = false;
                }
                else
                {
                    Product selectedProduct = availableProducts.Find(p => p.GetProductID() == selectedProductId);
                    if (selectedProduct != null)
                    {
                        Console.WriteLine("Enter the quantity:");
                        if (int.TryParse(Console.ReadLine(), out int quantity))
                        {
                            if (quantity > 0 && quantity <= selectedProduct.GetQuantity())
                            {
                                Product productToAdd = new Product(selectedProduct.GetNameOfProduct(), selectedProduct.GetProductID(), selectedProduct.GetProductPrice(), quantity);
                                order.AddProduct(productToAdd);
                                Console.WriteLine($"Added {quantity} {selectedProduct.GetNameOfProduct()} to the basket.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid quantity or insufficient stock.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for quantity.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid product ID.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid product ID.");
            }

            Console.WriteLine("\n-----------------------------------------");
        }

        Console.WriteLine("\nOrder Summary:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order.CalculateTotalCost():C}");
    }
}
