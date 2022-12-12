using System;
using System.Collections.Generic;
using System.Linq;
using Raylib_cs;

class GUI : Victory
{  
     Pokemon pokemon = new Pokemon();
    Hitmonchan hitmonchan = new Hitmonchan();
    Hitmonlee hitmonlee = new Hitmonlee(); 
    Controls control = new Controls();
    Cast cast = new Cast();
    Calculations calc = new Calculations();

    public int screenHeight = 800;
    public int screenWidth = 900;



    public Texture2D background()
    {
        var image = Raylib.LoadImage("images/pkmbattle.resize.png");
        Texture2D texture = Raylib.LoadTextureFromImage(image);
        Raylib.UnloadImage(image);

        return texture;
    }

    public Texture2D LeeImg()
    {
        var image = Raylib.LoadImage("images/hitmonleeBack (1).png");
        Texture2D texture = Raylib.LoadTextureFromImage(image);
        Raylib.UnloadImage(image);

        return texture;
    }

    public Texture2D ChanImg()
    {
        var image = Raylib.LoadImage("images/hitmonchan (1).png");
        Texture2D texture = Raylib.LoadTextureFromImage(image);
        Raylib.UnloadImage(image);

        return texture;
    }

    // public Texture2D TopImg()
    // {
    //     var image = Raylib.LoadImage("images/hitmontop (1).png");
    //     Texture2D texture = Raylib.LoadTextureFromImage(image);
    //     Raylib.UnloadImage(image);

    //     return texture;
    // }

    public void generateWindow(Dictionary<IStats, int> castList)
    {
        Raylib.InitWindow(screenWidth, screenHeight, "POKEMON");
        Raylib.SetTargetFPS(12);

        IStats hitmonchan = castList.ElementAt(1).Key;
        int chanHealth = castList.ElementAt(1).Value;

        IStats hitmonlee = castList.ElementAt(0).Key;
        int leeHealth = castList.ElementAt(0).Value;
        

        while (!Raylib.WindowShouldClose())
        {   
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);

            if(control.keys() == 1)
            {
                chanHealth = chanHealth - calc.attackDmg(hitmonlee, hitmonchan);
            }
            if(control.keys() == 2)
            {
                leeHealth = leeHealth - calc.attackDmg(hitmonchan, hitmonlee);
            }

            Raylib.DrawTexture(background(), 2, 0,Color.WHITE);
            Raylib.DrawTexture(LeeImg(), 170, 312,Color.WHITE);
            Raylib.DrawTexture(ChanImg(), 450, 100,Color.WHITE);

            Raylib.DrawText($"{hitmonchan.Name()}: {chanHealth}/{hitmonchan.Health()}", 450, 80, 25, Color.BLACK);
            Raylib.DrawText($"{hitmonlee.Name()}: {leeHealth}/{hitmonlee.Health()}", 160, 320, 25, Color.BLACK);

            Raylib.DrawText(control.keys().ToString(), screenWidth/2, screenHeight/2, 25, Color.BLACK);

            Raylib.EndDrawing();
        }
    }
}