using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{

        public class cheater : Character
        {
            public cheater(int hp, int mana, int armor, int force, double evasion)
            {
                this.Hp = hp;
                this.Mana = mana;
                this.Armor = armor;
                this.Force = force;
                this.Evasion = evasion;
            }
            public override double Evasion
            {
                get
                {
                    return base.Evasion;
                }
                set
                {
                    base.Evasion = value;
                }
            }
            public override string Skill1(List<Character> targets)
            {
                if (this.Mana >= 020)
                {
                    Armor += 2;
                    Mana = Mana - 20;
                    return "Я забираю твой армор!";
                }
                else
                {
                    return "not enough mana";
                }
            }
        }
    }
