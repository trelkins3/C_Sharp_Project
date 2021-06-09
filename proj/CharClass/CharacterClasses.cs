using System;

namespace CharClass
{
    public class Job
    {
        public int HPPerLevel;
        public int AttackPerLevel;
        public int SkillPerLevel;
        public Job () //constructor
        {
            HPPerLevel = 10;
            AttackPerLevel = 1;
            SkillPerLevel = 1;
        }
    }
    public class Fighter : Job
    {
        public Fighter(int HP, int Att, int Sk) //constructor 
        {
            HPPerLevel = HP;
            AttackPerLevel = Att;
            SkillPerLevel = Sk;
        }
        public int DamageBonus()
        {
            return AttackPerLevel + SkillPerLevel;
        }

    }
    public class CharacterClasses
    {
    }
}
