using System;
using Abstracao_Jogo_RPG_em_C.src.Entities;

namespace Abstracao_Jogo_RPG_em_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior arus = new Warrior("Arus", 23, "Warrior"); // instanciando um objeto
            Knight ronan = new Knight("Ronan", 26, "Knight");
            Ninja lass = new Ninja("Lass", 24, "Ninja");
            Console.WriteLine(arus.Attack());
            Console.WriteLine(ronan.Attack(2));
            Console.WriteLine(ronan.Attack(7));
            Console.WriteLine(lass.Attack());
        }
    }
}
