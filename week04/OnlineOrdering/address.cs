using System;
using System.Collections.Generic;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string StreetAddress , string City, string State, string Country)
    {
        _streetAddress = StreetAddress;
        _city = City;
        _state = State;
        _country = Country;
    }

    public string GetStreetAddress()
    {
        return _streetAddress;
    }

    public string GetState()
    {
        return _state;
    }

    public string GetCountry()
    {
        return _country;
    }

    public string GetCity()
    {
        return _city;
    }

    public bool IsInUSA()
        {
            return _country.Trim().ToUpper() == "USA" 
                || _country.Trim().ToUpper() == "UNITED STATES";
        }

    public void  DisplayAddress()
    {
        Console.WriteLine($"{_streetAddress}\n {_city}, {_state}\n {_country}");

    }

    
}