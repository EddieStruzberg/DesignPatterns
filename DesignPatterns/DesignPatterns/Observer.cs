

using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPatterns
{
    public class TrainSignal
    {
        public static Action<string> TrainsIsComing;
        public void HereComesATrains(string key)
        {
            TrainsIsComing(key);
        }
    }
    class CarObserver
    {
        private string _modelName;
        public CarObserver(string modelName)
        {
            TrainSignal.TrainsIsComing += StopTheCar;
            _modelName = modelName;
        }

        private void StopTheCar(string key)
        {
            //do stuff.......
            Console.WriteLine(key + " " + _modelName + " +Screeeeeerch......");
        }
    }

    //=======================================================
    public interface IObserver
    {
        void Update();
    }
    public interface ISubject
    {
        void AddObserver(IObserver o);

        void RemoveObserver(IObserver o);

        void NotifyObservers();
    }

    public class MailBox : IObserver
    {
        string Address;
        public void Update()
        {
            Console.WriteLine(Address+" New Mail Arrived");
        }
    }
    public class PostOffice : ISubject
    {
        private String Address;
        public String GetAddress()
        {
            return this.Address;
        }

        private List<IObserver> observers = new List<IObserver>();

        public PostOffice(String Address) : base()
        {
            this.Address = Address;
        }

        public void newMail()
        {
            this.NotifyObservers();
        }

        public void AddObserver(IObserver o)
        {
            this.observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            this.observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (var observer in this.observers)
                observer.Update();
        }
    }
    //=======================================================

    public class ExampleOfObserverUse
    {
        public static void Example()
        {
            Console.WriteLine("Observer--------------------------------------------------");
            MailBox mailBox1 = new MailBox();
            PostOffice officeKfarSava = new PostOffice("ha gefen kfar sava 3");

            officeKfarSava.AddObserver(mailBox1);
            officeKfarSava.newMail();
            officeKfarSava.RemoveObserver(mailBox1);
            officeKfarSava.newMail();

            Console.WriteLine();
            Console.WriteLine("/simple Observer------------------------------------------");
            TrainSignal theTrain = new TrainSignal();
            CarObserver BMW = new CarObserver("BMW");
            CarObserver Nissan = new CarObserver("Nissan");
            CarObserver Mazda = new CarObserver("Mazda");
            theTrain.HereComesATrains("Train is comming...");

        }
    }


}
