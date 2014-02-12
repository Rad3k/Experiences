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
        public Point[][][] Location;

        // Size
        public Size[][] Size;

        public GraphicPosition()
        {
            Location = new Point[][][]
            {
                // Class structure
                new Point[][]
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
                    new Point[]              // Class spells
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
                        new Point(130, 72),
                        new Point(80, 157),
                        new Point(180, 157),
                        new Point(80, 222),
                        new Point(180, 222),
                        new Point(130, 282),
                        new Point(80, 367),
                        new Point(180, 367),
                        new Point(80, 437),
                        new Point(180, 437),
                    },
                    new Point[]              // minus
                    {
                        new Point(55, 72),
                        new Point(5, 157),
                        new Point(105, 157),
                        new Point(5, 224),
                        new Point(105, 224),
                        new Point(55, 284),
                        new Point(5, 367),
                        new Point(105, 367),
                        new Point(5, 437),
                        new Point(105, 437),
                    },
                    new Point[]              // Reset Tree
                    {
                        new Point(410, 169),
                        new Point(615, 169),
                        new Point(823, 169),
                    }
                },
                // Armor structure
                new Point[][]
                {
                    new Point[]
                    {
                        // Spells
                        new Point(80, 60),
                        new Point(30, 145),
                        new Point(130, 145),
                        new Point(30, 210),
                        new Point(130, 210),
                        new Point(80, 270),
                    },
                    new Point[]              // plus
                    {
                        new Point(130, 72),
                        new Point(80, 157),
                        new Point(180, 157),
                        new Point(80, 222),
                        new Point(180, 222),
                        new Point(130, 282),
                    },
                    new Point[]              // minus
                    {
                        new Point(55, 72),
                        new Point(5, 157),
                        new Point(105, 157),
                        new Point(5, 224),
                        new Point(105, 224),
                        new Point(55, 284),
                    }
                }
            };
            Size = new Size[][]
            {
                new Size[]
                {
                    // Menu
                    new Size(141, 26),   // dragonknight
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
                    new Size(23, 23),    // plus / minus
                }
            };
        }
    }
}
