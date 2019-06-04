using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Org.Ivan.Dungeons.Commmon;

/// <summary>
/// 開始場景使用的script
/// </summary>
public class AppStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        App.Instance.Initial();

#if DEBUG
        Debug.Log("Debug Start.");

        SceneManager.LoadScene("2_DebugSetting");
#else
        Debug.Log("Release Start.");

        SceneManager.LoadScene("2_DebugSetting");
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}