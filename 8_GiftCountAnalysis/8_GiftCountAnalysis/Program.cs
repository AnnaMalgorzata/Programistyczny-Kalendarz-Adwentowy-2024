/**
 * Mikołaj ma dane na temat liczby dostarczonych prezentów w poszczególnych latach.
 * Policz statystyki takie jak:
 * - suma prezentów dostarczonych we wszystkich podanych latach
 * - średnia dostarczonych prezentów ze wszystkich podanych lat
 * - największa liczba prezentów dostarczonych
 * - najmniejsza liczba prezentów dostarczonych
 */

List<GiftStat> giftStats = new List<GiftStat>();
giftStats.Add(new GiftStat(2021, 2000));
giftStats.Add(new GiftStat(2022, 1800));
giftStats.Add(new GiftStat(2023, 2800));

var sum = giftStats.Sum(x=> x.numberOfGifts);
var avg = giftStats.Average(x => x.numberOfGifts);
var max = giftStats.MaxBy(x => x.year);
var min = 0;

Console.WriteLine("Suma = " + sum);
Console.WriteLine("Średnia = " + avg);
Console.WriteLine("Największa liczba dostarczonych prezentów = " + max);
Console.WriteLine("Najmniejsza liczba dostarczonych prezentów = " + min);

public record GiftStat(int year, int numberOfGifts)
{
}