using System;
using SFML;
using SFML.Window;
using SFML.Graphics;
using SFML.System;
using SFML.Audio;

namespace sfml_core_test
{
    class Program
    {
        static void Main(string[] args)
        {
            ContextSettings contextSettings = new ContextSettings()
            {
                AntialiasingLevel = 16,
            };
            RenderWindow window = new RenderWindow(new VideoMode(1024, 768), "きりたん～", Styles.Close, contextSettings);
            Font font = new Font("mplus-2p-light.ttf");
            string textData = "進捗どうですか？";
            Text text = new Text(textData, font, 40);
            text.Position = new Vector2f(100, 275);
            RectangleShape shape = new RectangleShape(new Vector2f(400f, 200f));
            shape.FillColor = new Color(125, 140, 100);
            shape.Position = new Vector2f(50, 200);
            Image image = new Image("zzm_a1zunko32.png");
            Texture texture = new Texture(image);
            Sprite sprite = new Sprite(texture);
            sprite.Scale = new Vector2f(0.5f, 0.5f);
            Music music = new Music("NtP 11 Music Box Gardener.ogg");
            music.Play();

            window.Closed += (sender, e) => window.Close();
            window.TextEntered += (sender, e) =>
            {
                if (e.Unicode == "\b")
                {
                    if (textData.Length > 0)
                    {
                        textData = textData.Substring(0, textData.Length - 1);
                    }
                    text = new Text(textData, font, 40);
                    text.Position = new Vector2f(100, 275);
                }
                else if(e.Unicode == "\r")
                {
                    textData += "\n";
                    text = new Text(textData, font, 40);
                    text.Position = new Vector2f(100, 275);
                }
                else
                {
                    textData += e.Unicode;
                    text = new Text(textData, font, 40);
                    text.Position = new Vector2f(100, 275);
                }
            };
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
