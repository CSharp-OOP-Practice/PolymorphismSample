using System.Collections.Generic;

namespace PracticePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas();
            var shapes = new List<Shape>();
            // 改寫
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            canvas.DrwaShapes(shapes);
        }
    }
}
