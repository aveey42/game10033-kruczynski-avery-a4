// Include the namespaces (code libraries) you need below.
using System;
using System.Collections.Generic;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{

    public class Game
    {
        // Variables
        List<Bullet> bullets = new List<Bullet>
        {
            // Top Left Pattern 1
                // Right - Left = -x,0
                // Left - Right = x,0
                // Top - Bottom = 0,y
                // Bottom - Top = 0,-y
            new Bullet(10, new Vector2(0,0), new Vector2(100,100)),
        };
        Player user = new Player(400, 300, 20, 20, true, 150f);
        public void Setup()
        {
            Window.SetTitle("Not Undertale");
            Window.SetSize(800, 600);
        }
        public void Update()
        {
            Window.ClearBackground(Color.Black);
            user.Update();

            for (int i = 0; i < bullets.Count; i++)
            {
                bullets[i].Update();
            }
        }
    }
}