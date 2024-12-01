
Console.WriteLine("Podaj wysokość choinki:");
string? input = Console.ReadLine();

if (!int.TryParse(input, out int wysokosc) || wysokosc <= 1)
{
    Console.WriteLine("Niepoprawna wysokość.");
    return;
}

int szerokosc = wysokosc * 2 - 1;
string[,] tree = new string[wysokosc + 1, szerokosc];

for (int i = 0; i < wysokosc + 1; i++)
{
    for (int j = 0; j < szerokosc; j++)
    {
        tree[i, j] = " ";
    }
}

for (int i = 0; i < wysokosc; i++)
{
    for (int j = szerokosc / 2 - i; j <= szerokosc / 2 + i; j++)
    {
        tree[i, j] = "*";
    }
}
tree[wysokosc, wysokosc - 1] = "||";

for (int i = 0; i < wysokosc + 1; i++)
{
    for (int j = 0; j < szerokosc; j++)
    {
        Console.Write(tree[i, j]);
    }
    Console.WriteLine();
}