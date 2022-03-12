namespace Metodos_Abstratos.Entities
{
    class Individual : TaxPayer
    {
        public double HelthExpenditiures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double helthExpenditiures) : base(name, anualIncome)
        {
            HelthExpenditiures = helthExpenditiures;
        }

        public override double Tax()
        {
            if(AnualIncome < 20000)
            {
                return (AnualIncome * 0.15) - (HelthExpenditiures * 0.5);
            }
            else
            {
                return (AnualIncome * 0.25) - (HelthExpenditiures * 0.5);
            }
        }
    }
}
