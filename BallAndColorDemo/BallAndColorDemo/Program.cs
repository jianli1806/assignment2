using System;

namespace BallAndColorDemo
{
    // Color class
    public class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        // Constructor with all values
        public Color(int red, int green, int blue, int alpha)
        {
            this.red = Clamp(red);
            this.green = Clamp(green);
            this.blue = Clamp(blue);
            this.alpha = Clamp(alpha);
        }

        // Constructor with default alpha
        public Color(int red, int green, int blue) : this(red, green, blue, 255)
        {
        }

        // Getters and setters
        public int Red
        {
            get => red;
            set => red = Clamp(value);
        }

        public int Green
        {
            get => green;
            set => green = Clamp(value);
        }

        public int Blue
        {
            get => blue;
            set => blue = Clamp(value);
        }

        public int Alpha
        {
            get => alpha;
            set => alpha = Clamp(value);
        }

        // Grayscale value (average of red, green, blue)
        public int GetGrayscale()
        {
            return (red + green + blue) / 3;
        }

        // Helper to keep values in 0-255
        private int Clamp(int value)
        {
            return Math.Max(0, Math.Min(255, value));
        }

        public override string ToString()
        {
            return $"Color(R:{red}, G:{green}, B:{blue}, A:{alpha})";
        }
    }

    // Ball class
    public class Ball
    {
        private int size;
        private Color color;
        private int throwCount;

        public Ball(int size, Color color)
        {
            this.size = size;
            this.color = color;
            this.throwCount = 0;
        }

        public int Size
        {
            get => size;
            set => size = value;
        }

        public Color BallColor
        {
            get => color;
            set => color = value;
        }

        // Pop method
        public void Pop()
        {
            size = 0;
        }

        // Throw method
        public void Throw()
        {
            if (size > 0)
            {
                throwCount++;
            }
        }

        // Get throw count
        public int GetThrowCount()
        {
            return throwCount;
        }

        public override string ToString()
        {
            return $"Ball(Size:{size}, Color:{color}, Throws:{throwCount})";
        }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            // Create colors
            var red = new Color(255, 0, 0);
            var green = new Color(0, 255, 0, 200);
            var blue = new Color(0, 0, 255);

            // Create balls
            var ball1 = new Ball(10, red);
            var ball2 = new Ball(15, green);
            var ball3 = new Ball(20, blue);

            // Throw balls
            ball1.Throw();
            ball1.Throw();
            ball2.Throw();
            ball3.Throw();
            ball3.Throw();
            ball3.Throw();

            // Pop ball2 and ball3
            ball2.Pop();
            ball3.Pop();

            // Try to throw popped balls
            ball2.Throw();
            ball3.Throw();

            // Print results
            Console.WriteLine("Ball 1: " + ball1);
            Console.WriteLine("Ball 2: " + ball2);
            Console.WriteLine("Ball 3: " + ball3);

            // Print grayscale of colors
            Console.WriteLine($"Ball 1 Color Grayscale: {ball1.BallColor.GetGrayscale()}");
            Console.WriteLine($"Ball 2 Color Grayscale: {ball2.BallColor.GetGrayscale()}");
            Console.WriteLine($"Ball 3 Color Grayscale: {ball3.BallColor.GetGrayscale()}");
        }
    }
}
