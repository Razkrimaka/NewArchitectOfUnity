using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RazTools
{
    public class Controller : Singleton<Controller>
    {
        public override void Initialise()
        {

        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                GLogic.Instance.CreateEntity(new Monster());
            if (Input.GetKeyDown(KeyCode.Alpha1))
                GLogic.Instance.DestroyEntity(1);
        }
    }
}
