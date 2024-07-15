class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int minutes, double speed)
    : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * _minutes / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override string GetSummary()
    {
        return $"Date: {_date} Cycling {_minutes} minutes Distance: {GetDistance():F1} miles, Speed: {_speed} mph, Pace {GetPace():F1} min per mile";
    }
}