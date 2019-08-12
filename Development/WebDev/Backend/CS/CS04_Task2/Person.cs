namespace CS04_Task2
{
    public abstract class Person
    {
        protected string name { get; }
        protected short age { get; }
        protected string sex { get; }

        public abstract void play();
        public abstract void printObject();

        protected Person(string name, short age, string sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }
        
        
        
        

    }
}