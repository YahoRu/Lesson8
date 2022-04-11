using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Lesson8.Monsters;

namespace Lesson8.BattleArena
{
    public class MortalCombat
    {
        private readonly Monster _challenger;
        private readonly Monster[] monsters = new Monster[12];

        public MortalCombat(Monster challenger)
        {
            _challenger = challenger;

            for (int i = 0; i < monsters.Length; i++)
            {
                monsters[i] = new Monster();
            }
        }

        public void StartTheMortalCombat()
        {
            Console.WriteLine("Претендент! Добро пожаловать на смертельную битву!");
            Thread.Sleep(1500);
            Console.WriteLine("Тебя ждет 12 раундов с опаснейшими монстрами!");
            Thread.Sleep(1500);
            Console.WriteLine("И только после победы над каждым из них ты сможешь стать настоящим победителем!");
            Thread.Sleep(1500);
            Console.WriteLine("Победителем Mortal Combat! Да начнется битва!");
            Thread.Sleep(1500);

            for (int i = 0; i < monsters.Length; i++)
            {
                Console.WriteLine($"\n Битва {i + 1} из {monsters.Length}! \n");
                Thread.Sleep(1500);
                Console.WriteLine($"Претендент: {_challenger.GetInfo}");
                Thread.Sleep(1500);
                Console.WriteLine("\t\t\t    VS");
                Thread.Sleep(1500);
                Console.WriteLine($"Противник: {monsters[i].GetInfo}");
                Thread.Sleep(1500);
                Console.WriteLine("\t\t\t  FIGHT!");
                Thread.Sleep(1500);

                Monster tmp = Battle.BattleOfTwoMonsters(_challenger, monsters[i]);

                if (tmp != _challenger)
                {
                    Console.WriteLine(_challenger.DieCry); 
                    Console.WriteLine("Ты проиграл!");
                    return;
                }
                else
                {
                    Console.WriteLine($"Претендент {_challenger.Name} Победил! Славная победа!");
                    _challenger.Heal();
                }
            }

            if (!(_challenger.IsDead)) { Console.WriteLine("Поздравляю! Ты стал великим победителем турнира MORTAL COMBAT!"); }
        }
    }
}
