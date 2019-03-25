using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Org.Ivan.Dungeons.Commmon
{
    /// <summary>
    /// <c>MonoInstanceObject</c>實際的<see cref="GameObject"/>
    /// </summary>
    public class MonoInstanceObject : MonoBehaviour
    {
        void Awake()
        {
            name = nameof(MonoInstanceObject);

            DontDestroyOnLoad(gameObject);
        }
    }
}