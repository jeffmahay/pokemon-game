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

    public Texture2D TopImg()
    {
        var image = Raylib.LoadImage("images/hitmontop (1).png");
        Texture2D texture = Raylib.LoadTextureFromImage(image);
        Raylib.UnloadImage(image);

        return texture;
    }

    public void generateWindow(Dictionary<IStats, int> castList)
    {
        Raylib.InitWindow(screenWidth, screenHeight, "POKEMON");
        Raylib.SetTargetFPS(12);

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);

            Raylib.DrawTexture(background(), 2, 0,Color.WHITE);
            Raylib.DrawTexture(LeeImg(), 170, 312,Color.WHITE);
            Raylib.DrawTexture(ChanImg(), 450, 100,Color.WHITE);
            Raylib.DrawTexture(TopImg(), 650, 150,Color.WHITE);



            




            Raylib.EndDrawing();
        }
    }
}