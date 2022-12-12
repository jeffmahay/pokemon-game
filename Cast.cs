using System;
using System.Collections.Generic;
using System.Linq;

class Cast : PokeDex
{
    private Dictionary<IStats, int> castDic = new Dictionary<IStats, int>();
    private Dictionary<IStats, int> enemyDic = new Dictionary<IStats, int>();

    private Dictionary<IStats, int> playerDic = new Dictionary<IStats, int>();

    public void addList(IStats pokemon)
    {
        castDic.Add(pokemon, pokemon.Health());
    }

    public void addEnemyList(IStats pokemon)
    {
        enemyDic.Add(pokemon, pokemon.Health());
    }

    public void addPlayerList(IStats pokemon)
    {
        playerDic.Add(pokemon, pokemon.Health());
    }

    public Dictionary<IStats, int> GetEnemyDic()
    {
        return enemyDic;
    }

    public Dictionary<IStats, int> GetPlayerDic()
    {
        return playerDic;
    }

    public Dictionary<IStats, int> sortDic()
    {
        return castDic.OrderByDescending(v => v.Key.Speed()).ToDictionary(kvp=>kvp.Key,kvp=>kvp.Value);
    }
}
    