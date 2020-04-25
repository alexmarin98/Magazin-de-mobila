namespace MagazinDeMobila.COR
{
    public class RequestPrice
    {
        private readonly Seller Seller;
        private readonly Local Local;
        private readonly Importator Importator;

        public RequestPrice(Seller seller)
        {
            Seller = seller;
            Local = new Local();
            Importator = new Importator();

            seller.SetSuccesor(Local);
            Local.SetSuccesor(Importator);
        }

        public double GetProductPrice(string productName)
        {
            return Seller.GetProductPrise(productName);

        }
    }
}
