using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation.Models;

public class Circle
{
    private const double PI = 3.14;

    public double AreaCal(double halfDiameter)
    {
        return PI * (halfDiameter * halfDiameter);
    }

    public double PerimeterCal(double halfDiameter) => 2 * PI * halfDiameter;
}
