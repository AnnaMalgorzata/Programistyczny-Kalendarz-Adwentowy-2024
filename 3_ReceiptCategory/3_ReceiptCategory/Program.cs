/**
 * Rodzina zrobiła zakupy na święta i z paragonu chcą policzyć, ile pieniędzy wydali na konkretną kategorię.
 * Napisz program, który policzy wydatki rodziny w zależności od kategorii i doda je do mapy, która będzie
 * przechowywała wartości (KATEGORIA - SUMA). Wypisz stworzoną mapę na ekranie.
 */

List<Receipt> shoppingReceipts = PrepareShoppingReceipt();
Dictionary<Category, decimal> sumByCategory = new Dictionary<Category, decimal>();

foreach (var receipt in shoppingReceipts)
{
    if (sumByCategory.ContainsKey(receipt.category))
    {
        sumByCategory[receipt.category] += receipt.price;
    }
    else
    {
        sumByCategory[receipt.category] = receipt.price;
    }
}

foreach (var entry in sumByCategory)
{
    Console.WriteLine($"{entry.Key}: {entry.Value}");
}


static List<Receipt> PrepareShoppingReceipt()
{
    return new List<Receipt>
    {
        new Receipt("Pierogi", Category.FOOD, 10m),
        new Receipt("Barszcz czerwony", Category.FOOD, 10m),
        new Receipt("Cukier", Category.FOOD, 5m),
        new Receipt("Woda", Category.DRINKS, 2m),
        new Receipt("Sok pomarańczowy", Category.DRINKS, 4m),
        new Receipt("Klocki LEGO", Category.PRESENTS, 100m),
        new Receipt("Samochód zdalnie sterowany", Category.PRESENTS, 130m)
    };
}
