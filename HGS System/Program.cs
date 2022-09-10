using System;

namespace HGS
{  
    class Program
    {
        static void Main()
        {
            /*
             * These codes are written for testing the modules.
            Vehicle car1 = new();
            car1.HGSNumber = "a";
            car1.OwnerName = "sedat";
            car1.OwnerSurname = "cihat";
            DateTime Now = DateTime.Now;
            car1.Date = Now.ToString("dd/MM/yyyy");
            car1.Time = Now.ToString("HH:mm:ss");
            car1.VehicleClass = "FirstClass";
            car1.Balance = 71;
            ticket.Ticket(car1);
            Management.Report();
            */

        }
    }
    // Our ticket class to determine the how much money will be cut and log the daily income.
    class ticket
    {
        public static int[] DailyReport { get; set; }
        public static void Ticket(Vehicle car)
        {
            DailyReport = new int[3];
            if (car.VehicleClass == "FirstClass")
            {
                if (car.Balance >= 47)
                {
                    car.Balance -= 47;
                    ticket.DailyReport[0] += 1;
                }
                else
                    Console.WriteLine("Not Enoug Currency");
            }
            else if (car.VehicleClass == "SecondClass")
            {
                if (car.Balance >= 54)
                {
                    car.Balance -= 54;
                    DailyReport[1] += 1;
                }
                else
                    Console.WriteLine("Yetersiz Bakiye");
            }
            else if (car.VehicleClass == "ThirdClass")
            {
                if (car.Balance >= 72)
                {
                    car.Balance -= 72;
                    DailyReport[2] += 1;
                }
                else
                    Console.WriteLine("Yetersiz Bakiye");
            }

        }
    }
    // To show the how much vehicles pass and how much currency cutted.
    class Management
    {
        public static void Report()
        {
            Console.WriteLine("First Class Vehicles: "+ticket.DailyReport[0].ToString());
            Console.WriteLine("Second Class Vehicles: " + ticket.DailyReport[1].ToString());
            Console.WriteLine("Third Class Vehicles: " + ticket.DailyReport[2].ToString());
            Console.WriteLine("Total Daily Currency: " + 
                (ticket.DailyReport[0]*47 + ticket.DailyReport[1]*54 + ticket.DailyReport[2]*72).ToString());
        }
    }
    // Vehicle class which is using for the recognize the car.
    public class Vehicle
    {
        public string HGSNumber;
        public string OwnerName;
        public string OwnerSurname;
        public string Date;
        public string Time;
        public string VehicleClass;
        public int Balance;
    }
}