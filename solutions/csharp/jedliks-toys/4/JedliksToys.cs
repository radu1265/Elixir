class RemoteControlCar
{
    private int MetersDriven = 0;
    private int BatteryPercentage = 100;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {MetersDriven.ToString()} meters";

    public string BatteryDisplay()
    {
        if (BatteryPercentage == 0) 
        {
            return "Battery empty";
        }
        else
            return $"Battery at {BatteryPercentage.ToString()}%";
    }

    public void Drive()
    {
        if (BatteryPercentage > 0)
        {
            MetersDriven += 20;
            BatteryPercentage -= 1;
        }
    }
}
