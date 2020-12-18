namespace StrategyPattern
{
    class Transaction
    {
        private readonly ModeOfPayment _type;

        public Transaction(ModeOfPayment type)
        {
            _type = type;
        }

        public string MakePayment()
        {
            IPayment pay = null;
            switch(_type)
            {
                case ModeOfPayment.CreditCard:
                    pay = new CreditCard();
                    break;
                case ModeOfPayment.DebitCard:
                    pay = new DebitCard();
                    break;
                case ModeOfPayment.NetBanking:
                    pay = new NetBanking();
                    break;
            }
            return pay.Payment();
        }
    }
}
