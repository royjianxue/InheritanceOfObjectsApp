using System;

namespace InheritanceOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Please enter the name: ");

                if (i == 0)
                {
                    people[i] = new Teacher(Console.ReadLine());
                }
                else
                {
                    people[i] = new Student(Console.ReadLine());

                }

            }

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    (people[i] as Teacher).Explain();
                }
                else
                {
                    (people[i] as Student).Study();
                }
            }


            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }

 
        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Student : Person
    {
        public Student(string name) : base(name) // inherit from Parent class constructor
        {
            Name = name;
        }
        public void Study()
        {
            Console.WriteLine("Study");
        }
    }

    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
            Name = name;
        }
        public void Explain()
        {
            Console.WriteLine("Explain");
        }
    }



}
