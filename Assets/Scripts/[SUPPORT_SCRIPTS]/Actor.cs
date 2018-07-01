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
        Entity _entity;
        public Actor (string Name, GameObject group, Entity entity)
        {
            _entity = entity;
            LoadData(entity.GetType().ToString());


            //Записываемся в менеджере апдейта
            AddToManager(this);

            //Создаемся как Child на сцене в нужной точке
            ActorsObject = new GameObject(Name);
            ActorsObject.transform.SetParent(group.transform);
            ActorsObject.transform.position = entity.position;


        }

        private void LoadData (string entityName)
        {
            //Получаем у дата-менеджера свою дату и настраиваем для нее словарь
            if (_entity.GetType().ToString() == entityName)
            {
                dataContainer = DataManager.GetData(entityName);
                dataContainer.NormaliseDict();
            }
        }

        public void AddToManager(IUpdateble updateble)
        {
            UpdateManager.AddTo(this);
        }

        public void Tick()
        {
            Debug.Log("[Actor]: speed = " + dataContainer.GetData<MoveData>().speed);
        }

    }
}
