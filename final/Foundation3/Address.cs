public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(){

    }

    public void SetStreet(string street){
        _street = street;
    }

    public void SetCity(string city){
        _city = city;
    }

    public void SetState(string state){
        _state = state;
    }

    public void SetCountry(string country){
        _country = country;
    }

    public string GetCompleteAddress(){
        return $"{_street}, {_city}\n{_state} -- {_country}";
    }
}