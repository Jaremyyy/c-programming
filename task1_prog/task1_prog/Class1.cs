using System;

namespace task1_prog
{
    public class MyAccessModifiers
    {
        private int birthyear;
        public string personalInfo;
        private string idNumber;
        public static byte averageMiddleAge = 50;

        public MyAccessModifiers(int birthyear, string idNumber, string personalInfo)
        {
            this.birthyear = birthyear;
            this.idNumber = idNumber; 
            this.personalInfo = personalInfo;
        }

        public int Age
        {
            get
            {
                int currentYear = 2024;
                return currentYear - birthyear;
            }
        }

        public int Birthyear
        {
            get
            {
                return birthyear;
            }
            set
            {
                birthyear = value;
            }
        }
        public string IdNumber 
        {
            get
            {
                return idNumber;
            }
            set
            {
                idNumber = value;
            }
        }
        public string Name
        { get; set; }

        public string NickName
        { get; internal set; }

        internal bool HasLivedHalfOfLife() { return Age >= MyAccessModifiers.averageMiddleAge / 2; }

        public static bool operator ==(MyAccessModifiers obj1, MyAccessModifiers obj2)
        {
            if (obj1 is null || obj2 is null)
            {
                return false;
            }

            return obj1.Name == obj2.Name && obj1.Age == obj2.Age && obj1.personalInfo == obj2.personalInfo && obj1.IdNumber == obj2.IdNumber;
        }

        public static bool operator !=(MyAccessModifiers obj1, MyAccessModifiers obj2)
        {
            return !(obj1 == obj2);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            MyAccessModifiers obj1 = new MyAccessModifiers(2004, "ID12345", "Yarema Shehynskyi");
            obj1.Name = "Yarema";
            
            Console.WriteLine($"The person {obj1.Name} has {obj1.Age} years old and ID: {obj1.IdNumber}.");

            MyAccessModifiers obj2 = new MyAccessModifiers(2005, "ID12345", "Yarema Shehynskyi");
            obj2.Name = "Yarema";
            Console.WriteLine($"The person {obj2.Name} has {obj2.Age} years old and ID: {obj2.IdNumber}.");

            if (obj1 == obj2)
            {
                Console.WriteLine("Objects are equal");
            }
            else
            {
                Console.WriteLine("Objects are not equal");
            }
        }
    }
}
