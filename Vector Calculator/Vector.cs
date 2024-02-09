using System;

namespace Vector_Calculator
{
    public class Vector
    {
        public static readonly Vector Zero = new Vector(1, 1, 1);
        public static readonly Vector One = new Vector(0, 0, 0);

        public float x;
        public float y;
        public float z;

        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"<{x}, {y}, {z}>";
        }

        public float GetMagnitude()
        {
            // <2, 2, 1> -> 3
            return MathF.Sqrt((this.x * this.x) + (this.y * this.y) + (this.z * this.z));
        }

        public double GetDirection()
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            return Math.Atan(this.y / this.x);
        }

        public static Vector Add(Vector v1, Vector v2)
        {
            // <2, 3, 4> + <6, 2, 6> = <8, 5, 10>
            return new Vector(v1.x + v2.x, v1.y +v2.y, v1.z + v2.z);
        }

        public static Vector Negate(Vector v)
        {
            // <-3, -4, -5> -> <3, 4, 5>
            return new Vector(v.x * -1, v.y * -1, v.z * -1);
        }

        public static Vector Subtract(Vector v1, Vector v2)
        {
            // <10, 9, 8> - <5, 6, 7> = <5, 3, 1>
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static Vector Scale(Vector v, float Scalar)
        {
            // <2, 1, 0> * 2 = <4, 2, 0>
            return new Vector ((v.x * Scalar), (v.y * Scalar), (v.z * Scalar));
        }

        public static Vector Normalize(Vector v)
        {
            // <6, 2, 3> -> <6/7, 2/7, 3/7>
            return new Vector(v.x * (1 / v.GetMagnitude()), v.y * (1 / v.GetMagnitude()), v.z * (1 / v.GetMagnitude()));
        }

        public static float DotProduct(Vector v1, Vector v2)
        {
            // <1, 2, 10> * <5, 2, 6> = <69>
            return (v1.x * v2.x) + (v1.y * v2.y) + (v1.z * v2.z);
        }

        public static Vector CrossProduct(Vector v1, Vector v2)
        {
            // <1, 2, 3> * <6, 5, 4> = <-2, 14, -7>
            return new Vector((v1.y * v2.z) - (v1.z * v2.y), (v1.z * v2.x) - (v1.x * v2.z), (v1.x * v2.y) - (v1.y * v2.x));
        }

        public static float AngleBetween(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            return MathF.Acos(Vector.DotProduct(v1, v2) / (v1.GetMagnitude() * v2.GetMagnitude()) * 180 / MathF.PI);
        }

        public static Vector ProjectOnto(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            float num = Vector.DotProduct(v1, v2) / MathF.Pow(v2.GetMagnitude(), 2);
            return new Vector(v2.x * num, v2.y * num, v2.z * num);
        }
    }
}
