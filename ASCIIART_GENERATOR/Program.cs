using SkiaSharp;
using System;
using System.Drawing;


namespace ASCIIART_GENERATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ascii = new string[] { "#", "@", "%", "=", "+", "*", ":", "-", ".", " " };
           SKBitmap img = SKBitmap.Decode("breaking-bad-heisenberg-pin-128x128.png");
            for (int y=0; y<img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    SKColor color = img.GetPixel(x, y); 
                    int grayColor = (color.Red + color.Green + color.Blue) / 3;
                    int index = grayColor * 9 / 255;
                    Console.Write(ascii[index]);
                }

                Console.Write(Environment.NewLine);
            }
            Console.ReadKey();
        }
    }
}
