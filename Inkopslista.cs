List<string>produktNamn = [];
List<int>produktPriser = [];

produktNamn.Add("Mjölk");
produktPriser.Add(15);
produktNamn.Add("Bröd");
produktPriser.Add(32);
produktNamn.Add("Ost");
produktPriser.Add(89);

while (true)
{

    if 

        int total = 0;

        for (int i = 0; i < produktNamn.Count; i++)
        {
            Console.WriteLine($" {i + 1}  {produktNamn[i]} - {produktPriser[i]} kr");
            total += produktPriser[i];
            break;
        }
        Console.WriteLine($"    Total {total} kr");

        Console.WriteLine("Skriv en vara, ett nummer eller Avsluta: ");
        string input = Console.ReadLine();


}