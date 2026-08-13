class RemoteControlCar
{
    private int _metersDriven = 0;
    private int _batteryPercentage = 100;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {_metersDriven.ToString()} meters";

    public string BatteryDisplay()
    {
        if (_batteryPercentage == 0) 
        {
            return "Battery empty";
        }
        else
            return $"Battery at {_batteryPercentage.ToString()}%";
    }

    public void Drive()
    {
        if (_batteryPercentage > 0)
        {
            _metersDriven += 20;
            _batteryPercentage -= 1;
        }
    }
}
