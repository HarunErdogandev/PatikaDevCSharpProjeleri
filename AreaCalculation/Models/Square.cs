namespace AreaCalculation.Models;

public class Square:IBaseShape
{
    public double AreaCal(double a)
    {
        return a * a;
    }
    public double PerimeterCal(double a)
    {

        return a * 4;
    }


}
