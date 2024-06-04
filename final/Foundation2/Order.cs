public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(){
        _products = new List<Product>();
    }

    public void AddProduct(Product product){
        _products.Add(product);
    }

    public void SetCustomer(Customer customer){
        _customer = customer;
    }

    public string GetPackingLabel(){
        string info = "";
        foreach (Product p in _products){
            info += $"Name: {p.GetName()}\nID: {p.GetId()}\n-------------\n";
        }
        return info;
    }

    public string GetShippingLabel(){
        return $"Name: {_customer.GetName()}\nAddress: {_customer.GetAddress()}";
    }

    public double TotalPrice(){
        double totalPrice = 0;
        foreach (Product p in _products){
            totalPrice += p.GetTotalCost();
        }
        if (_customer.LivesInUsa()){
            return totalPrice += 5;
        }
        else{
            return totalPrice += 35;
        }
    }
}