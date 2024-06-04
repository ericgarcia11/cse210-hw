public class Product
{
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    public Product(){}
    public double GetTotalCost(){
        return _price * _quantity;
    }   

    public string GetName(){
        return _name;
    }

    public int GetId(){
        return _id;
    }

    public void SetName(string name){
        _name = name;
    }

    public void SetId(int id){
        _id = id;
    }

    public void SetPrice(double price){
        _price = price;
    }

    public void SetQuantity(int quantity){
        _quantity = quantity;
    }
}