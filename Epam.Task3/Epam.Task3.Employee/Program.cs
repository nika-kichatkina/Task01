using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Employee
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("enter name: ");
            string Name = Console.ReadLine();

            Console.WriteLine("enter surname: ");
            string Surname = Console.ReadLine();

            Console.WriteLine("enter patronymic: ");
            string Patronymic = Console.ReadLine();

            Console.WriteLine("enter Birthday in format day.month.year: ");
            DateTime Birthday = new DateTime();
            Birthday = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("enter Work Experience: ");
            string WorkExperience = Console.ReadLine();

            Console.WriteLine("enter Position: ");
            string Position = Console.ReadLine();

            Employee U = new Employee(Name, Surname, Patronymic, Birthday, WorkExperience, Position);

            U.WriteUser();
        }
    }
}
