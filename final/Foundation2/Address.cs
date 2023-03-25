public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateOrProvince = state;
        _country = country;
    }
    public bool GetLiveInUSA()
    {
        if( _country.ToLower().Equals("united states") || _country.ToLower().Equals("united states of america") ||
        _country.ToLower().Equals("america") || _country.ToLower().Equals("u.s.") || _country.ToLower().Equals("us") || 
        _country.ToLower().Equals("usa") || _country.ToLower().Equals("u.s") || _country.ToLower().Equals("us of a"))
        {
            return true;
        }
        return false;
    }
    public string GetFullAddress()
    {
        return $"   {_streetAddress}\n   {_city}\n   {_stateOrProvince}\n   {_country}";
    }
}