namespace Inheritance3.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public double Income { get; set; }

        protected Person(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double Tax();


    }
}
