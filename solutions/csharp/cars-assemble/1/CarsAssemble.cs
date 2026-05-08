static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if(speed > 0 && speed < 5){
            return 1;
        } else if(speed > 4 && speed < 9){
            return .90;
        } else if(speed == 9){
            return .80;
        } else if(speed == 10){
            return .77;
        } else{
            return 0;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return SuccessRate(speed) * 221.0 * speed;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)(ProductionRatePerHour(speed) / 60);
    }
}
