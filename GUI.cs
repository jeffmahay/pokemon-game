using System;
using System.Collections.Generic;
using System.Linq;
using Raylib_cs;

class GUI : PokeDex
{
    public void generateWindow(Dictionary<IStats, int> castList)
    {
        Pokemon pokemon = new Pokemon();
        Hitmonchan hitmonchan = new Hitmonchan();
        Hitmonlee hitmonlee = new Hitmonlee(); 
        Controls control = new Controls();
        Cast cast = new Cast();

        var screenHeight = 800;
        var screenWidth = 900;

        Raylib.InitWindow(screenWidth, screenHeight, "POKEMON");
        Raylib.SetTargetFPS(12);

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);

            Raylib.DrawRectangle(0, 500, screenWidth, 300, Color.GRAY);
            Raylib.DrawRectangle(50, 525, 145, 60,Color.LIGHTGRAY);
            Raylib.DrawRectangle(705, 525, 145, 60,Color.LIGHTGRAY);
            Raylib.DrawText("test", 87, 548, 15, Color.BLACK);
            Raylib.DrawText("test", 740, 548, 15, Color.BLACK);
            Raylib.DrawRectangle(250, 250, 50, 50, Color.BLUE);
            // Raylib.DrawText($"{hitmonlee.Name()}: {}", 250, 255, 15, Color.BLACK);

            // // Raylib.DrawText(key, screenHeight/2, screenWidth/2, 25, Color.BLACK);
            // Raylib.DrawText(control.selectDefender().Name(), 50, 200, 15, Color.BLACK);
            // Raylib.DrawText($"HP: {turn().Item1}/{hitmonchan.Health()}", 87, 200, 15, Color.BLACK);
            // Raylib.DrawText($"HP: {turn().Item2}/{hitmonlee.Health()}", 300, 200, 15, Color.BLACK);



            Raylib.EndDrawing();
        }
    }
}