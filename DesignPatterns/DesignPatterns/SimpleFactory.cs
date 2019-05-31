using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class KidSimpleFactory
    {
        protected abstract string getName();
        public string GetName()
        {
            return getName();
        }
        public string name { get; set; }
        public KidSimpleFactory(string _name)
        {
            name = _name;
        }
        public static void writeMsg(KidSimpleFactory kid)
        {
            Console.WriteLine(kid.GetName());
        }
    }
    public class kid1 : KidSimpleFactory
    {
        public kid1(string _name) : base(_name) { }
        protected override string getName()
        {
            return name + " of type 1 ";
        }
    }
    public class kid2 : KidSimpleFactory
    {
        public kid2(string _name) : base(_name) { }
        protected override string getName()
        {
            return name + " of type 2 ";
        }
    }
    public class useSimpleFactory
    {
        // useSimpleFactory.runSimpleFactoryExample();
        public static void runSimpleFactoryExample()
        {
            KidSimpleFactory kid1Factory = new kid1("kody");
            KidSimpleFactory kid2Factory = new kid2("boby");

            string name1 = kid1Factory.GetName();
            string name2 = kid2Factory.GetName();
            Console.WriteLine(name1);
            Console.WriteLine(name2);
        }
    }
}

