
class Cylinder
{
    private Circle _circle;

    private double _height;

    public void SetCircle(Circle circle)
    {
        _circle = circle;

    }

    public void SetHeight (double height)
    {
        _height = height;
    }

    public double GetVolume()
    {
        return _circle.GetArea() * _height;

        //double radius = _circle.GetRadius();
        //return Math.PI * radius * radius * _height;
    }



}