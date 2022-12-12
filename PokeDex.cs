using System;
using System.Collections.Generic;
using System.Linq;

class PokeDex : KeyboardService
{
        public  interface IStats
    {
        string Name();
        int Health();
        int Attack();
        int Defence();
        int SpecAttack();
        int SpecDefence();
        int Speed();
    }
        
    public class Hitmonchan : IStats
    {
        public string Name()
        {
            return "Hitmonchan";
        }
        
        public int Health()
        {
            return 221;
        }
        public int Attack()
        {
            return 105;
        }
        public int Defence()
        {
            return 79;
        }
        public int SpecAttack()
        {
            return 35;
        }
        public int SpecDefence()
        {
            return 110;
        }
        public int Speed()
        {
            return 76;
        }
    }

    public class Hitmonlee : IStats
    {
        public string Name()
        {
            return "Hitmonlee";
        }
        
        public int Health()
        {
            return 224;
        }
        public int Attack()
        {
            return 120;
        }
        public int Defence()
        {
            return 53;
        }
        public int SpecAttack()
        {
            return 35;
        }
        public int SpecDefence()
        {
            return 110;
        }
        public int Speed()
        {
            return 87;
        }
    }
    
    public class Hitmontop : IStats
    {
        public string Name()
        {
            return "Hitmontop";
        }
        
        public int Health()
        {
            return 241;
        }
        public int Attack()
        {
            return 95;
        }
        public int Defence()
        {
            return 95;
        }
        public int SpecAttack()
        {
            return 35;
        }
        public int SpecDefence()
        {
            return 110;
        }
        public int Speed()
        {
            return 70;
        }
    }

    public class MissingNo : IStats
    {
         public string Name()
        {
            return "";
        }
        
        public int Health()
        {
            return 0;
        }
        public int Attack()
        {
            return 0;
        }
        public int Defence()
        {
            return 0;
        }
        public int SpecAttack()
        {
            return 0;
        }
        public int SpecDefence()
        {
            return 0;
        }
        public int Speed()
        {
            return 0;
        }
    }
}