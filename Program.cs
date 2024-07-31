namespace AppDemoWeek5
{
    abstract class Shape
    {
        public abstract int GetArea();
    }
    class Square : Shape
    {
        private int _side;
        public Square(int n) => _side = n;

        // GetArea method is required to avoid a compile-time error.
        public override int GetArea() => _side * _side;
    }
    class Rectangle : Shape
    {
        private int _width;
        private int _length;
        public Rectangle(int width, int length)
        {
            _width = width;
            _length = length;
        }
        public override int GetArea() => _width * _length;
    }
    internal class Program
    {
        static void Main()
        {
            Object[] shapes = { new Square(5), new Rectangle(3, 4)  };
            Console.WriteLine($"Area of the square = {((Shape)shapes[0]).GetArea()}");
            var sq = new Square(4);
            var rc = new Rectangle(5, 4);
            Console.WriteLine($"Area of the square = {sq.GetArea()}");
            Console.WriteLine($"Area of the rectangle = {rc.GetArea()}");
        }
    }
}
