namespace MagazinDeMobila.Decorator
{
    class HandleDecorator : MaterialMixDecorator
    {
        public HandleDecorator(IMaterialAccesory myMaterial) : base(myMaterial)
        {
            DecoratedMaterial.AccesoryType = Builder.EAccesoryType.EHandle;
            SetPrice();
        }
        public override sealed void SetPrice()
        {
            DecoratedMaterial.Price += 1100;
        }
    }
}