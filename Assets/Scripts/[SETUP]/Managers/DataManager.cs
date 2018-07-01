using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RazTools
{
    public class DataManager : Singleton<DataManager>
    {
        public List<DataContainer> _dataBank = new List<DataContainer>();

        public override void Initialise()
        {

        }

        public static DataContainer GetData (string name)
        {
            DataContainer dataContainer;
            for (int i = 0; i < Instance._dataBank.Count; i++)
            {
                if (Instance._dataBank[i].Name == name)
                {
                    dataContainer = Instantiate(Instance._dataBank[i]);
                    return dataContainer;
                }
            }
            Debug.Log("[DataManager]: не нашёл даты для сущности. Создал defaut");
            return dataContainer = new DataContainer();
        }
    }
}
