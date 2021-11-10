using System;
using System.Collections.Generic;

namespace LabGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //MyList<Person,Human> list = new MyList<Person,Human>();

            //Dictionary<string, Car> Cars = new Dictionary<string, Car>();
            //Cars.Add("19-BF-019", new Car { Model = "Mercedes" });
            //Cars.Add("10-BC-919", new Car { Model = "BMW" });
            //Cars.Add("99-AF-212", new Car { Model = "Hyundai" });
            //Cars.Add("77-ZZ-777", new Car { Model = "LADA" });

            //foreach (var item in Cars)
            //{
            //    Console.WriteLine($"No: {item.Key} - Model: {item.Value.Model}");
            //}
            //Console.WriteLine("==================");
            //Cars.Remove("77-ZZ-777");
            //foreach (var item in Cars)
            //{
            //    Console.WriteLine($"No: {item.Key} - Model: {item.Value.Model}");
            //}

            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            foreach (var item in ReverseQueue(q))
            {
                Console.WriteLine(item);
            }

            List<Person> arr = new List<Person>();

            arr.Find(n => n.Name == "");
            

        }

        public static Queue<int> ReverseQueue(Queue<int> q)
        {
            int count = q.Count;

            Stack<int> s = new Stack<int>();

            for (int i = 0; i < count; i++)
            {
                s.Push(q.Dequeue());
            }
            for (int i = 0; i < count; i++)
            {
                int a = s.Pop();
                q.Enqueue(a);
            }

            return q;
        }
    }
    class Car
    {
        public string Model { get; set; }
    }
    class MyList<T,U>
    {
        T[] list;
        public MyList()
        {
            list = new T[0];
        }

        public void Add(T value)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = value;
        }
        public void ShowList()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
    class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Human(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }

}
