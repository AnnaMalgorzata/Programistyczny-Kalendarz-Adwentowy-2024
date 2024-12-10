Random random = new Random();
int secretNumber = random.Next(0, 100); 
int userGuess = -1;
int userGuessesNumber = 0;


Console.WriteLine("Zgadnij liczbę z przedziału 0 - 99.");

while (userGuess != secretNumber)
{
    Console.Write("Podaj swoją liczbę: ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out userGuess))
    {
        Console.WriteLine("To nie jest poprawna liczba. Spróbuj ponownie.");
        continue;
    }

    if (userGuess < secretNumber)
    {
        Console.WriteLine("Za mało! Spróbuj jeszcze raz.");
        userGuessesNumber++;
    }
    else if (userGuess > secretNumber)
    {
        Console.WriteLine("Za dużo! Spróbuj jeszcze raz.");
        userGuessesNumber++;
    }
    else
    {
        Console.WriteLine($"Gratulacje! Zgadłeś liczbę {secretNumber} za {userGuessesNumber} razem");
    }
}