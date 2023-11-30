using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    class Skill
    {
        public int damage;
        public int energyCost;
        public string name;

        public Elements element;

        void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DeleteEnergy(energyCost);
            target.TakeDamage(damage);
        }
        public enum Elements
        {
            fire,
            poison,
            dark,
            electric,
            grass,
            water
        }
        internal Skill()
        {

        }
        internal Skill(Skill other)
        {
            this.damage = other.damage;
            this.energyCost = other.energyCost;
            this.name = other.name;
            this.element = other.element;
        }
    }
}