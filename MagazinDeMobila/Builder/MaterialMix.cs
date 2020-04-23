using MagazinDeMobila.Decorator;

namespace MagazinDeMobila.Builder
{
    public class MaterialMix : IMaterialAccesory
    {
        public EMaterialMixType Type { get; set; }
        public EAccesoryType AccesoryType { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }


        public MaterialMix()
        {

            AccesoryType = EAccesoryType.EBasic;
            SetPrice();
        }

        public void Assemble(string color)
        {
            Color = color;
            AccesoryType = EAccesoryType.EBasic;
            SetPrice();
        }

        public void SetPrice()
        {
            switch (AccesoryType)
            {
                case EAccesoryType.EBasic:
                    Price = 100;
                    break;
                case EAccesoryType.EExtendable:
                    Price = 100;
                    break;
                case EAccesoryType.EHandle:
                    Price = 200;
                    break;
                case EAccesoryType.EHeightAdjusted:
                    Price = 150;
                    break;
                case EAccesoryType.EUpholstered:
                    Price = 180;
                    break;
            }
        }
    }
}