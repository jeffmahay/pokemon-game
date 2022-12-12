using System;
using System.Collections;
using System.Linq;

class Program : Pokemon
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

        foreach(KeyValuePair<IStats, int> i in cast.sortList())
        {
            Console.WriteLine($"Name:{i.Key.Name()}");
            Console.WriteLine($"Speed:{i.Key.Speed()}");
        }
    }
}
