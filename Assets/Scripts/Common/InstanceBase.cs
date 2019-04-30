using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                    _instance = new T();

                return _instance;
            }
        }

        private static

        protected void Initial()
        {

        }
    }
}