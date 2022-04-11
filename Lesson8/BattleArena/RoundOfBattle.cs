using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Lesson8.Monsters;

namespace Lesson8.BattleArena
{
    public static class RoundOfBattle
    {
        public static void OneRoundOfBattle(Monster monster1, Monster monster2)
        {
            Thread.Sleep(1500);
            SingleAttack.MakeAnAttack(monster1, monster2);
            if (monster2.IsDead)
            {
                Console.WriteLine($"{monster2.Name} погибает в агонии! \"{monster2.DieCry}\"");
                return;
            }
            else
            {
                Thread.Sleep(1500);
                SingleAttack.MakeAnAttack(monster2, monster1);
            }

            if (monster1.IsDead) { Console.WriteLine($"{monster1.Name} погибает в агонии! \"{monster1.DieCry}\""); }
        }
    }
}
