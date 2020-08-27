using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    class SquareWall : RectangleWall
    {
        public SquareWall(string name, string color, int sideLength) : base(name, color, sideLength, sideLength)
        {
            SideLength = sideLength;
        }

        public int SideLength { get; }

        public override string ToString()
        {
            return $"{Name} ({SideLength}x{SideLength}) square";
        }
    }
}
