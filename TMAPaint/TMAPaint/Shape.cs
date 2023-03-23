using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TMAPaint
{
    public abstract class Shape
    {
        public Point Position { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }

        public abstract void Draw(Graphics graphics);
    }
    
    // Rectangles class that inherits from Shape
    public class Rectangles : Shape
    {
        public override void Draw(Graphics graphics)
        {
            int x = Position.X;
            int y = Position.Y;
            int width = Size.Width;
            int height = Size.Height;

            using (var brush = new SolidBrush(Color))
            {
                graphics.FillRectangle(brush, x, y, width, height);
            }
        }
    }

    // Circle class that inherits from Shape
    public class Circle : Shape
    {
        public override void Draw(Graphics graphics)
        {
            int x = Position.X;
            int y = Position.Y;
            int diameter = Math.Min(Size.Width, Size.Height);

            using (var brush = new SolidBrush(Color))
            {
                graphics.FillEllipse(brush, x, y, diameter, diameter);
            }
        }
    }
}
