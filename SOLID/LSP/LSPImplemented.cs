namespace SOLID.LSP
{
    public abstract class Shape
    {
        public abstract int Area();
    }

    public class RectangleLsp : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public override int Area()
        {
            return Height*Width;
        }
    }

    public class SquareLsp : Shape
    {
        public int Sides;

        public override int Area()
        {
            return Sides*Sides;
        }
    }
}
