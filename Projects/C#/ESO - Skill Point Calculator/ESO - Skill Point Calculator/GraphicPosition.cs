using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ESO___Skill_Point_Calculator
{
    class GraphicPosition
    {
        // Location
        public Point[][] Location;

        // Size
        public Size[][] Size;

        public GraphicPosition()
        {
            Location = new Point[][]
            {
                new Point[]
                {
                    // Menu
                    new Point(89, 224),
                    // Class
                    new Point(325, 200),
                    // Reset Tree
                    new Point(410, 169),
                    new Point(615, 169),
                    new Point(823, 169)
                }
            };
            Size = new Size[][]
            {
                new Size[]
                {
                    // Menu
                    new Size(133, 26), // dragonknight
                    new Size(98, 26),  // sorcerer
                    new Size(115, 26), // nightblade
                    new Size(90, 26),  // templar
                    // Class
                    new Size(619, 484),
                    // Reset Tree
                    new Size(28, 25)
                }
            };
        }
    }
}
