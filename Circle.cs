﻿using Math2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Math2D
{
    public class Circle : Shape
    {
        // Instance variables
        public Position position;
        public double radius;
        public double currentRadius;

        // Constructor
        public Circle(Position position, double radius) {
            this.position = position;
            this.radius = radius;
            this.currentRadius = radius;
        }

        // Method to check if shape is colliding with another shape
        public override bool isColliding(Polygon polygon)
        {
            polygon.updateVertices();
            Vector2[] closestVectors = polygon.getClosest(this.position.x, this.position.y);
            
            //for (int i = 0; i < closestVectors.Length; i++) { Console.WriteLine(closestVectors[i]); }        
            // TODO: make function and solve circle equation
            return true;
        }

        // Method to check if shape is colliding with another shape
        public override bool isColliding(Circle circle)
        {
            double dx = Math.Pow(this.position.x - circle.position.x, 2);
            double dy = Math.Pow(this.position.y - circle.position.y, 2);
            double distance = Math.Sqrt(dx + dy);

            if (this.radius + circle.radius >= distance) return true;

            return false;
        }

        // Method to check if shape is inside another shape
        public override bool isContained(Polygon polygon)
        {
            return true;
        }

        // Method to check if shape is inside another shape
        public override bool isContained(Circle circle)
        {
            if (this.radius == circle.radius) return false;

            double dx = Math.Pow(this.position.x - circle.position.x, 2);
            double dy = Math.Pow(this.position.y - circle.position.y, 2);
            double distance = Math.Sqrt(dx + dy);

            if (this.radius > circle.radius && this.radius > circle.radius + distance) return true;
            else if (circle.radius > this.radius + distance) return true;
            return false;
        }

        public override void resizeCurrent(double percentage)
        {
            this.currentRadius = percentage * this.currentRadius;
        }

        public override void resizeOriginal(double percentage)
        {
            this.currentRadius = percentage * this.radius;
        }

        public override void changePosition(double x, double y)
        {
            this.position = new Position(x, y);
        }

    }
}
