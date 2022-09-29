using System;
namespace Uppgift_3._13
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? j/n");
            string svar = Console.ReadLine().ToLower();
            
            if (svar == "j")
            {
                Console.WriteLine("Bra");
            }
            if (svar == "n")
            {
                Console.WriteLine("Tyvär, du måste gå ut gymnasiet före");
            }
            
            if (svar == "j")
            {
                Console.WriteLine("Hur gammal är du?");
            }
            int ålder = int.Parse(Console.ReadLine());
            
            if (ålder <= 21)
            {
                Console.WriteLine("Perfekt, vi vill anställa dig");
            }
            else if (ålder >= 22)
            {
                Console.WriteLine("Du är tyvär för gammal");
            }



             
            

               
             
            
            
        }
    }
}