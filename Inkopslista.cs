List<string>produktNamn = [];
List<int>produktPriserna = [];

produktNamn.Add("Mjölk");
produktPriserna.Add(15);
produktNamn.Add("Bröd");
produktPriserna.Add(32);
produktNamn.Add("Ost");
produktPriserna.Add(89);

while (true)
{
    
    int total = 0;

    for (int i = 0; i < produktNamn.Count; i++)
    {
        Console.WriteLine($" {i + 1}  {produktNamn[i]} - {produktPriserna[i]} kr");
        total += produktPriserna[i];
            
    }
    Console.WriteLine($"    Total {total} kr");

   
   
    Console.WriteLine("Skriv en vara, ett nummer eller Avsluta: ");
    string input = Console.ReadLine();


    if (input == Avsluta)
    {
        break;
    }

    if (int.TryParse(input, out int position))
    {

        if (position >= 1 && position <= produktNamn.Count)
        {
            produktNamn.RemoveAt(position -1);
            produktPriserna.RemoveAt(position-1);
            Console.WriteLine("Varan har tagits bort ");
        }  
        else
        {

            Console.WriteLine("Nummeret finns inte i listan");
        }
 
    
    }







}


