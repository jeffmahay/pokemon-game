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

        cast.addList(hitmonchan);
        cast.addList(hitmonlee);
        cast.addList(hitmontop);

        cast.addEnemyList(hitmonchan);
        cast.addEnemyList(hitmontop);

        cast.addPlayerList(hitmonlee);

        gui.generateWindow(cast.GetEnemyDic());
    }
}
