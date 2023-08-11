using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
     class Employeedetails<T>
    {
        private T[]  employee = new T[50];

        public T this[int index]
        {
            get
            {
                return employee[index];
            }
            set { employee[index] = value; }
        }
    }

    class Display
    {
        public static void Main()
        {
            Employeedetails<int> Id = new Employeedetails<int>();
            Employeedetails<string>Name = new Employeedetails<string>();
            Employeedetails<double> Salary = new Employeedetails<double>();

            Console.WriteLine("Enter Employee Count");
            int count = Console.ReadLine().Length;
            for(int  i = 0; i <= count; i++) 
            {
                Console.WriteLine("enter Employee Id");
                Id[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter Employee name:");
                Name[i] = Console.ReadLine();
                Console.WriteLine("enter salary");
                Salary[i]=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Employee {Name[i]} is of ID {Id[i]} is getting salary {Salary[i]}");
            }

            Console.ReadLine();
        }
    }
}
