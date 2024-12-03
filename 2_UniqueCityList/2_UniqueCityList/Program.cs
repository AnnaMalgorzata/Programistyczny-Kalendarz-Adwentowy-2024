/**
 * Mikołaj ma przygotowaną listę adresów, pod które musi dostarczyć prezent. Chciałby on
 * skorzystać z pomocy technologii i wyświetlić listę miast, do których musi pojechać.
 * Napisz program, który wyświetli w konsoli nazwy miast bez duplikatów.
 */

public class Program
{
    public static void Main(string[] args)
    {
        List<Address> addresses = PrepareListOfAddresses();

        HashSet<string> cities = new HashSet<string>();
        foreach (var addres in addresses)
        {
            bool added = cities.Add(addres.City);
            if (added)
            {
                Console.WriteLine(addres.City);
            }
        }
    }

    private static List<Address> PrepareListOfAddresses()
    {
        return new List<Address>
        {
            new Address("Warszawa", "1 maja", 25),
            new Address("Wrocław", "Akacjowa", 33),
            new Address("Kielce", "Warszawska", 16),
            new Address("Warszawa", "Hassa", 25),
            new Address("Wrocław", "Altanowa", 44),
            new Address("Gdańsk", "Aldony", 71),
            new Address("Poznań", "Granitowa", 36)
        };
    }
}

public record Address(string City, string Street, int Number);