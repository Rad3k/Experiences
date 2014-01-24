using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ESO___Skill_Point_Calculator
{
    class GraphicPosition
    {
        // Location
        public int[][][] Location;

        // Size
        public int[][][] Size;

        public GraphicPosition()
        {
            Location = new int[][][]
            {
                new int[][]
                {
                    // Menu
                    new int[89],
                    // Class
                    new int[325],
                    // Reset Tree
                    new int[410],
                    new int[615],
                    new int[823]
                },
                new int[][]
                {
                    // Menu
                    new int[223],
                    // Class
                    new int[200],
                    // Reset Tree
                    new int[169],
                    new int[169],
                    new int[169]
                }
            };
            Size = new int[][][]
            {
                new int[][]
                {
                    // Menu
                    new int[133],
                    // Class
                    new int[619],
                    // Reset Tree
                    new int[28]
                },
                new int[][]
                {
                    // Menu
                    new int[26],
                    // Class
                    new int[484],
                    // Reset Tree
                    new int[25]
                }
            };
        }
    }
}
