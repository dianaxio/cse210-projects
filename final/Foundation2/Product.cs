public class Product
{
    private string _name;
    private string _productID;
    private float _price;
    private int _quantity;
    private float _totalPrice;

    public Product(string name, string productID, float price, int quantity)
    {
        _name= name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
        CalculateTotalPrice();
    }
    private void CalculateTotalPrice()
    {
        _totalPrice = _price*_quantity;
    }
    public float GetIndividualPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public float GetTotalPrice()
    {
        return _totalPrice;
    }
    public string GetProductID()
    {
        return _productID;
    }
    public string GetProductName()
    {
        return _name;
    }
}