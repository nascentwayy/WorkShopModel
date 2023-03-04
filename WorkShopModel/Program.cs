﻿Shop onlineShop = new Shop();
Basket newBasket = new Basket();

while (true)
{
    Console.WriteLine("Выберите действие: \nПоказать каталог продуктов - 1\nПосмотреть содержимое корзины - 2\nДобавить продукт в корзину - 3\nОформить заказ - 4");
    string userAnswer = Console.ReadLine();
    if (userAnswer == "1")
    {
        onlineShop.ShowCatalog(); continue;
    }
    else if (userAnswer == "2")
    {
        newBasket.ShowBasket(); continue;
    }
    else if (userAnswer == "3")
    {
        Console.WriteLine("Выберите номера из списка товаров, чтобы добавить его в корзину. Чтобы закончить выбор товаров введите - 'exit'");
        while (true)
        {
            Console.Write("Введите номер товара или команду для выхода - 'exit': ");
            userAnswer = Console.ReadLine();
            if (userAnswer.ToLower().Trim() == "exit") break;

            try
            {
                int.Parse(userAnswer);
            }
            catch
            {
                Console.WriteLine("Проверьте правильность введенных данных!");
                continue;
            }

            if (int.Parse(userAnswer) > 0 && int.Parse(userAnswer) <= onlineShop.CountItemsInShop())
            {
                newBasket.Add(onlineShop.Products[int.Parse(userAnswer) - 1]);
            }
            else
            {
                Console.WriteLine("Товара с таким номером не существует, пожалуйста проверьте введенные данные.");
                continue;
            }
        }
    }
    else if (userAnswer == "4")
    {
        if (newBasket.BasketProd.Count == 0)
        {
            Console.WriteLine("Ваша корзина пуста. Пожалуйста добавьте товар в корзину, чтобы продолжить.");
            continue;
        }
        else
        {
            Console.WriteLine($"Ваш заказ на сумму {newBasket.SumOrder()} рублей успешно оформлен, спасибо за покупку!"); break;
        }
    }
    else
    {
        Console.Write("Выберите действие: \nПоказать каталог продуктов - 1\nПосмотреть содержимое корзины - 2\nДобавить продукт в корзину - 3 ");
        userAnswer = Console.ReadLine();
    }
}
