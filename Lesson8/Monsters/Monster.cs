using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8.Monsters
{
    public class Monster
    {
        readonly Random random = new Random();

        private string _name;
        private readonly int _max_HP;
        private int _hP;
        private int _minAttack;
        private int _maxAttack;
        private string _warCry;
        private string _dieCry;
        private MonsterType _type;

        public string Name
        {
            get { return _name; }
            private set
            {
                if (value != null) _name = value;
                else throw new ArgumentException("Неверное имя монстра.");
            }
        }

        public MonsterType Type
        {
            get { return _type; }
            private set
            {
                if ((int)value >= 1 && (int)value <= 9) _type = value;
                else throw new ArgumentException("Неверный тип монстра.");
            }
        }

        public int MaxHP { get { return _max_HP; } }

        public int HP
        {
            get { return _hP; }
            private set
            {
                if (value >= 0 && value <= 500) _hP = value;
            }
        }

        private int MinAttack
        {
            get { return _minAttack; }
            set
            {
                if ((int)_type == 9) _minAttack = 100;
                else if (value >= 1 && value <= 10) _minAttack = value;
            }
        }

        private int MaxAttack
        {
            get { return _maxAttack; }
            set
            {
                if ((int)_type == 9) _maxAttack = 100;
                else if (value >= 20 && value <= 1000) _maxAttack = value;
            }
        }

        public string WarCry
        {
            get { return _warCry; }
            private set
            {
                if (value != null) _warCry = value;
            }
        }

        public string DieCry
        {
            get { return _dieCry; }
            private set
            {
                if (value != null) _dieCry = value;
            }
        }

        private string TypeText
        {
            get
            {
                switch ((int)Type)
                {
                    case 1:
                        return "Гоблин";
                    case 2:
                        return "Урод";
                    case 3:
                        return "Зомби";
                    case 4:
                        return "Прирак";
                    case 5:
                        return "Орк";
                    case 6:
                        return "Банши";
                    case 7:
                        return "Демон";
                    case 8:
                        return "Вампир";
                    case 9:
                        return "Дракон";
                    default:
                        return "Ошибка, неверный тип монстра";
                }
            }
        }

        public bool IsDead
        {
            get
            {
                if (HP > 0) return false;
                else return true;
            }
        }

        public string GetInfo
        {
            get
            {
                return $"Монстр: {TypeText}, Имя: {Name}, Всего HP: {MaxHP}, Урон: {MinAttack} - {MaxAttack}.";
            }
        }

        public Monster()
        {
            Type = (MonsterType)random.Next(1, 10);
            Name = TypeText;
            _max_HP = (int)Type * 50;
            HP = MaxHP;
            MinAttack = random.Next(1, 11);
            MaxAttack = random.Next(20, 101);
            WarCry = "РААААВР!";
            DieCry = "Эээ-э-э-э...";
        }

        public Monster(string name, MonsterType type, int minAttack, int maxAttack, string warCry, string dieCry)
        {
            Name = name;
            Type = type;
            _max_HP = (int)type * 50;
            HP = MaxHP;
            MinAttack = minAttack;
            MaxAttack = maxAttack;
            WarCry = warCry;
            DieCry = dieCry;
        }

        public int GetAttack()
        {
            return random.Next(MinAttack, MaxAttack + 1) + random.Next(0, 11);
        }

        public void Wounds(int damage)
        {
            if ((HP - damage) > 0) HP -= damage;
            else if ((HP - damage) <= 0) HP = 0;
        }

        public void Heal()
        {
            HP = MaxHP;
        }
    }
}
