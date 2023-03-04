public class Basket
{
    public List<Product> BasketProd;
    
    public Basket()
    {
        BasketProd = new List<Product>();
    }

    public void Add(Product product)
    {
        BasketProd.Add(product);
    }

    public double SumOrder()
    {
        double sum = 0;
        for (int i = 0; i < BasketProd.Count; i++)
        {
            sum += BasketProd[i].Price;
        }
        return sum;
    }

    public void ShowBasket()
    {
        if (BasketProd.Count == 0) Console.WriteLine("Сейчас Ваша корзина пустует.");
        else
        {
            for (int i = 0; i < BasketProd.Count; i++)
            {
                {
                    Console.WriteLine($"{BasketProd[i].Name} {BasketProd[i].Price}");
                }
            }
        }
    }
}