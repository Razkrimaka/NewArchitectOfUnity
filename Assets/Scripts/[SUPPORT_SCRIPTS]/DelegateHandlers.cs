using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RazTools
{
    public static class DelegateHandlers
    {
        public delegate void void_Handler_Int(int INT);
        public delegate void void_Handler_void();
        public delegate void void_Handler_Entity(Entity entity);
    }
}
