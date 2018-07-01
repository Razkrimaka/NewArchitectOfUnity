using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace RazTools
{
    public class Actor : MonoBehaviour, ITick
    {
        

        GameObject ActorsObject;
        DataContainer dataContainer;
        public Actor (string Name, GameObject group, Entity entity)
        {
            AddToManager(this);
            ActorsObject = new GameObject(Name);
            ActorsObject.transform.SetParent(group.transform);
            ActorsObject.transform.position = entity.position;

            dataContainer = DataManager.GetData(entity.GetType().ToString());
            Debug.Log("[Actor]: Загружена дата - " + entity.GetType().ToString());
        }

        public void AddToManager(IUpdateble updateble)
        {
            UpdateManager.AddTo(this);
        }

        public void Tick()
        {
            Debug.Log(dataContainer.GetData<MoveData>().speed);
        }

    }
}
