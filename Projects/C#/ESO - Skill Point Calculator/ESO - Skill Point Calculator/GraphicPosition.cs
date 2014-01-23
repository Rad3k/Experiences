using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ESO___Skill_Point_Calculator
{
    class GraphicPosition
    {
        // Location
        public int[][,] Location;

        // Size
        public int[][,] Size;

        public GraphicPosition()
        {
            Location = new int[][,]
            {
                // Menu
                new int[89, 223],
                // Class
                new int[325, 200],
                // Reset Tree
                new int[410, 169],
                new int[615, 169],
                new int[823, 169]
            };
            Size = new int[][,]
            {
                // Menu
                new int[133, 26],
                // Class
                new int[619, 484],
                // Reset Tree
                new int[28,25]
            };
        }
    }
}
