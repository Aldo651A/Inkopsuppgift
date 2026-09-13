// Här skapar både en string lista och en int lista.
// String skapr en tom lista som bara ter emot textsträngar
// som t ex Mjölk, Ost ocg Bröd
// int skapar en tom lista som bara tar emot heltal 
// som t ex priserna på produkterna 15, 32 och 89
List<string>produktNamn = [];
List<int>produktPriserna = [];

// här lägger jag till olika produkter och priser.
// jag kan även lägga till en ny produkt eller ta bort en produkt.
produktNamn.Add("Mjölk");
produktPriserna.Add(15);
produktNamn.Add("Bröd");
produktPriserna.Add(32);
produktNamn.Add("Ost");
produktPriserna.Add(89);

// Detta är en loop som körs om och om igen eftersom den är sant (true)
// detta kommer att köras tills den läser break; 
// eler användaren skriver Avsluta i detta fallet.
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
    string? input = Console.ReadLine();

    if (input == "Avsluta")
    {
        break;
    }

    if (input?.ToLower() == "dyrast")
    {
        int hogstaPris = -1;
        int dyrastIndex = -1;

        for (int i = 0; i < produktNamn.Count; i++)
        {
        
            if (hogstaPris <= produktPriserna[i])
            {
                hogstaPris =  produktPriserna[i];
                dyrastIndex = i;
            }
            
        }
    Console.WriteLine($" Den dyraste varan är {produktNamn[dyrastIndex]} och den kostar {hogstaPris} kr ");
    
    continue;
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
    else
    {
        Console.WriteLine("Ange pris: ");
        string? prisText = Console.ReadLine();


        if (int.TryParse(prisText, out int pris))
        {
        
            produktNamn.Add(input??"");
            produktPriserna.Add(pris);
        }       
    
    }


}


