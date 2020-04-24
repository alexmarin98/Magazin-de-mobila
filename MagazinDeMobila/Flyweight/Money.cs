namespace MagazinDeMobila.Flyweight
{
    public abstract class Money
    {
        public double TotalCache { get; set; }
        public abstract EMoneyType GetMoneyType();
    }
}
