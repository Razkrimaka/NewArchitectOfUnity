using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RazTools {
    public class UpdateManager : Singleton<UpdateManager> {
        List<ITick> OnUpdateTicked = new List<ITick>();
        List<IFixedTick> OnFixedTicked = new List<IFixedTick>();
        List<ILateTick> OnLateUpdateTicked = new List<ILateTick>();

        public static void AddTo(IUpdateble add)
        {
            if (add is ITick)
            {
                Instance.OnUpdateTicked.Add(add as ITick);
            }
            if (add is IFixedTick)
            {
                Instance.OnFixedTicked.Add(add as IFixedTick);
            }
            if (add is ILateTick)
            {
                Instance.OnLateUpdateTicked.Add(add as ILateTick);
            }
        }

        public override void Initialise()
        {

        }

        private void Update()
        {
            for (int i=0; i < OnUpdateTicked.Count; i++)
            {
                OnUpdateTicked[i].Tick();
            }
            for (int i = 0; i<OnFixedTicked.Count; i++)
            {
                OnFixedTicked[i].FixedTick();
            }
            for (int i = 0; i<OnLateUpdateTicked.Count; i++)
            {
                OnLateUpdateTicked[i].LateTick();
            }
        }
    }
}
