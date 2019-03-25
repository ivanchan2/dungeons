using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Org.Ivan.Dungeons.Commmon
{
    /// <summary>
    /// 管理自動產生的<seealso cref="MonoInstanceBase{T}"/>
    /// </summary>
    public class MonoInstanceManager : MonoBehaviour
    {
        // instance
        private static MonoInstanceManager _instance;
        // private constructor
        private MonoInstanceManager() { }

        /// <summary>
        /// Instance
        /// </summary>
        public static MonoInstanceManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    GameObject gameObject = new GameObject(nameof(MonoInstanceManager), typeof(MonoInstanceManager));
                    Object.DontDestroyOnLoad(gameObject);
                    _instance = gameObject.GetComponent<MonoInstanceManager>();
                }

                return _instance;
            }
        }

        void Start()
        {
        }

        /// <summary>
        /// 新增一個MonoInstance
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T AddInstance<T>()
        {
            GameObject gameObject = new GameObject(typeof(T).Name, typeof(T));
            gameObject.transform.parent = _instance.gameObject.transform;

            return gameObject.GetComponent<T>();
        }

        public void Initial()
        {

        }
    }
}