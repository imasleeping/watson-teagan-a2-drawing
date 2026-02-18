// Include the namespaces (code libraries) you need below.
using Raylib_cs;
using System;
using System.ComponentModel;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {   
        Color Drawcolor = Color.Blue;
        float brushsize = 13;
        Color pink = new Color(250,150,150);
        int colorpickerpos = 900;
        Color[] colarray = [Color.Black,Color.Blue,Color.Green,Color.Yellow];
        public void Setup()
        {
            // button graphics
            Window.SetSize(1000, 1000);
            Window.ClearBackground(Color.White);
            Draw.FillColor = Color.OffWhite;
            Draw.Rectangle(0, -20, 150, 2000);
            Draw.FillColor = Color.White;
            Draw.Capsule(60, 500, 60, 200, 45);
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.Black;
            Draw.Circle(60, 450, 25);
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.White;
            Draw.Square(20, 50, 80);
            Draw.LineColor = pink;
            Draw.FillColor = pink;
            Draw.Rectangle(25, 70, 70, 40);
            Draw.LineColor = pink;
            Draw.FillColor = pink;
            for (int i = 0; i <= 3; i ++)
            {
                Draw.LineColor = Color.Black;
                Draw.FillColor = colarray[i];
                Draw.Square(20, colorpickerpos, 80);
                colorpickerpos -= 100;
            }
        }
        public void Update()
        {
            if (Input.IsMouseButtonDown(MouseInput.Left))
                {
                float mousex = Input.GetMouseX();
                float mousey = Input.GetMouseY();
                // color change buttons
                if (mousey >= 600 && mousey <= 700 && mousex <= 100)
                {
                    Drawcolor = Color.Yellow;
                }
                if (mousey >= 700 && mousey <= 800 && mousex <= 100)
                {
                    Drawcolor = Color.Green;
                }
                if (mousey >= 800 && mousey <= 900 && mousex <= 100)
                {
                    Drawcolor = Color.Blue;
                }
                if (mousey >= 900 && mousey <= 1000 && mousex <= 100)
                {
                    Drawcolor = Color.Black;
                }
                // sizeslider
                if (mousey >= 200 && mousey <= 500 && mousex <= 100)
                {
                    brushsize = mousey/ 18;
                    Draw.FillColor = Color.White;
                    Draw.LineColor = Color.Black;
                    Draw.Capsule(60, 500, 60, 200, 45);
                    Draw.FillColor = Color.Black;
                    Draw.LineColor = Color.Black;
                    Draw.Circle( 60,mousey, mousey / 18);
                }
                //erase selector
                if (mousey >= 50 && mousey <= 150 && mousex <= 100)
                {
                    Drawcolor = Color.White;
                }
                // draw
                if (mousex > 150)
                {

                Draw.LineColor = Drawcolor;
                Draw.FillColor = Drawcolor;
                    Draw.Circle(mousex, mousey,brushsize);
                }


            }
        }
    }

}
