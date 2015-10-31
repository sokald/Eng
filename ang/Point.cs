using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ang
{
    class Point
    {
        int x, y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point()
        {
            x = y = 0;
        }

        public Point(int X, int Y)
        {
            x = X;
            y = Y;
        }
    }
}
