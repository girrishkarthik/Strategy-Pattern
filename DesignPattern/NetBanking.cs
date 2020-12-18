namespace StrategyPattern
{
    class NetBanking : IPayment
    {
        public string Payment()
        {
            return "Making payment through NET BANKING";
        }
    }
}
