/**
 * W systemie Mikołaja wystąpił błąd i wszystkie imiona dzieci zostały odwrócone.
 * Napisz program, który odwróci imiona oraz wypisze je w konsoli dużymi literami.
 */

List<string> names = new List<string> { "alop", "nicram", "ketjow", "mada", "kenaj" };

for (int i = 0; i < names.Count; i++)
{
    names[i] = new string(names[i].Reverse().ToArray());
    Console.WriteLine(names[i].ToUpper());
}