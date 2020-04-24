namespace MagazinDeMobila.Flyweight
{
    public class Cashier
    {
        public CashRegisterCard CashRegisterCard { get; set; }

        public Cashier()
        {
            CashRegisterCard = new CashRegisterCard();
        }

        public void CashIn(double value, EMoneyType moneyType)
        {
            CashRegisterCard.CashIn(value);
        }

        public void CashOut(double value, EMoneyType moneyType)
        {
            CashRegisterCard.CashOut(value);
        }

        public double GetTotalCache()
        {
            return CashRegisterCard.GetTotalCash();
        }
    }
}