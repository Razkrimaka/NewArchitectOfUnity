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
                for (int i=0; i<3; i++)
                {
                    GLogic.Instance.CreateEntity(new Monster(new Vector3(i, 0, 0)));
                }
            if (Input.GetKeyDown(KeyCode.Alpha1))
                GLogic.Instance.DestroyEntity(1);
        }
    }
}
