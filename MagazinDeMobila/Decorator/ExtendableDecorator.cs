namespace MagazinDeMobila.Decorator
{
    class ExtendableDecorator : MaterialMixDecorator
    {
        public ExtendableDecorator(IMaterialAccesory myMaterial) : base(myMaterial)
        {
            DecoratedMaterial.AccesoryType = Builder.EAccesoryType.EExtendable;
            SetPrice();
        }
        public override sealed void SetPrice()
        {
            DecoratedMaterial.Price += 1100;
        }
    }
}