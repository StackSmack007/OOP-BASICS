using System;

namespace AnimalFarm.Animals
{
    public abstract class Animal
    {
       public static Action Error = () => throw new ArgumentException("Invalid input!");
        protected string name;
        protected int age;
        private string gender;

        public Animal(string name, string age, string gender)
        {
            int temp;
            if (!int.TryParse(age, out temp)) Error();
            Name = name;
            Age = temp;
            Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value)) Error();
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0) Error();
                this.age = value;
            }
        }

        public string Gender
        {
            get => gender;
            protected set
            {
                if (value.ToLower() != "male" && value.ToLower() != "female") Error();
                gender = value;
            }
        }

        public void PrintData()
        {
            Console.WriteLine(this.GetType().Name);
            Console.WriteLine($"{Name} {Age} {Gender}");
            Console.WriteLine(MakeASound());
        }
        public virtual string MakeASound()
        {
            return null;
        }
    }
}