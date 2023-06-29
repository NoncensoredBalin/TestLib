using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib.Interface;

namespace TestLib
{
    public class AreaCounter
    {
        IFigure figure;
        public AreaCounter(IFigure figure) 
        {
            this.figure = figure;
        }

        public double CountArea()
        {
            return figure.GetArea();
        }
    }
}
