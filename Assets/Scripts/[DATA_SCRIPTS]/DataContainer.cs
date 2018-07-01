using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace RazTools
{
    [CreateAssetMenu(fileName = "DataContainer", menuName = "RazTools/DataContainer")]
    public class DataContainer : ScriptableObject
    {
        [SerializeField]
        public string Name;

        [SerializeField]
        Dictionary<Type, int> data = new Dictionary<Type, int>();

        [SerializeField]
        List<ScriptableObject> dataList = new List<ScriptableObject>();

        public void NormaliseDict ()
        {
            for (int i = 0; i<dataList.Count; i++)
            {
                data.Add(dataList[i].GetType(), i);
            }
        }

        public T GetData<T> () where T: ScriptableObject
        {
            T geteddata = null;
            int number;
            if( data.ContainsKey(typeof(T)))
            {
                number = data[typeof(T)];
                geteddata = dataList[number] as T;
            }

            return geteddata;
        }

    }
}
