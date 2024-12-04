/**
 * Mikołaj otrzymał listę prezentów do kupienia przed świętami. Niestety podczas
 * wpisywania nazwy prezentu nie było żadnej walidacji i zawierają one błędy
 * (przykładowo nadmierne puste znaki lub brak wartości). Wypisz listę prezentów
 * po przecinku. Pomiń puste wartości i usuń zbędne odstępy.
 */

List<String> listOfPresents = getListOfPresents();
List<string> cleanedPresents = new List<string>();

foreach (var present in listOfPresents)
{
    if (!string.IsNullOrWhiteSpace(present))
    {
        cleanedPresents.Add(present.Trim());
    }
}

Console.WriteLine(string.Join(", ", cleanedPresents));

static List<String> getListOfPresents()
{
    List<string> presents = new List<string>();

    presents.Add("Klocki LEGO   ");
    presents.Add("Lalka Barbie");
    presents.Add(" ");
    presents.Add("  Samochód zdalnie sterowany");
    presents.Add("Rower  ");
    presents.Add(null);
    presents.Add("   Kostka Rubika");
    presents.Add("Myszka do komputera    ");

    return presents;
}
