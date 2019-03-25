using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Org.Ivan.Dungeons.Commmon;

public class AppStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MonoInstanceManager.Instance.Initial();

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