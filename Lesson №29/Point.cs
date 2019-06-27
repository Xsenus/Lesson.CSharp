using System;

namespace Lesson__29
{
    class Point
    {
        public int X { get; set; }

        public MyClass MyClass { get; set; }

        public Point Y { get; set; }

        public override bool Equals(object obj)
        {
            /*
             * Никогда не должен выдавать Exception!
             */

            //if (obj == null)
            //{
            //    return false;
            //}

            //if (obj is Point)
            //{

            //}

            //var point = obj as Point;

            //if (point != null)

            if (obj is Point point)
            {
                return point.X == X;
            }
            else
            {
                return false;
            }

            //return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return X;
        }

        public override string ToString()
        {
            return X.ToString();
        }

        public Point Clone()
        {
            //var result = (Point)MemberwiseClone();
            //result.Y = Y.Clone();

            //return result;
            return MemberwiseClone() as Point;
        }

        public new Type GetType()
        {
            return typeof(UInt16);
        }
    }
}
