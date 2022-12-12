using System;
using System.Collections;
using System.Linq;

class Program : GUI
{
    static void Main()
    {
        GUI gui = new GUI();
        Cast cast = new Cast();

        Hitmonchan hitmonchan = new Hitmonchan();
        Hitmonlee hitmonlee = new Hitmonlee();
        Hitmontop hitmontop = new Hitmontop();
        Pokemon pokemon = new Pokemon();
        Victory victory = new Victory();

        // string? winner = null;
        // string victoryText = "";

        cast.addList(hitmonchan);
        cast.addList(hitmonlee);

        cast.addEnemyList(hitmonchan);

        cast.addPlayerList(hitmonlee);

        // while(victory.checkGameOver() == null)
        // {
        //     pokemon.battle();
        //     winner = victory.checkGameOver();
        // }
        // if(victory.checkVictory(winner) == true)
        // {
        //     victoryText = "Congrats, you win!";
        // }
        // else if(victory.checkVictory(winner) == false)
        // {
        //     victoryText = "You lose!";
        // }


        gui.generateWindow(cast.sortDic());
    }
}
