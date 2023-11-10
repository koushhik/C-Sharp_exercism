
/*
In this exercise you'll be writing code to analyze the production of an assembly line in a car factory. The assembly line's speed can range from 0 (off) to 10 (maximum).

At its lowest speed (1), 221 cars are produced each hour. The production increases linearly with the speed. So with the speed set to 4, it should produce 4 * 221 = 884 cars per hour. However, higher speeds increase the likelihood that faulty cars are produced, which then have to be discarded.

You have three tasks.

1. Calculate the success rate
Implement the (static) AssemblyLine.SuccessRate() method to calculate the ratio of an item being created without error for a given speed. The following table shows how speed influences the success rate:

0: 0% success rate.
1 to 4: 100% success rate.
5 to 8: 90% success rate.
9: 80% success rate.
10: 77% success rate.
AssemblyLine.SuccessRate(10)
// => 0.77
2. Calculate the production rate per hour
Implement the (static) AssemblyLine.ProductionRatePerHour() method to calculate the assembly line's production rate per hour, taking into account its success rate:

AssemblyLine.ProductionRatePerHour(6)
// => 1193.4
Note that the value returned is a double.

3. Calculate the number of working items produced per minute
Implement the (static) AssemblyLine.WorkingItemsPerMinute() method to calculate how many working cars are produced per minute:

AssemblyLine.WorkingItemsPerMinute(6)
// => 19
*/

using System;
static class AssemblyLine
{
    private const int DefaultSpeed = 221; //WE CRETAE A PRIVATE CONSTRUCTOR NAMED DEFAULTSPEED WHICH INDICATES production rate for 1 Minute , that can be accessed within AssemblyLine class members.

    public static double ProductionRatePerHour(int speed)
    {
        return ProductionRatePerHourForSpeed(speed) * SuccessRate(speed);
        //here we calculate the production rate per hour.
    }

    private static int ProductionRatePerHourForSpeed(int speed)
    {
        return DefaultSpeed * speed;
        //here we calculate production rate per hour for the speed.
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)(ProductionRatePerHour(speed) / 60);
        //rather than hours we calculate the working items per minute.
        //the basic formula for computation goes like
        // for 1hour(60 minutes) - 221 productions
        // for any minutes - ? productions.
        //(any minutes * any no of pruductions/60)
    }

    public static double SuccessRate(int speed) //we create a method of Double return type to calculate the ratios.
    {
        if (speed == 10)
        {
            return 0.77;
        }

        if (speed == 9)
        {
            return 0.8;
        }

        if (speed >= 5)
        {
            return 0.9;
        }

        if (speed <= 0)
        {
            return 0.0;
        }

        return 1;
    }
}





