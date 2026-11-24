using System;
using System.Numerics;

namespace MohawkGame2D
{
    public class Player
    {
        Vector2 player;
        public float playerX;
        public float playerY;
        float playerWidth;
        float playerHeight;
        float playerSpeed;
        bool isPlayerAlive;

        public Player(int playerX, int playerY, float playerWidth, float playerHeight, bool isPlayerAlive, float playerSpeed)
        {
            this.playerX = playerX;
            this.playerY = playerY;
            this.playerWidth = playerWidth;
            this.playerHeight = playerHeight;
            this.isPlayerAlive = isPlayerAlive;
            this. playerSpeed = playerSpeed;
        }
        public void Setup()
        {
            player = Window.Size / 2;
            playerSpeed = 150;
        }
        public void Update()
        {
            DrawPlayer();
            Movement();
        }
        public void DrawPlayer()
        {
            // Draw Player
            Draw.SetFillColor(Color.Yellow);
            Draw.Rectangle(playerX,playerY,playerWidth,playerHeight);
        }
        public void Movement()
        {
            // Up
            if (Input.IsKeyboardKeyDown(KeyboardKey.W) && playerY > 0 || Input.IsKeyboardKeyDown(KeyboardKey.Up) && playerY > 0)
            {
                playerY -= playerSpeed * Time.DeltaTime;
            }

            // Down
            if (Input.IsKeyboardKeyDown(KeyboardKey.S) && playerY < 600 - playerHeight|| Input.IsKeyboardKeyDown(KeyboardKey.Down) && playerY < 800 - playerHeight)
            {
                playerY += playerSpeed * Time.DeltaTime;
            }

            // Left
            if (Input.IsKeyboardKeyDown(KeyboardKey.A) && playerX > 0 || Input.IsKeyboardKeyDown(KeyboardKey.Left) && playerX > 0)
            {
                playerX -= playerSpeed * Time.DeltaTime;
            }

            // Right
            if (Input.IsKeyboardKeyDown(KeyboardKey.D) && playerX < 800 - playerHeight || Input.IsKeyboardKeyDown(KeyboardKey.Right) && playerX < 800 + playerWidth)
            {
                playerX += playerSpeed * Time.DeltaTime;
            }
        }
        public void Collision()
        {
          
        }
    }
}


