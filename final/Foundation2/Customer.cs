public class Customer
{
    private string _name;
    private Address _address;
    
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool GetLiveInUSA()
    {
        return _address.GetLiveInUSA();
    }
    public Address GetAddress()
    {
        return _address;
    }
    public string GetName()
    {
        return _name;
    }
}