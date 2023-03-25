public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private float _totalCost;
    private int _shippingCost;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;

        if(customer.GetLiveInUSA())
        {
            _shippingCost = 10;
        }
        else
        {
            _shippingCost = 35;
        }
        _products = products;
        CalculateTotalCost();
    }
    private void CalculateTotalCost()
    {
        _totalCost = _shippingCost;
        foreach(Product product in _products)
        {
            _totalCost += product.GetTotalPrice();
        }

    }
    public float GetTotalCost()
    {
        return _totalCost;
    }
    public string GetShippingLabel()
    {
        string shippingLabel = "";

        shippingLabel += $"Customer Name: {_customer.GetName()}\nCustomer Address:\n{_customer.GetAddress().GetFullAddress()}\n";

        return shippingLabel;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        int cont = 1;
        foreach(Product product in _products)
        {
            packingLabel += $"Product Number {cont}:\n   Product Name: {product.GetProductName()}\n   Product ID: {product.GetProductID()}\n   Product Price: ${product.GetIndividualPrice()}\n   Product Quantity: {product.GetQuantity()}\n\n";
            cont += 1;
        }
        return packingLabel;
    }
}