using System;
using System.Collections.Generic;
using System.Linq;

class Cast : PokeDex
{
    private Dictionary<IStats, int> castList = new Dictionary<IStats, int>();

    public void addList(IStats pokemon)
    {
        castList.Add(pokemon, pokemon.Health());
    }

    public Dictionary<IStats, int> sortList()
    {
        return castList.OrderByDescending(v => v.Key.Speed()).ToDictionary(kvp=>kvp.Key,kvp=>kvp.Value);
    }
}
    