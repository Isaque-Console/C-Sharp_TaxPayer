namespace Inheritance3.Entities
{
    class LegalPerson : Person
    {
        public int Employees { get; set; }

        public LegalPerson(string name, double income, int employees) : base(name,income)
        {
            Employees = employees;
        }

        public override double Tax()
        {
            if (Employees > 10) 
            {
                return (0.14 * Income);
            }
            else
            {
                return (0.16 * Income);
            }
        }
    }
}
