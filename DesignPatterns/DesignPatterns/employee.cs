using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class employee
    {
        public int TypeId;
        public decimal Bonus;
        public decimal HourlyPay;
        public string Name;
        public employee(string name, int typeId)
        {
            TypeId = typeId;
            Name = name;
            EmployeeManagerFactory empFactory = new EmployeeManagerFactory();
            IemployeeManager empManager = empFactory.GetEmployeeManager(TypeId);
            Bonus = empManager.GetBonus();
            HourlyPay = empManager.GetPay();
        }
    }

    public interface IemployeeManager
    {
        decimal GetBonus();
        decimal GetPay();
    }
    public abstract class BaseEmployeeFactory
    {
        public employee _emp;
        public BaseEmployeeFactory(employee emp)
        {
            _emp = emp;
        }
        public abstract IemployeeManager Create();
    }
    public class EmployeeFactory : BaseEmployeeFactory
    {
        public EmployeeFactory(employee emp) : base(emp)
        {
        }

        public override IemployeeManager Create()
        {
            throw new NotImplementedException();
        }
    }
    public class EmployeeManagerFactory
    {
        public IemployeeManager GetEmployeeManager(int employeeTypeId)
        {
            IemployeeManager returnValue = null;
            if (employeeTypeId == 1)
                return new employeeType1();
            else if (employeeTypeId == 2)
                return new employeeType2();

            return returnValue;
        }
    }
    public class employeeType1 : IemployeeManager
    {
        public decimal GetBonus()
        {
            return 10;
        }
        public decimal GetPay()
        {
            return 8;
        }
    }
    public class employeeType2 : IemployeeManager
    {
        public decimal GetBonus()
        {
            return 5;
        }
        public decimal GetPay()
        {
            return 12;
        }
    }
}

