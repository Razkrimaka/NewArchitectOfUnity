using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RazTools
{
    public class GVisualise : Singleton<GVisualise>
    {
        GameObject EntitiesParent;


        Dictionary<int, GameObject> Entities = new Dictionary<int, GameObject>();

        public void CreateNewEntity (Entity entity)
        {
            GameObject newEntity;
            int ID = entity.GetID();
            if (Entities.TryGetValue(ID, out newEntity))
            {
                Debug.Log("[GVisualise]: Что-то пошло не так. Я пытаюсь создать объект, который уже есть на сцене!");
            } 
            else
            {
                newEntity = new GameObject("Сущность " + ID);
                newEntity.transform.SetParent(EntitiesParent.transform);
                Entities.Add(ID, newEntity);
                Debug.Log("[GVisualise]: Создал пустую сущность. ID = " + ID);
            }
        }

        public void DestroyEntity (int ID)
        {
            GameObject newEntity;
            if (Entities.TryGetValue(ID, out newEntity))
            {
                KillEntity(newEntity);
                Destroy(newEntity);
                Entities.Remove(ID);
                Debug.Log("[GVisualise]: Уничтожил сущность " + ID);
                NumberManager.Instance.AddFreeNumber(ID);
            } else
            {
                Debug.Log("[GVisualise]: Что-то пошло не так. Я пытаюсь уничтожить объект, которого не существует!");
            }

        }

        public override void Initialise()
        {
            EntitiesParent = new GameObject("[Entities]");
        }

        private void KillEntity (GameObject entity)
        {
            Debug.Log("Сущности нечего сказать перед смертью");
        }


    }
}
