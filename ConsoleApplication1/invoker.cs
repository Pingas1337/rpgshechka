using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{

    public class invoker : Character
    {
        public invoker(int hp, int mana, int armor, int force, double evasion)
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
                base.Evasion = (int)value;
            }
        }
        public override string Skill1(List<Character> targets)
    {
        if (this.Mana >= 120)
            {
                foreach (Character c in targets)
                {
                    c.Hp -= (this.Force = c.Armor);
                }
            Mana = Mana - 200;
            Hp = Hp - Force + Armor;
            return "Nichego";
        }
        else
        {
            return "not enough mana";
        }

        }
    }
}
