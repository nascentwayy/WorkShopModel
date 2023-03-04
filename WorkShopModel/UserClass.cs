public class User
{
    public string Name;
    public List<Basket> Orders;
    
    public User(string name)
    {
        Orders = new List<Basket>();
        Name = name;
    }
}