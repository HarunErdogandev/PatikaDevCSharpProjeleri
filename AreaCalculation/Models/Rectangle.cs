namespace AreaCalculation.Models;

public class Rectangle
{
    public double AreaCal(double longEdge,double shortEdge)
    {
        return longEdge * shortEdge;
    }
    public double PerimeterCal(double longEdge, double shortEdge)
    {
        double Area = 2 * (longEdge * shortEdge);

        return Area;
    }
}
