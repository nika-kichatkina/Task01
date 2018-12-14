using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Epam.Task3.Employee
{
    public class User
    {
        private DateTime dateNow = DateTime.Now;

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthday { get; set; }

        public User()
        {
        }
        public User(string name, string surname, string patronymic, DateTime birthday)
        {
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.Birthday = birthday;
        }

        public void WriteUser()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine("Patronymic: " + Patronymic);
            Console.WriteLine("Birthday: " + Birthday);
            Console.WriteLine("Age: " + (dateNow.Year - Birthday.Year));
        }

    }

    public class Employee : User
    {
        public string WorkExperience { get; set; }
        public string Position { get; set; }
        private DateTime dateNow = DateTime.Now;

        public Employee(string name, string surname, string patronymic, DateTime birthday, string WorkExperience, string Position) : base(name, surname, patronymic, birthday)
        {
            this.Position = Position;
            this.WorkExperience = WorkExperience;

        }

        public new void WriteUser()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine("Patronymic: " + Patronymic);
            Console.WriteLine("Birthday: " + Birthday);
            Console.WriteLine("Age: " + (dateNow.Year - Birthday.Year));
            Console.WriteLine("Work Experience: " + WorkExperience);
            Console.WriteLine("Position: " + Position);
        }


    }
}
