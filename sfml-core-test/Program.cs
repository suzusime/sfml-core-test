using System;
using SFML;
using SFML.Window;
using SFML.Graphics;

namespace sfml_core_test
{
    class Program
    {
        static void Main(string[] args)
        {
            RenderWindow window = new RenderWindow(new VideoMode(640, 400), "hoge");
            CircleShape shape = new CircleShape(100.0f);
            shape.FillColor = new Color(255, 0, 0);

            window.Closed += (sender, e) => window.Close();

            while (window.IsOpen)
            {
                window.DispatchEvents();

                window.Clear();

                window.Draw(shape);

                window.Display();
            }
        }
    }
}
