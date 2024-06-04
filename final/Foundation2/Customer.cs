public class Customer
{
    private string _name;
    private Address _address;

    public Customer(){}

    public bool LivesInUsa(){
        return _address.LivesInUsa();
    }

    public void SetName(string name){
        _name = name;
    }

    public void SetAddress(Address address){
        _address = address;
    }

    public string GetName(){
        return _name;
    }

    public string GetAddress(){
        return _address.GetCompleteAddress();
    }
}