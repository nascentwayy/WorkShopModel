public class Shop
{
    public List<Product> Products;

    public Shop()
    {
        Products = new List<Product>
        {
            new Product("Шарики", 900),
            new Product("Мышка", 1000),
            new Product("Книга: Моя Борьба", 1488),
            new Product("Семечки", 228),
            new Product("Книга: 1984", 999),
            new Product("Mail.Ru", 10)
        };
    }
    public int CountItemsInShop()
    {
        return Products.Count;
    }

    public void ShowCatalog()
    {
        for (int i = 0; i < Products.Count; i++)
        {
            Console.WriteLine($"[{i + 1}]{Products[i].Print()}");
        }
    }
}

