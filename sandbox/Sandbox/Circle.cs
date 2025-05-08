class Circle
{
    private double _radius;

    public void SetRadius(double radius)
    {
        _radius = radius;
        if (radius < 0)
        {
            Console.WriteLine("Error, radius must be > 0");
        }
    }

    public double GetRadius()
    {
        return _radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }

}