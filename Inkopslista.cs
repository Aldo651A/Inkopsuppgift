// Här skapar både en string lista och en int lista.
// String skapr en tom lista som bara ter emot textsträngar
// som t ex Mjölk, Ost ocg Bröd
// int skapar en tom lista som bara tar emot heltal 
// som t ex priserna på produkterna 15, 32 och
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
    Console.Clear();
    // Här deklarerar och initierar att total = 0; och detta ska läsas in
    // som en heltal
    int total = 0;

    // Detta är en loop som gör att användaren kan se en lista
    // på produkter och priser
    // int i = 0; är en räknare som kontrolerar i som är index som börjar 0.
    // i < produktNamn.Count talar om hur länge loopen kommar att köras
    // just nu 3 eftersom vi bara har tre varur
    // i++ kontrollerar att loopen kört färdigt och registrerar 1
    // för att sedan gå vidare till nästa produkt eller block.
    for (int i = 0; i < produktNamn.Count; i++)
    {
        // Här skriver dator ut en nummererad lista och räknar ut totalen.
        // {i + 1} Eftersom C# alltid börjar på noll så ber vi den att börja på ett
        Console.WriteLine($" {i + 1}  {produktNamn[i]} - {produktPriserna[i]} kr");
        total += produktPriserna[i];
            
    }// Här räknas ut totalen på produkt priserna och visas för användaren
    Console.WriteLine($"    Total {total} kr");

    // Här skrivs en text som användaren kan se i konsolen
    // Den andra raden pausar programmet tills användaren skrivit 
    // varan, ett nummer eller avslutar och trycker på Enter.
    Console.WriteLine("Skriv en: vara, ett nummer eller Avsluta: ");
    string? input = Console.ReadLine();

    // Detta gör hekt enkelt att loopen avslutas om användaren 
    // skriver i konsolen avsluta.
    if (input == "Avsluta")
    {
        break; // Avlsutar loopen.
    }

    // Om användaren skriver dyrast så startar programmet
    // Tolover gör att man kan skriva med små eller stora bokstäver.
    if (input?.ToLower() == "dyrast")
    {
        // Här kontrollerar man vilken vara är dyrast alltsdå vinnaren
        // Vi sätter -1 som start, eftersom alla priserna är högre så
        // kommer den första varan i loopen att vara vinnren sedan den andra osv.
        int hogstaPris = -1;
        int dyrastIndex = -1;

        // Detta är en loop som går igenom hela listan men en produktkt i taget.
        for (int i = 0; i < produktNamn.Count; i++)
        {
            // Här kontrolleras om priset är lika med eller högre
            // om priset är högre så sparas den nya värdet men även platsen 
            // där varan finns.
            if (hogstaPris <= produktPriserna[i])
            {
                hogstaPris =  produktPriserna[i];
                dyrastIndex = i;
            }
            
        }
        // När loppen har kontrollerat alla priser så hämtas varan som är dyrast
        Console.WriteLine($"Den dyraste varan är {produktNamn[dyrastIndex]} och den kostar {hogstaPris} kr ");
     
        Console.WriteLine("Tryck på valfrit tangent för att fotsätta. ");
        Console.ReadKey();

    
        continue; 
        // jag fick använda denna metoden för att hoppa över resten av koden 
        // och starta nästa varv i loopen direkt. 
        // För att hindra att "Ange pris" skrivs ut.
              
    } 

    // Detta är en säkerhet som hindrar användaren att skriva annat än ett tal
    if (int.TryParse(input, out int position))
    {
        // Kontrollerar om antalet produketer är 3 då kan användaren 
        // bara välja mellan 1 och 3 om man väljer en annan siffra
        // då får användaren ett fel meddelande
        if (position >= 1 && position <= produktNamn.Count)
        {
            // Här väljer man att ta bort en produkt från listan genom att 
            // ange ett nummer. Priset tas också bort. 
            // Användren får ett meddelande att varan har tagits bort
            produktNamn.RemoveAt(position -1);
            produktPriserna.RemoveAt(position-1);
            Console.WriteLine("Varan har tagits bort ");
        }  
        else
        {
            // här hgamnar du om du har angivit fel siffra 
            // då får du meddelandet som är ljusblå här nedanför.
            Console.WriteLine("Nummeret finns inte i listan");
        }
        Console.WriteLine("Tryck på valfit tangent för att fotsätta");
        Console.ReadKey();
 
    }
    else
    {   // Om vi skriver in en ny produkt då kemmer meddelandet "Ange pris"
        // nedre rad läser in den nya produkten och priset.
        Console.WriteLine("Ange pris: ");
        string? prisText = Console.ReadLine();

        // Även här är detta en säkerhets spärr för att hindra 
        // användaren att skriva in ett giltig heltal.
        if (int.TryParse(prisText, out int pris))
        {
            // Om allt är ok då läggs varan och priset in i listan
            // Detta vissa även i konsolen.
            produktNamn.Add(input??"");
            produktPriserna.Add(pris);
        }       
    
    }


}


