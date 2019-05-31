using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class FactoryMethod
    {
        static void ExampleOfUse(string[] args)
        {
            //Fcatory- use same class to implement several worlds
            //Easy to change code from worldA to worldB         
            //var CompanyWorkers = FactoryUse.createTable(WorkPlace.ClioWorkers);
            var CompanyWorkers = FactoryUse.createTable(WorkPlace.SkyLabWorkers);
            CompanyWorkers.ShowWorkers(new List<object>());
            //...Massive Code...
            Console.ReadKey();
        }
    }

    public interface iCustomersFactoryInterface
    {
        void ShowWorkers(List<object> Customers);
    }

    class SkyLabWorkers : iCustomersFactoryInterface
    {
        public void ShowWorkers(List<object> Customers)
        {
            Console.WriteLine("SkyLab Workers");
            foreach (var Customer in Customers)
            {
                Console.WriteLine(Customer.ToString());
            }

        }
    }
    class ClioWorkers : iCustomersFactoryInterface
    {
        public void ShowWorkers(List<object> Customers)
        {
            Console.WriteLine("Clio Workers");
            foreach (var Customer in Customers)
            {
                Console.WriteLine(Customer.ToString());
            }
        }
    }
    public class FactoryUse
    {
        public static iCustomersFactoryInterface createTable(WorkPlace wantedWorkPlace)
        {
            if (wantedWorkPlace == WorkPlace.ClioWorkers)
            {
                return new ClioWorkers();
            }
            else if (wantedWorkPlace == WorkPlace.SkyLabWorkers)
            {
                return new SkyLabWorkers();
            }
            return null;
        }
    }
    public enum WorkPlace
    {
        ClioWorkers = 1,
        SkyLabWorkers = 2
    }
}






