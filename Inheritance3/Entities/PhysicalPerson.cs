namespace Inheritance3.Entities
{
    class PhysicalPerson : Person
    {
        public double HealthExpenditures { get; set; }

        public PhysicalPerson(string name, double income, double healthExpenditures) : base(name,income)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if(Income < 20000)
            {
                return (0.15 * Income) - (0.5 * HealthExpenditures);
            }
            else
            {
                return (0.25 * Income) - (0.5 * HealthExpenditures);
            }
        }
    }
}
