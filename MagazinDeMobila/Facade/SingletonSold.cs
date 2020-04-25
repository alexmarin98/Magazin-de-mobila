namespace MagazinDeMobila.Facade
{
    public class SingletonSold
    {
        public static SingletonSold Instance { get; set; } = null;

        public Sold Sold { get; set; }
        public SingletonSold()
        {
            Sold = new Sold();
        }

        public static SingletonSold getInstance()
        {
            if (Instance == null)
                Instance = new SingletonSold();
            return Instance;
        }
        public void AddMoney(double sum)
        {
            Sold.AddMoney(sum);
        }
        public void RemoveMoney(double sum)
        {
            Sold.RemoveMoney(sum);
        }
        public double GetSold()
        {
            return Sold.CurrentSold;
        }

    }

}
