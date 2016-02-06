using UnityEngine;
using System.Collections;

public class Plane
{
    public const int center = 0;
    const int left = -3;
    const int right = 3;
    public int Walls { get; private set; }
    public int Center { get { return center; } }
    public int Left { get { return left; } }
    public int Right { get { return right; } }

    public Plane(int _wall)
    {
        this.Walls = _wall;

    }
}

