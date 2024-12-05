/**
 * Policz ile dni zostało do Świąt Bożego Narodzenia i wyświetl na ekranie. Jeśli aktualna
 * data będzie po tegorocznych Świętach, policz liczbę dni do najbliższego Bożego Narodzenia :)
 */

const int ChristmasMonth = 12;
const int ChristmasDay = 25;

DateOnly today = DateOnly.FromDateTime(DateTime.Now);
DateOnly christmas = new DateOnly(today.Year, ChristmasMonth, ChristmasDay);

if (today > christmas)
{
    christmas = new DateOnly(today.Year + 1, ChristmasMonth, ChristmasDay);
}

var daysTillChristmas = (christmas.DayNumber - today.DayNumber);

Console.WriteLine($"Dni do najbliższych świąt: {daysTillChristmas}");

