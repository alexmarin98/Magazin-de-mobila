namespace MagazinDeMobila.Flyweight
{
    public class CashRegisterCard : CashRegister
    {
        public override Money CreateNewMoney()
        {
            return new CardMoney();
        }

        public override bool IsSharedValue(double value)
        {
            return false;
        }
    }
}