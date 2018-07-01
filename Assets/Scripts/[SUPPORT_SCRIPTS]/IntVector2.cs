using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntVector2  {

    public int X;
    public int Y;

    #region Operators
    public static IntVector2 operator +(IntVector2 a, IntVector2 b)
    {
        return new IntVector2(a.X + b.X, a.Y + b.Y);
    }

    public static IntVector2 operator -(IntVector2 a, IntVector2 b)
    {
        return new IntVector2(a.X - b.X, a.Y - b.Y);
    }

    public override bool Equals(object obj)
    {
        IntVector2 EquVector = obj as IntVector2;
        if ((EquVector) != null)
        {
            if (EquVector.X == this.X &&
                EquVector.Y == this.Y)
                return true;
        }
        return false;
    }
    #endregion Operators

    public IntVector2(int x = 0, int y = 0)
    {
        X = x; Y = y;
    }
}
