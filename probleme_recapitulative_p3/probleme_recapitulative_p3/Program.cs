using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probleme_recapitulative_p3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declararea celor doua liste
            List<int> lista1 = new List<int> { 1, 3, 6, 9, 3  };
            List<int> lista2 = new List<int> { 3, 9, 18, 27, 9 };

            // a. Să se afișeze lista rezultată prin reuniunea 
            List<int> reuniune = lista1.Union(lista2).ToList();
            Console.WriteLine("Reuniunea listelor este: " + string.Join(", ", reuniune));

            // b. Să se afișeze mesajul "Proportional" dacă cele două mulțimi sunt proporționale, iar în caz contrar se va afișa mesajul "Nu sunt proportionale". 
            bool proportional = true;
            double factorProp = lista1.ElementAt(0) / lista2.ElementAt(0);
            if (lista1.Count() == lista2.Count())
            {
                for (int i = 0; i < lista1.Count(); i++)
                    if ((lista1.ElementAt(i) / lista2.ElementAt(i)) != factorProp)
                        proportional = false;
                if (proportional)
                    Console.WriteLine("Proportional");
                else
                    Console.WriteLine("Nu sunt proportionale");
            }
            else
                Console.WriteLine("Liste inegale");

            // c.Să se numere câte elemente comune există în cele două liste;
            List<int> intersectie = lista1.Intersect(lista2).ToList();
            Console.WriteLine("Numarul elementelor comune din lista este : " + intersectie.Count());

            // d. Să se calculeze suma elementelor din prima listă ridicate la puterea elementului de pe aceeași poziție din cea de-a doua listă;
            if (lista1.Count() == lista2.Count())
            {
                double s = 0;
                for (int i = 0; i < lista1.Count(); i++)
                    s += Math.Pow(lista1.ElementAt(i), lista2.ElementAt(i));
                Console.WriteLine("Suma este: " + s);
            }
            else
                Console.WriteLine("Liste inegale");

            // e.Să se determine dacă prima listă este inversul celei de-a doua liste. În caz afirmativ, se va afișa mesajul "oglinda".În caz contrar, nu se va afișa niciun mesaj;
            List<int> lista2Inversata = lista2.Select(x => x).ToList(); ;
            lista2Inversata.Reverse();
            if (string.Join(" ", lista1) == string.Join(" ", lista2Inversata))
                Console.WriteLine("oglinda");

            // f. Să se afișeze rezultatul împărțirii dintre suma elementelor primei liste și produsul elementelor din cea de-a doua listă;
            Console.WriteLine("Rezultatul impartirii este: " + ((double)lista1.Sum() / (double)(lista2.Aggregate(1, (c, p) => c*p))));

            // g. Să se afișeze mesajul "egale" dacă cele două liste au aceeași dimensiune. În caz contrar, se va afișa mesajul "inegale";
            if (lista1.Count() == lista2.Count())
                Console.WriteLine("egale");
            else
                Console.WriteLine("inegale");

            // h. Să se afișeze elementul cu valoarea minimă identificat în cele două liste;
            Console.WriteLine("Valoarea minima este: " + lista1.Union(lista2).Min());

            // Să se creeze și să se afișeze o nouă listă care conține fiecare element din prima listă de un număr de ori egal cu elementul din cea de-a doua listă aflat pe aceeași poziție.
            if (lista1.Count() == lista2.Count())
            {
                List<int> listaNoua = new List<int>();
                for (int i = 0; i < lista1.Count(); i++)
                    for (int j = 0; j < lista2.ElementAt(i); j++)
                        listaNoua.Add(lista1.ElementAt(i));
                Console.WriteLine("Noua lista este: " + string.Join(" ", listaNoua));
            }
            else
                Console.WriteLine("inegale");
        }
    }
}
