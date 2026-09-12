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
    // Meny
    

    int total = 0;

 or (int i = 0; i < produktNamn.Count; i++)
    {
        Console.WriteLine($" {i + 1}  {produktNamn[i]} - {produktPriser[i]} kr");
        total += produktPriser[i];
            
    }
    Console.WriteLine($"    Total {total} kr");

    Console.WriteLine("Skriv en vara, ett nummer eller Avsluta: ");
    string input = Console.ReadLine();

    if (Val == "produktNamn ")
    {
        Console.Write("Ange varans namn: ");
    }


}