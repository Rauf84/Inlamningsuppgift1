using System;
using System.Collections.Generic;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> allResults = new List<int>();

            //Använder en metod för uppgiften
            bool tryAgain = true;

            int summa = 0;
            
            while (tryAgain)
            {
                 int i = BeräkningAvTreTal();
                Console.Write("Vill du fortsätta spela Y/N? : ");
                string keepPlaying = Console.ReadLine();
                allResults.Add(i);
                summa += i;
                if (keepPlaying == "Y" || keepPlaying == "y")
                {
                    tryAgain = true;
                } else
                {
                    tryAgain = false;
                }
               
            }
            Console.Write("Alla svar i en lista: ");
            Console.WriteLine(string.Join(' ', allResults));
            Console.WriteLine("Summan av alla försök är {0}", summa);
        }
       
        static int BeräkningAvTreTal()
        {
            int resultat;

            Console.Write("Enter first operator: ");
            string firstOperator = Console.ReadLine();
            Console.Write("Enter second operator: ");
            string secondOperator = Console.ReadLine();
            Console.Write("Enter first temr: ");
            int förstaTal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second temr: ");
            int andraTal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third temr: ");
            int tredjeTal = Convert.ToInt32(Console.ReadLine());

            resultat = 0;

            if (firstOperator == "+" && secondOperator == "+")
            {
                resultat = förstaTal + andraTal + tredjeTal;
               
                
               
            } else if (firstOperator == "-" && secondOperator == "+")
            {
                resultat = förstaTal - andraTal + tredjeTal;
                

            } else if (firstOperator == "-" && secondOperator == "-")
            {
                resultat = förstaTal - andraTal - tredjeTal;
                

            } else if (firstOperator == "+" && secondOperator == "-")
            {
                resultat = förstaTal + andraTal - tredjeTal;
                

            } else if (firstOperator == "+" && secondOperator == "*")
            {
                resultat = förstaTal + (andraTal * tredjeTal);
                

            } else if (firstOperator == "+" && secondOperator == "/")
            {
                resultat = förstaTal + (andraTal / tredjeTal);
                

            } else if (firstOperator == "-" && secondOperator == "*")
            {
                resultat = förstaTal - (andraTal * tredjeTal);
                

            } else if (firstOperator == "-" && secondOperator == "/")
            {
                resultat = förstaTal - (andraTal / tredjeTal);
                

            } else if (firstOperator == "*" && secondOperator == "+")
            {
                resultat = förstaTal * andraTal + tredjeTal;
                

            } else if (firstOperator == "*" && secondOperator == "-")
            {
                resultat = förstaTal * andraTal - tredjeTal;
                

            } else if (firstOperator == "*" && secondOperator == "*")
            {
                resultat = förstaTal * andraTal * tredjeTal;
                

            } else if (firstOperator == "*" && secondOperator == "/")
            {
                resultat = förstaTal * andraTal / tredjeTal;
                
            }
            else if (firstOperator == "/" && secondOperator == "+")
            {
                resultat = förstaTal / andraTal + tredjeTal;
                

            } else if (firstOperator == "/" && secondOperator == "-")
            {
                resultat = förstaTal / andraTal - tredjeTal;
                
            }
            else if (firstOperator == "/" && secondOperator == "*")
            {
                resultat = förstaTal / andraTal * tredjeTal;
               
            } else if (firstOperator == "/" && secondOperator == "/")
            {
                resultat = förstaTal / andraTal / tredjeTal;
                
            } else
            {
                Console.Write("Du har matat in fel operator. Försök igen (Y) eller avsluta programmet (N): ");
            }
            Console.WriteLine(förstaTal + firstOperator + andraTal + secondOperator + tredjeTal + "=" + resultat);

            if (resultat < 100)
            {
                Console.WriteLine("The sum is less then a hundred");
            }
            else if (resultat > 100)
            {
                Console.WriteLine("The sum is more then a hundred");
            }
            else Console.WriteLine("B I N G O - you are a winner");

            return resultat;
            }
        // här avslutas metoden beräkning av tre tal

       
        
    }
}

//Inlämningsuppgift 1
//•	Be användaren att ange ett par operatorer
//•	Be sedan användaren om ett par termer att använda operatorerna på
//•	Visa sen ekvationen och resultatet av beräkningen.
//•	Resultatet skall sen läggas till i en array/List
//•	Om summan är mindre än 100 skriv ut; ”Less then a hundred”
//•	Om summan är mer än 100 skriv ut; ”More then a hundred”
//•	Om summan är lika med 100 skriv ut; ”Cool, now you have a hundred, clap clap”
//•	Programmets titel i konsolen skall vara modifierat
//•	Programmet skall upprepa tills användaren själv väljer att avsluta
//•	Vid avslut skall summan av alla resultat skrivas ut
//Använd Git för att verisionshantera koden och ladda upp git-repot till din GitHub
//Programmet måste inte vara felfritt eller buggfritt. Framför allt är det verisionshanteringen som testas. Om två operatorer är för svårt, börja med en och sen lägg på fler om du kan.
//Exempel: 
//(‘>’ or ‘$’ används ofta för att notera att något händer i en kommandotolk)
//> Enter first operator: x
//> Enter second operator: -
//> Enter first term: 8 
//> Enter second term: 6 
//> Enter third term: 3 
//> 8 x 6 – 3 = 45
//> ”The sum is less then a hundred”
//> Another try?
//> Thank you for playing.The sum of all round is 221. Bye
