using System;

namespace Anteckningar
{
    class Program
    {
        static void Main(string[] args)
        {

            Enemy e1 = new Enemy();
            Enemy e2 = new Enemy();


            int dmg = e1.Attack();

            e1.Hurt(dmg);

            e1.Draw();

            Console.ReadLine();


        }
    }
}
