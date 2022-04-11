using System;
using Lesson8.OPD;
using Lesson8.Monsters;
using System.Threading;
using Lesson8.BattleArena;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster eragon = new Monster("Эрагон", MonsterType.Dragon, 10, 80, "Поздно просить пощады.", "Они получат по заслугам.");

            MortalCombat mk2022 = new MortalCombat(eragon);

            mk2022.StartTheMortalCombat();
        }
    }
}
