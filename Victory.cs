class Victory : Pokemon
{
    public string? checkGameOver()
    {
        string? winner = "";   
        foreach(KeyValuePair<IStats, int> i in sortDic())
        {
            if(i.Value == 0)
            {
              if(GetEnemyDic().ContainsKey(i.Key))
              {
                winner = "player";
              }
              else if(GetPlayerDic().ContainsKey(i.Key))
              {
                winner = "computer";
              }  
            }
            else
            {
                winner = null;
            }
        }
        return winner;
    }
    public bool? checkVictory(string winner)
    {
        if(winner == "player")
        {
            return true;
        }
        else if(winner == "computer")
        {
            return false;
        }
        else
        {
            return null;
        }
    }
}