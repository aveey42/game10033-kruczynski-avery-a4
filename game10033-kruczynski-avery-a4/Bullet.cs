using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace MohawkGame2D
{
    public class Bullet
    {
        public int radius;
        public Vector2 position;
        public Vector2 velocity;
        public Bullet(int radius, Vector2 position, Vector2 velocity) 
        {
            this.radius = radius;
            this.position = position;
            this.velocity = velocity;
        }
        public void Movement()
        {
            position += velocity * Time.DeltaTime;
        }
        public void DrawBullet()
        {
            Draw.LineSize = 0;
            Draw.FillColor = Color.White;
            Draw.Circle(position, 5);
        }
        public void Update()
        {
            DrawBullet();
            Movement();
        }

    }
}