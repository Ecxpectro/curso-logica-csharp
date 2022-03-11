namespace exercicio_heranca_polimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }
        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }
        public double TotalPrice()
        {
            return CustomsFee + Price;
        }
        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice().ToString("f2")} (Customs fee: $ {CustomsFee.ToString("f2")})";
        }
    }
}
