using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string vreme = "";
            double min = double.MaxValue;
            Console.WriteLine("Unesite vreme trkaca:");
            while ((vreme = Console.ReadLine()).ToLower() != "kraj")
            {
                if(double.Parse(vreme) < min)
                    min = double.Parse(vreme);
                Console.WriteLine("Unesite vreme trkaca:");
            }
            Console.WriteLine("Najbolje vreme je: " + min + " sekundi.");
            Console.ReadKey();

            List<int> lista = new List<int>();
            for (int i = 0; i < 4; i++)
                lista.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine("-----------------------");
            PrikaziBrojeve(lista);
            int index = UnesiIndex();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Unesite vrednost");
            int novi_broj = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------");
            lista[index - 1] = novi_broj;
            PrikaziBrojeve(lista);
            Console.ReadKey();*/
            Random random = new Random();
            List<int> igrac1 = new List<int>() { random.Next(1, 7) , random.Next(1, 7) , random.Next(1, 7) };
 
            Console.WriteLine("-------------");
            List<int> igrac2 = new List<int>() { random.Next(1, 7), random.Next(1, 7), random.Next(1, 7) };

            int prvi = 0;
            int drugi = 0;
            igrac1.Sort();
            igrac2.Sort();
            foreach (int i in igrac1)
                Console.WriteLine(i);
            Console.WriteLine("-------------");
            foreach (int i in igrac2)
                Console.WriteLine(i);
            if (igrac1[0] > igrac2[0])drugi++;
            else if (igrac1[0] < igrac2[0])prvi++;
            else{prvi++;drugi++;}

            if (igrac1[1] > igrac2[1])drugi++;
            else if (igrac1[1] < igrac2[1])prvi++;
            else{prvi++;drugi++;}

            if (igrac1[2] > igrac2[2])drugi++;
            else if(igrac1[2] < igrac2[2])prvi++;
            else{prvi++;drugi++;}
            Console.WriteLine("-------------");
            Console.WriteLine("Prvi gubi:" + prvi);
            Console.WriteLine("Drugi gubi:" + drugi);
            Console.ReadKey();
        }
        /*static void PrikaziBrojeve(List<int> lista)
        {
            for (int i = 0; i < lista.Count; i++)
                Console.WriteLine(lista[i]);
            Console.WriteLine("-----------------------");
        }
        static int UnesiIndex()
        {
            Console.WriteLine("Unesite index broja koji treba da se promeni:");
            int index = int.Parse(Console.ReadLine());
            if (index > 0 && index < 5)
                return index;
            else
                return UnesiIndex();
        }*/
    }
}
