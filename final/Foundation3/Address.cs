class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;

    public string GetStreet()
    {
        return _street;
    }

    public void SetStreet(string street)
    {
        _street = street;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetState()
    {
        return _state;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public string GetZipCode()
    {
        return _zipCode;
    }

    public void SetZipCode(string zipCode)
    {
        _zipCode = zipCode;
    }

    public Address(string street, string city, string state, string zipCode)
    {
        SetStreet(street);
        SetCity(city);
        SetState(state);
        SetZipCode(zipCode);
    }

    public override string ToString()
    {
        return $"{_street}, {_city}, {_state}, {_zipCode}";
    }
}