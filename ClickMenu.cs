﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eridanus
{
    class ClickMenu
    {
        public BaseObj obj; //top left corner of box, location of planet or craft
        public Rectangle hitbox;
        public List<String> text;   //caption for each line
        public static Color color = new Color(117, 226, 247, 180), ordColor = new Color(242, 216, 87), boxColor = new Color(143, 252, 226, 180);
        public static int width = 200, height = 50;

        public ClickMenu(BaseObj b)
        {
            obj = b;
            text = new List<string>();
            text.Add("Enter Orbit");
            text.Add("Land on Surface");
            text.Add("Survey");
            text.Add("Load Cargo");
            text.Add("Unload Cargo");
            hitbox = new Rectangle((int)obj.loc.X, (int)obj.loc.Y, width + 10, (height * (text.Count + 5) + 5));
        }

        public void draw(SpriteBatch s)
        {
            hitbox = new Rectangle((int)obj.loc.X, (int)obj.loc.Y, width + 10, (height * (text.Count + 5) + 5));
            Primitives2D.FillRectangle(s, hitbox, color);
            s.DrawString(default, "Orders", position: new Vector2((int)hitbox.X, (int)hitbox.Y), ordColor);
            float x = hitbox.X+5;
            float y = hitbox.Y+5;

            for (int i = 0; i < text.Count; i++)
            {
                if (i % 2 == 1)
                {
                    Primitives2D.FillRectangle(s, new Rectangle((int)x, (int)y, width, height), boxColor);
                }
                s.DrawString(default, text[i], position: new Vector2((int)x,(int)y), Color.White);
                y -= height + 5;
            }
        }

        public Boolean checkClick(Vector2 click)
        {

            return false;
        }
    }
}
