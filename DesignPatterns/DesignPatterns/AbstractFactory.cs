using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class AbstractFactory
    {


    }
    //===========================================================
    //ComputerFActory------------------------------
    //===========================================================
    public interface IComputerFActory
    {
        ISystemType SystemType();
        IBrand Brand();
        IProcessor Processor();
    }
    //Mac------------------------------
    public class MACFactory : IComputerFActory
    {
        public IBrand Brand()
        {
            return new MAC();
        }
        public IProcessor Processor()
        {
            return new I7();
        }
        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }
    public class MACLaptopFactory : MACFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
    //DELL------------------------------
    public class DellFactory : IComputerFActory
    {
        public IBrand Brand()
        {
            return new DELL();
        }

        public IProcessor Processor()
        {
            return new I5();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }
    public class DellLaptopFactory : DellFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
    //===========================================================
    //SystemType------------------------------
    public interface ISystemType
    {
        string GetSystemType();
    }
    public class Laptop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerTyoes.Laptop.ToString();
        }
    }
    public class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerTyoes.Desktop.ToString();
        }
    }
    //Brand------------------------------
    public interface IBrand
    {
        string GetBrand();
    }
    public class MAC : IBrand
    {
        public string GetBrand()
        {
            return Brands.APPLE.ToString();
        }
    }
    public class DELL : IBrand
    {
        public string GetBrand()
        {
            return Brands.DELL.ToString();
        }
    }
    //Processor------------------------------
    public interface IProcessor
    {
        string GetProcessor();
    }
    public class I7 : IProcessor
    {
        public string GetProcessor()
        {
            return Processors.I7.ToString();
        }
    }
    public class I5 : IProcessor
    {
        public string GetProcessor()
        {
            return Processors.I5.ToString();
        }
    }
    //enum------------------------------
    public enum ComputerTyoes
    {
        Laptop,
        Desktop
    }
    public enum Brands
    {
        APPLE,
        DELL
    }
    public enum Processors
    {
        I3,
        I5,
        I7
    }
}
