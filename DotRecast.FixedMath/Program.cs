using FixedMathSharp;

public struct FixedVector3
{
    public Fixed64 X;
    public Fixed64 Y;
    public Fixed64 Z;

    public FixedVector3(Fixed64 x, Fixed64 y, Fixed64 z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    // Needed Operators for Detour
    public static FixedVector3 operator +(FixedVector3 a, FixedVector3 b)
        => new FixedVector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

    public static FixedVector3 operator -(FixedVector3 a, FixedVector3 b)
        => new FixedVector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

    public static FixedVector3 operator *(FixedVector3 a, Fixed64 b)
        => new FixedVector3(a.X * b, a.Y * b, a.Z * b);

    // Dot Product - Required for the navigation
    public static Fixed64 Dot(FixedVector3 a, FixedVector3 b)
    {
        return (a.X * b.X) + (a.Y * b.Y) + (a.Z * b.Z);
    }

    // Cross Product - Used on the border of poly
    public static FixedVector3 Cross(FixedVector3 a, FixedVector3 b)
    {
        return new FixedVector3(
            (a.Y * b.Z) - (a.Z * b.Y),
            (a.Z * b.X) - (a.X * b.Z),
            (a.X * b.Y) - (a.Y * b.X)
        );
    }

    public Fixed64 Length() => FixedMath.Sqrt(X * X + Y * Y + Z * Z);
}