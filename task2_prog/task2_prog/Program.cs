using System;

namespace task2_prog
{
    public class Employee
    {
        internal string name;
        private DateTime hiringDate;
        public Employee(string name, DateTime hiringDate)
        {
            this.name = name;
            this.hiringDate = hiringDate;
        }

        public int Experience()
        {
            return (DateTime.Now - hiringDate).Days / 365;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{name} has {Experience()} years of experience.");
        }
    }

    public class Developer : Employee
    {
        private string programmingLanguage;

        public Developer(string name, DateTime hiringDate, string programmingLanguage) : base(name, hiringDate)
        {
            this.programmingLanguage = programmingLanguage;
        }

        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"{name} is {programmingLanguage} programmer.\n");
        }
    }

    public class Tester : Employee
    {
        private bool isAutomation;

        public Tester(string name, DateTime hiringDate, bool isAutomation) : base(name, hiringDate)
        {
            this.isAutomation = isAutomation;
        }

        public new void ShowInfo()
        {
            base.ShowInfo();
            if (isAutomation)
            {
                Console.WriteLine($"{name} is automated tester and has {Experience()} years of experience.\n");
            }
            else
            {
                Console.WriteLine($"{name} is manual tester and has {Experience()} years of experience.\n");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee person1 = new Employee("Yarema", new DateTime(2014, 9, 7));
            person1.ShowInfo();

            Developer person2 = new Developer("Jeka", new DateTime(2016, 5, 31), "Python");
            person2.ShowInfo();

            Tester person3 = new Tester("Danimark", new DateTime(2015, 2, 21), true);
            person3.ShowInfo();

            Tester person4 = new Tester("Danya", new DateTime(2015, 1, 22), false);
            person4.ShowInfo();
        }
    }
}
