namespace MagazinDeMobila.Decorator
{
    class HeightAdjustedDecorator : MaterialMixDecorator
    {
        public HeightAdjustedDecorator(IMaterialAccesory myMaterial) : base(myMaterial)
        {
            DecoratedMaterial.AccesoryType = Builder.EAccesoryType.EHeightAdjusted;
            SetPrice();
        }
        public override sealed void SetPrice()
        {
            DecoratedMaterial.Price += 1100;
        }
    }
}