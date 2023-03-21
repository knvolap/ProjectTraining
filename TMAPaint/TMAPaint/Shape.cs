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
        public bool Is3D { get; set; }
        public int Depth { get; internal set; }

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

            if (Is3D)
            {
                // Draw a 3D rectangle with a gradient color
                using (var brush = new LinearGradientBrush(new Point(x, y), new Point(x, y + height), Color.White, Color.Gray))
                {
                    graphics.FillRectangle(brush, x, y, width, height);
                }
            }
            else
            {
                // Draw a 2D rectangle with a solid color
                using (var brush = new SolidBrush(Color))
                {
                    graphics.FillRectangle(brush, x, y, width, height);
                }
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
