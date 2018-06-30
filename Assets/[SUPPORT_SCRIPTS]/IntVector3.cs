using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntVector3
{
    public int X;
    public int Y;
    public int Z;
    #region Operators
    public static IntVector3 operator + (IntVector3 a, IntVector3 b)
    {
        return new IntVector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    }

    public static IntVector3 operator -(IntVector3 a, IntVector3 b)
    {
        return new IntVector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    }

    public override bool Equals(object obj)
    {
        IntVector3 EquVector = obj as IntVector3;
        if ((EquVector)!=null)
        {
            if (EquVector.X == this.X &&
                EquVector.Y == this.Y &&
                EquVector.Z == this.Z)
                return true;
        }
        return false;
    }
    #endregion Operators

    public IntVector3(int x = 0, int y = 0, int z = 0)
    {
        X = x; Y = y; Z = z;
    }
}
