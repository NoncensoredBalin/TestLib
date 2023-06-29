using TestLib.Interface;

namespace TestLib
{
    public class Triangle : IFigure
    {
        private double sideA, sideB, sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        private (double firstSide, double secondSide)? CheckSquare()
        {
            if (Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2))
            {
                return (sideA,sideB); 
            }
            if (Math.Pow(sideA, 2) + Math.Pow(sideC, 2) == Math.Pow(sideB, 2))
            {
                return (sideA, sideC);
            }
            if (Math.Pow(sideC, 2) + Math.Pow(sideB, 2) == Math.Pow(sideA, 2))
            {
                return (sideC, sideB);
            }
            return null;
        }

        public double GetArea()
        {
            var squareSides = CheckSquare();
            if (squareSides != null && squareSides.HasValue)
            {
                return 0.5 * squareSides.Value.firstSide * squareSides.Value.secondSide;
            }
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }
    }
}