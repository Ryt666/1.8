using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string outgoing_abonent, incoming_abonent;
            int duration_min, duration_sek;
            Console.WriteLine("Введите исходящий номер телефона: ");
            outgoing_abonent = Console.ReadLine();
            Console.WriteLine("Введите входящий номер телефона: ");
            incoming_abonent = Console.ReadLine();
            Console.WriteLine("Минуты: ");
            duration_min = int.Parse(Console.ReadLine());
            Console.WriteLine("Секунды: ");
            duration_sek = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Call C = new Call(outgoing_abonent, incoming_abonent, duration_min, duration_sek);
            Console.WriteLine(outgoing_abonent + " -> " + incoming_abonent + "  " + duration_min + " : " + duration_sek);
            Console.WriteLine(C.cost(20)); 
            Console.Read();
            Console.ReadKey();
        }
    }
}
