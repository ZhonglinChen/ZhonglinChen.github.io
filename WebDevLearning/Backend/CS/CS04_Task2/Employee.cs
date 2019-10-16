using System;

namespace CS04_Task2
{
    public class Employee:Person
    {
        protected int id;
        protected double salary;

        public Employee(string name, short age, string sex, int id, double salary) : base(name, age,sex)
        {
            this.id = id;
            this.salary = salary;

        }

        public void sing()
        {
            Console.WriteLine("I can sing");
        }

        public override void play()
        {
            Console.WriteLine("singing in KTV");
        }

        public override void printObject()
        {
            Console.WriteLine("Class: Employee, name: {0}, age: {1}, sex: {2}, id: {3}, salary: {4}",
                base.name,base.age,base.sex,this.id,this.salary);
        }
    }
}