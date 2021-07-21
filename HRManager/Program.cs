using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmpNum = 1;
            emp.FirstName = "Steve";
            emp.LastName = "Jobs";
            Console.WriteLine("emp.GetHashCode: " + emp.GetHashCode());
            Console.WriteLine("emp.GetType: " + emp.GetType());
            Console.WriteLine("emp.ToString: " + emp.ToString());

            HourlyEmployee hourEmp = new HourlyEmployee();
            hourEmp.EmpNum = 2;
            hourEmp.FirstName = "Bill";
            hourEmp.LastName = "Gates";
            hourEmp.HourlyRate = 15.00M;
            Console.WriteLine("hourEmp.GetHashCode: " + hourEmp.GetHashCode());
            Console.WriteLine("hourEmp.GetType: " + hourEmp.GetType());
            Console.WriteLine("hourEmp.ToString: " + hourEmp.ToString());

            //Boxing
            Object athing = hourEmp;
            Console.WriteLine("hourEmp.ToString: " + athing);

            //Unboxing
            HourlyEmployee unboxedEmp = (HourlyEmployee)athing;
            Console.WriteLine("First Name: " + unboxedEmp.FirstName);

            //Unboxing...notice you get an error! Athing is not a SalaryEmployee so you get the error.
            //SalaryEmployee unboxedEmp = (SalaryEmployee)athing;
            //Console.WriteLine("First Name: " + unboxedEmp.FirstName);

            //the above fixed...make sure that I am casting to the right type, I can use the
            //'is' operator. The 'is' operator returns true if the object on the left 'is' of
            //the type on the right of the 'is' operator.

            //if (athing is HourlyEmployee)
            //{
            //    //Unboxing
            //    HourlyEmployee unboxedEmp = (HourlyEmployee)athing;
            //    Console.WriteLine("First Name: " + unboxedEmp.FirstName);
            //}

            //if (athing is HourlyEmployee)
            //{
            //    //Unboxing
            //    SalaryEmployee unboxedEmp = (SalaryEmployee)athing;
            //    Console.WriteLine("First Name: " + unboxedEmp.FirstName);
            //}

            Console.ReadLine(); //so the program waits for an entry before quitting
        }
    }
}
