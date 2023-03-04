public class User
{
    public string Name;
    public List<Basket> Orders;
    
    public User(string name)
    {
        Orders = new List<Basket>();
        Name = name;
    }

    public void GetListOrderts()
    {
        for (int i = 0; i < Orders.Count; i++)
        {
            Console.WriteLine($"Заказ №{i + 1}");
            for (int z = 0; z < Orders[i].BasketProd.Count; z++)
            {
                Console.WriteLine(Orders[i].BasketProd[z].Name);
            }
        }
    }
}