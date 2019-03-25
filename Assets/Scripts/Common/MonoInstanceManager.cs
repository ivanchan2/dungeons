using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Org.Ivan.Dungeons.Commmon
{
    /// <summary>
    /// 管理自動產生的mono instance
    /// 會在scene裡面生成<seealso cref="MonoInstanceObject"/>
    /// </summary>
    public class MonoInstanceManager
    {
        private static MonoInstanceManager _instance;
        private static GameObject _gameObject;

        private MonoInstanceManager() { }

        public static MonoInstanceManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MonoInstanceManager();

                    // 建立GameManagerObject
                    _gameObject = GameObject.Find(nameof(MonoInstanceObject));
                    if (_gameObject == null)
                    {
                        _gameObject = new GameObject(nameof(MonoInstanceObject));
                        Object.Instantiate(_gameObject);

                        // Object.DontDestroyOnLoad(_gameObject);
                    }
                }

                return _instance;
            }
        }

        public T AddInstance<T>() where T : MonoBehaviour
        {
            if (_gameObject == null)
            {
                Debug.LogError("Can't find GameObject of MonoInstanceManager");
                return null;
            }

            GameObject gameObject = new GameObject(typeof(T).Name, typeof(T));
            gameObject.transform.parent = _gameObject.transform;

            Object.DontDestroyOnLoad(gameObject);

            return gameObject.GetComponent<T>();
        }

        public void Initial()
        {

        }
    }
}