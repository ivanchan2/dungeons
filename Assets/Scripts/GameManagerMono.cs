﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerMono : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        name = nameof(GameManagerMono);

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}