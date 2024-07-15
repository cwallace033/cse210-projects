using System.Diagnostics.Metrics;

class Swimming : Activity
{
    private int _laps;
    private double _lapLengthInMeters = 50;
    private double _metersToMiles = 0.000621371;



    public Swimming(string date, int minutes, int laps)
    : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * _lapLengthInMeters * _metersToMiles;
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }

    public override double GetSpeed()
    {
        return GetDistance() / _minutes * 60;
    }

    public override string GetSummary()
    {
        return $"Date: {_date} Swimming {_minutes} minutes Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace {GetPace():F1} min per mile";
    }
}