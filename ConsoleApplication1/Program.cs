using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main()
        {
            var flag = 1;
            var potion = 3;
            var hp = 50;
            var hp_m = 50;
            var skip = false;
            var atq = new Random();
            var heal = new Random();
            var atq_m = new Random();

            while (true)
            {
                if (skip == true)
                {
                    Console.WriteLine("Vous avez passer votre tour");
                    skip = false;
                }
                else
                {
                    Console.WriteLine($"Tour: {flag}");
                    Console.WriteLine("Attaquer: 1 | Potion: 2");
                    var choix = Convert.ToInt32(Console.ReadLine());

                    if (choix == 1)
                    {
                        var dmg = atq.Next(5, 10);
                        Console.WriteLine($"Vous avez enlever {dmg} hp a votre ennemi");
                        hp_m -= dmg;
                        if (hp_m <= 0)
                        {
                            Console.WriteLine("Vous avez gagné");
                            break;
                        }
                    } else if (choix == 2)
                    {
                        if (potion > 0)
                        {
                            var gethp = heal.Next(15, 50);
                            Console.WriteLine($"Vous avez récupérer {gethp} hp");
                            hp += gethp;
                            potion -= 1;
                            skip = true;
                        }
                        else
                        {
                            Console.WriteLine("Vous n'avez plus de potion"); 
                            continue;
                        }
                    }
                }
                
                var atq_ennemi = atq_m.Next(5, 15);
                hp -= atq_ennemi;
                Console.WriteLine($"Votre ennemi vous a infliger {atq_ennemi} hp");

                if (hp <= 0)
                {
                    Console.WriteLine("Vous avez perdu");
                    break;
                }
                
                Console.WriteLine($"Hp: {hp}");
                Console.WriteLine($"Hp ennemi: {hp_m}");
                
                Console.WriteLine("------------------------------------");
                flag++;

            }
        }
    }
}