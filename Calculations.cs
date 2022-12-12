using System;
using System.Collections.Generic;
using System.Linq;

class Calculations : PokeDex
{
    public int attackDmg(IStats attacker, IStats defender)
    {
        int attack = attacker.Attack();
        int defence = defender.Defence();

        int damage = attack - defence;

        if(damage <= 0)
        {
            damage = 5;
        }

        return damage;
    }

}
