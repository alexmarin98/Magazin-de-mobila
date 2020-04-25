namespace MagazinDeMobila.Decorator
{
    class UpholsteredDecorator : MaterialMixDecorator
    {
        public UpholsteredDecorator(IMaterialAccesory myMaterial) : base(myMaterial)
        {
            DecoratedMaterial.AccesoryType = Builder.EAccesoryType.EUpholstered;
            SetPrice();
        }
        public override sealed void SetPrice()
        {
            DecoratedMaterial.Price += 1100;
        }
    }
}
