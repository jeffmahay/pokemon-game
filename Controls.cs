using System;
using System.Collections.Generic;
using System.Linq;

class Controls: PokeDex
{
    Cast cast = new Cast();

    public int keys()
    {
        int key = 0; 

        if(IsKeyDown("a") == true)
        {
            key = 1;
        }
        else if(IsKeyDown("d") == true)
        {
            key = 2;
        }
        return key;
    }

    public IStats getDefender(Dictionary<IStats, int> pkmList)
    {
        MissingNo missingNo = new MissingNo();
        IStats defender = missingNo;

        if(IsKeyDown("j") == true)
        {
            defender = pkmList.ElementAt(0).Key;
        }
        else if(IsKeyDown("i") == true)
        {
            defender = pkmList.ElementAt(1).Key;
        }
        return defender;
    }
}