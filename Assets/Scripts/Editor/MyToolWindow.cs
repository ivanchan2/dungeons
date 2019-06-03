using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using Org.Ivan.Dungeons.Commmon;
using UnityEngine.SceneManagement;

public class MyToolWindow : EditorWindow
{
    /// <summary>
    /// 開始的起始場景路徑
    /// </summary>
    private const string startScenePath = "Assets/Scenes/1_FirstScene.unity";

    /// <summary>
    /// 上一次開啟的場景路徑
    /// </summary>
    private string _previousScenePath;

    [MenuItem("MyTool/MyToolWindow")]
    static void Init()
    {
        // Get existing open window or if none, make a new one:
        MyToolWindow window = (MyToolWindow)EditorWindow.GetWindow(typeof(MyToolWindow));
        window.Show();
    }

    void OnGUI()
    {
        if (EditorApplication.isPlaying)
        {
            if (GUILayout.Button("stop"))
            {
                EditorApplication.isPlaying = false;
            }
        }
        else
        {
            if (string.IsNullOrEmpty(_previousScenePath))
            {
                if (GUILayout.Button("start"))
                {
                    _previousScenePath = EditorSceneManager.GetActiveScene().path;

                    EditorSceneManager.OpenScene(startScenePath);
                    EditorApplication.isPlaying = true;
                }
            }
            else
            {
                if (GUILayout.Button("load scene"))
                {
                    EditorSceneManager.OpenScene( _previousScenePath);

                    _previousScenePath = "";
                    
                }
            }
        }
    }
}
