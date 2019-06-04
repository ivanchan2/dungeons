using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Org.Ivan.Dungeons.Commmon
{
    /// <summary>
    /// 管理所有的instnace
    /// </summary>
    public class InstanceManager
    {
        #region singleton
        // instance
        private static InstanceManager _inst;

        // private constructor
        private InstanceManager() { }

        /// <summary>
        /// Instance
        /// </summary>
        public static InstanceManager Instance
        {
            get
            {
                if (_inst == null)
                {
                    _inst = new InstanceManager();
                }

                return _inst;
            }
        }
        #endregion

        /// <summary>
        /// 所有instance的集合
        /// </summary>
        private Dictionary<Type, object> _instances = new Dictionary<Type, object>();

        /// <summary>
        /// new一個新的instance
        /// </summary>
        /// <typeparam name="T">要new的instance的類別</typeparam>
        /// <returns>回傳new出來的instance</returns>
        public T AddInstance<T>() where T : InstanceBase<T>, new()    
        {
            T instance = new T();

            _instances.Add(typeof(T), instance);

            return instance;
        }
    }
}