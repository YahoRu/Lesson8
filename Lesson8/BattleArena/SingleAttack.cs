using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson8.Monsters;

namespace Lesson8.BattleArena
{
    public static class SingleAttack
    {
        public static void MakeAnAttack(Monster monster1, Monster monster2)
        {
            int damage = monster1.GetAttack();
            monster2.Wounds(damage);
            Console.WriteLine($"{monster1.Name} наносит {damage} урона по {monster2.Name}, у него остается {monster2.HP} HP.");
        }
    }
}
