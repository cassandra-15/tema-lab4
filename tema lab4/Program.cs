using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_lab4
{
    class Program
    {
        static void Main()
        {
            string[][] tablou = new string[70][];
            string x = "abcdefghijklmnopqrstuvwyz";
            Console.WriteLine("alegeti o optiune:");
            string optiune;
            do
            {
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "A":
                        int ok = 0;
                        Console.WriteLine("dati cuvantul");
                        string nume = Console.ReadLine();
                        /*foreach (char c in x)
                            if (nume[0] == c || nume[0] == char.ToUpper(c))
                            {
                                tablou[x.IndexOf(nume[0])]=nume;
                            }*/
                        for(char a='a'; a<'z';a++)
                            if(a==nume[0] || char.ToUpper(a)== nume[0])
                                {
                                int i = 0;
                                tablou[x.IndexOf(nume[0])][0]= nume;
                                i++;
                            }
                        break;
                    case "B":
                        Console.WriteLine("tabloul este:");
                        for (int i = 0; i < tablou.Length; i++)
                            for (int j = 0; j < tablou[i].Length; j++)
                                Console.WriteLine("{ 0}", tablou[i][j]);
                        break;
                    case "C":
                        return;
                    default:
                        Console.WriteLine("optiune inexistenta");
                        break;
                }
            }
            while (optiune.ToUpper() != "C");
                Console.ReadKey();
    } }
}
