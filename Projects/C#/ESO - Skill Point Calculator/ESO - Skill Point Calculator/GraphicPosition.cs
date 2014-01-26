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
                    // Button information
                    new Point(8, 45), // ultimate
                    new Point(8, 130), // active
                    new Point(8, 335), // passive
                },
                new Point[]              // Spells
                {
                    // Spells
                    new Point(80, 60),
                    new Point(30, 145),
                    new Point(130, 145),
                    new Point(30, 210),
                    new Point(130, 210),
                    new Point(80, 270),
                    new Point(30, 355),
                    new Point(130, 355),
                    new Point(30, 425),
                    new Point(130, 425),
                },
                new Point[]              // plus
                {
                    new Point(135, 75),
                    new Point(85, 160),
                    new Point(185, 160),
                    new Point(85, 225),
                    new Point(185, 225),
                    new Point(135, 285),
                    new Point(85, 370),
                    new Point(185, 370),
                    new Point(85, 440),
                    new Point(185, 440),
                },
                new Point[]              // minus
                {
                    new Point(60, 82),
                    new Point(10, 167),
                    new Point(110, 167),
                    new Point(10, 232),
                    new Point(110, 232),
                    new Point(60, 292),
                    new Point(10, 377),
                    new Point(110, 377),
                    new Point(10, 447),
                    new Point(110, 447),
                },
                new Point[]              // Reset Tree
                {
                    new Point(410, 169),
                    new Point(615, 169),
                    new Point(823, 169),
                }
            };
            Size = new Size[][]
            {
                new Size[]
                {
                    // Menu
                    new Size(133, 26),   // dragonknight
                    new Size(98, 26),    // sorcerer
                    new Size(115, 26),   // nightblade
                    new Size(90, 26),    // templar
                    // Class
                    new Size(619, 484),
                    // Reset Tree
                    new Size(28, 25),
                    // Button information
                    new Size(52, 8),     // ultimate
                    new Size(39, 8),     // active / passive
                    // Spells
                    new Size(45, 44),
                    // Manipulate Button
                    new Size(15, 15),    // plus 
                    new Size(12, 3)      // minus
                }
            };
        }
    }
}
