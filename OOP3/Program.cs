using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager needCreditManager = new NeedCreditManager();         
            ICreditManager vehicleCreditManager = new VehicleCreditManager();          
            ICreditManager housingCreditManager = new HousingCreditManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            RecourseManager recourseManager = new RecourseManager();
            recourseManager.MakeAnRecourse(new EsnafCreditsManager(),new SmsLoggerService());

            List<ICreditManager> credits = new List<ICreditManager>() 
            { 
                needCreditManager,
                housingCreditManager,
                vehicleCreditManager
            };

            //recourseManager.KrediOnBilgilendirmesiYap(credits);
        }
    }
}
