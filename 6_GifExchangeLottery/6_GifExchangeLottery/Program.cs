/**
 * Grupa znajomych chce zrobić losowanie prezentów na święta. Napisz program, który dla każdej
 * osoby wylosuje, komu kupuje prezent. Pamiętaj, że każda z osób może zostać wylosowana tylko raz!
 */

Dictionary<int, string> names = new Dictionary<int, string>
{
    { 1, "Mikołaj" },
    { 2, "Gosia" },
    { 3, "Adam" },
    { 4, "Pola" },
    { 5, "Wojtek" }
};

var participants = names.Values.ToList();
var rnd = new Random();

// Przetasowanie listy uczestników
var shuffledParticipants = participants.OrderBy(x => rnd.Next()).ToList();

var giftAssignments = new Dictionary<string, string>();

for (int i = 0; i < participants.Count; i++)
{
    // Każdy uczestnik kupuje prezent dla następnego w kolejności,
    // ostatni kupuje dla pierwszego (cykliczne przypisanie)
    giftAssignments[participants[i]] = shuffledParticipants[(i + 1) % participants.Count];
}

Console.WriteLine("Przydział prezentów:");
foreach (var assignment in giftAssignments)
{
    Console.WriteLine($"{assignment.Key} kupuje prezent dla {assignment.Value}");
}
