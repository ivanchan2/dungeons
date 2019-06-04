using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Org.Ivan.Dungeons.Commmon
{
    /// <summary>
    /// Singleton基礎類別
    /// </summary>
    /// <typeparam name="T">要建立的物件類別</typeparam>
    public class InstanceBase<T> where T : InstanceBase<T>, new()
    {
        /// <summary>
        /// instance
        /// </summary>
        private static T _instance;

        /// <summary>
        /// instance
        /// </summary>
        public static T Instance
        {
            get
            {
                if (_instance == null)
                    _instance = InstanceManager.Instance.AddInstance<T>();

                return _instance;
            }
        }

        [Obsolete("本來想在new完之後互叫此functio, 但是測試的結果在那時候好像沒有多型的效果 ")]
        public virtual void Initial()
        {
        }
    }
}