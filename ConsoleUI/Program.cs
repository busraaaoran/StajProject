using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ColorTest();

            //AppointmentTest();

            apptTest();
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var result = colorManager.GetAll();

            if (result.Success)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

        private static void AppointmentTest()
        {
            AppointmentManager appointmentManager = new AppointmentManager(new EfAppointmentDal());

            var result = appointmentManager.GetAppointmentDetails();

            if (result.Success)
            {
                foreach(var appt in result.Data)
                {
                    Console.WriteLine("Appointment ID: " + appt.ApptId + "\nBrand Name: " + appt.BrandName + "\nCustomer Name: " + appt.CustomerName + "\nOto Service Name: " + appt.ServiceName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void apptTest()
        {
            AppointmentManager appointmentManager = new AppointmentManager(new EfAppointmentDal());

            var result = appointmentManager.GetAll();

            if (result.Success)
            {
                foreach (var appt in result.Data)
                {
                    Console.WriteLine(appt.ApptDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

    }
}
