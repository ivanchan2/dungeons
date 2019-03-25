using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Org.Ivan.Dungeons.Commmon
{
    /// <summary>
    /// 基礎的MonoInstace物件
    /// </summary>
    /// <typeparam name="T"></typeparam>
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