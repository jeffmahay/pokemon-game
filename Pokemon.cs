using System;
using System.Collections.Generic;
using System.Linq;

class Pokemon : Cast
{   
    Random random = new Random(); 
    Controls control = new Controls(); 
    Calculations calc = new Calculations();

    MissingNo missingNo = new MissingNo();  
    public void pokeActions()
    {   
        foreach(KeyValuePair<IStats, int> i in sortDic())
        {
            IStats attacker = i.Key;
            bool over = false;
            int whichtype = control.keys();
            int playerIndex = random.Next(GetPlayerDic().Count());
            IStats defender =   missingNo;

            while(over != false)
            {
                if(GetEnemyDic().ContainsKey(attacker))
                {
                    whichtype = random.Next();
                    defender = GetPlayerDic().ElementAt(playerIndex).Key;
                }
                switch (whichtype)
                {
                    case 1:
                        defender = control.getDefender(GetEnemyDic());
                        int damage = calc.attackDmg(attacker, defender);
                        sortDic()[defender] = sortDic()[defender] - damage;
                        over = true;
                        break;
                    case 2:
                        over = true;
                        break;
                } 
            }
        } 
    }
}