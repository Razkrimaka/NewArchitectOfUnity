using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUpdateble
{
    void AddToManager(IUpdateble updateble);
}

public interface ITick : IUpdateble
{
    void Tick();
}

public interface IFixedTick : IUpdateble
{
    void FixedTick();
}

public interface ILateTick :IUpdateble
{
    void LateTick();
}
