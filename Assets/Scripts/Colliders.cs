using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UI;

public class Script : MonoBehaviour
{
    public TextMeshProUGUI counter;
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        index = Convert.ToInt32(counter.text);
        index--;
        counter.text = index.ToString();
    }
}
