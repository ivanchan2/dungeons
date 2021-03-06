﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Org.Ivan.Dungeons
{
    /// <summary>
    /// 
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
                    _gameObject = GameObject.Find(nameof(GameManagerMono));
                    if (_gameObject == null)
                    {
                        _gameObject = new GameObject();
                        Object.Instantiate(_gameObject);

                        Object.DontDestroyOnLoad(_gameObject);
                    }
                }

                return _instance;
            }
        }

        public void Initial()
        {

        }
    }
}