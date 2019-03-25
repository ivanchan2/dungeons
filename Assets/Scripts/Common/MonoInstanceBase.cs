using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Org.Ivan.Dungeons.Commmon;

namespace Org.Ivan.Dungeons.Commmon
{
    public class MonoInstanceBase<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = MonoInstanceManager.Instance.AddInstance<T>() as T;
                }

                return _instance;
            }
        }
    }
}