using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Org.Ivan.Dungeons.Commmon;
using System;

/// <summary>
/// 管理整個App
/// </summary>
/// <typeparam name="App"></typeparam>
public class App
{
    #region Singleton
    // instance
    private static App _instance;

    // private constructor
    private App() { }

    /// <summary>
    /// Instance
    /// </summary>
    public static App Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new App();
            }

            return _instance;
        }
    }
    #endregion

    /// <summary>
    /// 是否初始化過了
    /// </summary>
    private bool _initialize;

    /// <summary>
    /// 初始化
    /// </summary>
    public void Initial()
    {
        try
        {
            Debug.Log("Start initial App.");

            if (_initialize)
                return;

            MonoInstanceManager.Instance.Initial();

            CharacterManager.Instance.DebugAddCharacter();

            _initialize = true;
        }
        catch (Exception e)
        {
            Debug.LogError("App initial failed." + e.ToString());
        }
    }

    /// <summary>
    /// 是否已經初始化完成
    /// </summary>
    /// <value></value>
    public bool IsInitialize { get { return _initialize; } }
}