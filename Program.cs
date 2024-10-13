using System;


namespace Helloworld
{
        class Program
        {
            static void Main(string[] args) 
            {
                Guerrier pers1 = new Guerrier("Rakoto", 20, 10, 50, 20);
                Guerrier pers2 = new Guerrier("Rabe", 25, 30, 10);
                pers1.LancerAttaque(pers2);
                Console.WriteLine("");
                pers1.ActiveSoin();
                pers1.ActiveSoin();
                pers1.ActiveSoin();
                Console.WriteLine("");
                pers1.LancerAttaqueAvecDefense(pers2);
                Console.WriteLine("Joueur 1");
                pers1.AfficheInformation();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Joueur 2");
                pers2.AfficheInformation();
            }
        }
}
