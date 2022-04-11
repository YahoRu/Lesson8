using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Lesson8.Monsters;

namespace Lesson8.BattleArena
{
    public static class Battle
    {
        public static Monster BattleOfTwoMonsters(Monster monster1, Monster monster2)
        {
            int count = 1;
            while (true)
            {
                Console.WriteLine($"\t \t \t {count} РАУНД! ");
                count++;
                RoundOfBattle.OneRoundOfBattle(monster1, monster2);

                Thread.Sleep(1500);
                if (monster1.IsDead)
                {
                    Console.WriteLine($"{monster2.Name} побеждает в сражении и издает боевой клич \"{monster2.WarCry}\" ");
                    return monster2;
                }
                else if (monster2.IsDead)
                {
                    Console.WriteLine($"{monster1.Name} побеждает в сражении и издает боевой клич \"{monster1.WarCry}\" ");
                    return monster1;
                }
            }

        }
    }
}
