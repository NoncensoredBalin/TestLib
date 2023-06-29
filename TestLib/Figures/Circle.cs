using TestLib.Interface;

namespace TestLib
{
    public class Circle : IFigure
    {
        private double radius;

        Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}