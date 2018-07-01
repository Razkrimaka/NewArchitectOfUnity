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
        List<ScriptableObject> _dataList = new List<ScriptableObject>();

        [SerializeField]
        public string Name;

        [SerializeField]
        Dictionary<Type, int> data = new Dictionary<Type, int>();


        public List<ScriptableObject> dataList
        {
            get
            {
                return _dataList;
            }
            set
            {
                _dataList = value;
            }
        }

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
            if (geteddata==null)
            {
                geteddata = DataManager.GetData("Defaut").GetData<T>();
            }

            return geteddata;
        }

    }
}
