﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math2D
{
    // Abstract class shape
    public abstract class Shape
    {
        // not sure if this is needed or not yet, probably to be reworked TODO
        public enum Result
        {
            overlaps = 0,
            contains,
            outside
        }
        // Abstract methods for shapes
        public abstract bool isColliding(Polygon polygon);
        public abstract bool isColliding(Circle circle);
        public abstract bool isContained(Polygon polygon);
        public abstract bool isContained(Circle circle);
        public abstract void resizeOriginal(double percentage);
        public abstract void resizeCurrent(double percentage);
        public abstract void changePosition(double x, double y);

    }
}
