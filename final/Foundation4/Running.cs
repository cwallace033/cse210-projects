using System.ComponentModel.DataAnnotations;

class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance)
    : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return _minutes / _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _minutes * 60;
    }

    public override string GetSummary()
    {
        return $"Date: {_date} Running {_minutes} minutes Distance: {_distance} miles, Speed: {GetSpeed():F1} mph, Pace {GetPace():F1} min per mile";
    }

}