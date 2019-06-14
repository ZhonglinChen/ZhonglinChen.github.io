namespace CS04_Task2
{
    public class Test
    {
        public void runTest()
        {
            Employee e = new Employee("employee name",20,"employee name",20,20000.5);
            Manager m = new Manager("manager name",30,"manager name",50,50000.5,"BMW");
            
            e.printObject();
            e.play();
            e.sing();
            
            m.printObject();
            m.play(); 
            m.sing();


        }
    }
}