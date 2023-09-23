using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder.Models
{
    public class Pokemon : IClassModel
    {
        public int Id { get; set; }
        public int DexNumber { get; set; }
        public string Name { get; set; }
        public string Form { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public int Total { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }
        public int Generation { get; set; }

        public Pokemon()
        {
            DexNumber = 0;
            Name = string.Empty;
            Form = string.Empty;
            Type1 = string.Empty;
            Type2 = string.Empty;
            Total = 0;
            HP = 0;
            Attack = 0;
            Defense = 0;
            SpecialAttack = 0;
            SpecialDefense = 0;
            Speed = 0;
            Generation = 0;
        }
        public Pokemon(int dexNumber, string name, string form, string type1, string type2, int total, int hp, int attack, int defense, int specialAttack, int specialDefense, int speed, int generation)
        {
            DexNumber = dexNumber;
            Name = name;
            Form = form;
            Type1 = type1;
            Type2 = type2;
            Total = total;
            HP = hp;
            Attack = Attack;
            Defense = Defense;
            SpecialAttack = SpecialAttack;
            SpecialDefense = SpecialDefense;
            Speed = speed;
            Generation = generation;
        }
        public Pokemon(Pokemon poke)
        {
            DexNumber = poke.DexNumber;
            Name = poke.Name;
            Form = poke.Form;
            Type1 = poke.Type1;
            Type2 = poke.Type2;
            Total = poke.Total;
            HP = poke.HP;
            Attack = poke.Attack;
            Defense = poke.Defense;
            SpecialAttack = poke.SpecialAttack;
            SpecialDefense = poke.SpecialDefense;
            Speed = poke.Speed;
            Generation = poke.Generation;
        }
    }
}
