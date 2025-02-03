using System;


namespace Uppgifttvåpunktett
{
    class program
    {
        static void Main()
        {
            //Defineras en klass som gör slumpmässig tal
            Random random = new Random();

            //Gör en variabel där tal 1-101 slumpas ingår
            int rättTal = random.Next(1, 101);

            //Gör en variabel som lagrar användarens gissning
            int gissning = 0;

            //Gör en variabel som lagrar och räknar användarens försök
            int antalFörsök = 0;

            //Gör en loop tills användaren gissar rätt tal
            while (gissning != rättTal)
            {

                Console.WriteLine("Jag tänker på en siffra mellan 1-100, vågar du gissa??");
                Console.WriteLine("Skriv in ett tal mellan 1-100: ");

                //Lagra användarens svar
                string inPut = Console.ReadLine();

                //Läser av användarens svar och ger sant eller falskt beroende på svar (siffror eller bokstäver)
                //Siffror godtas, ej bokstäver.
                bool nummergissning = int.TryParse(inPut, out gissning);

                //Om användaren gissar fel/skriver bokstäver, be om nytt försök
                if (!nummergissning)
                {

                    //Meddela användaren om ogiltigt och be användaren försöka igen
                    Console.WriteLine("Det är tyvärr fel, försök igen (Psst, endast siffror fungerar): ");
                    continue; //Hoppa tillbaka till början av loopen, användaren får ny chans
                }
                //Ge användaren ny chans efter gissning
                antalFörsök++;

                //Gör if sats, låg gissning
                if (gissning < rättTal)
                {
                    //Skriv ut för lågt

                    Console.WriteLine("För lågt, försök igen =): ");
                }
                //Gör if sats, hög gissning
                else if (gissning > rättTal)
                {
                    //Skriv ut för högt

                    Console.WriteLine("För högt, försök igen =): ");
                }
                //Gör en else, rätt

                else
                //Skriv ut rättsvar text
                {
                    Console.WriteLine("Grattis, dig lurar man inte!! RÄTT GISSAT");
                    Console.WriteLine($"Det tog dig {antalFörsök} försök");
                }
            }

        }
    }
}
