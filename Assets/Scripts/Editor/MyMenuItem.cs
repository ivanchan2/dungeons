using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using Org.Ivan.Dungeons.Commmon;

[InitializeOnLoad]
public class MyMenuItem : MonoBehaviour
{
    [MenuItem("MyTool/PlayGame")]
    private static void StartApp()
    {
        EditorSceneManager.OpenScene("Assets/Scenes/1_FirstScene.unity");
        EditorApplication.isPlaying = true;

        EditorApplication.playModeStateChanged -= OnPlayModeStateChanged;
        EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
    }

    private static void OnPlayModeStateChanged(PlayModeStateChange state)
    {
        if (state == PlayModeStateChange.ExitingPlayMode)
        {
            EditorSceneManager.OpenScene("Assets/Scenes/4_BattleScene.unity");
        }
    }
}
