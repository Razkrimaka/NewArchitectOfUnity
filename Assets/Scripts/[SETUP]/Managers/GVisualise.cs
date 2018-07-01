using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RazTools
{
    public class GVisualise : Singleton<GVisualise>
    {
        GameObject EntitiesParent;


        Dictionary<int, Actor> Entities = new Dictionary<int, Actor>();

        public void CreateNewEntity (Entity entity)
        {
            Actor newEntity;
            int ID = entity.GetID();
            if (Entities.TryGetValue(ID, out newEntity))
            {
                Debug.Log("[GVisualise]: Что-то пошло не так. Я пытаюсь создать объект, который уже есть на сцене!");
            } 
            else
            {
                newEntity = new Actor("Сущность " + ID, EntitiesParent, entity);
                Entities.Add(ID, newEntity);
                Debug.Log("[GVisualise]: Создал актера. ID = " + ID);
            }
        }

        public void DestroyEntity (int ID)
        {
            Actor newEntity;
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

        private void KillEntity (Actor entity)
        {
            Debug.Log("Сущности нечего сказать перед смертью");
        }


    }
}
