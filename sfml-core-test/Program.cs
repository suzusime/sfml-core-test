using System;
using SFML;
using SFML.Window;
using SFML.Graphics;
using SFML.System;

namespace sfml_core_test
{
    class Program
    {
        static void Main(string[] args)
        {
            RenderWindow window = new RenderWindow(new VideoMode(1024, 768), "きりたん～");
            Font font = new Font("mplus-2p-light.ttf");
            Text text = new Text("進捗どうですか？", font, 40);
            text.Position = new Vector2f(100, 275);
            RectangleShape shape = new RectangleShape(new Vector2f(400f, 200f));
            shape.FillColor = new Color(125, 140, 100);
            shape.Position = new Vector2f(50, 200);
            Image image = new Image("zzm_a1zunko32.png");
            Texture texture = new Texture(image);
            Sprite sprite = new Sprite(texture);

            window.Closed += (sender, e) => window.Close();
            sprite.Position = new Vector2f(350, 20);

            while (window.IsOpen)
            {
                window.DispatchEvents();

                window.Clear();

                window.Draw(shape);

                window.Draw(sprite);

                window.Draw(text);

                window.Display();
            }
        }
    }
}
