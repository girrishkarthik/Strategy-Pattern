namespace StrategyPattern
{
    class DebitCard : IPayment
    {
        public string Payment()
        {
            return "Making payment through DEBIT CARD";
        }
    }
}
