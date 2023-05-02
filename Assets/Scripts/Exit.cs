using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEditor;

public class Exit : MonoBehaviour
{
    

    void Start()
    {
        gameObject.GetComponent<writePoints>().AddNewScore();
        gameObject.GetComponent<readPoints>().ShowTopScores();

        
    }

}
