namespace StrategyPattern
{
    class CreditCard : IPayment
    {
        public string Payment()
        {
            return "Making payment through CREDIT CARD.";
        }
    }
}
