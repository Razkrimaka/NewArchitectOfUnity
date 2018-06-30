using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RazTools
{

    public class GLogic : Singleton<GLogic>
    {
        public event DelegateHandlers.void_Handler_Int CreateEntityEvent;
        public event DelegateHandlers.void_Handler_Int DestroyEntityEvent;


        public void CreateEntity(Entity entity)
        {
            Debug.Log("[GLogic]: сообщаю, что Сущность[" + entity.GetID() + "] создана");
            CreateEntityEvent(entity.GetID());
        }
            
        public void DestroyEntity (int ID)
        {
            Debug.Log("[GLogic]: сообщаю, что Сущность[" + ID + "] уничтожена");
            DestroyEntityEvent(ID);
        }

        public override void Initialise()
        {
            CreateEntityEvent += GVisualise.Instance.CreateNewEntity;
            DestroyEntityEvent += GVisualise.Instance.DestroyEntity;
        }
    }
}
