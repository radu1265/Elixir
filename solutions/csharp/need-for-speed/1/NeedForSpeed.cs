class RemoteControlCar
{
    private int speed;
    private int battery;
    private int batteryDrain;
    private int distanceDriven;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        this.distanceDriven = 0;
        this.battery = 100;
    }

    public bool BatteryDrained() => battery < batteryDrain;

    public int DistanceDriven()
    {
        return distanceDriven;
    }

    public void Drive()
    {
        Console.WriteLine(!BatteryDrained());
        Console.WriteLine(batteryDrain);
        if (!BatteryDrained())
        {
            distanceDriven += speed;
            battery -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            car.Drive();
            if (car.DistanceDriven() >= distance)
                return true;
        }
        return false;
    }
}
