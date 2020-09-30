using System;

namespace Anteckningar
{
    public class Enemy
    {

        static Random generator = new Random();


        public int hp = generator.Next(3,50);

        public Enemy()
        {
            int choice = generator.Next(2);

            if (choice == 0)
            {
                hp = 50;
            }
            else 
            {
                hp = 100;
            }
        }


        public int Attack()
        {
            return 2;
        }

        public void Draw()
        {
            System.Console.WriteLine(@"
  X X
  ___
            
            ");
        }

        public void Hurt(int amount )
        {
            hp-= amount;

            hp--;

            if (hp < 0)
            {
                hp = 0;
            }
            System.Console.WriteLine("Oj nu har fiende bara " + hp + "hp kvar");
        }
    }
}

//STATIC FÖRKLARING
//här skapas en ny slump generator för varje ny fiende
        //detta gör att alla generatorer slumpar samma slumptal
        //Random generator = new Random();

        //här skapas en generator som alla enemies har tillgång till
        //static Random generator = new Random();