using System;

namespace uppettpunktett
{
    class program
    {
        static void Main()
        {

            //Välkomsttext
            Console.WriteLine("Din pensionssimulator i kajjan");    
            
            //Fråga användaren efter dess namn.
            Console.WriteLine("Skriv ditt namn:");
            
            //Gör en sträng för att lagra datan användaren har angivit
            string namn = Console.ReadLine();
            
            //Gör så att fältet inte kan lämnas blankt eller att annat än bokstäver används.
            while (string.IsNullOrWhiteSpace(namn) || namn.Any (C => !char.IsLetter(C)))

            //Ge meddelande till användaren om ogiltig inmatning
            {
                Console.Write("Namn kan inte vara tomt eller innehålla siffror. (Skriv t.ex. Nisse) Försök igen: ");
                namn = Console.ReadLine();
            }
            //Fråga efter användarens ålder.
            Console.WriteLine("Skriv din ålder");

            //Gör en sträng för lagra datan användaren har angivit
            string ålderInput = Console.ReadLine();
            
            //Definera en variabel för hantera siffror
            int ålder;

            //Definera en variabel för pensionsålder (65)
            int pensionsålder = 65;

            //Beräkna differens ålder-pensionsålder.
            //Gör så att användaren inte kan ange negativ siffra / siffra över pensionsålder (65)
            //Gör så att fältet enbart hanterar siffror
            while (!int.TryParse(ålderInput, out ålder) || ålder <= 0 || ålder > pensionsålder)
            
            //Ge användaren meddelade om ogiltig inmatning
            { 
            Console.WriteLine("Ogiltig ålder. Vänligen svar i siffror t.ex. 33");
                ålderInput = Console.ReadLine();
            }

            //Skriv ut samald info om användarens namn, ålder och kvar till pension
            Console.WriteLine($"Ditt namn är {namn} och du är {ålder} år gammal. Du har {pensionsålder - ålder} kvar till pension");

        }
    }
}

