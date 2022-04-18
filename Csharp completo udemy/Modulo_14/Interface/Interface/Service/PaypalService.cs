using Interface.Entities;
namespace Interface.Service
{
    class PaypalService : IOnlinePaymentService
    {        
        public double Interest(double amount, int months)
        {
            return amount * 0.01 * months;
        }
        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }
    }
}
