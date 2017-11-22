using System;
using System.Collections.Generic;

namespace PracticePolymorphism
{
    class Canvas
    {
        public void DrwaShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                //不同的Shape繼承自Shape，透過loop倒出來，再使用不同Shape的Draw方法得到不同結果，這種概念就是多態
                shape.Draw();
                
                //switch (shape.Type)
                //{
                //    case ShapeType.Circle:
                //        Console.WriteLine("Draw a circle");
                //    break;

                //    case ShapeType.Rectangle:
                //        Console.WriteLine("Draw a Rectangle");
                //        break;
                //}
            }
        }
    }
}
