using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RazTools;

public class Monster : Entity, ITick
{
    int Timer = 0;
    public Monster()
    {
        AddToManager(this);
    }

    public void AddToManager(IUpdateble updateble)
    {
        UpdateManager.AddTo(this);
    }

    public void Tick()
    {
        Timer++;
    }
}
