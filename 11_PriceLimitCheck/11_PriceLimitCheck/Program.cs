
const int MAX_PRICE = 150;

Dictionary<string, int> giftPriceMap = PrepareMapOfGiftPrices();

// Sprawdzenie, czy suma cen prezentów mieści się w zakresie cenowym (MAX_PRICE)
int totalPrice = 0;

foreach (var price in giftPriceMap.Values)
{
    totalPrice += price;
}

if (totalPrice <= MAX_PRICE)
{
    Console.WriteLine($"Całkowita cena prezentów wynosi {totalPrice} i mieści się w zakresie cenowym.");
}
else
{
    Console.WriteLine($"Całkowita cena prezentów {totalPrice} przekracza maksymalną dopuszczalną cenę o {totalPrice-MAX_PRICE}.");
}

static Dictionary<string, int> PrepareMapOfGiftPrices()
{
    Dictionary<string, int> giftPriceMap = new Dictionary<string, int>();

    giftPriceMap["Java. Efektywne programowanie."] = 59;
    giftPriceMap["Kostka Rubika"] = 30;
    giftPriceMap["Skarpetki z motywem świątecznym"] = 19;
    giftPriceMap["Słodycze"] = 45;

    return giftPriceMap;
}
