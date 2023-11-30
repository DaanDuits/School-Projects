using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    class ConsoleMon
    {
        public int health;
        public int energy;
        public string name;

        public List<Skill> skills;

        public Skill.Elements weakness;

        public void TakeDamage(int damage)
        {
            health -= damage;
        }
        public void DeleteEnergy(int energy)
        {
            this.energy -= energy;
        }

        internal ConsoleMon()
        {
            
        }

        internal ConsoleMon(ConsoleMon copyFrom)
        {
            this.health = copyFrom.health;
            this.energy = copyFrom.energy; 
            this.name = copyFrom.name;
            foreach(Skill skill in copyFrom.skills)
            {
                this.skills.Add(new Skill(skill));
            }
            this.weakness = copyFrom.weakness;
        }
    }
}
