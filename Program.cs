

/*
Oppgave 2: 

Lag en metode som tar imot to tall og returnerer summen av tallene dersom de er ulike, 

og returnerer tallene multiplisert med hverandre dersom de er like
*/


namespace If_else_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Skriver til konsollen
            number1 og number2 er likt det man skriver i konsollen i tallverdi
            */
            Console.WriteLine("Skriv inn det første tallet: "); 
            int number1 = int.Parse(Console.ReadLine());        

            Console.WriteLine("Skriv inn det andre tallet: ");  
            int number2 = int.Parse(Console.ReadLine());

            int result = ReturnSumIfDifferent(number1, number2); // lagrer funksjonen i en variabel for å bruke den enklere

            /*
            Vi skriver inn to tall i konsollen, hvis de er like vil if-en i main slå til og skrive at de er like
            og kalle på if-delen av if-elsen i ReturnSumIfDifferent(). Det gjør at vi ser tallene ganget med hverandre.

            Hvis de to tallene vi skriver inn IKKE er like så vil else-en i main slå til og skrive til konsollen at
            tallene ikke er like og med hjelp av else-en i ReturnSumIfDifferent vil tallene plusset sammen bli skrevet ut.
            */

            if (number1 == number2) 
            {
                Console.WriteLine("Tallene er like, her er tallene ganget med hverandre: " + result);
            }
            else
            {
                Console.WriteLine("Tallene er ulike, her er summen av dem: " + result);
            }
        }

        static int ReturnSumIfDifferent(int number1, int number2)
        {
            if (number1 == number2)
            {   
                return number1 * number2;
            }
            else
            {
                return number1 + number2;
            }
        }
    }
}

