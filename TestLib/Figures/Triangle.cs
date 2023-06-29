using TestLib.Interface;

namespace TestLib
{
    public class Triangle : IFigure
    {
        private double angle;

        private double sideA, sideB;

        Triangle(double sideA, double sideB, double angle)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.angle = angle;
        }

        public double GetArea()
        {
            if (angle <= 0 || angle >= 180)
            {
                throw new Exception("It is not Triangle");
            }
            if (angle == 90)
            {
                return 0.5 * sideA * sideB;
            }
            return 0.5 * sideA * sideB * Math.Sin(angle);
        }
    }
}