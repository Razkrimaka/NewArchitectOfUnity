using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RazTools {
    public class NumberManager : Singleton<NumberManager> {
        private Queue<int> _freeNumbers = new Queue<int>();
        private int _currNumber;

        public int GetNumber ()
        {
            int number;
            if (_freeNumbers.Count==0)
            {
                number = _currNumber;
                _currNumber++;
            } else
            {
                number = _freeNumbers.Dequeue();
            }
            return number;
        }

        public void AddFreeNumber (int number)
        {
            _freeNumbers.Enqueue(number);
            Debug.Log("[NumberManager]: Освободил номер " + number);
        }

        public override void Initialise()
        {

        }
    }
}
