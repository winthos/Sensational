﻿using UnityEngine;
using System.Collections;

public class HitCountLogic : MonoBehaviour 
{

    private GameObject TimeGlobal;
    // Use this for initialization
    private float TotalTimeSoFar;

    void Start()
    {
        TimeGlobal = GameObject.Find("LevelGlobals");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<TextMesh>().text = "HITS TAKEN: " + TimeGlobal.GetComponent<LevelGlobals>().HitCount;

    }
}
