using System;


namespace Rulett
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy színt (fekete/piros):");
            string szin = Console.ReadLine();

            if (szin != "piros")
            {
                if (szin != "fekete")
                {
                    Console.WriteLine("Nincs ilyen szín.");
                    return;
                }
            }

            Console.WriteLine("");

            Console.WriteLine("Adj meg egy számot (0-36):");
            int szam = Convert.ToInt32(Console.ReadLine());



            if (szam < 37)
            {
            }

            else
            {
                Console.WriteLine("Nincs ilyen szám.");
                return;
            }

            Console.WriteLine("");

            String[] szinek = { "fekete", "piros" };
            Random rnd = new Random();
            int index = rnd.Next(0, szinek.Length);
            string randomszin = szinek[index];
            Console.WriteLine("A gép által kipörgött szín: {0}", randomszin);

            var rand = new Random();
            int randomszam = rand.Next(36);
            Console.Write("A gép által kipörgött szám: {0:N0}", randomszam);
            Console.WriteLine();

            Console.WriteLine("");

            if (szin == randomszin)
            {
                Console.WriteLine("Nyertél a {0} színnel.", szin);
            }
            else
            {
                Console.WriteLine("Sajnos nem nyertél a {0} színnel.", szin);
            }

            if (szam == randomszam)
            {
                Console.WriteLine("Nyertél a {0} számmal.", szam);
            }
            else
            {
                Console.WriteLine("Sajnos nem nyertél a {0} számmal.", szam);
            }
            Console.Read();
        }
    }
}
