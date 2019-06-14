using System;

namespace CS04_Task2
{
    public class Manager:Employee
    {
        protected string vehicle;

        public Manager(string name, short age, string sex, int id, double salary, string vehicle) : base(name, age, sex,
            id, salary)
        {
            this.vehicle = vehicle;
        }
            
        public override void play()
        {
            Console.WriteLine("Play Golf");
        }
        public override void printObject()
        {
            Console.WriteLine("Class: Manager, name: {0}, age: {1}, sex: {2}, id: {3}, salary: {4}, vehicle: {5}",
                name,age,sex,id,salary,vehicle);
        }
    }
}